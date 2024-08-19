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
    public partial class FourImage : UserControl
    {
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=INSTAGRAM;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;
        // Khai báo và khởi tạo mảng chuỗi
        string[] imagePath;
        bool canNext = false;
        bool canBack = false;
        int index;
        int numImage;
        public FourImage()
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
            pb1.Image = Image.FromFile(imagePath[0]);
            pb2.Image = Image.FromFile(imagePath[1]);
            pictureBox1.Image = Image.FromFile(imagePath[2]);
            pb4.Image = Image.FromFile(imagePath[3]);
            //pb3.Image = Image.FromFile(imagePath[2]);
        }
    }
}
