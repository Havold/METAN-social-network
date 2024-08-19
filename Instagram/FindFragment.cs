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
    public partial class FindFragment : UserControl
    {
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=INSTAGRAM;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;
        string username, fullname, avatarPath, usernameOnline;
        public event EventHandler CloseButtonClicked;
        public FindFragment()
        {
            InitializeComponent();
            loadItem();
            findIcon.BackColor = ColorTranslator.FromHtml("#1c2a33");
            findTxt.BackColor = ColorTranslator.FromHtml("#1c2a33");
            findTxt.ForeColor = ColorTranslator.FromHtml("#b5bdc8");
        }

        private void findTxt_Click(object sender, EventArgs e)
        {
            if (findTxt.Text == "Tìm kiếm")
            {
                findTxt.Text = string.Empty;
            }
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
            sqlCmd.CommandText = "SELECT TOP 1 USERNAME FROM ONLINE ORDER BY TIMEIN DESC";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                usernameOnline = reader.GetString(0);
            }

            reader.Close();


            // Load data trong TABLE ACCOUNT để lấy thông tin điền vào Item và Add vào listUser
            sqlCmd.CommandText = "SELECT USERNAME,FULLNAME,AVATAR FROM ACCOUNT WHERE USERNAME!='"+usernameOnline+"'";
            sqlCmd.Connection = sqlCon;
            reader = sqlCmd.ExecuteReader();
            while(reader.Read())
            {
                username = reader.GetString(0);
                fullname = reader.GetString(1);
                avatarPath = reader.GetString(2);

                //Tạo Item
                AccountItem item = new AccountItem();
                item.loadData(username,fullname,avatarPath); //isOutcome=true
                item.ItemClicked += Item_ItemClicked;
                listUser.Controls.Add(item);
            }


            reader.Close();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            // Gọi hàm thực hiện tìm kiếm khi nội dung của TextBox thay đổi
            PerformSearch(findTxt.Text);
        }

        private void PerformSearch(string searchTerm)
        {

            // Xóa các UserControl hiện tại trong FlowLayoutPanel
            listUser.Controls.Clear();

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
            sqlCmd.CommandText = "SELECT TOP 1 USERNAME FROM ONLINE ORDER BY TIMEIN DESC";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                usernameOnline = reader.GetString(0);
            }

            reader.Close();


            // Load data trong TABLE ACCOUNT để lấy thông tin điền vào Item và Add vào listUser
            sqlCmd.CommandText = "SELECT USERNAME,FULLNAME,AVATAR FROM ACCOUNT WHERE USERNAME!='" + usernameOnline + "'";
            sqlCmd.Connection = sqlCon;
            reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                username = reader.GetString(0);
                fullname = reader.GetString(1);
                avatarPath = reader.GetString(2);

                if (username.ToLower().Contains(searchTerm.ToLower()) || fullname.ToLower().Contains(searchTerm.ToLower()))
                {
                    //Tạo Item
                    AccountItem item = new AccountItem();
                    item.loadData(username, fullname, avatarPath); //isOutcome=true
                    item.ItemClicked += Item_ItemClicked;
                    listUser.Controls.Add(item);
                }
            }

            reader.Close();
        }

        private void Item_ItemClicked(object? sender, EventArgs e)
        {
            // Xử lý khi một UserControl Song được bấm
            if (sender is AccountItem clickedAccount)
            {
                // Bạn có thể sử dụng theo cách bạn muốn
                userProfile.CloseButtonClicked += Close_CloseButtonClicked;
                userProfile.setUser(clickedAccount.username_tmp,false);
                
                userProfile.Visible = true;
            }

        }

        private void Close_CloseButtonClicked(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
