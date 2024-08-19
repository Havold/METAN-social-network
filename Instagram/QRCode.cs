using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instagram
{
    public partial class QRCode : UserControl
    {
        public QRCode()
        {
            InitializeComponent();
        }

        public void createQRcode(string data)
        {
            QRCoder.QRCodeGenerator qr = new QRCoder.QRCodeGenerator();
            var qr1 = qr.CreateQrCode(data, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(qr1);
            pbQR.Image = code.GetGraphic(11);
            txtUsername.Text = data;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void scanIcon_Click(object sender, EventArgs e)
        {
            scanqr.Visible = true;
        }
    }
}
