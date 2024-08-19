namespace Instagram
{
    partial class CreatePost
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
            listImage = new FlowLayoutPanel();
            edtCaption = new TextBox();
            shareBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
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
            backBtn.TabIndex = 39;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // txtCreate
            // 
            txtCreate.AutoSize = true;
            txtCreate.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCreate.ForeColor = Color.White;
            txtCreate.Location = new Point(62, 19);
            txtCreate.Name = "txtCreate";
            txtCreate.Size = new Size(174, 37);
            txtCreate.TabIndex = 38;
            txtCreate.Text = "Bài viết mới";
            txtCreate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listImage
            // 
            listImage.Location = new Point(12, 89);
            listImage.Name = "listImage";
            listImage.Size = new Size(576, 320);
            listImage.TabIndex = 40;
            // 
            // edtCaption
            // 
            edtCaption.AllowDrop = true;
            edtCaption.BackColor = Color.Black;
            edtCaption.BorderStyle = BorderStyle.None;
            edtCaption.Font = new Font("Roboto", 10F);
            edtCaption.ForeColor = Color.White;
            edtCaption.Location = new Point(12, 433);
            edtCaption.Multiline = true;
            edtCaption.Name = "edtCaption";
            edtCaption.Size = new Size(576, 157);
            edtCaption.TabIndex = 41;
            edtCaption.Text = "Viết nội dung...";
            edtCaption.Click += edtCaption_Click;
            // 
            // shareBtn
            // 
            shareBtn.BackColor = Color.DodgerBlue;
            shareBtn.Cursor = Cursors.Hand;
            shareBtn.FlatStyle = FlatStyle.Flat;
            shareBtn.Font = new Font("Roboto", 14F, FontStyle.Bold);
            shareBtn.ForeColor = Color.White;
            shareBtn.Location = new Point(12, 893);
            shareBtn.Name = "shareBtn";
            shareBtn.Size = new Size(576, 59);
            shareBtn.TabIndex = 42;
            shareBtn.Text = "Chia sẻ";
            shareBtn.UseVisualStyleBackColor = false;
            shareBtn.Click += shareBtn_Click;
            // 
            // CreatePost
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(600, 1000);
            Controls.Add(shareBtn);
            Controls.Add(edtCaption);
            Controls.Add(listImage);
            Controls.Add(backBtn);
            Controls.Add(txtCreate);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreatePost";
            Text = "CreatePost";
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox backBtn;
        private Label txtCreate;
        private FlowLayoutPanel listImage;
        private TextBox edtCaption;
        private Button shareBtn;
    }
}