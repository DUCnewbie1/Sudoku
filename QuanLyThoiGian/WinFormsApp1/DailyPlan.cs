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

namespace WinFormsApp1
{
    public partial class DailyPlan : Form
    {
        private DateTime date;
        private int userId; // Thêm thuộc tính userId

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        //Tạo ra một điều khiển chứa các điều khiển con và tự động sắp xếp chúng theo chiều ngang hoặc chiều dọc.
        FlowLayoutPanel fPanel = new FlowLayoutPanel();

        // Phương thức khởi tạo của lớp DailyPlan
        public DailyPlan(DateTime date, int userId) // Thêm tham số userId vào constructor
        {
            // Gọi phương thức InitializeComponent để khởi tạo các điều khiển
            InitializeComponent();

            // Khởi tạo các thuộc tính Date, Job và userId với các giá trị tương ứng
            this.Date = date;
            this.userId = userId;

            // Thiết lập kích thước của fPanel và thêm nó vào pnlJob
            fPanel.Width = pnlJob.Width;
            fPanel.Height = pnlJob.Height;
            pnlJob.Controls.Add(fPanel);

            // Đặt giá trị của dtpkDate bằng giá trị của thuộc tính Date
            dtpkDate.Value = Date;
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
        }
    }
}
