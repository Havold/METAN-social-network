namespace Instagram
{
    partial class Register
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
            txtCreate = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            backBtn = new PictureBox();
            createBtn = new PictureBox();
            edtName = new TextBox();
            pictureBox2 = new PictureBox();
            edtUsername = new TextBox();
            pictureBox3 = new PictureBox();
            edtPhone = new TextBox();
            pictureBox4 = new PictureBox();
            txtDate = new DateTimePicker();
            maleSelect = new RadioButton();
            femaleSelect = new RadioButton();
            pictureBox5 = new PictureBox();
            edtEmail = new TextBox();
            pictureBox6 = new PictureBox();
            edtPwd = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)createBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // txtCreate
            // 
            txtCreate.AutoSize = true;
            txtCreate.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCreate.ForeColor = Color.White;
            txtCreate.Location = new Point(12, 94);
            txtCreate.Name = "txtCreate";
            txtCreate.Size = new Size(258, 37);
            txtCreate.TabIndex = 9;
            txtCreate.Text = "Tạo tài khoản mới";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 141);
            label1.Name = "label1";
            label1.Size = new Size(455, 25);
            label1.TabIndex = 8;
            label1.Text = "Nhập các thông tin cần thiết để tạo tài khoản mới.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.box2;
            pictureBox1.Location = new Point(12, 196);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(576, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Transparent;
            backBtn.Cursor = Cursors.Hand;
            backBtn.Image = Properties.Resources.backBtn;
            backBtn.Location = new Point(12, 27);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(40, 40);
            backBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            backBtn.TabIndex = 13;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            backBtn.MouseEnter += backBtn_MouseEnter;
            backBtn.MouseLeave += backBtn_MouseLeave;
            // 
            // createBtn
            // 
            createBtn.Cursor = Cursors.Hand;
            createBtn.Image = Properties.Resources.createBtn;
            createBtn.Location = new Point(12, 870);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(576, 71);
            createBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            createBtn.TabIndex = 12;
            createBtn.TabStop = false;
            createBtn.Click += signupBtn_Click;
            createBtn.MouseEnter += createBtn_MouseEnter;
            createBtn.MouseLeave += createBtn_MouseLeave;
            // 
            // edtName
            // 
            edtName.BackColor = Color.Gray;
            edtName.BorderStyle = BorderStyle.None;
            edtName.Font = new Font("Roboto", 16F);
            edtName.ForeColor = Color.White;
            edtName.Location = new Point(47, 222);
            edtName.Name = "edtName";
            edtName.Size = new Size(505, 33);
            edtName.TabIndex = 11;
            edtName.Text = "Nhập họ tên";
            edtName.Click += edtName_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.box2;
            pictureBox2.Location = new Point(12, 308);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(576, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // edtUsername
            // 
            edtUsername.BackColor = Color.Gray;
            edtUsername.BorderStyle = BorderStyle.None;
            edtUsername.Font = new Font("Roboto", 16F);
            edtUsername.ForeColor = Color.White;
            edtUsername.Location = new Point(47, 334);
            edtUsername.Name = "edtUsername";
            edtUsername.Size = new Size(505, 33);
            edtUsername.TabIndex = 11;
            edtUsername.Text = "Nhập Username";
            edtUsername.Click += edtUsername_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.box2;
            pictureBox3.Location = new Point(12, 525);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(576, 84);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // edtPhone
            // 
            edtPhone.BackColor = Color.Gray;
            edtPhone.BorderStyle = BorderStyle.None;
            edtPhone.Font = new Font("Roboto", 16F);
            edtPhone.ForeColor = Color.White;
            edtPhone.Location = new Point(47, 551);
            edtPhone.Name = "edtPhone";
            edtPhone.Size = new Size(505, 33);
            edtPhone.TabIndex = 11;
            edtPhone.Text = "Nhập số điện thoại";
            edtPhone.Click += edtPhone_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.box2;
            pictureBox4.Location = new Point(20, 417);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(393, 84);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // txtDate
            // 
            txtDate.AccessibleRole = AccessibleRole.None;
            txtDate.CalendarMonthBackground = Color.DarkGray;
            txtDate.CalendarTitleBackColor = SystemColors.ControlText;
            txtDate.CalendarTitleForeColor = SystemColors.GrayText;
            txtDate.Font = new Font("Roboto", 14F);
            txtDate.Format = DateTimePickerFormat.Short;
            txtDate.Location = new Point(59, 441);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(318, 36);
            txtDate.TabIndex = 15;
            // 
            // maleSelect
            // 
            maleSelect.AutoSize = true;
            maleSelect.BackColor = Color.Transparent;
            maleSelect.Checked = true;
            maleSelect.Cursor = Cursors.Hand;
            maleSelect.Font = new Font("Roboto", 16F, FontStyle.Bold);
            maleSelect.ForeColor = Color.White;
            maleSelect.Location = new Point(456, 420);
            maleSelect.Name = "maleSelect";
            maleSelect.Size = new Size(92, 37);
            maleSelect.TabIndex = 16;
            maleSelect.TabStop = true;
            maleSelect.Text = "Nam";
            maleSelect.UseVisualStyleBackColor = false;
            maleSelect.Click += maleSelect_Click;
            // 
            // femaleSelect
            // 
            femaleSelect.AutoSize = true;
            femaleSelect.BackColor = Color.Transparent;
            femaleSelect.Cursor = Cursors.Hand;
            femaleSelect.Font = new Font("Roboto", 16F, FontStyle.Bold);
            femaleSelect.ForeColor = Color.White;
            femaleSelect.Location = new Point(456, 470);
            femaleSelect.Name = "femaleSelect";
            femaleSelect.Size = new Size(71, 37);
            femaleSelect.TabIndex = 17;
            femaleSelect.TabStop = true;
            femaleSelect.Text = "Nữ";
            femaleSelect.UseVisualStyleBackColor = false;
            femaleSelect.Click += femaleSelect_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.box2;
            pictureBox5.Location = new Point(12, 635);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(576, 84);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // edtEmail
            // 
            edtEmail.BackColor = Color.Gray;
            edtEmail.BorderStyle = BorderStyle.None;
            edtEmail.Font = new Font("Roboto", 16F);
            edtEmail.ForeColor = Color.White;
            edtEmail.Location = new Point(47, 661);
            edtEmail.Name = "edtEmail";
            edtEmail.Size = new Size(505, 33);
            edtEmail.TabIndex = 11;
            edtEmail.Text = "Nhập địa chỉ email";
            edtEmail.Click += edtEmail_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.box2;
            pictureBox6.Location = new Point(12, 746);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(576, 84);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 10;
            pictureBox6.TabStop = false;
            // 
            // edtPwd
            // 
            edtPwd.BackColor = Color.Gray;
            edtPwd.BorderStyle = BorderStyle.None;
            edtPwd.Font = new Font("Roboto", 16F);
            edtPwd.ForeColor = Color.White;
            edtPwd.Location = new Point(47, 772);
            edtPwd.Name = "edtPwd";
            edtPwd.Size = new Size(505, 33);
            edtPwd.TabIndex = 11;
            edtPwd.Text = "Nhập mật khẩu";
            edtPwd.Click += edtPwd_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(600, 1000);
            Controls.Add(maleSelect);
            Controls.Add(femaleSelect);
            Controls.Add(txtDate);
            Controls.Add(backBtn);
            Controls.Add(createBtn);
            Controls.Add(edtPwd);
            Controls.Add(edtEmail);
            Controls.Add(edtPhone);
            Controls.Add(edtUsername);
            Controls.Add(edtName);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtCreate);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            Text = "     ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)createBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtCreate;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox backBtn;
        private PictureBox createBtn;
        private TextBox edtName;
        private PictureBox pictureBox2;
        private TextBox edtUsername;
        private PictureBox pictureBox3;
        private TextBox edtPhone;
        private PictureBox pictureBox4;
        private DateTimePicker txtDate;
        private RadioButton maleSelect;
        private RadioButton femaleSelect;
        private PictureBox pictureBox5;
        private TextBox edtEmail;
        private PictureBox pictureBox6;
        private TextBox edtPwd;
    }
}