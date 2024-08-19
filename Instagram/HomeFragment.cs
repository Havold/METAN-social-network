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
    public partial class HomeFragment : UserControl
    {
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=INSTAGRAM;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;
        int tmp;
        string userOnline;
        string avatarPath;
        // Định nghĩa một sự kiện để thông báo khi đóng UserControl2
        public event EventHandler CloseButtonClicked;
        public HomeFragment()
        {
            InitializeComponent();
            getUserOnline();
            loadPost();
        }

        private void Item_ItemClicked(object? sender, EventArgs e)
        {
            // Xử lý khi một UserControl Song được bấm
            if (sender is Post clickedPost)
            {
                // Bạn có thể sử dụng theo cách bạn muốn
                userProfile.CloseButtonClicked += Close_CloseButtonClicked;
                userProfile.setUser(clickedPost.userPost, true);
                userProfile.Visible = true;
            }
        }

        private void Close_CloseButtonClicked(object sender, EventArgs e)
        {
            this.ParentForm.Close();
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
                avatarPath = reader.GetString(1);
            }

            sqlCon.Close();
        }

        private void loadPost()
        {
            if (!checkValidNumPost())
            {
                return;
            }
            txtNoOne.Visible = false;
            // MỞ KẾT NỐI
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
            sqlCmd.CommandText = "SELECT MAPOST FROM POST ORDER BY TIMEPOST DESC";
            sqlCmd.Connection = sqlCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                string idPost;
                idPost = reader.GetString(0);
                Post postItem = new Post();
                postItem.setUserOnline(userOnline);
                postItem.loadData(idPost);
                postItem.ItemClicked += Item_ItemClicked;
                postItem.CmtClicked += Cmt_ItemClicked;
                postItem.CloseClicked += CloseButtonClicked;
                listPost.Controls.Add(postItem);
            }

            sqlCon.Close();
        }


        private void Cmt_ItemClicked(object? sender, EventArgs e)
        {
            // Xử lý khi một UserControl Song được bấm
            if (sender is Post clickedPost)
            {
                // Bạn có thể sử dụng theo cách bạn muốn
                commentPost.CloseButtonClicked += Close_CloseButtonClicked;
                commentPost.setIdPost(clickedPost.idPost);
                commentPost.setUserOnline(userOnline);
                commentPost.setAvatar(avatarPath);
                commentPost.setUserPost(clickedPost.userPost);
                commentPost.loadCmt();
                commentPost.Visible = true;
            }
        }

        private void messageIcon_Click(object sender, EventArgs e)
        {
            Messenger messenger = new Messenger();
            messenger.Show();
            // Khi nút Close được bấm, kích hoạt sự kiện CloseButtonClicked
            CloseButtonClicked?.Invoke(this, EventArgs.Empty);
            this.Hide();
        }

        private bool checkValidNumPost()
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
            sqlCmd.CommandText = "SELECT COUNT(*) FROM POST";
            sqlCmd.Connection = sqlCon;


            SqlDataReader reader = sqlCmd.ExecuteReader();
            
            while (reader.Read())
            {
                tmp = reader.GetInt32(0);
            }

            reader.Close();
            if (tmp>0)
            {
                return true;
            }
            else
            {
                return false;
            }
            sqlCon.Close();


        }

    }
}
