namespace Instagram
{
    partial class EditProfile
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
            txtEdit = new Label();
            backBtn = new PictureBox();
            avatar = new PictureBox();
            editAvatar = new Label();
            label1 = new Label();
            edtFullname = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            edtUsername = new TextBox();
            panel2 = new Panel();
            label3 = new Label();
            edtCaption = new TextBox();
            panel3 = new Panel();
            label4 = new Label();
            panel4 = new Panel();
            changeIcon = new PictureBox();
            updateBtn = new PictureBox();
            edtPwd = new TextBox();
            changePwd = new ChangePwd();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)avatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)changeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updateBtn).BeginInit();
            SuspendLayout();
            // 
            // txtEdit
            // 
            txtEdit.AutoSize = true;
            txtEdit.Font = new Font("Roboto", 16F, FontStyle.Bold);
            txtEdit.ForeColor = Color.White;
            txtEdit.Location = new Point(80, 27);
            txtEdit.Name = "txtEdit";
            txtEdit.Size = new Size(307, 33);
            txtEdit.TabIndex = 17;
            txtEdit.Text = "Chỉnh sửa trang cá nhân";
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Transparent;
            backBtn.Cursor = Cursors.Hand;
            backBtn.Image = Properties.Resources.backBtn;
            backBtn.Location = new Point(17, 24);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(40, 40);
            backBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            backBtn.TabIndex = 16;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // avatar
            // 
            avatar.Image = Properties.Resources.circke2;
            avatar.Location = new Point(247, 91);
            avatar.Name = "avatar";
            avatar.Size = new Size(100, 100);
            avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            avatar.TabIndex = 18;
            avatar.TabStop = false;
            // 
            // editAvatar
            // 
            editAvatar.AutoSize = true;
            editAvatar.Cursor = Cursors.Hand;
            editAvatar.Font = new Font("Roboto", 12F);
            editAvatar.ForeColor = Color.DodgerBlue;
            editAvatar.Location = new Point(217, 208);
            editAvatar.Name = "editAvatar";
            editAvatar.Size = new Size(163, 25);
            editAvatar.TabIndex = 17;
            editAvatar.Text = "Chỉnh sửa avatar";
            editAvatar.Click += editAvatar_Click;
            editAvatar.MouseEnter += editAvatar_MouseEnter;
            editAvatar.MouseLeave += editAvatar_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 10F);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(17, 248);
            label1.Name = "label1";
            label1.Size = new Size(60, 22);
            label1.TabIndex = 17;
            label1.Text = "Họ tên";
            // 
            // edtFullname
            // 
            edtFullname.BackColor = Color.Black;
            edtFullname.BorderStyle = BorderStyle.None;
            edtFullname.Font = new Font("Roboto", 13F);
            edtFullname.ForeColor = Color.White;
            edtFullname.Location = new Point(21, 281);
            edtFullname.Name = "edtFullname";
            edtFullname.Size = new Size(564, 27);
            edtFullname.TabIndex = 19;
            edtFullname.Text = "Havold";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(17, 305);
            panel1.Name = "panel1";
            panel1.Size = new Size(571, 2);
            panel1.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 10F);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(17, 328);
            label2.Name = "label2";
            label2.Size = new Size(87, 22);
            label2.TabIndex = 17;
            label2.Text = "Username";
            // 
            // edtUsername
            // 
            edtUsername.BackColor = Color.Black;
            edtUsername.BorderStyle = BorderStyle.None;
            edtUsername.Font = new Font("Roboto", 13F);
            edtUsername.ForeColor = Color.White;
            edtUsername.Location = new Point(21, 361);
            edtUsername.Name = "edtUsername";
            edtUsername.Size = new Size(564, 27);
            edtUsername.TabIndex = 19;
            edtUsername.Text = "_jul.3rd";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(17, 385);
            panel2.Name = "panel2";
            panel2.Size = new Size(571, 2);
            panel2.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 10F);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(21, 413);
            label3.Name = "label3";
            label3.Size = new Size(66, 22);
            label3.TabIndex = 17;
            label3.Text = "Tiểu sử";
            // 
            // edtCaption
            // 
            edtCaption.BackColor = Color.Black;
            edtCaption.BorderStyle = BorderStyle.None;
            edtCaption.Font = new Font("Roboto", 13F);
            edtCaption.ForeColor = Color.White;
            edtCaption.Location = new Point(25, 446);
            edtCaption.Name = "edtCaption";
            edtCaption.Size = new Size(563, 27);
            edtCaption.TabIndex = 19;
            edtCaption.Text = "Do lowkey chứ hông phải clone .-.";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(21, 470);
            panel3.Name = "panel3";
            panel3.Size = new Size(571, 2);
            panel3.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 10F);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(21, 496);
            label4.Name = "label4";
            label4.Size = new Size(80, 22);
            label4.TabIndex = 17;
            label4.Text = "Mật khẩu";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(21, 553);
            panel4.Name = "panel4";
            panel4.Size = new Size(571, 2);
            panel4.TabIndex = 20;
            // 
            // changeIcon
            // 
            changeIcon.BackColor = Color.Transparent;
            changeIcon.Cursor = Cursors.Hand;
            changeIcon.Image = Properties.Resources.changeIcon;
            changeIcon.Location = new Point(555, 508);
            changeIcon.Name = "changeIcon";
            changeIcon.Size = new Size(30, 30);
            changeIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            changeIcon.TabIndex = 16;
            changeIcon.TabStop = false;
            changeIcon.Click += changeIcon_Click;
            // 
            // updateBtn
            // 
            updateBtn.Cursor = Cursors.Hand;
            updateBtn.Image = Properties.Resources.updateBtn;
            updateBtn.Location = new Point(12, 607);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(576, 71);
            updateBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            updateBtn.TabIndex = 21;
            updateBtn.TabStop = false;
            updateBtn.Click += updateBtn_Click;
            updateBtn.MouseEnter += updateBtn_MouseEnter;
            updateBtn.MouseLeave += updateBtn_MouseLeave;
            // 
            // edtPwd
            // 
            edtPwd.BackColor = Color.Black;
            edtPwd.BorderStyle = BorderStyle.None;
            edtPwd.Enabled = false;
            edtPwd.Font = new Font("Roboto", 13F);
            edtPwd.ForeColor = Color.White;
            edtPwd.Location = new Point(25, 529);
            edtPwd.Name = "edtPwd";
            edtPwd.PasswordChar = '*';
            edtPwd.ReadOnly = true;
            edtPwd.Size = new Size(517, 27);
            edtPwd.TabIndex = 19;
            edtPwd.Text = "123";
            // 
            // changePwd
            // 
            changePwd.BackColor = Color.Black;
            changePwd.Location = new Point(-2, 0);
            changePwd.Name = "changePwd";
            changePwd.Size = new Size(601, 1000);
            changePwd.TabIndex = 22;
            changePwd.Visible = false;
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(600, 1000);
            Controls.Add(changePwd);
            Controls.Add(updateBtn);
            Controls.Add(changeIcon);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(edtPwd);
            Controls.Add(edtCaption);
            Controls.Add(edtUsername);
            Controls.Add(label4);
            Controls.Add(edtFullname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(avatar);
            Controls.Add(label1);
            Controls.Add(editAvatar);
            Controls.Add(txtEdit);
            Controls.Add(backBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditProfile";
            Text = "EditProfile";
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)avatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)changeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)updateBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtEdit;
        private PictureBox backBtn;
        private PictureBox avatar;
        private Label editAvatar;
        private Label label1;
        private TextBox edtFullname;
        private Panel panel1;
        private Label label2;
        private TextBox edtUsername;
        private Panel panel2;
        private Label label3;
        private TextBox edtCaption;
        private Panel panel3;
        private Label label4;
        private TextBox edtPwd;
        private Panel panel4;
        private PictureBox changeIcon;
        private PictureBox updateBtn;
        private ChangePwd changePwd;
    }
}