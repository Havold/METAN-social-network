namespace Instagram
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pictureBox2 = new PictureBox();
            loginBtn = new PictureBox();
            pictureBox1 = new PictureBox();
            txtForget = new Label();
            registerBtn = new PictureBox();
            label2 = new Label();
            edtUser = new TextBox();
            edtPwd = new TextBox();
            eyeBtn = new PictureBox();
            remeberBox = new CheckBox();
            backBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loginBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)registerBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eyeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("VALORANT", 40F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(161, 112);
            label1.Name = "label1";
            label1.Size = new Size(295, 68);
            label1.TabIndex = 0;
            label1.Text = "METAN";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.box2;
            pictureBox2.Location = new Point(12, 398);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(576, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // loginBtn
            // 
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.Image = Properties.Resources.loginBtn;
            loginBtn.Location = new Point(12, 555);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(576, 71);
            loginBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            loginBtn.TabIndex = 1;
            loginBtn.TabStop = false;
            loginBtn.Click += loginBtn_Click;
            loginBtn.MouseEnter += loginBtn_MouseEnter;
            loginBtn.MouseLeave += loginBtn_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.box2;
            pictureBox1.Location = new Point(12, 284);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(576, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txtForget
            // 
            txtForget.AutoSize = true;
            txtForget.Cursor = Cursors.Hand;
            txtForget.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtForget.ForeColor = Color.White;
            txtForget.Location = new Point(393, 505);
            txtForget.Name = "txtForget";
            txtForget.Size = new Size(195, 25);
            txtForget.TabIndex = 2;
            txtForget.Text = "Bạn quên mật khẩu?";
            txtForget.Click += txtForget_Click;
            txtForget.MouseEnter += txtForget_MouseEnter;
            txtForget.MouseLeave += txtForget_MouseLeave;
            // 
            // registerBtn
            // 
            registerBtn.Cursor = Cursors.Hand;
            registerBtn.Image = Properties.Resources.registerBtn;
            registerBtn.Location = new Point(12, 818);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(576, 71);
            registerBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            registerBtn.TabIndex = 1;
            registerBtn.TabStop = false;
            registerBtn.Click += registerBtn_Click;
            registerBtn.MouseEnter += registerBtn_MouseEnter;
            registerBtn.MouseLeave += registerBtn_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("VALORANT", 16F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(252, 932);
            label2.Name = "label2";
            label2.Size = new Size(20, 28);
            label2.TabIndex = 0;
            label2.Text = " ";
            // 
            // edtUser
            // 
            edtUser.BackColor = Color.Gray;
            edtUser.BorderStyle = BorderStyle.None;
            edtUser.Font = new Font("Roboto", 16F);
            edtUser.ForeColor = Color.White;
            edtUser.Location = new Point(47, 310);
            edtUser.Name = "edtUser";
            edtUser.Size = new Size(484, 33);
            edtUser.TabIndex = 3;
            edtUser.Text = "Tên người dùng, email/số di động";
            edtUser.Click += edtUser_Click;
            // 
            // edtPwd
            // 
            edtPwd.BackColor = Color.Gray;
            edtPwd.BorderStyle = BorderStyle.None;
            edtPwd.Font = new Font("Roboto", 16F);
            edtPwd.ForeColor = Color.White;
            edtPwd.Location = new Point(47, 423);
            edtPwd.Name = "edtPwd";
            edtPwd.Size = new Size(484, 33);
            edtPwd.TabIndex = 3;
            edtPwd.Text = "Mật khẩu";
            edtPwd.Click += edtPwd_Click;
            // 
            // eyeBtn
            // 
            eyeBtn.BackColor = Color.Transparent;
            eyeBtn.Cursor = Cursors.Hand;
            eyeBtn.Image = Properties.Resources.eye_close1;
            eyeBtn.Location = new Point(537, 419);
            eyeBtn.Name = "eyeBtn";
            eyeBtn.Size = new Size(40, 40);
            eyeBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            eyeBtn.TabIndex = 4;
            eyeBtn.TabStop = false;
            eyeBtn.Click += eyeBtn_Click;
            // 
            // remeberBox
            // 
            remeberBox.AutoSize = true;
            remeberBox.BackColor = Color.Transparent;
            remeberBox.Font = new Font("Roboto", 12F, FontStyle.Bold);
            remeberBox.ForeColor = Color.White;
            remeberBox.Location = new Point(12, 504);
            remeberBox.Name = "remeberBox";
            remeberBox.Size = new Size(165, 29);
            remeberBox.TabIndex = 7;
            remeberBox.Text = "Remember me";
            remeberBox.UseVisualStyleBackColor = false;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Transparent;
            backBtn.Cursor = Cursors.Hand;
            backBtn.Image = Properties.Resources.closeBtn1;
            backBtn.Location = new Point(537, 12);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(40, 40);
            backBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            backBtn.TabIndex = 10;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(600, 1000);
            Controls.Add(backBtn);
            Controls.Add(remeberBox);
            Controls.Add(eyeBtn);
            Controls.Add(edtPwd);
            Controls.Add(edtUser);
            Controls.Add(txtForget);
            Controls.Add(registerBtn);
            Controls.Add(loginBtn);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "      ";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)loginBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)registerBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)eyeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox loginBtn;
        private PictureBox pictureBox1;
        private Label txtForget;
        private PictureBox registerBtn;
        private Label label2;
        private TextBox edtUser;
        private TextBox edtPwd;
        private PictureBox eyeBtn;
        private CheckBox remeberBox;
        private PictureBox backBtn;
    }
}
