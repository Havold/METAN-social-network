namespace Instagram
{
    partial class ImageItem
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
            Ptrbox = new PictureBox();
            deleteBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Ptrbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deleteBox).BeginInit();
            SuspendLayout();
            // 
            // Ptrbox
            // 
            Ptrbox.BorderStyle = BorderStyle.FixedSingle;
            Ptrbox.Image = Properties.Resources.plus;
            Ptrbox.Location = new Point(0, 0);
            Ptrbox.Name = "Ptrbox";
            Ptrbox.Size = new Size(120, 120);
            Ptrbox.SizeMode = PictureBoxSizeMode.StretchImage;
            Ptrbox.TabIndex = 0;
            Ptrbox.TabStop = false;
            Ptrbox.Click += Item_Click;
            // 
            // deleteBox
            // 
            deleteBox.Image = Properties.Resources.closeBtn;
            deleteBox.Location = new Point(80, 0);
            deleteBox.Name = "deleteBox";
            deleteBox.Size = new Size(40, 40);
            deleteBox.SizeMode = PictureBoxSizeMode.StretchImage;
            deleteBox.TabIndex = 1;
            deleteBox.TabStop = false;
            deleteBox.Visible = false;
            deleteBox.Click += deleteBox_Click;
            // 
            // ImageItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(deleteBox);
            Controls.Add(Ptrbox);
            Cursor = Cursors.Hand;
            Name = "ImageItem";
            Size = new Size(120, 120);
            ((System.ComponentModel.ISupportInitialize)Ptrbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)deleteBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Ptrbox;
        private PictureBox deleteBox;
    }
}
