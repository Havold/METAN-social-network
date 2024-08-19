using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Xml.Linq;

namespace Instagram
{
    public partial class Post : UserControl
    {
        string caption, avatarPath;
        int numCmt, numLike, numImage, tmp;
        public string idPost;
        DateTime timePost;
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=INSTAGRAM;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;
        string userOnline;
        bool isLike = false;
        public string userPost;
        public Post()
        {
            InitializeComponent();
        }

        public void setUserOnline(string username)
        {
            this.userOnline = username;
        }

        public void loadData(string idPost)
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
            sqlCmd.CommandText = "SELECT MAPOST,CAPTION,TIMEPOST,USERNAME,NUM_CMT,NUM_LIKE,NUM_IMAGE FROM POST WHERE MAPOST='" + idPost + "'";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                this.idPost = reader.GetString(0);
                caption = reader.GetString(1);
                timePost = reader.GetDateTime(2);
                userPost = reader.GetString(3);
                numCmt = reader.GetInt32(4);
                numLike = reader.GetInt32(5);
                numImage = reader.GetInt32(6);
            }

            reader.Close();

            sqlCmd.CommandText = "SELECT AVATAR FROM ACCOUNT WHERE USERNAME='" + userPost + "'";
            sqlCmd.Connection = sqlCon;
            reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                avatarPath = reader.GetString(0);
            }

            reader.Close();

            sqlCmd.CommandText = "SELECT COUNT(*) FROM LIKE_STATUS WHERE USERNAME_LIKE='" + this.userOnline + "' AND MAPOST='" + this.idPost + "'";
            sqlCmd.Connection = sqlCon;
            reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                tmp = reader.GetInt32(0);
            }
            if (tmp > 0)
            {
                isLike = true;
                likeBtn.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\favorite_on_red.png");
            }

            reader.Close();

            sqlCon.Close();

            avatar.Image = Image.FromFile(avatarPath);
            txtUser.Text = userPost;
            txtDate.Text = timePost.ToString();
            likeTxt.Text = numLike.ToString() + " lượt thích";
            captionTxt.Text = caption;
            cmtTotal.Text = "Xem tất cả " + numCmt.ToString() + " bình luận";

            if (numImage == 1)
            {
                OneImage oneImage = new OneImage();
                oneImage.loadImage(idPost, numImage);
                listImage.Controls.Add(oneImage);
            }
            else if (numImage == 2)
            {
                TwoImage twoImage = new TwoImage();
                twoImage.loadImage(idPost, numImage);
                listImage.Controls.Add(twoImage);
            }
            else if (numImage == 3)
            {
                ThreeImage threeImage = new ThreeImage();
                threeImage.loadImage(idPost, numImage);
                listImage.Controls.Add(threeImage);
            }
            else if (numImage == 4)
            {
                FourImage fourImage = new FourImage();
                fourImage.loadImage(idPost, numImage);
                listImage.Controls.Add(fourImage);

            }
            else if (numImage == 5)
            {
                FiveImage fiveImage = new FiveImage();
                fiveImage.loadImage(idPost, numImage);
                listImage.Controls.Add(fiveImage);
            }
            else
            {
                OneImage oneImage = new OneImage();
                oneImage.loadImage(idPost, numImage);
                listImage.Controls.Add(oneImage);
            }
        }

        private void likeBtn_Click(object sender, EventArgs e)
        {
            if (!isLike)
            {
                likeBtn.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\favorite_on_red.png");
                isLike = true;
                updateLike();
            }
            else
            {
                likeBtn.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\favorite.png");
                isLike = false;
                updateRemoveLike();
            }
        }

        private void updateLike()
        {
            numLike += 1;
            likeTxt.Text = numLike.ToString() + " lượt thích";
            updateNumLike();
            addUserLike();
        }

        private void updateNumLike()
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
            // CẬP NHẬT LƯỢT THÍCH
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "UPDATE POST SET NUM_LIKE=" + numLike + " WHERE MAPOST='" + idPost + "'";
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();

            sqlCon.Close();
        }

        private void addUserLike()
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
            // CẬP NHẬT NGƯỜI THÍCH
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            DateTime dateTime = DateTime.Now;
            sqlCmd.CommandText = "INSERT INTO LIKE_STATUS VALUES('" + userOnline + "','" + idPost + "','"+userPost+"','" + dateTime + "','N')";
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();

            sqlCon.Close();
        }

        private void deleteUserLike()
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
            // CẬP NHẬT NGƯỜI THÍCH
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            DateTime dateTime = DateTime.Now;
            sqlCmd.CommandText = "DELETE FROM LIKE_STATUS WHERE USERNAME_LIKE='" + userOnline + "' AND MAPOST='" + idPost + "'";
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();

            sqlCon.Close();
        }

        private void updateRemoveLike()
        {
            numLike -= 1;
            likeTxt.Text = numLike.ToString() + " lượt thích";
            updateNumLike();
            deleteUserLike();
        }

        public event EventHandler ItemClicked;
        private void Avatar_Click(object sender, EventArgs e)
        {
            // Khi UserControl Song được bấm, gửi sự kiện để thông báo
            ItemClicked?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler CmtClicked;
        private void cmtTxt_Click(object sender, EventArgs e)
        {
            // Khi UserControl Song được bấm, gửi sự kiện để thông báo
            CmtClicked?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler CloseClicked;

        private void cmtTotal_Click(object sender, EventArgs e)
        {
            // Khi UserControl Song được bấm, gửi sự kiện để thông báo
            CmtClicked?.Invoke(this, EventArgs.Empty);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (userOnline != userPost)
            {
                MessageBox.Show("Bạn không phải người đăng nên không thể xóa bài viết này", "Thông báo");
                return;
            }
            // Hiển thị hộp thoại hỏi
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bài viết này không?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            // Kiểm tra phản hồi từ người dùng
            if (result == DialogResult.OK)
            {
                // Người dùng chọn OK, thực hiện xóa
                // Code xóa ở đây
                deletePost();
                decreaseNumPost();
                // Hiển thị thông báo đã xóa

                // Khi UserControl Song được bấm, gửi sự kiện để thông báo
                CloseClicked?.Invoke(this, EventArgs.Empty);
                MainPage mainPage= new MainPage();
                mainPage.ShowHome();
                mainPage.Show();
                MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                // Người dùng chọn Cancel hoặc đóng hộp thoại, không thực hiện xóa
            }
        }


        private void decreaseNumPost()
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
            // XÓA GIẢM SỐ LƯỢNG BÀI VIẾT
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "UPDATE ACCOUNT SET NUM_POST=NUM_POST-1 WHERE USERNAME='"+userOnline+"'";
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();

            sqlCmd.CommandText = "UPDATE ONLINE SET NUM_POST=NUM_POST-1 WHERE USERNAME='" + userOnline + "'";
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();
        }

        private void deletePost()
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
            // XÓA BÀI VIẾT
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "DELETE FROM POST WHERE MAPOST = '"+idPost+"'";
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();
            
            // XÓA LƯỢT THÍCH Ở POST ĐÓ
            sqlCmd.CommandText = "DELETE FROM LIKE_STATUS WHERE MAPOST = '" + idPost + "'";
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();

            // XÓA COMMENT Ơ POST ĐÓ
            sqlCmd.CommandText = "DELETE FROM COMMENT WHERE MAPOST = '" + idPost + "'";
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
        }
    }
}
