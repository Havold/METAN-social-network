namespace Instagram
{
    partial class MainPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            profileIcon = new PictureBox();
            notiIcon = new PictureBox();
            addIcon = new PictureBox();
            findIcon = new PictureBox();
            homeIcon = new PictureBox();
            whiteCircle = new PictureBox();
            homeFragment = new HomeFragment();
            profileFragment = new ProfileFragment();
            findFragment = new FindFragment();
            notification = new Notification();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profileIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)notiIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)findIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)whiteCircle).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(profileIcon);
            panel1.Controls.Add(notiIcon);
            panel1.Controls.Add(addIcon);
            panel1.Controls.Add(findIcon);
            panel1.Controls.Add(homeIcon);
            panel1.Controls.Add(whiteCircle);
            panel1.Location = new Point(-1, 932);
            panel1.Name = "panel1";
            panel1.Size = new Size(606, 66);
            panel1.TabIndex = 3;
            // 
            // profileIcon
            // 
            profileIcon.Cursor = Cursors.Hand;
            profileIcon.Image = Properties.Resources.circke;
            profileIcon.Location = new Point(518, 13);
            profileIcon.Name = "profileIcon";
            profileIcon.Size = new Size(40, 40);
            profileIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            profileIcon.TabIndex = 2;
            profileIcon.TabStop = false;
            profileIcon.Click += profileIcon_Click;
            // 
            // notiIcon
            // 
            notiIcon.Cursor = Cursors.Hand;
            notiIcon.Image = Properties.Resources.favorite1;
            notiIcon.Location = new Point(394, 13);
            notiIcon.Name = "notiIcon";
            notiIcon.Size = new Size(40, 40);
            notiIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            notiIcon.TabIndex = 2;
            notiIcon.TabStop = false;
            notiIcon.Click += notiIcon_Click;
            // 
            // addIcon
            // 
            addIcon.Cursor = Cursors.Hand;
            addIcon.Image = Properties.Resources.addBtn;
            addIcon.Location = new Point(266, 13);
            addIcon.Name = "addIcon";
            addIcon.Size = new Size(40, 40);
            addIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            addIcon.TabIndex = 2;
            addIcon.TabStop = false;
            addIcon.Click += addIcon_Click;
            // 
            // findIcon
            // 
            findIcon.Cursor = Cursors.Hand;
            findIcon.Image = Properties.Resources.find1;
            findIcon.Location = new Point(144, 15);
            findIcon.Name = "findIcon";
            findIcon.Size = new Size(40, 40);
            findIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            findIcon.TabIndex = 2;
            findIcon.TabStop = false;
            findIcon.Click += findIcon_Click;
            // 
            // homeIcon
            // 
            homeIcon.Cursor = Cursors.Hand;
            homeIcon.Image = Properties.Resources.Home_full;
            homeIcon.Location = new Point(37, 15);
            homeIcon.Name = "homeIcon";
            homeIcon.Size = new Size(40, 40);
            homeIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            homeIcon.TabIndex = 2;
            homeIcon.TabStop = false;
            homeIcon.Click += homeIcon_Click;
            // 
            // whiteCircle
            // 
            whiteCircle.Cursor = Cursors.Hand;
            whiteCircle.Image = Properties.Resources.circke;
            whiteCircle.Location = new Point(514, 10);
            whiteCircle.Name = "whiteCircle";
            whiteCircle.Size = new Size(48, 48);
            whiteCircle.SizeMode = PictureBoxSizeMode.StretchImage;
            whiteCircle.TabIndex = 2;
            whiteCircle.TabStop = false;
            whiteCircle.Visible = false;
            whiteCircle.Click += profileIcon_Click;
            // 
            // homeFragment
            // 
            homeFragment.BackColor = Color.Black;
            homeFragment.Location = new Point(-1, 12);
            homeFragment.Name = "homeFragment";
            homeFragment.Size = new Size(602, 914);
            homeFragment.TabIndex = 4;
            // 
            // profileFragment
            // 
            profileFragment.BackColor = Color.Black;
            profileFragment.Location = new Point(3, 0);
            profileFragment.Name = "profileFragment";
            profileFragment.Size = new Size(599, 926);
            profileFragment.TabIndex = 0;
            profileFragment.Visible = false;
            // 
            // findFragment
            // 
            findFragment.BackColor = Color.Black;
            findFragment.Location = new Point(4, 12);
            findFragment.Name = "findFragment";
            findFragment.Size = new Size(597, 914);
            findFragment.TabIndex = 5;
            findFragment.Visible = false;
            // 
            // notification
            // 
            notification.BackColor = Color.Black;
            notification.Location = new Point(-1, 8);
            notification.Name = "notification";
            notification.Size = new Size(600, 918);
            notification.TabIndex = 3;
            notification.Visible = false;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(600, 1000);
            Controls.Add(notification);
            Controls.Add(findFragment);
            Controls.Add(profileFragment);
            Controls.Add(homeFragment);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainPage";
            Text = "z";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)profileIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)notiIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)addIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)findIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)whiteCircle).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox findIcon;
        private PictureBox homeIcon;
        private PictureBox profileIcon;
        private PictureBox addIcon;
        private HomeFragment homeFragment;
        private ProfileFragment profileFragment;
        private FindFragment findFragment;
        private PictureBox notiIcon;
        private Notification notification;
        private PictureBox whiteCircle;
    }
}