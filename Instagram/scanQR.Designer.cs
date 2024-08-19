namespace Instagram
{
    partial class scanQR
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
            panel1 = new Panel();
            cbCamera = new ComboBox();
            txtUsername = new Label();
            pbQR = new PictureBox();
            openBtn = new PictureBox();
            closeBtn = new PictureBox();
            backBtn = new PictureBox();
            openProfileBtn = new PictureBox();
            userProfile = new UserProfile();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbQR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)openBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)openProfileBtn).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BackgroundImage = Properties.Resources.rectangle;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(cbCamera);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(pbQR);
            panel1.Location = new Point(67, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(472, 484);
            panel1.TabIndex = 1;
            // 
            // cbCamera
            // 
            cbCamera.Font = new Font("Roboto", 9F, FontStyle.Bold);
            cbCamera.FormattingEnabled = true;
            cbCamera.Location = new Point(35, 9);
            cbCamera.Name = "cbCamera";
            cbCamera.Size = new Size(410, 27);
            cbCamera.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.Font = new Font("SVN-Anastasia", 20F, FontStyle.Bold);
            txtUsername.ForeColor = Color.RosyBrown;
            txtUsername.Location = new Point(9, 418);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(452, 55);
            txtUsername.TabIndex = 10;
            txtUsername.Text = "havold";
            txtUsername.TextAlign = ContentAlignment.MiddleCenter;
            txtUsername.Visible = false;
            // 
            // pbQR
            // 
            pbQR.Location = new Point(35, 47);
            pbQR.Name = "pbQR";
            pbQR.Size = new Size(410, 363);
            pbQR.TabIndex = 0;
            pbQR.TabStop = false;
            // 
            // openBtn
            // 
            openBtn.Cursor = Cursors.Hand;
            openBtn.Image = Properties.Resources.openCamBtn1;
            openBtn.Location = new Point(67, 733);
            openBtn.Name = "openBtn";
            openBtn.Size = new Size(461, 62);
            openBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            openBtn.TabIndex = 2;
            openBtn.TabStop = false;
            openBtn.Click += openBtn_Click;
            openBtn.MouseEnter += openCamBtn_MouseEnter;
            openBtn.MouseLeave += openCamBtn_MouseLeave;
            // 
            // closeBtn
            // 
            closeBtn.Cursor = Cursors.Hand;
            closeBtn.Image = Properties.Resources.closeCamBtn;
            closeBtn.Location = new Point(67, 856);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(461, 62);
            closeBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            closeBtn.TabIndex = 2;
            closeBtn.TabStop = false;
            closeBtn.Click += Close_Click;
            closeBtn.MouseEnter += closeCamBtn_MouseEnter;
            closeBtn.MouseLeave += closeCamBtn_MouseLeave;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Transparent;
            backBtn.Cursor = Cursors.Hand;
            backBtn.Image = Properties.Resources.closeBtn2;
            backBtn.Location = new Point(22, 18);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(60, 60);
            backBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            backBtn.TabIndex = 15;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // openProfileBtn
            // 
            openProfileBtn.Cursor = Cursors.Hand;
            openProfileBtn.Image = Properties.Resources.openProfileBtn;
            openProfileBtn.Location = new Point(67, 617);
            openProfileBtn.Name = "openProfileBtn";
            openProfileBtn.Size = new Size(461, 62);
            openProfileBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            openProfileBtn.TabIndex = 2;
            openProfileBtn.TabStop = false;
            openProfileBtn.Visible = false;
            openProfileBtn.Click += openProfileBtn_Click;
            openProfileBtn.MouseEnter += openProfileBtn_MouseEnter;
            openProfileBtn.MouseLeave += openProfileBtn_MouseLeave;
            // 
            // userProfile
            // 
            userProfile.BackColor = Color.Black;
            userProfile.Location = new Point(-3, 0);
            userProfile.Name = "userProfile";
            userProfile.Size = new Size(600, 1000);
            userProfile.TabIndex = 16;
            userProfile.Visible = false;
            // 
            // scanQR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(userProfile);
            Controls.Add(backBtn);
            Controls.Add(closeBtn);
            Controls.Add(openProfileBtn);
            Controls.Add(openBtn);
            Controls.Add(panel1);
            Name = "scanQR";
            Size = new Size(600, 1000);
            Load += scanQR_Load_1;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbQR).EndInit();
            ((System.ComponentModel.ISupportInitialize)openBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)openProfileBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cbCamera;
        private Label txtUsername;
        private PictureBox pbQR;
        private PictureBox openBtn;
        private PictureBox closeBtn;
        private PictureBox backBtn;
        private PictureBox openProfileBtn;
        private UserProfile userProfile;
    }
}
