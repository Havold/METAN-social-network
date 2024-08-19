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
    public partial class ProfileFragment : UserControl
    {
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=INSTAGRAM;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;
        string username, fullname, avatarPath, caption;
        int post, follower, follow;
        // Định nghĩa một sự kiện để thông báo khi đóng UserControl2
        public event EventHandler CloseButtonClicked;
        // Định nghĩa một sự kiện để thông báo khi đóng UserControl2
        public event EventHandler EditButtonClicked;
        public ProfileFragment()
        {
            InitializeComponent();
            postInUser.setUserOnline(username);
            loadData();
        }

        public void loadData()
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
            sqlCmd.CommandText = "SELECT TOP 1 USERNAME,FULLNAME,AVATAR,CAPTION,NUM_POST,NUM_FOLLOWER,NUM_FOLLOW FROM ONLINE ORDER BY TIMEIN DESC";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                username = reader.GetString(0);
                fullname = reader.GetString(1);
                avatarPath = reader.GetString(2);
                caption = reader.GetString(3);
                post = reader.GetInt32(4);
                follower = reader.GetInt32(5);
                follow = reader.GetInt32(6);
            }

            avatar.Image = Image.FromFile(avatarPath);
            txtUsername.Text = username;
            txtName.Text = fullname;
            txtCaption.Text = caption;
            txtPost.Text = post.ToString();
            txtFollow.Text = follow.ToString();
            txtFollowers.Text = follower.ToString();
            reader.Close();

            // CẬP NHẬT POST
            sqlCmd.CommandText = "SELECT MAPOST FROM POST WHERE USERNAME ='" + username + "'";
            sqlCmd.Connection = sqlCon;
            reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                string idPost;
                idPost = reader.GetString(0);
                PostItem postItem = new PostItem();
                postItem.loadData(idPost);
                postItem.ItemClicked += Item_ItemClicked;
                listPost.Controls.Add(postItem);
            }
            reader.Close();
            sqlCon.Close();
        }

        private void Cmt_ItemClicked(object? sender, EventArgs e)
        {
            // Xử lý khi một UserControl Song được bấm
            if (sender is PostInUser clickedPost)
            {
                // Bạn có thể sử dụng theo cách bạn muốn
                commentPost.CloseButtonClicked += Close_CloseButtonClicked;
                commentPost.setIdPost(clickedPost.idPost);
                commentPost.setUserOnline(username);
                commentPost.setAvatar(avatarPath);
                commentPost.setFromProfile(true);
                commentPost.setUserPost(clickedPost.userPost);
                commentPost.loadCmt();
                commentPost.Visible = true;
                postInUser.Visible = false;
            }
        }

        private void Item_ItemClicked(object? sender, EventArgs e)
        {
            // Xử lý khi một UserControl Song được bấm
            if (sender is PostItem clickedPost)
            {
                // Bạn có thể sử dụng theo cách bạn muốn
                postInUser.CloseButtonClicked += Close_CloseButtonClicked;
                postInUser.loadData(clickedPost.idPost);
                postInUser.setUserOnline(username);
                postInUser.CmtClicked += Cmt_ItemClicked;
                postInUser.Visible = true;
            }

        }

        private void Close_CloseButtonClicked(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            // Khi nút Close được bấm, kích hoạt sự kiện CloseButtonClicked
            CloseButtonClicked?.Invoke(this, EventArgs.Empty);
            this.Hide();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile();
            editProfile.Show();
            // Khi nút Close được bấm, kích hoạt sự kiện CloseButtonClicked
            EditButtonClicked?.Invoke(this, EventArgs.Empty);
            this.Hide();
        }

        private void shareBtn_Click(object sender, EventArgs e)
        {
            qrCode.createQRcode(username);
            qrCode.Show();
        }

        private void txtFollow_Click(object sender, EventArgs e)
        {
            showFollow.setUserOnline(username);
            showFollow.setFollow(true);
            showFollow.loadData();
            showFollow.Visible = true;
        }

        private void txtFollowers_Click(object sender, EventArgs e)
        {
            showFollow.setUserOnline(username);
            showFollow.setFollow(false);
            showFollow.loadData();
            showFollow.Visible = true;
        }
    }
}
