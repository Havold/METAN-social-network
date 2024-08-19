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
using System.Xml.Linq;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Instagram
{
    public partial class EditProfile : Form
    {
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=INSTAGRAM;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;
        string username, fullname, avatarPath, caption;
        public EditProfile()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            // MỞ KẾT NỐI
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strcCon);
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            // LẤY THÔNG TIN NGƯỜI ĐĂNG NHẬP GẦN NHẤT
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT TOP 1 USERNAME,FULLNAME,AVATAR,CAPTION FROM ONLINE ORDER BY TIMEIN DESC";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                username = reader.GetString(0);
                fullname = reader.GetString(1);
                avatarPath = reader.GetString(2);
                caption = reader.GetString(3);
            }

            avatar.Image = Image.FromFile(avatarPath);
            edtUsername.Text = username;
            edtFullname.Text = fullname;
            edtCaption.Text = caption;
            reader.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.ShowProfile();
            mainPage.Show();
            this.Close();
        }

        private void updateBtn_MouseEnter(object sender, EventArgs e)
        {
            updateBtn.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\updateBtn_MouseEnter.png");
        }

        private void updateBtn_MouseLeave(object sender, EventArgs e)
        {
            updateBtn.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\updateBtn.png");
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string edtUsername_tmp = edtUsername.Text;
            string edtFullname_tmp = edtFullname.Text;
            string edtCaption_tmp = edtCaption.Text;
            if (edtUsername_tmp != username)
            {
                if (CheckValid(edtUsername_tmp))
                {
                    ChangeUsername(edtUsername_tmp, username);
                }
                else
                {
                    return;
                }
            }
            if (edtFullname_tmp != fullname)
            {
                ChangeFullname(edtFullname_tmp, edtUsername_tmp);
            }
            if (edtCaption_tmp != caption)
            {
                ChangeCaption(edtCaption_tmp, edtUsername_tmp);
            }
            MessageBox.Show("Cập nhật thành công!", "Thành công");
        }

        private bool CheckValid(string username)
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
            sqlCmd.CommandText = "SELECT USERNAME FROM ACCOUNT";

            sqlCmd.Connection = sqlCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string usernameGet = reader.GetString(0);

                if (username == usernameGet)
                {
                    MessageBox.Show("Username đã tồn tại. Vui lòng chọn một username khác!", "Thất bại");
                    reader.Close();
                    return false;
                }
            }
            reader.Close();
            return true;
        }

        private void ChangeUsername(string usernameNew, string usernameOld)
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
            sqlCmd.CommandText = "UPDATE ACCOUNT SET USERNAME = '" + usernameNew + "' WHERE USERNAME = '" + usernameOld + "'";
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();

            sqlCmd.CommandText = "UPDATE ONLINE SET USERNAME = '" + usernameNew + "' WHERE USERNAME = '" + usernameOld + "'";
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();
        }

        private void ChangeFullname(string fullnameNew, string username)
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
            sqlCmd.CommandText = "UPDATE ACCOUNT SET FULLNAME = '" + fullnameNew + "' WHERE USERNAME = '" + username + "'";
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();

            sqlCmd.CommandText = "UPDATE ONLINE SET FULLNAME = '" + fullnameNew + "' WHERE USERNAME = '" + username + "'";
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();
        }

        private void ChangeCaption(string captionNew, string username)
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
            sqlCmd.CommandText = "UPDATE ACCOUNT SET CAPTION = '" + captionNew + "' WHERE USERNAME = '" + username + "'";
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();

            sqlCmd.CommandText = "UPDATE ONLINE SET CAPTION = '" + captionNew + "' WHERE USERNAME = '" + username + "'";
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();
        }

        private void editAvatar_MouseEnter(object sender, EventArgs e)
        {
            editAvatar.ForeColor = Color.White;
        }

        private void editAvatar_MouseLeave(object sender, EventArgs e)
        {
            editAvatar.ForeColor = Color.DodgerBlue;
        }

        private void editAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                // MỞ KẾT NỐI
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strcCon);
                }

                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                // LẤY THÔNG TIN NGƯỜI ĐĂNG NHẬP GẦN NHẤT
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "UPDATE ACCOUNT SET AVATAR = '" + imagePath + "' WHERE USERNAME='" + username + "'";
                sqlCmd.Connection = sqlCon;

                int kq = sqlCmd.ExecuteNonQuery();
                if (kq > 0)
                {

                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi hệ thống", "Lỗi");
                }

                sqlCmd.CommandText = "UPDATE ONLINE SET AVATAR = '" + imagePath + "' WHERE USERNAME='" + username + "'";
                sqlCmd.Connection = sqlCon;

                kq = sqlCmd.ExecuteNonQuery();
                if (kq > 0)
                {

                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi hệ thống", "Lỗi");
                }

                avatar.Image = Image.FromFile(imagePath);

            }
            MessageBox.Show("Changed avatar successfully!");
        }

        private void changeIcon_Click(object sender, EventArgs e)
        {
            changePwd.Visible = true;
            changePwd.CloseButtonClicked += ChangePwd_CloseButtonClicked;
        }

        private void ChangePwd_CloseButtonClicked(object? sender, EventArgs e)
        {
            if (changePwd.isChanged)
            {
                edtPwd.Text = changePwd.password_tmp;
            }
        }
    }
}
