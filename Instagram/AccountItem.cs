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
    public partial class AccountItem : UserControl
    {
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=INSTAGRAM;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;
        string username, fullname, avatarPath, caption;
        public string username_tmp;
        public AccountItem()
        {
            InitializeComponent();
        }

        public void loadData(string username, string fullname, string avatarPath)
        {
            txtUsername.Text = username;
            txtFullname.Text = fullname;
            avatar.Image = Image.FromFile(avatarPath);
            username_tmp = username;
        }

        private void backgroundItem_MouserEnter(object sender, EventArgs e)
        {
            backgroundItem.BackColor = Color.Gray;
            txtFollow.BackColor = Color.Gray;
            txtFullname.BackColor = Color.Gray;
            txtUsername.BackColor = Color.Gray;
            avatar.BackColor = Color.Gray;
        }

        private void backgroundItem_MouseLeave(object sender, EventArgs e)
        {
            backgroundItem.BackColor = Color.Black;
            txtFollow.BackColor = Color.Black;
            txtFullname.BackColor = Color.Black;
            txtUsername.BackColor = Color.Black;
            avatar.BackColor = Color.Black;
        }

        public void loadDataJustUsername(string username)
        {
            this.username = username;
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
            sqlCmd.CommandText = "SELECT FULLNAME,AVATAR FROM ACCOUNT WHERE USERNAME='" + username + "'";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                this.fullname = reader.GetString(0);
                this.avatarPath = reader.GetString(1);
            }
            reader.Close();
            sqlCon.Close();
            loadData(username,fullname,avatarPath);
        }

        public event EventHandler ItemClicked;
        private void AccountItem_Click(object sender, EventArgs e)
        {
            // Khi UserControl Song được bấm, gửi sự kiện để thông báo
            ItemClicked?.Invoke(this, EventArgs.Empty);
        }

        /*public bool searchSong(int index, string searchTerm)
        {
            //Đường dẫn tới thư mục chứa các tệp JSON
            string dirPath = "C:/982/HKI (2023-2024)/CS511 - Ngôn ngữ lập trình C#/BTTH02/Spotify/Database/songInfo";

            //Tạo tên tệp dựa trên giá trị i
            string fileName = $"{index}.json";

            //Kết hợp đường dẫn thư mục và tên tệp
            string filePath = Path.Combine(dirPath, fileName);
            
            try
            {
                //Độc nội dung của tệp JSON
                string jsonContent = File.ReadAllText(filePath);

                //Sử dụng JObject để truy cập giá trị cụ thể trong tệp JSON
                JObject jsonObject = JObject.Parse(jsonContent);

                //Lấy giá trị của trường "name"
                string songName = (string)jsonObject["name"];
                if (songName.ToLower().Contains(searchTerm.ToLower()))
                {   
                    string artistName = (string)jsonObject["artist"];
                    string imgPath = (string)jsonObject["imgPath"];

                    this.SongName.Text = songName;
                    this.ArtistName.Text = artistName;
                    this.songImg.Image = Image.FromFile(imgPath);
         
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }*/
    }


}
