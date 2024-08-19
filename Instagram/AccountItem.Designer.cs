namespace Instagram
{
    partial class AccountItem
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
            avatar = new PictureBox();
            txtFollow = new Label();
            txtUsername = new Label();
            txtFullname = new Label();
            backgroundItem = new Panel();
            ((System.ComponentModel.ISupportInitialize)avatar).BeginInit();
            SuspendLayout();
            // 
            // avatar
            // 
            avatar.BackColor = Color.Transparent;
            avatar.Location = new Point(15, 16);
            avatar.Name = "avatar";
            avatar.Size = new Size(100, 100);
            avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            avatar.TabIndex = 0;
            avatar.TabStop = false;
            avatar.Click += AccountItem_Click;
            // 
            // txtFollow
            // 
            txtFollow.AutoSize = true;
            txtFollow.BackColor = Color.Transparent;
            txtFollow.Font = new Font("Roboto", 10F);
            txtFollow.ForeColor = Color.Silver;
            txtFollow.Location = new Point(132, 83);
            txtFollow.Name = "txtFollow";
            txtFollow.Size = new Size(115, 22);
            txtFollow.TabIndex = 18;
            txtFollow.Text = "Đang theo dõi";
            txtFollow.Visible = false;
            // 
            // txtUsername
            // 
            txtUsername.AutoSize = true;
            txtUsername.BackColor = Color.Transparent;
            txtUsername.Font = new Font("Roboto", 10F);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(132, 23);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(96, 22);
            txtUsername.TabIndex = 18;
            txtUsername.Text = "tranquocan";
            txtUsername.Click += AccountItem_Click;
            // 
            // txtFullname
            // 
            txtFullname.AutoSize = true;
            txtFullname.BackColor = Color.Transparent;
            txtFullname.Font = new Font("Roboto", 11F);
            txtFullname.ForeColor = Color.Silver;
            txtFullname.Location = new Point(132, 51);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(123, 24);
            txtFullname.TabIndex = 18;
            txtFullname.Text = "Trần Quốc An";
            txtFullname.Click += AccountItem_Click;
            // 
            // backgroundItem
            // 
            backgroundItem.Location = new Point(0, 0);
            backgroundItem.Name = "backgroundItem";
            backgroundItem.Size = new Size(520, 125);
            backgroundItem.TabIndex = 19;
            backgroundItem.Click += AccountItem_Click;
            backgroundItem.MouseEnter += backgroundItem_MouserEnter;
            backgroundItem.MouseLeave += backgroundItem_MouseLeave;
            // 
            // AccountItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(txtFullname);
            Controls.Add(txtUsername);
            Controls.Add(txtFollow);
            Controls.Add(avatar);
            Controls.Add(backgroundItem);
            Cursor = Cursors.Hand;
            Name = "AccountItem";
            Size = new Size(527, 131);
            Click += AccountItem_Click;
            ((System.ComponentModel.ISupportInitialize)avatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox avatar;
        private Label txtFollow;
        private Label txtUsername;
        private Label txtFullname;
        private Panel backgroundItem;
    }
}
