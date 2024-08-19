namespace Instagram
{
    partial class Post
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
            listImage = new FlowLayoutPanel();
            cmtTxt = new PictureBox();
            likeBtn = new PictureBox();
            likeTxt = new Label();
            avatar = new PictureBox();
            txtUser = new Label();
            txtDate = new Label();
            cmtTotal = new Label();
            captionTxt = new Label();
            deleteBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)cmtTxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)likeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)avatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deleteBtn).BeginInit();
            SuspendLayout();
            // 
            // listImage
            // 
            listImage.Location = new Point(3, 62);
            listImage.Name = "listImage";
            listImage.Size = new Size(560, 360);
            listImage.TabIndex = 0;
            // 
            // cmtTxt
            // 
            cmtTxt.Cursor = Cursors.Hand;
            cmtTxt.Image = Properties.Resources.message;
            cmtTxt.Location = new Point(82, 441);
            cmtTxt.Name = "cmtTxt";
            cmtTxt.Size = new Size(40, 40);
            cmtTxt.SizeMode = PictureBoxSizeMode.StretchImage;
            cmtTxt.TabIndex = 7;
            cmtTxt.TabStop = false;
            cmtTxt.Click += cmtTxt_Click;
            // 
            // likeBtn
            // 
            likeBtn.Cursor = Cursors.Hand;
            likeBtn.Image = Properties.Resources.favorite;
            likeBtn.Location = new Point(16, 441);
            likeBtn.Name = "likeBtn";
            likeBtn.Size = new Size(40, 40);
            likeBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            likeBtn.TabIndex = 6;
            likeBtn.TabStop = false;
            likeBtn.Click += likeBtn_Click;
            // 
            // likeTxt
            // 
            likeTxt.AutoSize = true;
            likeTxt.Font = new Font("Roboto", 10F, FontStyle.Bold);
            likeTxt.ForeColor = Color.White;
            likeTxt.Location = new Point(16, 497);
            likeTxt.Name = "likeTxt";
            likeTxt.Size = new Size(134, 22);
            likeTxt.TabIndex = 8;
            likeTxt.Text = "1.036 lượt thích";
            // 
            // avatar
            // 
            avatar.Cursor = Cursors.Hand;
            avatar.Image = Properties.Resources.circke1;
            avatar.Location = new Point(16, 10);
            avatar.Name = "avatar";
            avatar.Size = new Size(40, 40);
            avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            avatar.TabIndex = 6;
            avatar.TabStop = false;
            avatar.Click += Avatar_Click;
            // 
            // txtUser
            // 
            txtUser.AutoSize = true;
            txtUser.Font = new Font("Roboto", 10F, FontStyle.Bold);
            txtUser.ForeColor = Color.White;
            txtUser.Location = new Point(62, 10);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(63, 22);
            txtUser.TabIndex = 8;
            txtUser.Text = "havold";
            txtUser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDate
            // 
            txtDate.AutoSize = true;
            txtDate.Font = new Font("Roboto", 8F);
            txtDate.ForeColor = Color.White;
            txtDate.Location = new Point(63, 33);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(87, 18);
            txtDate.TabIndex = 8;
            txtDate.Text = "7 ngày trước";
            txtDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmtTotal
            // 
            cmtTotal.AutoSize = true;
            cmtTotal.Cursor = Cursors.Hand;
            cmtTotal.Font = new Font("Roboto", 8F);
            cmtTotal.ForeColor = Color.Silver;
            cmtTotal.Location = new Point(16, 616);
            cmtTotal.Name = "cmtTotal";
            cmtTotal.Size = new Size(146, 18);
            cmtTotal.TabIndex = 8;
            cmtTotal.Text = "Xem tất cả 7 bình luận";
            cmtTotal.TextAlign = ContentAlignment.MiddleLeft;
            cmtTotal.Click += cmtTotal_Click;
            // 
            // captionTxt
            // 
            captionTxt.Font = new Font("Roboto", 10F);
            captionTxt.ForeColor = Color.White;
            captionTxt.Location = new Point(16, 530);
            captionTxt.Name = "captionTxt";
            captionTxt.Size = new Size(544, 86);
            captionTxt.TabIndex = 10;
            captionTxt.Text = "Biết nói gì nữa bây giờ";
            // 
            // deleteBtn
            // 
            deleteBtn.Cursor = Cursors.Hand;
            deleteBtn.Image = Properties.Resources._9004673_trash_delete_bin_remove_icon;
            deleteBtn.Location = new Point(500, 13);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(36, 36);
            deleteBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            deleteBtn.TabIndex = 6;
            deleteBtn.TabStop = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // Post
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(captionTxt);
            Controls.Add(cmtTotal);
            Controls.Add(txtDate);
            Controls.Add(txtUser);
            Controls.Add(likeTxt);
            Controls.Add(cmtTxt);
            Controls.Add(deleteBtn);
            Controls.Add(avatar);
            Controls.Add(likeBtn);
            Controls.Add(listImage);
            Name = "Post";
            Size = new Size(560, 659);
            ((System.ComponentModel.ISupportInitialize)cmtTxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)likeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)avatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)deleteBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel listImage;
        private PictureBox cmtTxt;
        private PictureBox likeBtn;
        private Label likeTxt;
        private PictureBox avatar;
        private Label txtUser;
        private Label txtDate;
        private Label cmtTotal;
        private Label captionTxt;
        private PictureBox deleteBtn;
    }
}
