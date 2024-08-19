using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Instagram
{
    public partial class Register : Form
    {
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=INSTAGRAM;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;

        public Register()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            edtName.BackColor = ColorTranslator.FromHtml("#1c2a33");
            edtName.ForeColor = ColorTranslator.FromHtml("#b5bdc8");

            edtUsername.BackColor = ColorTranslator.FromHtml("#1c2a33");
            edtUsername.ForeColor = ColorTranslator.FromHtml("#b5bdc8");

            edtPhone.BackColor = ColorTranslator.FromHtml("#1c2a33");
            edtPhone.ForeColor = ColorTranslator.FromHtml("#b5bdc8");

            edtEmail.BackColor = ColorTranslator.FromHtml("#1c2a33");
            edtEmail.ForeColor = ColorTranslator.FromHtml("#b5bdc8");

            edtPwd.BackColor = ColorTranslator.FromHtml("#1c2a33");
            edtPwd.ForeColor = ColorTranslator.FromHtml("#b5bdc8");
        }

        private bool CheckValid(string username, string email, string phone)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection();
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT USERNAME,PHONE,EMAIL FROM ACCOUNT";

            sqlCmd.Connection = sqlCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string usernameGet = reader.GetString(0);
                string phoneGet = reader.GetString(1);
                string emailGet = reader.GetString(2);

                if (username == usernameGet)
                {
                    MessageBox.Show("Username đã tồn tại. Vui lòng chọn một username khác!", "Thất bại");
                    reader.Close();
                    return false;
                }
                else if (email == emailGet)
                {
                    MessageBox.Show("Email này đã được dùng để đăng ký. Vui lòng chọn email khác!", "Thất bại");
                    reader.Close();
                    return false;
                }
                else if (phone == phoneGet)
                {
                    MessageBox.Show("Số điện thoại này đã được dùng để đăng ký. Vui lòng chọn số điện thoại khác!", "Thất bại");
                    reader.Close();
                    return false;

                }
            }
            reader.Close();
            return true;

        }


        void resetEdt()
        {
            if (edtName.Text == string.Empty)
            {
                edtName.Text = "Nhập họ tên";
            }
            if (edtUsername.Text == string.Empty)
            {
                edtUsername.Text = "Nhập Username";
            }
            if (edtPhone.Text == string.Empty)
            {
                edtPhone.Text = "Nhập số điện thoại";
            }
            if (edtEmail.Text == string.Empty)
            {
                edtEmail.Text = "Nhập địa chỉ email";
            }
            if (edtPwd.Text == string.Empty)
            {
                edtPwd.Text = "Nhập mật khẩu";
            }
        }

        private void createBtn_MouseEnter(object sender, EventArgs e)
        {
            createBtn.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\createBtn_MouseEnter.png");
        }

        private void createBtn_MouseLeave(object sender, EventArgs e)
        {
            createBtn.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\createBtn.png");
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
            backBtn.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\backBtn_MouseEnter.png");
        }

        private void backBtn_MouseLeave(object sender, EventArgs e)
        {
            backBtn.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\backBtnWhite.png");
        }

        private void edtName_Click(object sender, EventArgs e)
        {
            resetEdt();
            if (edtName.Text == "Nhập họ tên")
            {
                edtName.Text = string.Empty;
            }
        }

        private void edtUsername_Click(object sender, EventArgs e)
        {
            resetEdt();
            if (edtUsername.Text == "Nhập Username")
            {
                edtUsername.Text = string.Empty;
            }
        }

        private void edtPhone_Click(object sender, EventArgs e)
        {
            resetEdt();
            if (edtPhone.Text == "Nhập số điện thoại")
            {
                edtPhone.Text = string.Empty;
            }
        }

        private void edtEmail_Click(object sender, EventArgs e)
        {
            resetEdt();
            if (edtEmail.Text == "Nhập địa chỉ email")
            {
                edtEmail.Text = string.Empty;
            }
        }

        private void edtPwd_Click(object sender, EventArgs e)
        {
            resetEdt();
            if (edtPwd.Text == "Nhập mật khẩu")
            {
                edtPwd.Text = string.Empty;
            }
        }

        private void maleSelect_Click(object sender, EventArgs e)
        {
            resetEdt();
        }

        private void femaleSelect_Click(object sender, EventArgs e)
        {
            resetEdt();
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strcCon);
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            // Lay du lieu
            string name = edtName.Text.Trim();
            string username = edtUsername.Text.Trim();
            string email = edtEmail.Text.Trim();
            string pwd = edtPwd.Text.Trim();
            string phone = edtPhone.Text.Trim();
            DateTime birth = txtDate.Value;
            string sex = "F";

            if (maleSelect.Checked)
            {
                sex = "M";
            }

            // Kiem tra xem email co hop le khong?
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ", "Lỗi");
                return;
            }

            if (!IsValidPhoneNumber(phone))
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Lỗi");
                return;
            }

            if (!CheckValid(username, email, phone))
            {
                return;
            }

            //DateTime dateTime = DateTime.Now;

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO ACCOUNT VALUES(@USERNAME,@FULLNAME,@BIRTH,@SEX,@PHONE,@EMAIL,@PASSWORD,'C:\\C#\\Instagram\\png\\avatar\\default.png',0,0,0,'')";

            SqlParameter parName = new SqlParameter("@FULLNAME", SqlDbType.VarChar);
            SqlParameter parUsername = new SqlParameter("@USERNAME", SqlDbType.VarChar);
            SqlParameter parPhone = new SqlParameter("@PHONE", SqlDbType.VarChar);
            SqlParameter parEmail = new SqlParameter("@EMAIL", SqlDbType.VarChar);
            SqlParameter parDate = new SqlParameter("@BIRTH", SqlDbType.SmallDateTime);
            SqlParameter parPwd = new SqlParameter("@PASSWORD", SqlDbType.VarChar);
            SqlParameter parSex = new SqlParameter("@SEX", SqlDbType.Char);
            

            parDate.Value = birth;
            parName.Value = name;
            parUsername.Value = username;
            parPhone.Value = phone;
            parEmail.Value = email;
            parPwd.Value = pwd;
            parSex.Value = sex;
            

            sqlCmd.Parameters.Add(parName);
            sqlCmd.Parameters.Add(parUsername);
            sqlCmd.Parameters.Add(parEmail);
            sqlCmd.Parameters.Add(parDate);
            sqlCmd.Parameters.Add(parPwd);
            sqlCmd.Parameters.Add(parSex);
            sqlCmd.Parameters.Add(parPhone);

            sqlCmd.Connection = sqlCon;

            int kq = sqlCmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Đăng ký tài khoản thành công", "Thành công");
                edtEmail.Text = "Nhập địa chỉ email";
                edtName.Text = "Nhập họ tên";
                edtUsername.Text = "Nhập Username";
                edtPwd.Text = "Nhập mật khẩu";
                edtPhone.Text = "Nhập số điện thoại";
            }
            else
            {
                MessageBox.Show("Đăng ký tài khoản thất bại", "Lỗi");
            }
        }

        private bool IsValidEmail(string email)
        {
            // Biểu thức chính quy để kiểm tra định dạng email
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Sử dụng Regex.IsMatch để kiểm tra
            return Regex.IsMatch(email, pattern);
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Biểu thức chính quy để kiểm tra định dạng số điện thoại
            string pattern = @"^\d{10}$";

            // Sử dụng Regex.IsMatch để kiểm tra
            return Regex.IsMatch(phoneNumber, pattern);
        }
    }
}
