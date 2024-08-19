namespace Instagram
{
    partial class Notification
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
            txtCreate = new Label();
            listNoti = new FlowLayoutPanel();
            commentPost = new CommentPost();
            postInUser = new PostInUser();
            userProfile = new UserProfile();
            SuspendLayout();
            // 
            // txtCreate
            // 
            txtCreate.AutoSize = true;
            txtCreate.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCreate.ForeColor = Color.White;
            txtCreate.Location = new Point(15, 24);
            txtCreate.Name = "txtCreate";
            txtCreate.Size = new Size(161, 37);
            txtCreate.TabIndex = 17;
            txtCreate.Text = "Thông báo";
            // 
            // listNoti
            // 
            listNoti.Location = new Point(3, 84);
            listNoti.Name = "listNoti";
            listNoti.Size = new Size(600, 839);
            listNoti.TabIndex = 18;
            // 
            // commentPost
            // 
            commentPost.BackColor = Color.Black;
            commentPost.Location = new Point(3, 3);
            commentPost.Name = "commentPost";
            commentPost.Size = new Size(603, 920);
            commentPost.TabIndex = 21;
            commentPost.Visible = false;
            // 
            // postInUser
            // 
            postInUser.BackColor = Color.Black;
            postInUser.Location = new Point(3, 3);
            postInUser.Name = "postInUser";
            postInUser.Size = new Size(606, 920);
            postInUser.TabIndex = 20;
            postInUser.Visible = false;
            // 
            // userProfile
            // 
            userProfile.BackColor = Color.Black;
            userProfile.Location = new Point(0, 0);
            userProfile.Name = "userProfile";
            userProfile.Size = new Size(606, 920);
            userProfile.TabIndex = 19;
            userProfile.Visible = false;
            // 
            // Notification
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(commentPost);
            Controls.Add(postInUser);
            Controls.Add(userProfile);
            Controls.Add(listNoti);
            Controls.Add(txtCreate);
            Name = "Notification";
            Size = new Size(606, 926);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtCreate;
        private FlowLayoutPanel listNoti;
        private CommentPost commentPost;
        private PostInUser postInUser;
        private UserProfile userProfile;
    }
}
