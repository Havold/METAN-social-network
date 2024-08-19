namespace Instagram
{
    partial class QRCode
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbQR = new PictureBox();
            txtUsername = new Label();
            panel1 = new Panel();
            backBtn = new PictureBox();
            scanIcon = new PictureBox();
            scanqr = new scanQR();
            ((System.ComponentModel.ISupportInitialize)pbQR).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scanIcon).BeginInit();
            SuspendLayout();
            // 
            // pbQR
            // 
            pbQR.Location = new Point(82, 66);
            pbQR.Name = "pbQR";
            pbQR.Size = new Size(300, 300);
            pbQR.TabIndex = 0;
            pbQR.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.Font = new Font("SVN-Anastasia", 20F, FontStyle.Bold);
            txtUsername.ForeColor = Color.RosyBrown;
            txtUsername.Location = new Point(3, 394);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(466, 55);
            txtUsername.TabIndex = 10;
            txtUsername.Text = "havold";
            txtUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BackgroundImage = Properties.Resources.rectangle;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(pbQR);
            panel1.Location = new Point(60, 151);
            panel1.Name = "panel1";
            panel1.Size = new Size(472, 467);
            panel1.TabIndex = 0;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Transparent;
            backBtn.Cursor = Cursors.Hand;
            backBtn.Image = Properties.Resources.closeBtn;
            backBtn.Location = new Point(19, 18);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(60, 60);
            backBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            backBtn.TabIndex = 11;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // scanIcon
            // 
            scanIcon.BackColor = Color.Transparent;
            scanIcon.Cursor = Cursors.Hand;
            scanIcon.Image = Properties.Resources.scanQR;
            scanIcon.Location = new Point(522, 18);
            scanIcon.Name = "scanIcon";
            scanIcon.Size = new Size(60, 60);
            scanIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            scanIcon.TabIndex = 11;
            scanIcon.TabStop = false;
            scanIcon.Click += scanIcon_Click;
            // 
            // scanqr
            // 
            scanqr.BackColor = Color.Black;
            scanqr.Location = new Point(-2, 0);
            scanqr.Name = "scanqr";
            scanqr.Size = new Size(600, 1000);
            scanqr.TabIndex = 12;
            scanqr.Visible = false;
            // 
            // QRCode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(scanqr);
            Controls.Add(scanIcon);
            Controls.Add(backBtn);
            Controls.Add(panel1);
            Name = "QRCode";
            Size = new Size(600, 1000);
            ((System.ComponentModel.ISupportInitialize)pbQR).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)scanIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbQR;
        private Label txtUsername;
        private Panel panel1;
        private PictureBox backBtn;
        private PictureBox scanIcon;
        private scanQR scanqr;
    }
}
