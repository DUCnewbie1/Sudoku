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
        private int userId;
        FlowLayoutPanel fPanel = new FlowLayoutPanel();

        // Phương thức khởi tạo của lớp DailyPlan
        public DailyPlan(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }
        // Phương thức xử lý sự kiện khi form được hiển thị
        private void DailyPlan_Load(object sender, EventArgs e)
        {
            LoadEvents();
        }
        // Phương thức xử lý sự kiện khi người dùng nhấn vào nút btnPreviousDay
        private void btnPreviousDay_Click(object sender, EventArgs e)
        {
            // Trừ giá trị của điều khiển nhập liệu ngày tháng năm dtpkDate đi một ngày
            dtpkDate.Value = dtpkDate.Value.AddDays(-1);
            LoadEvents();
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
                        dataTable.Columns.Add("eventName", typeof(string));
                        dataTable.Columns.Add("startTime", typeof(TimeSpan));
                        dataTable.Columns.Add("endTime", typeof(TimeSpan));
                        dataTable.Columns.Add("eventStatus", typeof(string));
                        dataTable.Columns.Add("eventNote", typeof(string));

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
                        dataGridView1.Columns["mask"].HeaderText = "Mã sự kiện";
                        dataGridView1.Columns["eventName"].HeaderText = "Tên sự kiện";
                        dataGridView1.Columns["startTime"].HeaderText = "Thời gian bắt đầu";
                        dataGridView1.Columns["endTime"].HeaderText = "Thời gian kết thúc";
                        dataGridView1.Columns["eventStatus"].HeaderText = "Trạng thái";
                        dataGridView1.Columns["eventNote"].HeaderText = "Ghi chú";
                    }
                }
            }
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

        // hiển thị ngày hôm nay
        private void button4_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = DateTime.Today;
            LoadEvents();
        }
    }
}