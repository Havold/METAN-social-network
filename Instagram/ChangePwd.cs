using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Instagram
{
    public partial class ChangePwd : UserControl
    {
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=INSTAGRAM;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;
        // Định nghĩa một sự kiện để thông báo khi đóng UserControl2
        public event EventHandler CloseButtonClicked;
        string username;
        public bool isChanged=false;
        public string password_tmp;
        bool eyeOpen = false;
        bool eyeOpen_2 = false;
        public ChangePwd()
        {
            InitializeComponent();
            edtNewPwd.BackColor = ColorTranslator.FromHtml("#1c2a33");
            edtNewPwd.ForeColor = ColorTranslator.FromHtml("#b5bdc8");
            edtOldPwd.BackColor = ColorTranslator.FromHtml("#1c2a33");
            edtOldPwd.ForeColor = ColorTranslator.FromHtml("#b5bdc8");
            eyeOld.BackColor = ColorTranslator.FromHtml("#1c2a33");
            eyeNew.BackColor = ColorTranslator.FromHtml("#1c2a33");
        }

        private void resetState()
        {
            edtNewPwd.Text = "Nhập mật khẩu mới";
            edtOldPwd.Text = "Nhập mật khẩu cũ";
            eyeOpen=false; eyeOpen_2 = false;
            edtNewPwd.PasswordChar = '\0';
            edtOldPwd.PasswordChar = '\0';
            eyeOld.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\eye_close.png");
            eyeNew.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\eye_close.png");
        }

        private void changeBtn_MouseEnter(object sender, EventArgs e)
        {
            changeBtn.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\changePwdBtn_MouseEnter.png");
        }

        private void changeBtn_MouseLeave(object sender, EventArgs e)
        {
            changeBtn.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\changePwdBtn.png");
        }

        /*private void edtOldPwd_Click(object sender, EventArgs e)
        {
            if (edtOldPwd.Text == "Nhập mật khẩu cũ")
            {
                edtOldPwd.Text = string.Empty;
            }
            if (edtNewPwd.Text == string.Empty)
            {
                edtNewPwd.Text = "Nhập mật khẩu mới";
            }
        }

        private void edtNewPwd_Click(Object sender, EventArgs e)
        {
            if (edtNewPwd.Text == "Nhập mật khẩu mới")
            {
                edtNewPwd.Text = string.Empty;
            }
            if (edtOldPwd.Text == string.Empty)
            {
                edtOldPwd.Text = "Nhập mật khẩu cũ";
            }
        }*/

        private void changeBtn_Click(object sender, EventArgs e)
        {
            string oldPwd = edtOldPwd.Text;
            string newPwd = edtNewPwd.Text;
            if (oldPwd==string.Empty || oldPwd=="Nhập mật khẩu cũ") {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ", "Lỗi");
                return;
            }

            if (newPwd == string.Empty || oldPwd == "Nhập mật khẩu mới")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới", "Lỗi");
                return;
            }
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
            sqlCmd.CommandText = "SELECT TOP 1 USERNAME FROM ONLINE ORDER BY TIMEIN DESC";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                username = reader.GetString(0);
            }
            reader.Close();

            sqlCmd.CommandText = "SELECT COUNT(*) FROM ACCOUNT WHERE USERNAME = @Username AND PASSWORD = @OldPassword";
            sqlCmd.Connection = sqlCon;

            // Sử dụng Parameters để tránh tấn công SQL Injection
            sqlCmd.Parameters.AddWithValue("@Username", username);
            sqlCmd.Parameters.AddWithValue("@OldPassword", oldPwd);

            // Thực hiện truy vấn và kiểm tra số lượng bản ghi trả về
            int count = Convert.ToInt32(sqlCmd.ExecuteScalar());

            if (count > 0)
            {
                // Có kết quả trả về, thực hiện thay đổi mật khẩu
                // Thêm mã lệnh ChangePassword ở đây
                changePass(username, newPwd);
                MessageBox.Show("Mật khẩu đã được đổi thành công!", "Thành công");
                resetState();
                isChanged = true;
                password_tmp = newPwd;
            }
            else
            {
                // Không có kết quả trả về, hiện thông báo lỗi
                MessageBox.Show("Mật khẩu cũ của bạn không đúng", "Lỗi");
            }

            sqlCon.Close();
        }

        private void changePass(string username, string newPwd)
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
            sqlCmd.CommandText = "UPDATE ACCOUNT SET PASSWORD = '" + newPwd + "' WHERE USERNAME = '" + username + "'";
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();

            sqlCmd.CommandText = "UPDATE ONLINE SET PASSWORD = '" + newPwd + "' WHERE USERNAME = '" + username + "'";
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            CloseButtonClicked?.Invoke(this, EventArgs.Empty);
            this.Hide();
        }

        private void edtOldPwd_Click_1(object sender, EventArgs e)
        {

            if (edtNewPwd.Text == "")
            {
                edtNewPwd.PasswordChar = '\0';
                edtNewPwd.Text = "Nhập mật khẩu mới";
            }

            if (edtOldPwd.Text == "Nhập mật khẩu cũ")
            {
                edtOldPwd.Text = "";
                edtOldPwd.PasswordChar = '*';

            }
        }

        private void edtNewPwd_Click_1(object sender, EventArgs e)
        {

            if (edtNewPwd.Text == "Nhập mật khẩu mới")
            {
                edtNewPwd.PasswordChar = '*';
                edtNewPwd.Text = "";
            }

            if (edtOldPwd.Text == "")
            {
                edtOldPwd.PasswordChar = '\0';
                edtOldPwd.Text = "Nhập mật khẩu cũ";
            }
        }
        private void eyeOld_Click(object sender, EventArgs e)
        {
            if (!eyeOpen)
            {
                eyeOpen = true;
                eyeOld.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\eye_open.png");
                edtOldPwd.PasswordChar = '\0';
            }
            else
            {
                eyeOpen = false;
                eyeOld.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\eye_close.png");
                edtOldPwd.PasswordChar = '*';
            }
        }

        private void eyeNew_Click(object sender, EventArgs e)
        {
            if (!eyeOpen_2)
            {
                eyeOpen_2 = true;
                eyeNew.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\eye_open.png");
                edtNewPwd.PasswordChar = '\0';
            }
            else
            {
                eyeOpen_2 = false;
                eyeNew.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\eye_close.png");
                edtNewPwd.PasswordChar = '*';
            }
        }
    }
}
