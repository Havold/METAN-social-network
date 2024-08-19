using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Instagram
{
    public partial class Notification : UserControl
    {
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=INSTAGRAM;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;
        string username, fullname, avatarPath, usernameOnline;
        public event EventHandler CloseButtonClicked;
        string idPost;
        public Notification()
        {
            InitializeComponent();
            listNoti.AutoScroll = true;
            loadItem();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void loadItem()
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
            sqlCmd.CommandText = "SELECT TOP 1 USERNAME,AVATAR FROM ONLINE ORDER BY TIMEIN DESC";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                usernameOnline = reader.GetString(0);
                avatarPath = reader.GetString(1);
            }

            reader.Close();

            loadRequestData(usernameOnline);
            loadLikeData(usernameOnline);
            loadCmtData(usernameOnline);
            


        }

        private void loadLikeData(string usernameOnline)
        {
            DateTime date;
            string seen;
            // MỞ KẾT NỐI
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strcCon);
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            // Load data trong TABLE ACCOUNT để lấy thông tin điền vào Item và Add vào listUser
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandText = "SELECT USERNAME_LIKE,MAPOST,TIME_LIKE,SEEN FROM LIKE_STATUS WHERE USER_POST='" + usernameOnline + "'";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                username = reader.GetString(0);
                idPost = reader.GetString(1);
                date = reader.GetDateTime(2);
                seen = reader.GetString(3);
                if (username == usernameOnline)
                {
                    continue;
                }
                //Tạo Item
                NotiItem item = new NotiItem();
                item.loadLiketData(username, date, seen,idPost); //isOutcome=true
                item.ItemClicked += Item_LikeClicked;
                listNoti.Controls.Add(item);
            }


            reader.Close();
        }

        private void loadCmtData(string usernameOnline)
        {
            DateTime date;
            string seen;
            // MỞ KẾT NỐI
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strcCon);
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            // Load data trong TABLE ACCOUNT để lấy thông tin điền vào Item và Add vào listUser
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandText = "SELECT USERNAME_CMT,MAPOST,TIMECMT,SEEN FROM COMMENT WHERE USER_POST='" + usernameOnline + "'";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                username = reader.GetString(0);
                idPost = reader.GetString(1);
                date = reader.GetDateTime(2);
                seen = reader.GetString(3);
                if (username == usernameOnline)
                {
                    continue;
                }
                //Tạo Item
                NotiItem item = new NotiItem();
                item.loadCmtData(username, date, seen, idPost); //isOutcome=true
                item.ItemClicked += Item_LikeClicked;
                listNoti.Controls.Add(item);
            }
            reader.Close();
        }

        private void Item_LikeClicked(object? sender, EventArgs e)
        {
            // Xử lý khi một UserControl Song được bấm
            if (sender is NotiItem clickedNoti)
            {
                // Bạn có thể sử dụng theo cách bạn muốn
                // Đăng ký sự kiện từ changeDefault
                postInUser.CloseButtonClicked += Close_CloseButtonClicked;
                postInUser.setUserOnline(usernameOnline);
                postInUser.loadData(clickedNoti.idPost);
                postInUser.setFromNoti(true);
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
                commentPost.setUserOnline(usernameOnline);
                commentPost.setAvatar(avatarPath);
                commentPost.setFromNoti(true);
                commentPost.setUserPost(clickedPost.userPost);
                commentPost.loadCmt();
                commentPost.Visible = true;
                postInUser.Visible = false;
            }
        }

        private void loadRequestData(string usernameOnline)
        {
            DateTime date;
            string seen;
            // MỞ KẾT NỐI
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strcCon);
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            // Load data trong TABLE ACCOUNT để lấy thông tin điền vào Item và Add vào listUser
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandText = "SELECT USER_REQUEST,TIMEREQUEST,SEEN FROM REQUEST WHERE USER_REQUESTED='" + usernameOnline + "'";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                username = reader.GetString(0);
                date = reader.GetDateTime(1);
                seen = reader.GetString(2);
                if (username == usernameOnline)
                {
                    continue;
                }
                //Tạo Item
                NotiItem item = new NotiItem();
                item.loadRequestData(username, date,seen); //isOutcome=true
                item.ItemClicked += Item_ItemClicked;
                listNoti.Controls.Add(item);
            }


            reader.Close();
        }

        private void Item_ItemClicked(object? sender, EventArgs e)
        {
            // Xử lý khi một UserControl Song được bấm
            if (sender is NotiItem clickedAccount)
            {
                // Bạn có thể sử dụng theo cách bạn muốn
                // Đăng ký sự kiện từ changeDefault
                userProfile.CloseButtonClicked += Close_CloseButtonClicked;
                userProfile.setUser_Request(clickedAccount.username_tmp);
                userProfile.Visible = true;
            }
        }
        private void Close_CloseButtonClicked(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

    }
}
