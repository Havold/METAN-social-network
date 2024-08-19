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
    public partial class CreatePost : Form
    {
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=INSTAGRAM;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;

        int count = 0;
        string userOnline;
        string idPost = CreateRandomString(10);
        public CreatePost()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            loadItem();
        }

        public void setUserOnline(string userOnline)
        {
            this.userOnline = userOnline;
        }
        private void loadItem()
        {
            ImageItem imageItem = new ImageItem();
            listImage.Controls.Add(imageItem);
            imageItem.setIDPost(idPost);
            imageItem.ItemClicked += Item_ItemClicked;
            imageItem.CloseClicked += Item_CloseClicked;
            count++;
        }

        private void Item_CloseClicked(object? sender, EventArgs e)
        {
            // Xử lý khi một UserControl Song được bấm
            if (sender is ImageItem clickedImage)
            {
                listImage.Controls.Remove(clickedImage);
            }
        }

        private void Item_ItemClicked(object? sender, EventArgs e)
        {
            // Xử lý khi một UserControl Song được bấm
            if (sender is ImageItem clickedImage)
            {
                // Bạn có thể sử dụng theo cách bạn muốn
                // Đăng ký sự kiện từ changeDefault
                loadItem();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            deleteAllImage();
            this.Close();
        }

        private void deleteAllImage()
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
            sqlCmd.CommandText = "DELETE FROM IMAGEPOST WHERE MAPOST='" + idPost + "'";
            sqlCmd.Connection = sqlCon;

            sqlCmd.ExecuteNonQuery();
        }

        private void edtCaption_Click(object sender, EventArgs e)
        {
            if (edtCaption.Text == "Viết nội dung...")
            {
                edtCaption.Text = string.Empty;
            }
        }

        public static string CreateRandomString(int length)
        {
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                int code = rnd.Next(65, 123);
                sb.Append((char)code);
            }

            return sb.ToString();
        }

        private void shareBtn_Click(object sender, EventArgs e)
        {
            
            if (!checkImageValid())
            {
                MessageBox.Show("Vui lòng chọn ít nhất một tấm hình để có thể đăng bài", "Lỗi");
                return;
            }

            if (edtCaption.Text==string.Empty || edtCaption.Text== "Viết nội dung...")
            {
                MessageBox.Show("Vui lòng viết nội dung của bài viết này", "Lỗi");
                return;
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

            DateTime dateTime = DateTime.Now;
            int count = listImage.Controls.Count-1;
            // LẤY THÔNG TIN NGƯỜI ĐĂNG NHẬP GẦN NHẤT
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO POST VALUES('"+idPost+"','"+edtCaption.Text+"','"+dateTime+"','"+userOnline+"',0,0,"+count+")";
            sqlCmd.Connection = sqlCon;

            int kq = sqlCmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Đã đăng bài", "Thành công");
                increaseNumPostSQL();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi hệ thống", "Lỗi");
            }
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }

        private void increaseNumPostSQL()
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
            // TĂNG CỘT SỐ LƯỢNG BÀI VIẾT
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "UPDATE ACCOUNT SET NUM_POST = NUM_POST+1 WHERE USERNAME='" + userOnline + "'";
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();

            sqlCmd.CommandText = "UPDATE ONLINE SET NUM_POST = NUM_POST+1 WHERE USERNAME='" + userOnline + "'";
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
        }
        private bool checkImageValid()
        {
                if (listImage.Controls[0] is ImageItem userControl)
                {
                    return userControl.isUsed;
                }
            return false;
        }
    }
}
