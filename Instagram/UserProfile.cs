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
using TCPchat;
using ZXing;

namespace Instagram
{
    public partial class UserProfile : UserControl
    {
        bool fromHome;
        // Định nghĩa một sự kiện để thông báo khi đóng UserControl2
        public event EventHandler CloseButtonClicked;
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=INSTAGRAM;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;
        string username, fullname, caption, avatarPath;
        string userOnline,avatarPathOnline;
        int post, follower, follow;
        bool request = false;
        public UserProfile()
        {
            InitializeComponent();
            getUserOnline();
            postInUser.setUserOnline(userOnline);
        }

        void getUserOnline()
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

            // LẤY THÔNG TIN 
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT TOP 1 USERNAME,AVATAR FROM ONLINE ORDER BY TIMEIN DESC";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                userOnline = reader.GetString(0);
                avatarPathOnline = reader.GetString(1);
            }

            sqlCon.Close();
        }

        public bool CheckUserValid(string username)
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
            // LẤY THÔNG TIN 
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT COUNT(*) FROM ACCOUNT WHERE USERNAME='" + username + "'";
            sqlCmd.Connection = sqlCon;

            // Thực hiện truy vấn và kiểm tra số lượng bản ghi trả về
            int count = Convert.ToInt32(sqlCmd.ExecuteScalar());

            if (count > 0)
            {
                return true;
            }

            return false;
        }

        public void setUser(string usernameGet, bool fromHome)
        {
            this.fromHome = fromHome;
            followBtn.Text = "Theo dõi";
            followBtn.BackColor = Color.DodgerBlue;

            // MỞ KẾT NỐI
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strcCon);
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            // LẤY THÔNG TIN 
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT USERNAME,FULLNAME,CAPTION,AVATAR,NUM_POST,NUM_FOLLOWER,NUM_FOLLOW FROM ACCOUNT WHERE USERNAME='" + usernameGet + "'";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();



            while (reader.Read())
            {
                username = reader.GetString(0);
                fullname = reader.GetString(1);
                caption = reader.GetString(2);
                avatarPath = reader.GetString(3);
                post = reader.GetInt32(4);
                follower = reader.GetInt32(5);
                follow = reader.GetInt32(6);
            }

            txtUsername.Text = username;
            txtName.Text = fullname;
            txtCaption.Text = caption;
            txtPost.Text = post.ToString();
            txtFollow.Text = follow.ToString();
            txtFollowers.Text = follower.ToString();
            avatar.Image = Image.FromFile(avatarPath);
            reader.Close();

            // CẬP NHẬT POST
            sqlCmd.CommandText = "SELECT MAPOST FROM POST WHERE USERNAME ='" + usernameGet + "'";
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

            // Set trạng thái button follow
            sqlCmd.CommandText = "SELECT COUNT(*) FROM REQUEST WHERE USER_REQUEST='" + userOnline + "' AND USER_REQUESTED='" + username + "'";
            sqlCmd.Connection = sqlCon;
            // Thực hiện truy vấn và kiểm tra số lượng bản ghi trả về
            int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
            if (count > 0)
            {
                followBtn.BackColor = Color.Gray;
                followBtn.Text = "Đã gửi yêu cầu";

            }



            sqlCmd.CommandText = "SELECT * FROM REQUEST WHERE USER_REQUEST='" + usernameGet + "' AND USER_REQUESTED='" + userOnline + "'";
            sqlCmd.Connection = sqlCon;
            reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                // Set trạng thái button follow
                followBtn.BackColor = Color.DodgerBlue;
                followBtn.Text = "Đồng ý";
            }

            reader.Close();

            sqlCmd.CommandText = "SELECT * FROM FOLLOW WHERE FOLLOWER='" + usernameGet + "' AND FOLLOW='" + userOnline + "' OR (FOLLOWER='" + userOnline + "' AND FOLLOW='" + usernameGet + "')";
            sqlCmd.Connection = sqlCon;
            reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                // Set trạng thái button follow
                followBtn.BackColor = Color.Black;
                followBtn.Text = "Đang theo dõi";
            }

            reader.Close();
        }

        private void Item_ItemClicked(object? sender, EventArgs e)
        {
            // Xử lý khi một UserControl Song được bấm
            if (sender is PostItem clickedPost)
            {
                // Bạn có thể sử dụng theo cách bạn muốn
                postInUser.CloseButtonClicked += Close_CloseButtonClicked;
                postInUser.loadData(clickedPost.idPost);
                postInUser.setFromFind(true);
                postInUser.CmtClicked += Cmt_ItemClicked;
                postInUser.Visible = true;
            }

        }

        private void Cmt_ItemClicked(object? sender, EventArgs e)
        {
            // Xử lý khi một UserControl Song được bấm
            if (sender is PostInUser clickedPost)
            {
                // Bạn có thể sử dụng theo cách bạn muốn
                commentPost.CloseButtonClicked += Close_CloseButtonClicked;
                commentPost.setIdPost(clickedPost.idPost);
                commentPost.setUserOnline(userOnline);
                commentPost.setAvatar(avatarPathOnline);
                commentPost.setFromFind(true);
                commentPost.setUserPost(clickedPost.userPost);
                commentPost.loadCmt();
                commentPost.Visible = true;
                postInUser.Visible = false;
            }
        }


        private void Close_CloseButtonClicked(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        public void setUser_Request(string usernameGet)
        {
            request = true;
            followBtn.Text = "Theo dõi";
            followBtn.BackColor = Color.DodgerBlue;

            // MỞ KẾT NỐI
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strcCon);
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            // LẤY THÔNG TIN 
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT USERNAME,FULLNAME,CAPTION,AVATAR,NUM_POST,NUM_FOLLOWER,NUM_FOLLOW FROM ACCOUNT WHERE USERNAME='" + usernameGet + "'";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                username = reader.GetString(0);
                fullname = reader.GetString(1);
                caption = reader.GetString(2);
                avatarPath = reader.GetString(3);
                post = reader.GetInt32(4);
                follower = reader.GetInt32(5);
                follow = reader.GetInt32(6);
            }

            txtUsername.Text = username;
            txtName.Text = fullname;
            txtCaption.Text = caption;
            txtPost.Text = post.ToString();
            txtFollow.Text = follow.ToString();
            txtFollowers.Text = follower.ToString();
            avatar.Image = Image.FromFile(avatarPath);
            reader.Close();

            // CẬP NHẬT POST
            sqlCmd.CommandText = "SELECT MAPOST FROM POST WHERE USERNAME ='" + usernameGet + "'";
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

            // Set trạng thái button follow
            followBtn.BackColor = Color.DodgerBlue;
            followBtn.Text = "Đồng ý";
        }


        private void backBtn_Click(object sender, EventArgs e)
        {

            // Khi nút Close được bấm, kích hoạt sự kiện CloseButtonClicked
            MainPage mainPage = new MainPage();
            if (fromHome)
            {
                mainPage.ShowHome();
            }
            else if (request)
            {
                mainPage.ShowNotification();
            }
            else
            {
                mainPage.ShowFind();
            }
            CloseButtonClicked?.Invoke(this, EventArgs.Empty);
            mainPage.Show();


            this.Hide();

        }

        private void followBtn_Click(object sender, EventArgs e)
        {
            if (followBtn.Text == "Theo dõi")
            {
                followBtn.BackColor = Color.Gray;
                followBtn.Text = "Đã gửi yêu cầu";
                sendRequest(username);
            }

            else if (followBtn.Text == "Đã gửi yêu cầu")
            {
                followBtn.BackColor = Color.DodgerBlue;
                followBtn.Text = "Theo dõi";
                deleteRequest(username);
            }

            else if (followBtn.Text == "Đang theo dõi")
            {
                followBtn.BackColor = Color.DodgerBlue;
                followBtn.Text = "Theo dõi";
                deleteFollow(username);
                decreaseNumFollowSQL(username);
            }

            else if (followBtn.Text == "Đồng ý")
            {
                followBtn.BackColor = Color.Black;
                followBtn.Text = "Đang theo dõi";
                updateFollow(username);
                deleteRequest(username);

            }
        }

        private void updateFollow(string usernameGet)
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

            DateTime dateTime = DateTime.Now;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "UPDATE ACCOUNT SET NUM_FOLLOW=NUM_FOLLOW+1,NUM_FOLLOWER=NUM_FOLLOWER+1 WHERE USERNAME = '" + usernameGet + "' OR USERNAME = '" + userOnline + "'";
            sqlCmd.Connection = sqlCon;

            int kq = sqlCmd.ExecuteNonQuery();
            if (kq > 0)
            {

            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi hệ thống", "Lỗi");
            }

            sqlCmd.CommandText = "UPDATE ONLINE SET NUM_FOLLOW=NUM_FOLLOW+1,NUM_FOLLOWER=NUM_FOLLOWER+1 WHERE USERNAME = '" + usernameGet + "' OR USERNAME = '" + userOnline + "'";
            sqlCmd.Connection = sqlCon;

            kq = sqlCmd.ExecuteNonQuery();
            if (kq > 0)
            {

            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi hệ thống", "Lỗi");
            }

            dateTime = DateTime.Now;
            sqlCmd.CommandText = "INSERT INTO FOLLOW VALUES('" + usernameGet + "','" + userOnline + "','" + dateTime + "','N')";
            sqlCmd.Connection = sqlCon;

            kq = sqlCmd.ExecuteNonQuery();
            if (kq > 0)
            {

            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi hệ thống", "Lỗi");
            }

            sqlCon.Close();
        }

        private void sendRequest(string usernameGet)
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

            DateTime dateTime = DateTime.Now;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO REQUEST VALUES('" + userOnline + "','" + usernameGet + "','" + dateTime + "','N')";
            sqlCmd.Connection = sqlCon;

            int kq = sqlCmd.ExecuteNonQuery();
            if (kq > 0)
            {

            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi hệ thống", "Lỗi");
            }
            sqlCon.Close();
        }

        private void deleteRequest(string usernameGet)
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

            DateTime dateTime = DateTime.Now;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "DELETE FROM REQUEST WHERE USER_REQUEST='" + userOnline + "' AND USER_REQUESTED='" + usernameGet + "' OR (USER_REQUEST='" + usernameGet + "' AND USER_REQUESTED='" + userOnline + "')";
            sqlCmd.Connection = sqlCon;

            int kq = sqlCmd.ExecuteNonQuery();
            if (kq > 0)
            {

            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi hệ thống", "Lỗi");
            }
            sqlCon.Close();
        }

        private void deleteFollow(string usernameGet)
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

            DateTime dateTime = DateTime.Now;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "DELETE FROM FOLLOW WHERE FOLLOWER='" + userOnline + "' AND FOLLOW='" + usernameGet + "' OR (FOLLOWER='" + usernameGet + "' AND FOLLOW='" + userOnline + "')";
            sqlCmd.Connection = sqlCon;

            int kq = sqlCmd.ExecuteNonQuery();
            if (kq > 0)
            {

            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi hệ thống", "Lỗi");
            }
            sqlCon.Close();
        }

        private void messageBtn_Click(object sender, EventArgs e)
        {
            ChatBox chatBox = new ChatBox();
            chatBox.setUser(userOnline, username);
            chatBox.Show();
        }

        private void decreaseNumFollowSQL(string usernameGet)
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

            DateTime dateTime = DateTime.Now;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "UPDATE ACCOUNT SET NUM_FOLLOW=NUM_FOLLOW-1,NUM_FOLLOWER=NUM_FOLLOWER-1 WHERE USERNAME = '" + usernameGet + "' OR USERNAME = '" + userOnline + "'";
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();

            sqlCmd.CommandText = "UPDATE ONLINE SET NUM_FOLLOW=NUM_FOLLOW-1,NUM_FOLLOWER=NUM_FOLLOWER-1 WHERE USERNAME = '" + usernameGet + "' OR USERNAME = '" + userOnline + "'";
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();
        }
    }
}
