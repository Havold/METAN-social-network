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
    public partial class ImageItem : UserControl
    {
        string imagePath;
        string idPost;
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=INSTAGRAM;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;
        public bool isUsed = false;
        

        public ImageItem()
        {
            InitializeComponent();
        }

        public void setIDPost(string idPost)
        {
            this.idPost = idPost;
        }

        public event EventHandler ItemClicked;

        private void Item_Click(object sender, EventArgs e)
        {
            ItemClicked?.Invoke(this, EventArgs.Empty);
            isUsed = true;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;

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
                sqlCmd.CommandText = "INSERT INTO IMAGEPOST VALUES('" + imagePath + "','" + idPost + "')";
                sqlCmd.Connection = sqlCon;

                int kq = sqlCmd.ExecuteNonQuery();
                if (kq > 0)
                {

                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi hệ thống", "Lỗi");
                }

                Ptrbox.Image = Image.FromFile(imagePath);
                deleteBox.Visible = true;
            }
           
        }


        public event EventHandler CloseClicked;
        private void deleteBox_Click(object sender, EventArgs e)
        {
            CloseClicked?.Invoke(this, EventArgs.Empty);
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
                sqlCmd.CommandText = "DELETE FROM IMAGEPOST WHERE IMAGEPATH='" + imagePath + "' AND MAPOST='" + idPost + "'";
                sqlCmd.Connection = sqlCon;

                int kq = sqlCmd.ExecuteNonQuery();
                if (kq > 0)
                {

                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi hệ thống", "Lỗi");
                }
            
        }
    }
}
