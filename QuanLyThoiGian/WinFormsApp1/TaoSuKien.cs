﻿using Npgsql;
using System;
using System.Windows.Forms;
using WinFormsApp1;

namespace QuanLyThoiGian
{
    public partial class TaoSuKien : Form
    {
        private int currentUserId;
        private int userId;
        public TaoSuKien(int userId)
        {
            this.userId = userId;
            InitializeComponent();

            // Add hours to the ComboBox
            for (int hour = 0; hour < 24; hour++)
            {
                comboBox1.Items.Add(hour);
            }

            // Add minutes to the ComboBox
            for (int minute = 0; minute < 60; minute++)
            {
                comboBox2.Items.Add(minute);
            }

            for (int hour = 0; hour < 24; hour++)
            {
                comboBox3.Items.Add(hour);
            }

            // Add minutes to the ComboBox
            for (int minute = 0; minute < 60; minute++)
            {
                comboBox4.Items.Add(minute);
            }
            comboBox5.Items.Add("Sắp tới");
            comboBox5.Items.Add("Đang làm");
            comboBox5.Items.Add("Hoàn thành");
            comboBox5.Items.Add("bỏ lỡ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn hủy tạo sự kiện?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form1 f = new Form1(currentUserId);
                f.Show();
                this.Hide();
            }
        }
        // chọn giờ bắt đầu
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                int selectedHour = (int)comboBox1.SelectedItem;
                if (comboBox2.SelectedItem != null)
                {
                    int selectedMinute = (int)comboBox2.SelectedItem;
                    labelSelectedTime.Text = $"Thời gian bắt đầu: {selectedHour:D2}:{selectedMinute:D2}";
                }
            }
            UpdateSelectedTimeLabel();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                int selectedMinute = (int)comboBox2.SelectedItem;
                if (comboBox1.SelectedItem != null)
                {
                    int selectedHour = (int)comboBox1.SelectedItem;
                    labelSelectedTime.Text = $"Thời gian bắt đầu: {selectedHour:D2}:{selectedMinute:D2}";
                }
            }
            UpdateSelectedTimeLabel();
        }
        // chọn giờ kết thúc
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem != null)
            {
                int selectedHour = (int)comboBox3.SelectedItem;
                if (comboBox4.SelectedItem != null)
                {
                    int selectedMinute = (int)comboBox4.SelectedItem;
                    endTime.Text = $"Thời gian kết thúc: {selectedHour:D2}:{selectedMinute:D2}";
                }
            }
            UpdateEndTimeLabel();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedItem != null)
            {
                int selectedMinute = (int)comboBox4.SelectedItem;
                if (comboBox3.SelectedItem != null)
                {
                    int selectedHour = (int)comboBox3.SelectedItem;
                    endTime.Text = $"Thời gian kết thúc: {selectedHour:D2}:{selectedMinute:D2}";
                }
            }
            UpdateEndTimeLabel();
        }

        // nhập tên sự kiện
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TaoSuKien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn hủy tạo sự kiện?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Form1 f = new Form1(currentUserId);
                    f.Show();
                }
                else
                {
                    e.Cancel = true; // Ngăn chặn việc đóng form nếu người dùng chọn "No"
                }
            }
        }

        // lưu thông tin vào bảng sự kiện và bảng lịch
        private void button2_Click(object sender, EventArgs e)
        {
            string tenSuKien = textBox1.Text;
            string ngayTaoSuKien = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            string ngayKetThucSuKien = dateTimePicker2.Value.ToString("dd/MM/yyyy");
            string trangThai = comboBox5.SelectedItem.ToString();
            string ghiChu = textBoxGhiChu.Text;
            string thoiGianBatDau = $"{comboBox1.SelectedItem:D2}:{comboBox2.SelectedItem:D2}";
            string thoiGianKetThuc = $"{comboBox3.SelectedItem:D2}:{comboBox4.SelectedItem:D2}";

            using (NpgsqlConnection connection = new NpgsqlConnection(Helper.ConnectionString))
            {
                connection.Open();

                string query = "INSERT INTO sukien (tensk, thoigianbd, thoigiankt, trangthai, ghichu, sukien_id) " +
                               "VALUES (@tensk, @thoigianbd, @thoigiankt, @trangthai, @ghichu, @sukien_id) " +
                               "RETURNING mask";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tensk", tenSuKien);
                    command.Parameters.AddWithValue("@thoigianbd", TimeSpan.ParseExact(thoiGianBatDau, "hh\\:mm", null));
                    command.Parameters.AddWithValue("@thoigiankt", TimeSpan.ParseExact(thoiGianKetThuc, "hh\\:mm", null));
                    command.Parameters.AddWithValue("@trangthai", trangThai);
                    command.Parameters.AddWithValue("@ghichu", ghiChu);
                    command.Parameters.AddWithValue("@sukien_id", userId);

                    int mask = Convert.ToInt32(command.ExecuteScalar()); // Lấy giá trị mask từ bảng "sukien"

                    string insertLichQuery = "INSERT INTO lich (ngaytaosukien, ngayketthucsukien, id, mask) " +
                                             "VALUES (@ngaytaosukien, @ngayketthucsukien, @id, @mask)";

                    using (NpgsqlCommand insertLichCommand = new NpgsqlCommand(insertLichQuery, connection))
                    {
                        insertLichCommand.Parameters.AddWithValue("@ngaytaosukien", ngayTaoSuKien);
                        insertLichCommand.Parameters.AddWithValue("@ngayketthucsukien", ngayKetThucSuKien);
                        insertLichCommand.Parameters.AddWithValue("@id", userId);
                        insertLichCommand.Parameters.AddWithValue("@mask", mask);

                        int rowsAffected = insertLichCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm sự kiện và lịch thành công.");
                            // Reset controls or do other necessary actions
                        }
                        else
                        {
                            MessageBox.Show("Thêm sự kiện và lịch thất bại.");
                        }
                    }
                }
            }
        }
        private void UpdateSelectedTimeLabel()
        {
            if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
            {
                int selectedHour = (int)comboBox1.SelectedItem;
                int selectedMinute = (int)comboBox2.SelectedItem;
                labelSelectedTime.Text = $"Thời gian bắt đầu: {selectedHour:D2}:{selectedMinute:D2}";

                CheckTimeValidity();
            }
        }

        private void UpdateEndTimeLabel()
        {
            if (comboBox3.SelectedItem != null && comboBox4.SelectedItem != null)
            {
                int selectedHour = (int)comboBox3.SelectedItem;
                int selectedMinute = (int)comboBox4.SelectedItem;
                endTime.Text = $"Thời gian kết thúc: {selectedHour:D2}:{selectedMinute:D2}";

                CheckTimeValidity();
            }
        }

        private void CheckTimeValidity()
        {
            if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null)
            {
                int startHour = (int)comboBox1.SelectedItem;
                int startMinute = (int)comboBox2.SelectedItem;
                int endHour = (int)comboBox3.SelectedItem;
                int endMinute = (int)comboBox4.SelectedItem;

                TimeSpan startTime = new TimeSpan(startHour, startMinute, 0);
                TimeSpan endTime = new TimeSpan(endHour, endMinute, 0);

                if (startTime >= endTime)
                {
                    MessageBox.Show("Thời gian bắt đầu phải nhỏ hơn thời gian kết thúc.");
                }
            }
        }
    }
}
