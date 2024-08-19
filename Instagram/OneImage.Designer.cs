namespace Instagram
{
    partial class OneImage
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
            nextBtn = new PictureBox();
            backBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imgPost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nextBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            SuspendLayout();
            // 
            // imgPost
            // 
            imgPost.Location = new Point(0, 0);
            imgPost.Name = "imgPost";
            imgPost.Size = new Size(558, 357);
            imgPost.SizeMode = PictureBoxSizeMode.StretchImage;
            imgPost.TabIndex = 0;
            imgPost.TabStop = false;
            // 
            // nextBtn
            // 
            nextBtn.Cursor = Cursors.Hand;
            nextBtn.Image = Properties.Resources.nextBtnArrow1;
            nextBtn.Location = new Point(498, 142);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(60, 60);
            nextBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            nextBtn.TabIndex = 1;
            nextBtn.TabStop = false;
            nextBtn.Click += nextBtn_Click;
            // 
            // backBtn
            // 
            backBtn.Cursor = Cursors.Hand;
            backBtn.Image = Properties.Resources.backBtnArrow2;
            backBtn.Location = new Point(3, 142);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(60, 60);
            backBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            backBtn.TabIndex = 1;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // OneImage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(backBtn);
            Controls.Add(nextBtn);
            Controls.Add(imgPost);
            Name = "OneImage";
            Size = new Size(558, 360);
            ((System.ComponentModel.ISupportInitialize)imgPost).EndInit();
            ((System.ComponentModel.ISupportInitialize)nextBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox imgPost;
        private PictureBox nextBtn;
        private PictureBox backBtn;
    }
}
