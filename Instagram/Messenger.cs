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
    public partial class Messenger : Form
    {
        public Messenger()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            findIcon.BackColor = ColorTranslator.FromHtml("#1c2a33");
            findTxt.BackColor = ColorTranslator.FromHtml("#1c2a33");
            findTxt.ForeColor = ColorTranslator.FromHtml("#b5bdc8");
        }

        private void findTxt_Click(object sender, EventArgs e)
        {
            if (findTxt.Text == "Tìm kiếm")
            {
                findTxt.Text = string.Empty;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }
    }
}
