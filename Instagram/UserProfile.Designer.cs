namespace Instagram
{
    partial class UserProfile
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
            pictureBox2 = new PictureBox();
            txtFollow = new Label();
            txtFollowers = new Label();
            panel2 = new Panel();
            listPost = new FlowLayoutPanel();
            panel1 = new Panel();
            messageBtn = new Button();
            followBtn = new Button();
            label5 = new Label();
            label4 = new Label();
            txtCaption = new Label();
            txtName = new Label();
            label1 = new Label();
            txtPost = new Label();
            txtUsername = new Label();
            backBtn = new PictureBox();
            postInUser = new PostInUser();
            commentPost = new CommentPost();
            ((System.ComponentModel.ISupportInitialize)avatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            SuspendLayout();
            // 
            // avatar
            // 
            avatar.Image = Properties.Resources.circke2;
            avatar.Location = new Point(25, 92);
            avatar.Name = "avatar";
            avatar.Size = new Size(100, 100);
            avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            avatar.TabIndex = 30;
            avatar.TabStop = false;
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
            // txtFollow
            // 
            txtFollow.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFollow.ForeColor = Color.White;
            txtFollow.Location = new Point(456, 105);
            txtFollow.Name = "txtFollow";
            txtFollow.Size = new Size(117, 37);
            txtFollow.TabIndex = 21;
            txtFollow.Text = "107";
            txtFollow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFollowers
            // 
            txtFollowers.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFollowers.ForeColor = Color.White;
            txtFollowers.Location = new Point(301, 106);
            txtFollowers.Name = "txtFollowers";
            txtFollowers.Size = new Size(117, 37);
            txtFollowers.TabIndex = 22;
            txtFollowers.Text = "9";
            txtFollowers.TextAlign = ContentAlignment.MiddleCenter;
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
            // listPost
            // 
            listPost.AutoScroll = true;
            listPost.Location = new Point(3, 404);
            listPost.Name = "listPost";
            listPost.Size = new Size(597, 511);
            listPost.TabIndex = 36;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(3, 336);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 69);
            panel1.TabIndex = 35;
            // 
            // messageBtn
            // 
            messageBtn.BackColor = Color.Black;
            messageBtn.Cursor = Cursors.Hand;
            messageBtn.FlatStyle = FlatStyle.Flat;
            messageBtn.Font = new Font("Roboto", 10F, FontStyle.Bold);
            messageBtn.ForeColor = Color.White;
            messageBtn.Location = new Point(306, 280);
            messageBtn.Name = "messageBtn";
            messageBtn.Size = new Size(267, 37);
            messageBtn.TabIndex = 33;
            messageBtn.Text = "Nhắn tin";
            messageBtn.UseVisualStyleBackColor = false;
            messageBtn.Click += messageBtn_Click;
            // 
            // followBtn
            // 
            followBtn.BackColor = Color.DodgerBlue;
            followBtn.Cursor = Cursors.Hand;
            followBtn.FlatStyle = FlatStyle.Flat;
            followBtn.Font = new Font("Roboto", 10F, FontStyle.Bold);
            followBtn.ForeColor = Color.White;
            followBtn.Location = new Point(25, 280);
            followBtn.Name = "followBtn";
            followBtn.Size = new Size(275, 37);
            followBtn.TabIndex = 34;
            followBtn.Text = "Theo dõi";
            followBtn.UseVisualStyleBackColor = false;
            followBtn.Click += followBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(445, 150);
            label5.Name = "label5";
            label5.Size = new Size(135, 25);
            label5.TabIndex = 23;
            label5.Text = "Đang theo dõi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(289, 150);
            label4.Name = "label4";
            label4.Size = new Size(142, 25);
            label4.TabIndex = 24;
            label4.Text = "Người theo dõi";
            // 
            // txtCaption
            // 
            txtCaption.AutoSize = true;
            txtCaption.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCaption.ForeColor = Color.White;
            txtCaption.Location = new Point(25, 236);
            txtCaption.Name = "txtCaption";
            txtCaption.Size = new Size(306, 25);
            txtCaption.TabIndex = 25;
            txtCaption.Text = "Do lowkey chứ hông phải clone .-.";
            txtCaption.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(25, 206);
            txtName.Name = "txtName";
            txtName.Size = new Size(74, 25);
            txtName.TabIndex = 26;
            txtName.Text = "Havold";
            txtName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(186, 150);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 27;
            label1.Text = "Bài viết";
            // 
            // txtPost
            // 
            txtPost.Font = new Font("Roboto", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPost.ForeColor = Color.White;
            txtPost.Location = new Point(168, 109);
            txtPost.Name = "txtPost";
            txtPost.Size = new Size(117, 37);
            txtPost.TabIndex = 28;
            txtPost.Text = "3";
            txtPost.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            txtUsername.AutoSize = true;
            txtUsername.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(75, 11);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(117, 37);
            txtUsername.TabIndex = 29;
            txtUsername.Text = "_jul.3rd";
            txtUsername.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Transparent;
            backBtn.Cursor = Cursors.Hand;
            backBtn.Image = Properties.Resources.backBtn;
            backBtn.Location = new Point(25, 12);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(40, 40);
            backBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            backBtn.TabIndex = 37;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // postInUser
            // 
            postInUser.BackColor = Color.Black;
            postInUser.Location = new Point(1, 0);
            postInUser.Name = "postInUser";
            postInUser.Size = new Size(603, 920);
            postInUser.TabIndex = 38;
            postInUser.Visible = false;
            // 
            // commentPost
            // 
            commentPost.BackColor = Color.Black;
            commentPost.Location = new Point(0, 0);
            commentPost.Name = "commentPost";
            commentPost.Size = new Size(606, 920);
            commentPost.TabIndex = 39;
            commentPost.Visible = false;
            // 
            // UserProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(commentPost);
            Controls.Add(postInUser);
            Controls.Add(backBtn);
            Controls.Add(avatar);
            Controls.Add(txtFollow);
            Controls.Add(txtFollowers);
            Controls.Add(listPost);
            Controls.Add(panel1);
            Controls.Add(messageBtn);
            Controls.Add(followBtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtCaption);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(txtPost);
            Controls.Add(txtUsername);
            Name = "UserProfile";
            Size = new Size(606, 926);
            ((System.ComponentModel.ISupportInitialize)avatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox avatar;
        private PictureBox pictureBox2;
        private Label txtFollow;
        private Label txtFollowers;
        private Panel panel2;
        private FlowLayoutPanel listPost;
        private Panel panel1;
        private Button messageBtn;
        private Button followBtn;
        private Label label5;
        private Label label4;
        private Label txtCaption;
        private Label txtName;
        private Label label1;
        private Label txtPost;
        private Label txtUsername;
        private PictureBox backBtn;
        private PostInUser postInUser;
        private CommentPost commentPost;
    }
}
