using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instagram
{
    public partial class showChat : UserControl
    {
        public showChat()
        {
            InitializeComponent();
        }

        static bool IsImagePath(string path)
        {
            if (!File.Exists(path))
            {
                return false;
            }
            string extension = Path.GetExtension(path)?.ToLower();
            if (extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".gif" || extension == ".bmp")
            {
                return true;
            }
            return false;
        }
        public void SetText(string text, string avt, string name)
        {
            label1.Text = text;
            if (label1.Width > 180)
            {
                label1.AutoSize = false;
                label1.Width = 180;
                label1.Height = 43;
                label1.Text = text;
            }
            label3.Text = name;
            if (IsImagePath(avt)) pictureBox1.Image = System.Drawing.Image.FromFile(avt);
            pictureBox4.Image = null;
            pictureBox3.Width = label1.Width + 10;
            pictureBox3.Height = label1.Height + 10;
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.Text = null;
            label4.Text = null;
        }

        public void SetFontSize(string text, string avt, string name)
        {
            label2.AutoSize = false;
            Font font = label2.Font;
            // Lấy kích thước của chuỗi văn bản
            Size textSize = TextRenderer.MeasureText(text, font);
            label2.Size = textSize;
            label2.Location = new Point(label2.Location.X - textSize.Width, label2.Location.Y);
            label2.Text = text;
            if (label2.Width > 180)
            {
                label2.AutoSize = false;
                label2.Width = 180;
                label2.Height = 43;
                
                label2.Text = text;
            }
            label4.Text = name;
            if (IsImagePath(avt)) pictureBox2.Image = System.Drawing.Image.FromFile(avt);
            pictureBox3.Image = null;
            pictureBox4.Width = label2.Width + 8;
            pictureBox4.Height = label2.Height + 8;
            pictureBox4.Location = new Point(label2.Location.X - 2, pictureBox4.Location.Y);
            label2.BackColor = System.Drawing.Color.Transparent;
            label1.Text = null;
            pictureBox1.Image = null;
            label3.Text = null;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
