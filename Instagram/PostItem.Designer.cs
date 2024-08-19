namespace Instagram
{
    partial class PostItem
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
            imgPost = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imgPost).BeginInit();
            SuspendLayout();
            // 
            // imgPost
            // 
            imgPost.Cursor = Cursors.Hand;
            imgPost.Location = new Point(0, 0);
            imgPost.Name = "imgPost";
            imgPost.Size = new Size(149, 149);
            imgPost.SizeMode = PictureBoxSizeMode.StretchImage;
            imgPost.TabIndex = 0;
            imgPost.TabStop = false;
            imgPost.Click += Item_Click;
            // 
            // PostItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(imgPost);
            Name = "PostItem";
            ((System.ComponentModel.ISupportInitialize)imgPost).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox imgPost;
    }
}
