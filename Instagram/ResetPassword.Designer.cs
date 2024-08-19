namespace Instagram
{
    partial class ResetPassword
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
            txtForget = new Label();
            label1 = new Label();
            edtEmail = new TextBox();
            pictureBox1 = new PictureBox();
            resetBtn = new PictureBox();
            backBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resetBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            SuspendLayout();
            // 
            // txtForget
            // 
            txtForget.AutoSize = true;
            txtForget.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtForget.ForeColor = Color.White;
            txtForget.Location = new Point(12, 93);
            txtForget.Name = "txtForget";
            txtForget.Size = new Size(241, 37);
            txtForget.TabIndex = 3;
            txtForget.Text = "Cấp lại mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 140);
            label1.Name = "label1";
            label1.Size = new Size(492, 25);
            label1.TabIndex = 3;
            label1.Text = "Nhập email mà bạn đã đăng ký cho tài khoản của bạn.";
            // 
            // edtEmail
            // 
            edtEmail.BackColor = Color.Gray;
            edtEmail.BorderStyle = BorderStyle.None;
            edtEmail.Font = new Font("Roboto", 16F);
            edtEmail.ForeColor = Color.White;
            edtEmail.Location = new Point(47, 221);
            edtEmail.Name = "edtEmail";
            edtEmail.Size = new Size(505, 33);
            edtEmail.TabIndex = 5;
            edtEmail.Text = "Nhập email của bạn";
            edtEmail.Click += edtEmail_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.box2;
            pictureBox1.Location = new Point(12, 195);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(576, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // resetBtn
            // 
            resetBtn.Cursor = Cursors.Hand;
            resetBtn.Image = Properties.Resources.resetBtn;
            resetBtn.Location = new Point(12, 308);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(576, 71);
            resetBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            resetBtn.TabIndex = 6;
            resetBtn.TabStop = false;
            resetBtn.Click += sendBtn_Click;
            resetBtn.MouseEnter += resetBtn_MouseEnter;
            resetBtn.MouseLeave += resetBtn_MouseLeave;
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
            backBtn.TabIndex = 7;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            backBtn.MouseEnter += backBtn_MouseEnter;
            backBtn.MouseLeave += backBtn_MouseLeave;
            // 
            // ResetPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(600, 1000);
            Controls.Add(backBtn);
            Controls.Add(resetBtn);
            Controls.Add(edtEmail);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtForget);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResetPassword";
            Text = "ResetPassword";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)resetBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtForget;
        private Label label1;
        private TextBox edtEmail;
        private PictureBox pictureBox1;
        private PictureBox resetBtn;
        private PictureBox backBtn;
    }
}