namespace Instagram
{
    partial class ShowFollow
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
            txtFollow = new Label();
            listFollow = new FlowLayoutPanel();
            backBtn = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(backBtn);
            panel1.Controls.Add(txtFollow);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 74);
            panel1.TabIndex = 0;
            // 
            // txtFollow
            // 
            txtFollow.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFollow.ForeColor = Color.White;
            txtFollow.Location = new Point(1, 20);
            txtFollow.Name = "txtFollow";
            txtFollow.Size = new Size(563, 37);
            txtFollow.TabIndex = 16;
            txtFollow.Text = "Followers";
            txtFollow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listFollow
            // 
            listFollow.AutoScroll = true;
            listFollow.Location = new Point(1, 82);
            listFollow.Name = "listFollow";
            listFollow.Size = new Size(566, 454);
            listFollow.TabIndex = 0;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Transparent;
            backBtn.Cursor = Cursors.Hand;
            backBtn.Image = Properties.Resources.closeBtn;
            backBtn.Location = new Point(506, 20);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(40, 40);
            backBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            backBtn.TabIndex = 17;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // ShowFollow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(listFollow);
            Controls.Add(panel1);
            Name = "ShowFollow";
            Size = new Size(568, 539);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel listFollow;
        private Label txtFollow;
        private PictureBox backBtn;
    }
}
