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
    public partial class ShowFollow : UserControl
    {
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=INSTAGRAM;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;
        bool showFollow;
        string userOnline;
        public ShowFollow()
        {
            InitializeComponent();
        }

        public void setFollow(bool follow)
        {
            this.showFollow = follow;
        }

        public void setUserOnline(string userOnline)
        {
            this.userOnline = userOnline;
        }

        public void loadData()
        {
            listFollow.Controls.Clear();
            if (this.showFollow)
            {
                txtFollow.Text = "Đang theo dõi";
            }
            else
            {
                txtFollow.Text = "Người theo dõi";

            }
            // MỞ KẾT NỐI
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strcCon);
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            // LẤY THÔNG TIN NHỮNG NGƯỜI FOLLOW
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT FOLLOW,FOLLOWER FROM FOLLOW WHERE FOLLOW ='" + userOnline + "' OR FOLLOWER='" + userOnline + "' ORDER BY TIMEFOLLOW DESC";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                string tmp_1 = reader.GetString(0);
                string tmp_2 = reader.GetString(1);
                if (tmp_1 != userOnline)
                {
                    
                    AccountItem accountItem = new AccountItem();
                    accountItem.loadDataJustUsername(tmp_1);
                    listFollow.Controls.Add(accountItem);
                }
                else
                {
                    AccountItem accountItem = new AccountItem();
                    accountItem.loadDataJustUsername(tmp_2);
                    listFollow.Controls.Add(accountItem);
                }
            }
            reader.Close();
            sqlCon.Close();
        }

        private string getFullname(string username)
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
            string tmp = "";
            // LẤY THÔNG TIN TÊN
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT FULLNAME FROM ACCOUNT WHERE USERNAME='" + username + "'";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                tmp = reader.GetString(0);
            }
            reader.Close();
            sqlCon.Close();
            return tmp;
        }

        private string getAvatarPath(string username)
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
            string tmp = "";
            // LẤY THÔNG TIN TÊN
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT AVATAR FROM ACCOUNT WHERE USERNAME='" + username + "'";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                tmp = reader.GetString(0);
            }
            reader.Close();
            sqlCon.Close();
            return tmp;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
