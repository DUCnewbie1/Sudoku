using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace QuanLyThoiGian
{
    public partial class CheckEmail : Form
    {
        KiemTraNhapChuoi EmailTextBoxHandler;
        public CheckEmail()
        {
            InitializeComponent();
            EmailTextBoxHandler = Helper.EmailTextBoxHandler;
        }

        private void Huy_Click(object sender, EventArgs e)
        {
            DangNhap f = new DangNhap();
            f.Show();
            this.Hide();
        }

        private void CheckEmail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) // Kiểm tra nếu như form được đóng bởi người dùng
            {
                if (Helper.ConfirmExit())
                {
                    // Hủy sự kiện đóng form để ngăn form đóng đi khi người dùng nhấn nút "X"
                    DangNhap f = new DangNhap();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void XacNhan_Click(object sender, EventArgs e)
        {
            string Email = txt_Email.Text;
            if (string.IsNullOrEmpty(Email))
            {
                MessageBox.Show("Vui lòng điền Email.");
                return;
            }
            if (!Helper.EmailDung(Email))
            {
                MessageBox.Show("Cấu trúc Email không hợp lệ, mời nhập lại");
                return;
            }
        }
    }
}
