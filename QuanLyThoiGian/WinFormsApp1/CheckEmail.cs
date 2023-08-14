using Npgsql;
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
using System.Net;
using System.Net.Mail;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Net.Mime.MediaTypeNames;

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
            // Thực hiện lưu thông tin vào cơ sở dữ liệu
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(Helper.ConnectionString))
                {
                    conn.Open();
                    // Kiểm tra xem Email có tồn tại không
                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "SELECT COUNT(*) FROM THONGTINTK WHERE Email = @Email";
                        cmd.Parameters.AddWithValue("@Email", Email);
                        int EmailCount = Convert.ToInt32(cmd.ExecuteScalar());
                        if (EmailCount == 0)
                        {
                            MessageBox.Show("Email này không tồn tại. Vui lòng nhập lại.");
                            return;
                        }
                    }
                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "SELECT TENTK, MATKHAU FROM THONGTINTK WHERE Email = @Email";
                        cmd.Parameters.AddWithValue("@Email", Email);
                        using (NpgsqlDataReader data = cmd.ExecuteReader())
                        {
                            if (data.Read())
                            {
                                string tentk = data["TENTK"].ToString();
                                string matkhau = data["MATKHAU"].ToString();
                                string EmailNhap = txt_Email.Text;
                                MailMessage message = new MailMessage();
                                SmtpClient smtp = new SmtpClient();
                                message.From = new MailAddress("dungkcr17@gmail.com");
                                message.To.Add(new MailAddress(EmailNhap));
                                message.Body = $"Xin chào {tentk},\nTên tài khoản của bạn là: {tentk}\nMật khẩu của bạn là: {matkhau}";
                                smtp.Port = 587;
                                smtp.Host = "smtp.gmail.com";
                                smtp.EnableSsl = true;
                                smtp.UseDefaultCredentials = false;
                                smtp.Credentials = new NetworkCredential("dungkcr17@gmail.com", "llaelxlmtnxyriyh\r\n");
                                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                                try
                                {
                                    smtp.Send(message);
                                    MessageBox.Show("Email gửi thành công, hãy kiểm tra Email để lấy thông tin tài khoản!.");
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Có lỗi trong quá trình gửi Email: " + ex.Message);
                                }
                            }
                        }
                    }
                    DangNhap f = new DangNhap();
                    f.Show();
                    this.Hide();
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình xác nhận Email: " + ex.Message);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo { FileName = "https://accounts.google.com/signin/v2/usernamerecovery?flowName=GlifWebSignIn&flowEntry=ServiceLogin", UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không thể mở link: " + ex.Message);
            }
        }
    }
}
