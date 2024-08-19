namespace Instagram
{
    partial class ProfileFragment
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
            txtUsername = new Label();
            pictureBox1 = new PictureBox();
            avatar = new PictureBox();
            txtPost = new Label();
            txtFollowers = new Label();
            txtFollow = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new Label();
            txtCaption = new Label();
            editBtn = new Button();
            shareBtn = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            listPost = new FlowLayoutPanel();
            logoutBtn = new PictureBox();
            postInUser = new PostInUser();
            qrCode = new QRCode();
            commentPost = new CommentPost();
            showFollow = new ShowFollow();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)avatar).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoutBtn).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.AutoSize = true;
            txtUsername.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(75, 22);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(117, 37);
            txtUsername.TabIndex = 16;
            txtUsername.Text = "_jul.3rd";
            txtUsername.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._lock;
            pictureBox1.Location = new Point(25, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // avatar
            // 
            avatar.Image = Properties.Resources.circke2;
            avatar.Location = new Point(25, 103);
            avatar.Name = "avatar";
            avatar.Size = new Size(100, 100);
            avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            avatar.TabIndex = 17;
            avatar.TabStop = false;
            // 
            // txtPost
            // 
            txtPost.Font = new Font("Roboto", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPost.ForeColor = Color.White;
            txtPost.Location = new Point(168, 120);
            txtPost.Name = "txtPost";
            txtPost.Size = new Size(117, 37);
            txtPost.TabIndex = 16;
            txtPost.Text = "3";
            txtPost.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFollowers
            // 
            txtFollowers.Cursor = Cursors.Hand;
            txtFollowers.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFollowers.ForeColor = Color.White;
            txtFollowers.Location = new Point(301, 117);
            txtFollowers.Name = "txtFollowers";
            txtFollowers.Size = new Size(117, 37);
            txtFollowers.TabIndex = 16;
            txtFollowers.Text = "9";
            txtFollowers.TextAlign = ContentAlignment.MiddleCenter;
            txtFollowers.Click += txtFollowers_Click;
            // 
            // txtFollow
            // 
            txtFollow.Cursor = Cursors.Hand;
            txtFollow.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFollow.ForeColor = Color.White;
            txtFollow.Location = new Point(456, 116);
            txtFollow.Name = "txtFollow";
            txtFollow.Size = new Size(117, 37);
            txtFollow.TabIndex = 16;
            txtFollow.Text = "107";
            txtFollow.TextAlign = ContentAlignment.MiddleCenter;
            txtFollow.Click += txtFollow_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(186, 161);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 16;
            label1.Text = "Bài viết";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(289, 161);
            label4.Name = "label4";
            label4.Size = new Size(142, 25);
            label4.TabIndex = 16;
            label4.Text = "Người theo dõi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(445, 161);
            label5.Name = "label5";
            label5.Size = new Size(135, 25);
            label5.TabIndex = 16;
            label5.Text = "Đang theo dõi";
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(25, 217);
            txtName.Name = "txtName";
            txtName.Size = new Size(74, 25);
            txtName.TabIndex = 16;
            txtName.Text = "Havold";
            txtName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCaption
            // 
            txtCaption.AutoSize = true;
            txtCaption.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCaption.ForeColor = Color.White;
            txtCaption.Location = new Point(25, 247);
            txtCaption.Name = "txtCaption";
            txtCaption.Size = new Size(306, 25);
            txtCaption.TabIndex = 16;
            txtCaption.Text = "Do lowkey chứ hông phải clone .-.";
            txtCaption.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // editBtn
            // 
            editBtn.Cursor = Cursors.Hand;
            editBtn.FlatStyle = FlatStyle.Flat;
            editBtn.Font = new Font("Roboto", 10F, FontStyle.Bold);
            editBtn.ForeColor = Color.White;
            editBtn.Location = new Point(25, 291);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(275, 37);
            editBtn.TabIndex = 18;
            editBtn.Text = "Chỉnh sửa trang cá nhân";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // shareBtn
            // 
            shareBtn.BackColor = Color.Black;
            shareBtn.Cursor = Cursors.Hand;
            shareBtn.FlatStyle = FlatStyle.Flat;
            shareBtn.Font = new Font("Roboto", 10F, FontStyle.Bold);
            shareBtn.ForeColor = Color.White;
            shareBtn.Location = new Point(306, 291);
            shareBtn.Name = "shareBtn";
            shareBtn.Size = new Size(267, 37);
            shareBtn.TabIndex = 18;
            shareBtn.Text = "Chia sẻ trang cá nhân";
            shareBtn.UseVisualStyleBackColor = false;
            shareBtn.Click += shareBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(3, 347);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 69);
            panel1.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(598, 3);
            panel2.TabIndex = 20;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.grid;
            pictureBox2.Location = new Point(284, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // listPost
            // 
            listPost.AutoScroll = true;
            listPost.Location = new Point(3, 415);
            listPost.Name = "listPost";
            listPost.Size = new Size(597, 511);
            listPost.TabIndex = 20;
            // 
            // logoutBtn
            // 
            logoutBtn.Cursor = Cursors.Hand;
            logoutBtn.Image = Properties.Resources.logoutBtn1;
            logoutBtn.Location = new Point(533, 22);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(40, 40);
            logoutBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            logoutBtn.TabIndex = 17;
            logoutBtn.TabStop = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // postInUser
            // 
            postInUser.BackColor = Color.Black;
            postInUser.Location = new Point(1, 0);
            postInUser.Name = "postInUser";
            postInUser.Size = new Size(603, 920);
            postInUser.TabIndex = 21;
            postInUser.Visible = false;
            // 
            // qrCode
            // 
            qrCode.BackColor = Color.Black;
            qrCode.Location = new Point(0, 0);
            qrCode.Name = "qrCode";
            qrCode.Size = new Size(606, 920);
            qrCode.TabIndex = 22;
            qrCode.Visible = false;
            // 
            // commentPost
            // 
            commentPost.BackColor = Color.Black;
            commentPost.Location = new Point(3, 3);
            commentPost.Name = "commentPost";
            commentPost.Size = new Size(606, 920);
            commentPost.TabIndex = 23;
            commentPost.Visible = false;
            // 
            // showFollow
            // 
            showFollow.BackColor = Color.Black;
            showFollow.BorderStyle = BorderStyle.FixedSingle;
            showFollow.Location = new Point(25, 98);
            showFollow.Name = "showFollow";
            showFollow.Size = new Size(560, 674);
            showFollow.TabIndex = 24;
            showFollow.Visible = false;
            // 
            // ProfileFragment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(showFollow);
            Controls.Add(commentPost);
            Controls.Add(qrCode);
            Controls.Add(postInUser);
            Controls.Add(listPost);
            Controls.Add(panel1);
            Controls.Add(shareBtn);
            Controls.Add(editBtn);
            Controls.Add(avatar);
            Controls.Add(logoutBtn);
            Controls.Add(pictureBox1);
            Controls.Add(txtFollow);
            Controls.Add(txtFollowers);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtCaption);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(txtPost);
            Controls.Add(txtUsername);
            Name = "ProfileFragment";
            Size = new Size(606, 926);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)avatar).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoutBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtUsername;
        private PictureBox pictureBox1;
        private PictureBox avatar;
        private Label txtPost;
        private Label txtFollowers;
        private Label txtFollow;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label txtName;
        private Label txtCaption;
        private Button editBtn;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private FlowLayoutPanel listPost;
        private PictureBox logoutBtn;
        private PostInUser postInUser;
        private Button shareBtn;
        private QRCode qrCode;
        private CommentPost commentPost;
        private ShowFollow showFollow;
    }
}
