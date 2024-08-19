namespace Instagram
{
    partial class FourImage
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
            pb1 = new PictureBox();
            pb2 = new PictureBox();
            pb4 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pb1
            // 
            pb1.Location = new Point(-1, 0);
            pb1.Name = "pb1";
            pb1.Size = new Size(274, 176);
            pb1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb1.TabIndex = 3;
            pb1.TabStop = false;
            // 
            // pb2
            // 
            pb2.Location = new Point(276, 0);
            pb2.Name = "pb2";
            pb2.Size = new Size(282, 176);
            pb2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb2.TabIndex = 5;
            pb2.TabStop = false;
            // 
            // pb4
            // 
            pb4.Location = new Point(276, 173);
            pb4.Name = "pb4";
            pb4.Size = new Size(282, 184);
            pb4.SizeMode = PictureBoxSizeMode.StretchImage;
            pb4.TabIndex = 7;
            pb4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 173);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(279, 184);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // FourImage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(pb4);
            Controls.Add(pb2);
            Controls.Add(pb1);
            Name = "FourImage";
            Size = new Size(558, 357);
            ((System.ComponentModel.ISupportInitialize)pb1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pb3;
        private PictureBox pb1;
        private PictureBox pb2;

        private PictureBox pb4;
        private PictureBox pictureBox1;
    }
}
