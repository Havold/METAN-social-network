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

namespace Instagram
{
    public partial class CmtItem : UserControl
    {
        string username, content, idPost, avatarPath,idCmt;
        DateTime timeCmt;
        string userOnline;
        string userPost;
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=INSTAGRAM;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;
        public CmtItem()
        {
            InitializeComponent();
        }

        public void setUserPost(string userPost)
        {
            this.userPost = userPost;
        }

        public void setUserOnline(string userOnline)
        {
            this.userOnline = userOnline;
        }

        public void loadData(string idCmt,string username, string content, string idPost, DateTime timeCmt)
        {
            this.idCmt = idCmt;
            this.username = username;
            this.content = content;
            this.idPost = idPost;
            this.timeCmt = timeCmt;
            setAvatar(username);
            avatar.Image = Image.FromFile(avatarPath);
            txtTime.Text = timeCmt.ToString();
            txtUserPost.Text = username;
            txtCmt.Text = content;

        }

        private void setAvatar(string username)
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
            sqlCmd.CommandText = "SELECT AVATAR FROM ACCOUNT WHERE USERNAME = '" + username + "'";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                this.avatarPath = reader.GetString(0);
            }
            reader.Close();
            sqlCon.Close();
        }

        public event EventHandler DeleteClicked;


        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (userOnline != username && userOnline != userPost)
            {
                MessageBox.Show("Bạn không phải người viết bình luận này nên không thể xóa bài viết này", "Thông báo");
                return;
            }
            // Hiển thị hộp thoại hỏi
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bài viết này không?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            // Kiểm tra phản hồi từ người dùng
            if (result == DialogResult.OK)
            {
                // Người dùng chọn OK, thực hiện xóa
                // Code xóa ở đây
                deleteCmt();
                // Khi UserControl Song được bấm, gửi sự kiện để thông báo
                DeleteClicked?.Invoke(this, EventArgs.Empty);
                // Hiển thị thông báo đã xóa
                MessageBox.Show("Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Người dùng chọn Cancel hoặc đóng hộp thoại, không thực hiện xóa
            }
        }

        private void deleteCmt()
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
            // XÓA COMMENT
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "DELETE FROM COMMENT WHERE MACMT = '"+idCmt+"'";
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();
            
        }
    }
}
