namespace Instagram
{
    partial class Messenger
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backBtn = new PictureBox();
            txtCreate = new Label();
            findInput = new PictureBox();
            findIcon = new PictureBox();
            findTxt = new TextBox();
            tinnhanTxt = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)findInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)findIcon).BeginInit();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Transparent;
            backBtn.Cursor = Cursors.Hand;
            backBtn.Image = Properties.Resources.backBtn;
            backBtn.Location = new Point(12, 20);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(40, 40);
            backBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            backBtn.TabIndex = 14;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // txtCreate
            // 
            txtCreate.AutoSize = true;
            txtCreate.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCreate.ForeColor = Color.White;
            txtCreate.Location = new Point(75, 23);
            txtCreate.Name = "txtCreate";
            txtCreate.Size = new Size(117, 37);
            txtCreate.TabIndex = 15;
            txtCreate.Text = "_jul.3rd";
            // 
            // findInput
            // 
            findInput.Image = Properties.Resources.box2;
            findInput.Location = new Point(12, 90);
            findInput.Name = "findInput";
            findInput.Size = new Size(576, 47);
            findInput.SizeMode = PictureBoxSizeMode.StretchImage;
            findInput.TabIndex = 16;
            findInput.TabStop = false;
            // 
            // findIcon
            // 
            findIcon.BackColor = Color.Transparent;
            findIcon.Cursor = Cursors.Hand;
            findIcon.Image = Properties.Resources.find_gray;
            findIcon.Location = new Point(29, 98);
            findIcon.Name = "findIcon";
            findIcon.Size = new Size(30, 30);
            findIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            findIcon.TabIndex = 14;
            findIcon.TabStop = false;
            // 
            // findTxt
            // 
            findTxt.BackColor = Color.Gray;
            findTxt.BorderStyle = BorderStyle.None;
            findTxt.Font = new Font("Roboto", 12F);
            findTxt.ForeColor = Color.White;
            findTxt.Location = new Point(75, 102);
            findTxt.Name = "findTxt";
            findTxt.Size = new Size(491, 25);
            findTxt.TabIndex = 17;
            findTxt.Text = "Tìm kiếm";
            findTxt.Click += findTxt_Click;
            // 
            // tinnhanTxt
            // 
            tinnhanTxt.AutoSize = true;
            tinnhanTxt.Font = new Font("Roboto", 13F, FontStyle.Bold);
            tinnhanTxt.ForeColor = Color.White;
            tinnhanTxt.Location = new Point(12, 167);
            tinnhanTxt.Name = "tinnhanTxt";
            tinnhanTxt.Size = new Size(97, 27);
            tinnhanTxt.TabIndex = 15;
            tinnhanTxt.Text = "Tin nhắn";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AllowDrop = true;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(12, 208);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(576, 780);
            flowLayoutPanel1.TabIndex = 18;
            // 
            // Messenger
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(600, 1000);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(findTxt);
            Controls.Add(findIcon);
            Controls.Add(findInput);
            Controls.Add(tinnhanTxt);
            Controls.Add(txtCreate);
            Controls.Add(backBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Messenger";
            Text = "Messenger";
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)findInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)findIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox backBtn;
        private Label txtCreate;
        private PictureBox findInput;
        private PictureBox findIcon;
        private TextBox findTxt;
        private Label tinnhanTxt;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}