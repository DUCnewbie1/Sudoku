using System;
using System.Windows.Forms;
using WinFormsApp1;

namespace QuanLyThoiGian
{
    public partial class TaoSuKien : Form
    {
        private int currentUserId;

        public TaoSuKien()
        {
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
        }

        // nhập tên sự kiện
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
