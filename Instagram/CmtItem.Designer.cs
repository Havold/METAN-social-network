namespace Instagram
{
    partial class CmtItem
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
            txtUserPost = new Label();
            txtTime = new Label();
            txtCmt = new Label();
            deleteBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)avatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deleteBtn).BeginInit();
            SuspendLayout();
            // 
            // avatar
            // 
            avatar.Image = Properties.Resources.avatar_3;
            avatar.Location = new Point(8, 6);
            avatar.Name = "avatar";
            avatar.Size = new Size(80, 80);
            avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            avatar.TabIndex = 1;
            avatar.TabStop = false;
            // 
            // txtUserPost
            // 
            txtUserPost.AutoSize = true;
            txtUserPost.Font = new Font("Roboto", 10F, FontStyle.Bold);
            txtUserPost.ForeColor = Color.White;
            txtUserPost.Location = new Point(97, 9);
            txtUserPost.Name = "txtUserPost";
            txtUserPost.Size = new Size(63, 22);
            txtUserPost.TabIndex = 3;
            txtUserPost.Text = "havold";
            // 
            // txtTime
            // 
            txtTime.Font = new Font("Roboto", 9F, FontStyle.Bold);
            txtTime.ForeColor = Color.Silver;
            txtTime.Location = new Point(385, 9);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(178, 22);
            txtTime.TabIndex = 3;
            txtTime.Text = "12/1/2024";
            txtTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCmt
            // 
            txtCmt.Font = new Font("Roboto", 10F);
            txtCmt.ForeColor = Color.White;
            txtCmt.Location = new Point(97, 35);
            txtCmt.Name = "txtCmt";
            txtCmt.Size = new Size(415, 50);
            txtCmt.TabIndex = 4;
            txtCmt.Text = "Bài này hay quá đi";
            // 
            // deleteBtn
            // 
            deleteBtn.Cursor = Cursors.Hand;
            deleteBtn.Image = Properties.Resources._9004673_trash_delete_bin_remove_icon;
            deleteBtn.Location = new Point(523, 44);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(36, 36);
            deleteBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            deleteBtn.TabIndex = 7;
            deleteBtn.TabStop = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // CmtItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(deleteBtn);
            Controls.Add(txtCmt);
            Controls.Add(txtTime);
            Controls.Add(txtUserPost);
            Controls.Add(avatar);
            Name = "CmtItem";
            Size = new Size(575, 98);
            ((System.ComponentModel.ISupportInitialize)avatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)deleteBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox avatar;
        private Label txtUserPost;
        private Label txtTime;
        private Label txtCmt;
        private PictureBox deleteBtn;
    }
}
