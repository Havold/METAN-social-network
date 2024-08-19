namespace Instagram
{
    partial class HomeFragment
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
            messageIcon = new PictureBox();
            logoMetan = new Label();
            listPost = new FlowLayoutPanel();
            txtNoOne = new Panel();
            label2 = new Label();
            label1 = new Label();
            userProfile = new UserProfile();
            commentPost = new CommentPost();
            ((System.ComponentModel.ISupportInitialize)messageIcon).BeginInit();
            listPost.SuspendLayout();
            txtNoOne.SuspendLayout();
            SuspendLayout();
            // 
            // messageIcon
            // 
            messageIcon.Cursor = Cursors.Hand;
            messageIcon.Image = Properties.Resources.messenger;
            messageIcon.Location = new Point(533, 23);
            messageIcon.Name = "messageIcon";
            messageIcon.Size = new Size(40, 40);
            messageIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            messageIcon.TabIndex = 5;
            messageIcon.TabStop = false;
            messageIcon.Click += messageIcon_Click;
            // 
            // logoMetan
            // 
            logoMetan.AutoSize = true;
            logoMetan.Font = new Font("VALORANT", 26F);
            logoMetan.ForeColor = Color.White;
            logoMetan.Location = new Point(6, 29);
            logoMetan.Name = "logoMetan";
            logoMetan.Size = new Size(193, 44);
            logoMetan.TabIndex = 3;
            logoMetan.Text = "METAN";
            // 
            // listPost
            // 
            listPost.AutoScroll = true;
            listPost.Controls.Add(txtNoOne);
            listPost.Location = new Point(0, 91);
            listPost.Name = "listPost";
            listPost.Size = new Size(606, 832);
            listPost.TabIndex = 6;
            // 
            // txtNoOne
            // 
            txtNoOne.Controls.Add(label2);
            txtNoOne.Controls.Add(label1);
            txtNoOne.Location = new Point(3, 3);
            txtNoOne.Name = "txtNoOne";
            txtNoOne.Size = new Size(597, 796);
            txtNoOne.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(172, 362);
            label2.Name = "label2";
            label2.Size = new Size(245, 25);
            label2.TabIndex = 5;
            label2.Text = "Hãy là người đầu tiên nào!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(97, 323);
            label1.Name = "label1";
            label1.Size = new Size(402, 25);
            label1.TabIndex = 6;
            label1.Text = "Mọi người chưa chia sẻ khoảng khắc nào cả";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // userProfile
            // 
            userProfile.BackColor = Color.Black;
            userProfile.Location = new Point(0, 0);
            userProfile.Name = "userProfile";
            userProfile.Size = new Size(606, 920);
            userProfile.TabIndex = 7;
            userProfile.Visible = false;
            // 
            // commentPost
            // 
            commentPost.BackColor = Color.Black;
            commentPost.Location = new Point(0, 0);
            commentPost.Name = "commentPost";
            commentPost.Size = new Size(606, 920);
            commentPost.TabIndex = 8;
            commentPost.Visible = false;
            // 
            // HomeFragment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(commentPost);
            Controls.Add(userProfile);
            Controls.Add(listPost);
            Controls.Add(messageIcon);
            Controls.Add(logoMetan);
            Name = "HomeFragment";
            Size = new Size(606, 926);
            ((System.ComponentModel.ISupportInitialize)messageIcon).EndInit();
            listPost.ResumeLayout(false);
            txtNoOne.ResumeLayout(false);
            txtNoOne.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox messageIcon;
        private Label logoMetan;
        private FlowLayoutPanel listPost;
        private Panel txtNoOne;
        private Label label2;
        private Label label1;
        private UserProfile userProfile;
        private CommentPost commentPost;
    }
}
