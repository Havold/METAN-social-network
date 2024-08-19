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
    public partial class OneImage : UserControl
    {
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=INSTAGRAM;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;
        // Khai báo và khởi tạo mảng chuỗi
        string[] imagePath;
        bool canNext = false;
        bool canBack = false;
        int index;
        int numImage;
        public OneImage()
        {
            InitializeComponent();
        }

        public void loadImage(string idPost, int numImage)
        {
            // Khai báo và khởi tạo mảng chuỗi với số phần tử là count
            imagePath = new string[numImage];
            int count = 0;
            this.numImage = numImage;
            // MỞ KẾT NỐI
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strcCon);
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            // LẤY THÔNG TIN ẢNH
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT IMAGEPATH FROM IMAGEPOST WHERE MAPOST='" + idPost + "'";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                imagePath[count] = reader.GetString(0);
                count++;
            }
            reader.Close();
            sqlCon.Close();
            index = 0;
            imgPost.Image = Image.FromFile(imagePath[index]);
            if (numImage > 1)
            {
                nextBtn.Image = Image.FromFile("D:\\C#\\Instagram\\png\\4x\\nextBtnArrowOn.png");
                canNext = true;
            }
            else
            {
                nextBtn.Visible = false;
                backBtn.Visible=false;
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (canNext)
            {
                index++;
                imgPost.Image = Image.FromFile(imagePath[index]);
                canBack = true;
                backBtn.Image = Image.FromFile("D:\\C#\\Instagram\\png\\4x\\backBtnArrowOn.png");
                if (index == numImage-1)
                {
                    canNext = false;
                    nextBtn.Image = Image.FromFile("D:\\C#\\Instagram\\png\\4x\\nextBtnArrow.png");
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (canBack)
            {
                index--;
                imgPost.Image = Image.FromFile(imagePath[index]);
                canNext = true;
                nextBtn.Image = Image.FromFile("D:\\C#\\Instagram\\png\\4x\\nextBtnArrowOn.png");
                if (index == 0)
                {
                    canBack = false;
                    backBtn.Image = Image.FromFile("D:\\C#\\Instagram\\png\\4x\\backBtnArrow.png");
                }
            }
        }
    }
}
