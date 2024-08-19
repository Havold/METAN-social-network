using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Instagram
{
    public partial class ResetPassword : Form
    {
        string email;
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=INSTAGRAM;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;
        public ResetPassword()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            edtEmail.BackColor = ColorTranslator.FromHtml("#1c2a33");
            edtEmail.ForeColor = ColorTranslator.FromHtml("#b5bdc8");
        }

        private void resetBtn_MouseEnter(object sender, EventArgs e)
        {
            resetBtn.Image = Image.FromFile("D:\\C#\\Instagram\\png\\4x\\resetBtn_MouseEnter.png");
        }

        private void resetBtn_MouseLeave(object sender, EventArgs e)
        {
            resetBtn.Image = Image.FromFile("D:\\C#\\Instagram\\png\\4x\\resetBtn.png");
        }

        /*private void resetBtn_Click(object sender, EventArgs e)
        {
            if (edtEmail.Text == string.Empty)
            {
                edtEmail.Text = "Nhập email của bạn";
                MessageBox.Show("Vui lòng nhập địa chỉ email mà bạn đã đăng ký.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (IsValidEmail(edtEmail.Text))
            {
                MessageBox.Show("Mật khẩu mới đã được gửi đến email của bạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một địa chỉ email hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        // Phương thức kiểm tra tính hợp lệ của địa chỉ email
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (edtEmail.Text == string.Empty)
            {
                edtEmail.Text = "Nhập email của bạn";
            }

            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void backBtn_MouseEnter(object sender, EventArgs e)
        {
            backBtn.Image = Image.FromFile("D:\\C#\\Instagram\\png\\4x\\backBtn_MouseEnter.png");
        }

        private void backBtn_MouseLeave(object sender, EventArgs e)
        {
            backBtn.Image = Image.FromFile("D:\\C#\\Instagram\\png\\4x\\backBtn.png");
        }

        private void edtEmail_Click(object sender, EventArgs e)
        {
            if (edtEmail.Text== "Nhập email của bạn")
            {
                edtEmail.Text= string.Empty;
            }
        }


        private void sendBtn_Click(object sender, EventArgs e)
        {
            email = edtEmail.Text;

            if (email.Trim() == "") { MessageBox.Show("Please enter the gmail!"); return; }

            if (!IsValidEmail(email))
            {
                return;
            }
            if (!CheckValid(email))
            {
                return;
            }
            else
            {
                MailMessage mail = new MailMessage();
                string mailFrom = "21521479@gm.uit.edu.vn";
                mail.From = new System.Net.Mail.MailAddress(mailFrom);
                SmtpClient smtp = new SmtpClient();
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(mail.From.Address, "hyyg djmo ejlt licw");
                smtp.Host = "smtp.gmail.com";
                mail.To.Add(new MailAddress(email));
                mail.IsBodyHtml = true;
                string newPass = GenerateRandomString(8);
                mail.Subject = "New METAN password";
                mail.Body = "Your new password: " + newPass;
                //string query = "Update Taikhoan set MK = '" + mknew + "' where TenTK = '" + Properties.Settings.Default.getTenTK + "'";
                //Modify.command(query);
                smtp.Send(mail);
                MessageBox.Show("Mật khẩu mới đã được gửi đến email của bạn!", "Thành công");
                updatePass(newPass, email);
                edtEmail.Text = "";

            }
        }

        private void updatePass(string newPass, string email)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strcCon);
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "UPDATE ACCOUNT SET PASSWORD = '" + newPass + "' WHERE EMAIL = '" + email + "'";
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();

            sqlCmd.CommandText = "UPDATE ONLINE SET PASSWORD = '" + newPass + "' WHERE EMAIL = '" + email + "'";
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();
        }

        static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();

            char[] randomArray = new char[length];
            for (int i = 0; i < length; i++)
            {
                randomArray[i] = chars[random.Next(chars.Length)];
            }

            return new string(randomArray);
        }

        private bool CheckValid(string email)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strcCon);
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT EMAIL FROM ACCOUNT";

            sqlCmd.Connection = sqlCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string emailGet = reader.GetString(0);

                if (email == emailGet)
                {

                    reader.Close();
                    return true;
                }
            }
            reader.Close();
            MessageBox.Show("Email này chưa được đăng ký để sử dụng", "Lỗi");
            return false;

        }
    }
}
