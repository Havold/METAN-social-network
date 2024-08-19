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

    public partial class NotiItem : UserControl
    {
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=INSTAGRAM;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;
        public string username_tmp;
        string userOnline;
        public string idPost;
        int type;
        public NotiItem()
        {
            InitializeComponent();
            getUserOnline();
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
            sqlCmd.CommandText = "SELECT TOP 1 USERNAME FROM ONLINE ORDER BY TIMEIN DESC";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                userOnline = reader.GetString(0);
            }

            sqlCon.Close();
        }

        private void backgroundItem_MouserEnter(object sender, EventArgs e)
        {
            backgroundItem.BackColor = Color.Gray;
            txtNoti.BackColor = Color.Gray;
            avatar.BackColor = Color.Gray;
        }

        private void backgroundItem_MouseLeave(object sender, EventArgs e)
        {
            backgroundItem.BackColor = Color.Black;
            txtNoti.BackColor = Color.Black;
            avatar.BackColor = Color.Black;
        }

        public void loadRequestData(string username, DateTime date, string seen)
        {
            type = 1;
            txtNoti.Text = username + " đã gửi một yêu cầu follow đến bạn vào lúc " + date;
            username_tmp = username;
            if (seen == "N")
            {
                point.Visible = true;
            }
            else
            {
                point.Visible = false;
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

            // LẤY THÔNG TIN 
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT AVATAR FROM ACCOUNT WHERE USERNAME='"+username+"'";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                avatar.Image = Image.FromFile(reader.GetString(0));
            }

            sqlCon.Close();
        }

        public void loadLiketData(string username, DateTime date, string seen,string idPost)
        {
            type = 2;
            this.idPost = idPost;
            txtNoti.Text = username + " đã thích một bài viết của bạn vào lúc " + date;
            username_tmp = username;
            if (seen == "N")
            {
                point.Visible = true;
            }
            else
            {
                point.Visible = false;
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

            // LẤY THÔNG TIN 
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT AVATAR FROM ACCOUNT WHERE USERNAME='" + username + "'";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                avatar.Image = Image.FromFile(reader.GetString(0));
            }

            sqlCon.Close();
        }

        public void loadCmtData(string username, DateTime date, string seen, string idPost)
        {
            type = 3; ;
            this.idPost = idPost;
            txtNoti.Text = username + " đã bình luận về một bài viết của bạn vào lúc " + date;
            username_tmp = username;
            if (seen == "N")
            {
                point.Visible = true;
            }
            else
            {
                point.Visible = false;
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

            // LẤY THÔNG TIN 
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT AVATAR FROM ACCOUNT WHERE USERNAME='" + username + "'";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                avatar.Image = Image.FromFile(reader.GetString(0));
            }

            sqlCon.Close();
        }



        public event EventHandler ItemClicked;
        private void Item_Click(object sender, EventArgs e)
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

            // CẬP NHẬT ĐÃ XEM
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            if (type==1)
            {
                sqlCmd.CommandText = "UPDATE REQUEST SET SEEN='S' WHERE USER_REQUEST='" + username_tmp + "' AND USER_REQUESTED='" + userOnline + "'";
            }

            else if (type==2)
            {
                sqlCmd.CommandText = "UPDATE LIKE_STATUS SET SEEN='S' WHERE USERNAME_LIKE='" + username_tmp + "' AND USER_POST='" + userOnline + "'";

            }
            else
            {
                sqlCmd.CommandText = "UPDATE COMMENT SET SEEN='S' WHERE USERNAME_CMT='" + username_tmp + "' AND USER_POST='" + userOnline + "'";

            }
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();

            sqlCon.Close();
            // Khi UserControl Song được bấm, gửi sự kiện để thông báo
            ItemClicked?.Invoke(this, EventArgs.Empty);
            point.Visible = false;
        }
    }
}
