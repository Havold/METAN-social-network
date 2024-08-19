namespace Instagram
{
    partial class showChat
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(464, 31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(59, 35);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(406, 36);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.rectangle1;
            pictureBox3.Location = new Point(56, 29);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(199, 58);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.rectangle2;
            pictureBox4.Location = new Point(261, 31);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(199, 56);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 5);
            label3.Name = "label3";
            label3.Size = new Size(251, 21);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.ForeColor = Color.White;
            label4.Location = new Point(261, 8);
            label4.Name = "label4";
            label4.Size = new Size(252, 18);
            label4.TabIndex = 7;
            label4.Text = "label4";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // showChat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(label2);
            Controls.Add(pictureBox4);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Name = "showChat";
            Size = new Size(513, 111);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label3;
        private Label label4;
    }
}
