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
    public partial class CommentPost : UserControl
    {
        string userOnline;
        string idPost;
        string avatarPath;
        string userPost;
        bool isFromProfile = false;
        bool isFromFind = false;
        bool isFromNoti = false;
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=INSTAGRAM;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;
        public CommentPost()
        {
            InitializeComponent();
        }

        public void setFromNoti(bool isFromNoti)
        {
            this.isFromNoti = isFromNoti;
        }

        public void setFromFind(bool isFromFind)
        {
            this.isFromFind = isFromFind;
        }

        public void setFromProfile(bool fromProfile)
        {
            this.isFromProfile = fromProfile;
        }

        public void loadCmt()
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
            // LẤY THÔNG TIN LỊCH SỬ COMMENT
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT MACMT,USERNAME_CMT,CONTENT,TIMECMT FROM COMMENT WHERE MAPOST = '" + idPost + "' ORDER BY TIMECMT DESC";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                string idCmt = reader.GetString(0);
                string usernameCmt = reader.GetString(1);
                string content = reader.GetString(2);
                DateTime timeCmt = reader.GetDateTime(3);
                CmtItem item = new CmtItem();
                item.loadData(idCmt,usernameCmt, content, idPost, timeCmt);
                item.DeleteClicked += Item_DeleteClicked;
                listCmt.Controls.Add(item);
            }
            reader.Close();
            sqlCon.Close();
            
        }

        private void Item_DeleteClicked(object? sender, EventArgs e)
        {
            decreaseNumCmt();
            listCmt.Controls.Clear();
            loadCmt();
        }

        public void setUserPost(string userPost)
        {
            this.userPost = userPost;
        }

        public void setAvatar(string avatar)
        {
            this.avatarPath = avatar;
            pbAvatar.Image = Image.FromFile(avatarPath);
        }

        public void setUserOnline(string userOnline)
        {
            this.userOnline = userOnline;
        }

        public void setIdPost(string idPost)
        {
            this.idPost = idPost;
        }

        private void send_MouseEnter(object sender, EventArgs e)
        {
            send.ForeColor = Color.Silver;
        }

        private void send_MouseLeave(object sender, EventArgs e)
        {
            send.ForeColor = Color.White;
        }

        private void edtCmt_Click(object sender, EventArgs e)
        {
            if (edtCmt.Text == "Hãy chia sẻ cảm nhận của bạn nào...")
            {
                edtCmt.Text = string.Empty;
            }
        }

        private void send_Click(object sender, EventArgs e)
        {
            if (edtCmt.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập bình luận của bạn trước khi gửi");
            }

            DateTime dateTime = DateTime.Now;
            CmtItem cmtItem = new CmtItem();
            // THÊM MỘT COMMENT VÀO DATABASE
            string idCmt = GenerateRandomString(10);
            cmtItem.loadData(idCmt, userOnline, edtCmt.Text, idPost, dateTime);
            cmtItem.setUserOnline(userOnline);
            cmtItem.setUserPost(userPost);
            cmtItem.DeleteClicked += Item_DeleteClicked;
            listCmt.Controls.Add(cmtItem);
            listCmt.Controls.SetChildIndex(cmtItem,0);
            addCmtSQL(idCmt,dateTime);
            increaseNumCmtSQL();
            edtCmt.Text = string.Empty;
        }

        private void addCmtSQL(string idCmt,DateTime dateTime)
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

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO COMMENT VALUES('"+idCmt+"','" + userOnline + "','" + edtCmt.Text + "','" + idPost + "','"+userPost+"','" + dateTime + "','N')";
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
        }

        private void decreaseNumCmt()
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
            sqlCmd.CommandText = "UPDATE POST SET NUM_CMT = NUM_CMT-1 WHERE MAPOST= '"+idPost+"'";
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();
        }

        private string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            char[] randomArray = new char[length];

            for (int i = 0; i < length; i++)
            {
                randomArray[i] = chars[random.Next(chars.Length)];
            }

            return new string(randomArray);
        }

        private void increaseNumCmtSQL()
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
            // TĂNG CỘT SỐ LƯỢNG CMT
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "UPDATE POST SET NUM_CMT = NUM_CMT+1 WHERE MAPOST='"+idPost+"'";
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
        }

        public event EventHandler CloseButtonClicked;
        private void backBtn_Click(object sender, EventArgs e)
        {       
            // Khi nút Close được bấm, kích hoạt sự kiện CloseButtonClicked
            MainPage mainPage = new MainPage();
            if (isFromNoti)
            {
                mainPage.ShowNotification();
            }
            else if (isFromFind)
            {
                mainPage.ShowFind();
            }
            else if (isFromProfile)
            {
                mainPage.ShowProfile();
            }
            else
            {
                mainPage.ShowHome();

            }
            CloseButtonClicked?.Invoke(this, EventArgs.Empty);
            mainPage.Show();
            this.Hide();
        }
    }
}
