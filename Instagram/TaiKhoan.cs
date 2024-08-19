using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPchat
{
    class Taikhoan
    {
        private string username;
        private string fullname;
        private DateTime birth;
        private string sex;
        private string phone;
        private string email;
        private string password;
        private string avatar;
        private int numPost;
        private int numFollower;
        private int numFollow;
        private string caption;
        
        public Taikhoan()
        {
        }
        public Taikhoan(string username, string fullname, DateTime birth, string sex, string phone, string email, string password,string avatar, int numPost, int numFollower, int numFollow, string caption)
        {
            this.username = username;
            this.fullname = fullname;
            this.birth = birth;
            this.sex = sex;
            this.phone = phone;
            this.email = email;
            this.password = password;
            this.avatar = avatar;
            this.numPost = numPost;
            this.numFollower = numFollower;
            this.numFollow = numFollow;
            this.caption = caption;
        }

        public string Username { get => username; set => username = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public DateTime Birth { get => birth; set => birth = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }

        public string Avatar { get => avatar; set => avatar = value; }
        public int NumPost { get => numPost; set => numPost = value; }
        public int NumFollower { get => numFollower; set => numFollower = value; }
        public int NumFollow { get => numFollow; set => numFollow = value; }
        public string Caption { get => caption; set => caption = value; }

    }
}
