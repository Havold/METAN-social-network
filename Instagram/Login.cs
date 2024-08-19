using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Xml.Linq;

namespace Instagram
{
    public partial class Login : Form
    {
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=INSTAGRAM;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;
        bool eyeOpen = false;
        string avatarPath, caption, fullname;
        int post, follower, follow;
        public Login()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            loadInput();
            edtUser.BackColor = ColorTranslator.FromHtml("#1c2a33");
            edtUser.ForeColor = ColorTranslator.FromHtml("#b5bdc8");
            edtPwd.BackColor = ColorTranslator.FromHtml("#1c2a33");
            edtPwd.ForeColor = ColorTranslator.FromHtml("#b5bdc8");
            eyeBtn.BackColor = ColorTranslator.FromHtml("#1c2a33");
        }

        private void loadInput()
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
            string username = "";
            string password = "";
            bool isRemember = false;
            // LẤY THÔNG TIN NGƯỜI ĐĂNG NHẬP GẦN NHẤT
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT TOP 1 USERNAME,PASSWORD,REMEMBER FROM ONLINE ORDER BY TIMEIN DESC";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                username = reader.GetString(0);
                password = reader.GetString(1);
                if (reader.GetString(2) == "T")
                {
                    isRemember = true;
                }
            }

            if (isRemember)
            {
                edtUser.Text = username;
                edtPwd.Text = password;
                edtPwd.PasswordChar = '*';
            }
            reader.Close();
        }

        void resetEdt()
        {
            if (edtUser.Text == string.Empty)
            {
                edtUser.Text = "Tên người dùng, email/số di động";
            }
            if (edtPwd.Text == string.Empty)
            {
                edtPwd.Text = "Mật khẩu";
            }
        }

        private void loginBtn_MouseEnter(object sender, EventArgs e)
        {
            loginBtn.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\loginBtn_MouseEnter.png");
        }

        private void loginBtn_MouseLeave(object sender, EventArgs e)
        {
            loginBtn.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\loginBtn.png");
        }

        private void registerBtn_MouseEnter(object sender, EventArgs e)
        {
            registerBtn.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\registerBtn_MouseEnter.png");
        }

        private void registerBtn_MouseLeave(object sender, EventArgs e)
        {
            registerBtn.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\registerBtn.png");
        }


        private void txtForget_MouseEnter(Object sender, EventArgs e)
        {
            txtForget.ForeColor = Color.Gray;
        }

        private void txtForget_MouseLeave(Object sender, EventArgs e)
        {
            txtForget.ForeColor = Color.White;
        }

        private void edtUser_Click(object sender, EventArgs e)
        {
            if (edtUser.Text == "Tên người dùng, email/số di động")
            {
                edtUser.Text = string.Empty;
            }
            if (edtPwd.Text == string.Empty)
            {
                edtPwd.Text = "Mật khẩu";
            }
        }

        private void edtPwd_Click(object sender, EventArgs e)
        {
            if (edtPwd.Text == "Mật khẩu")
            {
                edtPwd.PasswordChar = '*';
                edtPwd.Text = string.Empty;
            }
            if (edtUser.Text == string.Empty)
            {
                edtUser.Text = "Tên người dùng, email/số di động";
            }
        }

        private void txtForget_Click(object sender, EventArgs e)
        {
            resetEdt();
            ResetPassword resetPassword = new ResetPassword();
            resetPassword.Show();
            this.Hide();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            resetEdt();
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = edtUser.Text;
            string password = edtPwd.Text;
            if (CheckValid(username, password))
            {
                MessageBox.Show("Đăng nhập thành công", "Thành công");

                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strcCon);
                }

                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                // LẤY THÔNG TIN STK VÀ NGÂN HÀNG MẶC ĐỊNH
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "SELECT FULLNAME,AVATAR,CAPTION,NUM_POST,NUM_FOLLOWER,NUM_FOLLOW FROM ACCOUNT WHERE USERNAME = '" + username + "'";
                sqlCmd.Connection = sqlCon;
                SqlDataReader reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    fullname = reader.GetString(0);
                    avatarPath = reader.GetString(1);
                    caption = reader.GetString(2);
                    post = reader.GetInt32(3);
                    follower = reader.GetInt32(4);
                    follow = reader.GetInt32(5);

                }
                reader.Close();

                string remember = "F";
                DateTime dateTime = DateTime.Now;
                if (remeberBox.Checked)
                {
                    remember = "T";
                }

                //THÊM NGƯỜI DÙNG VÀO TABLE ĐANG ONLINE
                sqlCmd.CommandText = "INSERT INTO ONLINE VALUES('" + username + "','" + fullname + "','" + dateTime + "','" + remember + "','" + password + "','" + avatarPath + "','" + caption + "'," + post + "," + follower + "," + follow + ")";
                sqlCmd.Connection = sqlCon;
                int sql = sqlCmd.ExecuteNonQuery();

                MainPage mainPage = new MainPage();
                mainPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username hoặc mật khẩu của bạn không đúng", "Lỗi");
            }
        }

        private bool CheckValid(string username, string password)
        {
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
            sqlCmd.CommandText = "SELECT COUNT(*) FROM ACCOUNT WHERE USERNAME=@USERNAME AND PASSWORD=@PASSWORD";


            using (SqlCommand command = new SqlCommand(sqlCmd.CommandText, sqlCon))
            {
                command.Parameters.AddWithValue("@USERNAME", username);
                command.Parameters.AddWithValue("@PASSWORD", password);

                int count = (int)command.ExecuteScalar();

                // Nếu có ít nhất một kết quả trả về, đăng nhập thành công
                return count > 0;
            }

        }

        private void eyeBtn_Click(object sender, EventArgs e)
        {
            if (!eyeOpen)
            {
                eyeOpen = true;
                eyeBtn.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\eye_open.png");
                edtPwd.PasswordChar = '\0';
            }
            else
            {
                eyeOpen = false;
                eyeBtn.Image = Image.FromFile("C:\\C#\\Instagram\\png\\4x\\eye_close.png");
                edtPwd.PasswordChar = '*';
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
