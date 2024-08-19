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
    public partial class MainPage : Form
    {
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=INSTAGRAM;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;
        bool isOnHome = true;
        bool isOnFind = false;
        bool isOnProfile = false;
        bool isOnNotification = false;
        string avatar = "";
        string userOnline;

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
            sqlCmd.CommandText = "SELECT TOP 1 USERNAME FROM ONLINE ORDER BY TIMEIN DESC";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                userOnline = reader.GetString(0);
            }

            sqlCon.Close();
        }

        private void resetBtn()
        {
            homeIcon.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\Home.png");
            isOnHome = false;
            homeFragment.Visible = false;
            findIcon.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\find.png");
            isOnFind = false;
            profileIcon.BackColor = Color.Black;
            isOnProfile = false;
            notiIcon.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\favorite.png");
            isOnNotification = false;
            profileFragment.Visible = false;
            findFragment.Visible = false;
            notification.Visible= false;
            whiteCircle.Visible=false;
        }

        public MainPage()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            getUserOnline();
            
            loadImage();
            // Đăng ký sự kiện từ changeDefault
            homeFragment.CloseButtonClicked += CloseEdit_CloseButtonClicked;
            findFragment.CloseButtonClicked += CloseEdit_CloseButtonClicked;
            notification.CloseButtonClicked += CloseEdit_CloseButtonClicked;
        }

        public void ShowProfile()
        {
            if (!isOnProfile)
            {
                resetBtn();
                profileFragment.Visible = true;
                whiteCircle.Visible = true;
                profileIcon.BackColor = Color.White;
                // Đăng ký sự kiện từ changeDefault
                profileFragment.CloseButtonClicked += Close_CloseButtonClicked;
                profileFragment.EditButtonClicked += CloseEdit_CloseButtonClicked;
            }
        }

        public void ShowHome()
        {
            if (!isOnHome)
            {
                resetBtn();
                homeFragment.Visible = true;
                homeIcon.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\Home_full.png");
                // Đăng ký sự kiện từ changeDefault
                //notification.CloseButtonClicked += CloseEdit_CloseButtonClicked;
            }
        }

        public void ShowNotification()
        {
            if (!isOnNotification)
            {
                resetBtn();
                notification.Visible = true;
                notiIcon.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\favorite_on.png");
                // Đăng ký sự kiện từ changeDefault
                notification.CloseButtonClicked += CloseEdit_CloseButtonClicked;
            }
        }

        public void ShowFind()
        {
            if (!isOnNotification)
            {
                resetBtn();
                findFragment.Visible = true;
                findIcon.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\find_on.png");
                // Đăng ký sự kiện từ changeDefault
                findFragment.CloseButtonClicked += CloseEdit_CloseButtonClicked;
            }
        }

        private void loadImage()
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
            sqlCmd.CommandText = "SELECT TOP 1 AVATAR FROM ONLINE ORDER BY TIMEIN DESC";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                avatar = reader.GetString(0);
            }
            
            profileIcon.Image= Image.FromFile(avatar);

            reader.Close();
        }

        private void homeIcon_Click(object sender, EventArgs e)
        {
            if (!isOnHome)
            {
                resetBtn();
                homeIcon.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\Home_full.png");
                homeFragment.Visible = true;
                // Đăng ký sự kiện từ changeDefault
                homeFragment.CloseButtonClicked += CloseEdit_CloseButtonClicked;
            }

        }

        private void findIcon_Click(object sender, EventArgs e)
        {
            if (!isOnFind)
            {
                resetBtn();
                findIcon.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\find_on.png");
                findFragment.Visible = true;
                findFragment.CloseButtonClicked += CloseEdit_CloseButtonClicked;
            }

        }

        private void profileIcon_Click(object sender, EventArgs e)
        {
            if (!isOnProfile)
            {
                resetBtn();
                profileFragment.Visible = true;
                whiteCircle.Visible =true;
                profileIcon.BackColor = Color.White;
                // Đăng ký sự kiện từ changeDefault
                profileFragment.CloseButtonClicked += Close_CloseButtonClicked;
                profileFragment.EditButtonClicked += CloseEdit_CloseButtonClicked;
            }
        }

        private void CloseEdit_CloseButtonClicked(object sender, EventArgs e)
        {

            // Đóng UserControl2 sau khi thực hiện xong các thao tác
            homeFragment.Visible = false;
            this.Close();
        }


        private void Close_CloseButtonClicked(object sender, EventArgs e)
        {

            // Đóng UserControl2 sau khi thực hiện xong các thao tác
            profileFragment.Visible = false;
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void addIcon_Click(object sender, EventArgs e)
        {
            CreatePost createPost = new CreatePost();
            createPost.setUserOnline(userOnline);
            createPost.Show();
            this.Close();
        }

        private void notiIcon_Click(object sender, EventArgs e)
        {
            if (!isOnNotification)
            {
                resetBtn();
                notiIcon.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\favorite_on.png");
                notification.Visible = true;
                // Đăng ký sự kiện từ changeDefault
                notification.CloseButtonClicked += CloseEdit_CloseButtonClicked;
            }
        }
    }
}
