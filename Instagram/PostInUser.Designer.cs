namespace Instagram
{
    partial class PostInUser
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
            txtPost = new Label();
            backBtn = new PictureBox();
            txtDate = new Label();
            txtUser = new Label();
            avatar = new PictureBox();
            listImage = new FlowLayoutPanel();
            captionTxt = new Label();
            cmtTotal = new Label();
            likeTxt = new Label();
            cmtTxt = new PictureBox();
            likeBtn = new PictureBox();
            deleteBtn = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)avatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmtTxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)likeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deleteBtn).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtPost);
            panel1.Controls.Add(backBtn);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(606, 78);
            panel1.TabIndex = 0;
            // 
            // txtPost
            // 
            txtPost.AutoSize = true;
            txtPost.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPost.ForeColor = Color.White;
            txtPost.Location = new Point(81, 24);
            txtPost.Name = "txtPost";
            txtPost.Size = new Size(116, 37);
            txtPost.TabIndex = 17;
            txtPost.Text = "Bài viết";
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Transparent;
            backBtn.Cursor = Cursors.Hand;
            backBtn.Image = Properties.Resources.backBtn;
            backBtn.Location = new Point(18, 21);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(40, 40);
            backBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            backBtn.TabIndex = 16;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // txtDate
            // 
            txtDate.AutoSize = true;
            txtDate.Font = new Font("Roboto", 8F);
            txtDate.ForeColor = Color.White;
            txtDate.Location = new Point(69, 116);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(87, 18);
            txtDate.TabIndex = 11;
            txtDate.Text = "7 ngày trước";
            txtDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUser
            // 
            txtUser.AutoSize = true;
            txtUser.Font = new Font("Roboto", 10F, FontStyle.Bold);
            txtUser.ForeColor = Color.White;
            txtUser.Location = new Point(68, 93);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(63, 22);
            txtUser.TabIndex = 10;
            txtUser.Text = "havold";
            txtUser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // avatar
            // 
            avatar.Cursor = Cursors.Hand;
            avatar.Image = Properties.Resources.circke1;
            avatar.Location = new Point(22, 93);
            avatar.Name = "avatar";
            avatar.Size = new Size(40, 40);
            avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            avatar.TabIndex = 9;
            avatar.TabStop = false;
            // 
            // listImage
            // 
            listImage.Location = new Point(22, 158);
            listImage.Name = "listImage";
            listImage.Size = new Size(560, 360);
            listImage.TabIndex = 12;
            // 
            // captionTxt
            // 
            captionTxt.Font = new Font("Roboto", 10F);
            captionTxt.ForeColor = Color.White;
            captionTxt.Location = new Point(25, 626);
            captionTxt.Name = "captionTxt";
            captionTxt.Size = new Size(563, 86);
            captionTxt.TabIndex = 17;
            captionTxt.Text = "Biết nói gì nữa bây giờ";
            // 
            // cmtTotal
            // 
            cmtTotal.AutoSize = true;
            cmtTotal.Cursor = Cursors.Hand;
            cmtTotal.Font = new Font("Roboto", 8F);
            cmtTotal.ForeColor = Color.Silver;
            cmtTotal.Location = new Point(25, 720);
            cmtTotal.Name = "cmtTotal";
            cmtTotal.Size = new Size(146, 18);
            cmtTotal.TabIndex = 15;
            cmtTotal.Text = "Xem tất cả 7 bình luận";
            cmtTotal.TextAlign = ContentAlignment.MiddleLeft;
            cmtTotal.Click += cmtTotal_Click;
            // 
            // likeTxt
            // 
            likeTxt.AutoSize = true;
            likeTxt.Font = new Font("Roboto", 10F, FontStyle.Bold);
            likeTxt.ForeColor = Color.White;
            likeTxt.Location = new Point(25, 593);
            likeTxt.Name = "likeTxt";
            likeTxt.Size = new Size(134, 22);
            likeTxt.TabIndex = 16;
            likeTxt.Text = "1.036 lượt thích";
            // 
            // cmtTxt
            // 
            cmtTxt.Cursor = Cursors.Hand;
            cmtTxt.Image = Properties.Resources.message;
            cmtTxt.Location = new Point(91, 537);
            cmtTxt.Name = "cmtTxt";
            cmtTxt.Size = new Size(40, 40);
            cmtTxt.SizeMode = PictureBoxSizeMode.StretchImage;
            cmtTxt.TabIndex = 14;
            cmtTxt.TabStop = false;
            cmtTxt.Click += cmtTxt_Click;
            // 
            // likeBtn
            // 
            likeBtn.Cursor = Cursors.Hand;
            likeBtn.Image = Properties.Resources.favorite;
            likeBtn.Location = new Point(25, 537);
            likeBtn.Name = "likeBtn";
            likeBtn.Size = new Size(40, 40);
            likeBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            likeBtn.TabIndex = 13;
            likeBtn.TabStop = false;
            likeBtn.Click += likeBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Cursor = Cursors.Hand;
            deleteBtn.Image = Properties.Resources._9004673_trash_delete_bin_remove_icon;
            deleteBtn.Location = new Point(546, 97);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(36, 36);
            deleteBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            deleteBtn.TabIndex = 18;
            deleteBtn.TabStop = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // PostInUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(deleteBtn);
            Controls.Add(captionTxt);
            Controls.Add(cmtTotal);
            Controls.Add(likeTxt);
            Controls.Add(cmtTxt);
            Controls.Add(likeBtn);
            Controls.Add(listImage);
            Controls.Add(txtDate);
            Controls.Add(txtUser);
            Controls.Add(avatar);
            Controls.Add(panel1);
            Name = "PostInUser";
            Size = new Size(606, 920);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)avatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmtTxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)likeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)deleteBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label txtPost;
        private PictureBox backBtn;
        private Label txtDate;
        private Label txtUser;
        private PictureBox avatar;
        private FlowLayoutPanel listImage;
        private Label captionTxt;
        private Label cmtTotal;
        private Label likeTxt;
        private PictureBox cmtTxt;
        private PictureBox likeBtn;
        private PictureBox deleteBtn;
    }
}
