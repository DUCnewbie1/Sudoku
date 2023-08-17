using QuanLyThoiGian;
using ToastNotifications;
using Npgsql;
using Tulpep.NotificationWindow;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        #region peoperties
        private int appTime;
        public int AppTime { get => appTime; set => appTime = value; }
        private string filePath = "data.xml";
        private Button lastClickedButton = null;
        private bool isFirstClick = false;
        private List<List<Button>> matrix;
        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        private List<string> dateOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        #endregion
        private DailyPlan dailyPlanForm;
        private int userId;
        private Notifier notifier;
        private int MaSK; // Thêm thuộc tính MaSK
        public Form1(int userId)
        {
            this.userId = userId;
            MaSK = 0;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpkDate.CustomFormat = "dd/MM/yyyy"; // Hoặc để null nếu muốn sử dụng giá trị mặc định
            dtpkDate.ValueChanged += dtpkDate_ValueChanged; // Đăng ký sự kiện ValueChanged của DateTimePicker
            Matrix = new List<List<Button>>();
            Button oldbtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.Margin, 0) };
            for (int i = 0; i < Cons.Row; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.NgayTrongTuan; j++)
                {
                    Button btn = new Button() { Width = Cons.DateButtonWidth, Height = Cons.DateButtonHeight };
                    btn.Location = new Point(oldbtn.Location.X + oldbtn.Width + Cons.Margin, oldbtn.Location.Y);
                    btn.Click += Btn_Click;
                    btn.Click += Click_Color;
                    pnMatrix.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    oldbtn = btn;
                }
                oldbtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.Margin, oldbtn.Location.Y + Cons.DateButtonHeight) };
            }
            SetDefaultDay(); //Dat ngay mac dinh
            AddNumberIntoMatrixByDate(dtpkDate.Value);

        }
        private void AddNumberIntoMatrixByDate(DateTime date)
        {
            ClearMatrix();
            DateTime firstDayOfMonth = new DateTime(date.Year, date.Month, 1);

            // Tính toán để ngày 1 luôn nằm trong khoảng thứ 2 đến chủ nhật (2, 3, 4, 5, 6, 7, CN)
            int daysUntilFirstDay = (int)firstDayOfMonth.DayOfWeek - (int)DayOfWeek.Monday;
            if (daysUntilFirstDay < 0)
            {
                daysUntilFirstDay += 7;
            }
            DateTime useDate = firstDayOfMonth.AddDays(-daysUntilFirstDay);

            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    int dayOfMonth = useDate.Day;

                    if (useDate.Month == date.Month)
                    {
                        btn.Text = dayOfMonth.ToString();
                        btn.ForeColor = Color.Black;
                        if (KiemTraNgay(useDate, DateTime.Now))
                        {
                            btn.BackColor = Color.Orange;
                        }
                        if (KiemTraNgay(useDate, date))
                        {
                            btn.BackColor = Color.Aqua;
                            CheckColor = btn;
                        }
                    }
                    else
                    {
                        btn.Text = dayOfMonth.ToString();
                        btn.ForeColor = Color.Gray;
                    }

                    useDate = useDate.AddDays(1);
                }
            }
        }

        // Phương thức xử lý sự kiện khi người dùng double click vào nút Btn
        private void Btn_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem sender có phải là một Button hay không
            if (sender is Button btn)
            {
                // Kiểm tra xem nội dung của nút Btn có rỗng hay không
                if (string.IsNullOrEmpty(btn.Text))
                    return;
                if (lastClickedButton == btn)
                {

                    // Đặt lastClickedButton thành null để chuẩn bị cho lần nhấp tiếp theo
                    lastClickedButton = null;
                }
                else
                {
                    // Lưu trữ nút vào biến lastClickedButton để chờ đến lần nhấp tiếp theo
                    lastClickedButton = btn;
                }
            }
        }

        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            AddNumberIntoMatrixByDate(dtpkDate.Value);
        }

        int DayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || (date.Year % 400 == 0))
                    {
                        return 29;
                    }
                    else
                    {
                        return 28;
                    }
                default:
                    return 30;
            }
        }

        private Button CheckColor;
        // Hàm xử lý sự kiện khi người dùng click vào ô màu
        private void Click_Color(object sender, EventArgs e)
        {
            if (CheckColor != null)
            {
                CheckColor.BackColor = Color.WhiteSmoke;
            }

            Button ClickColor = (Button)sender;

            //Ngoài tháng thì không tô màu  
            if (string.IsNullOrEmpty(ClickColor.Text))
            {
                return;
            }

            ClickColor.BackColor = Color.Aqua;
            CheckColor = ClickColor;

        }
        // hàm so sánh ngày
        bool KiemTraNgay(DateTime dateA, DateTime dateB)
        {
            return dateA.Year == dateB.Year && dateA.Month == dateB.Month && dateA.Day == dateB.Day;
        }
        private void ClearMatrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.WhiteSmoke;
                }
            }
        }
        private void SetDefaultDay() => dtpkDate.Value = DateTime.Now;
        // thoát chương trình 
        private void Thoat_Click(object sender, EventArgs e)
        {
            if (Helper.ConfirmExit())
            {
                Application.ExitThread();
            }
        }
        // đăng xuất 
        private void DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất tài khoản không?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DangNhap dn = new DangNhap();
                dn.Show();
                this.Hide();
            }
        }

        //chuyển sang tháng tiếp theo
        private void btnnext_Click(object sender, EventArgs e)
        {
            // Tăng tháng của DateTimePicker lên 1 đơn vị
            dtpkDate.Value = dtpkDate.Value.AddMonths(1);

            // Cập nhật lại lịch cho tháng mới
            AddNumberIntoMatrixByDate(dtpkDate.Value);
        }
        // lùi lại 1 tháng
        private void btnPreviours_Click(object sender, EventArgs e)
        {
            // Giảm tháng của DateTimePicker xuống 1 đơn vị
            dtpkDate.Value = dtpkDate.Value.AddMonths(-1);

            // Cập nhật lại lịch cho tháng mới
            AddNumberIntoMatrixByDate(dtpkDate.Value);
        }
        // hiển thị ngày hôm nay
        private void button1_Click(object sender, EventArgs e)
        {
            SetDefaultDay();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        // Hàm xử lý sự kiện FormClosing để xác nhận việc thoát chương trình khi người dùng ấn nút "X" hoặc sử dụng tổ hợp phím Alt + F4.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kiểm tra nếu người dùng đang đóng Form1 bằng cách nhấp nút "X"
            // thì không hiển thị hội thoại xác nhận và đóng form mà không hỏi gì thêm.
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = !Helper.ConfirmExit();
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            ThongTinCaNhan t = new ThongTinCaNhan(this.userId);
            t.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TaoSuKien t = new TaoSuKien(userId);
            t.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DailyPlan dl = new DailyPlan(userId);
            dl.Show();
            this.Hide();
        }
    }
}