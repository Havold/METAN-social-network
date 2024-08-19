namespace Instagram
{
    partial class ThreeImage
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
            pb3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb3).BeginInit();
            SuspendLayout();
            // 
            // pb1
            // 
            pb1.Location = new Point(0, 0);
            pb1.Name = "pb1";
            pb1.Size = new Size(273, 357);
            pb1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb1.TabIndex = 0;
            pb1.TabStop = false;
            // 
            // pb2
            // 
            pb2.Location = new Point(269, 3);
            pb2.Name = "pb2";
            pb2.Size = new Size(286, 165);
            pb2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb2.TabIndex = 1;
            pb2.TabStop = false;
            // 
            // pb3
            // 
            pb3.Location = new Point(269, 174);
            pb3.Name = "pb3";
            pb3.Size = new Size(289, 183);
            pb3.SizeMode = PictureBoxSizeMode.StretchImage;
            pb3.TabIndex = 2;
            pb3.TabStop = false;
            // 
            // ThreeImage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(pb3);
            Controls.Add(pb2);
            Controls.Add(pb1);
            Name = "ThreeImage";
            Size = new Size(558, 357);
            ((System.ComponentModel.ISupportInitialize)pb1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pb1;
        private PictureBox pb2;
        private PictureBox pb3;
    }
}
