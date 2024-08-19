using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Instagram
{
    public partial class PostItem : UserControl
    {
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=INSTAGRAM;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;
        public string idPost;
        string imagePath;
        public PostItem()
        {
            InitializeComponent();
        }

        public void loadData(string idPost)
        {
            this.idPost = idPost;
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
            sqlCmd.CommandText = "SELECT IMAGEPATH FROM IMAGEPOST WHERE MAPOST='" + idPost + "'";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                imagePath = reader.GetString(0);
                break;
            }
            reader.Close();

            imgPost.Image = Image.FromFile(imagePath);
        }

        public event EventHandler ItemClicked;
        private void Item_Click(object sender, EventArgs e)
        {
            // Khi UserControl Song được bấm, gửi sự kiện để thông báo
            ItemClicked?.Invoke(this, EventArgs.Empty); 
        }
    }
}
