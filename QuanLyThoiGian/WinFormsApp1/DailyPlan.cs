using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using QuanLyThoiGian;

namespace WinFormsApp1
{
    public partial class DailyPlan : Form
    {
        private int userId; // Thêm thuộc tính userId}

        //Tạo ra một điều khiển chứa các điều khiển con và tự động sắp xếp chúng theo chiều ngang hoặc chiều dọc.
        FlowLayoutPanel fPanel = new FlowLayoutPanel();

        // Phương thức khởi tạo của lớp DailyPlan
        public DailyPlan(int userId) // Thêm tham số userId vào constructor
        {
            // Gọi phương thức InitializeComponent để khởi tạo các điều khiển
            InitializeComponent();
            this.userId = userId;
        }


        // Phương thức xử lý sự kiện khi người dùng nhấn vào nút mnAddJob
        private void mnAddJob_Click(object sender, EventArgs e)
        {
        }


        // Phương thức xử lý sự kiện khi người dùng nhấn vào nút btnNextDay
        private void btnNextDay_Click(object sender, EventArgs e)
        {
            // Cộng giá trị của điều khiển nhập liệu ngày tháng năm dtpkDate thêm một ngày
            dtpkDate.Value = dtpkDate.Value.AddDays(1);
        }

        // Phương thức xử lý sự kiện khi người dùng nhấn vào nút btnPreviousDay
        private void btnPreviousDay_Click(object sender, EventArgs e)
        {
            // Trừ giá trị của điều khiển nhập liệu ngày tháng năm dtpkDate đi một ngày
            dtpkDate.Value = dtpkDate.Value.AddDays(-1);
            LoadEvents();
        }


        // Phương thức xử lý sự kiện Edited của một đối tượng AJob
        void aJob_Edited(object sender, EventArgs e)
        {
            // Hiện tại phương thức này chưa được triển khai và không có chức năng gì
        }

        // Phương thức xử lý sự kiện khi người dùng nhấn vào nút mnsToday
        private void mnsToday_Click(object sender, EventArgs e)
        {
            // Đặt giá trị của điều khiển nhập liệu ngày tháng năm dtpkDate bằng ngày giờ hiện tại
            dtpkDate.Value = DateTime.Now;
        }

        private void btnNextDay_Click_1(object sender, EventArgs e)
        {
            // Cộng giá trị của điều khiển nhập liệu ngày tháng năm dtpkDate thêm một ngày
            dtpkDate.Value = dtpkDate.Value.AddDays(1);
            LoadEvents();
        }
        public void LoadEvents()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(Helper.ConnectionString))
            {
                connection.Open();

                // Chuyển đổi ngày từ DateTimePicker thành chuỗi theo định dạng "dd/MM/yyyy"
                string selectedDate = dtpkDate.Value.ToString("dd/MM/yyyy");

                string query = "SELECT l.mask, s.tensk, s.thoigianbd, s.thoigiankt, s.trangthai, s.ghichu " +
                               "FROM lich l " +
                               "INNER JOIN sukien s ON l.mask = s.mask " +
                               "WHERE l.ngaytaosukien = @selectedDate AND l.id = @userId";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@selectedDate", selectedDate);
                    command.Parameters.AddWithValue("@userId", userId);

                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Columns.Add("mask", typeof(int)); // Primary key
                        dataTable.Columns.Add("tensk", typeof(string));
                        dataTable.Columns.Add("thoigianbd", typeof(TimeSpan));
                        dataTable.Columns.Add("thoigiankt", typeof(TimeSpan));
                        dataTable.Columns.Add("trangthai", typeof(string));
                        dataTable.Columns.Add("ghichu", typeof(string));

                        while (reader.Read())
                        {
                            int mask = reader.GetInt32(0);
                            string eventName = reader.GetString(1);
                            TimeSpan startTime = reader.GetTimeSpan(2);
                            TimeSpan endTime = reader.GetTimeSpan(3);
                            string eventStatus = reader.GetString(4);
                            string eventNote = reader.GetString(5);
                            dataTable.Rows.Add(mask, eventName, startTime, endTime, eventStatus, eventNote);
                        }
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

        // Phương thức xử lý sự kiện khi form được hiển thị
        private void DailyPlan_Load(object sender, EventArgs e)
        {
            LoadEvents();
        }

        private void DailyPlan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn quay trở lại màn hình chính.?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else if (result == DialogResult.Yes)
                {
                    Form1 form1 = new Form1(userId);
                    form1.Show();
                    this.Hide();
                }
            }
        }
        // trở lại Form1
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn hủy tạo sự kiện và trở lại màn hình chính?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form1 form1 = new Form1(userId);
                form1.Show();
                this.Hide();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            TaoSuKien t = new TaoSuKien(userId);
            t.Show();
            this.Hide();
        }

        private void DailyPlan_Activated_2(object sender, EventArgs e)
        {
            LoadEvents();
        }
    }
}