namespace Instagram
{
    partial class ChangePwd
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
            backBtn = new PictureBox();
            txtChange = new Label();
            changeBtn = new PictureBox();
            edtOldPwd = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            edtNewPwd = new TextBox();
            eyeOld = new PictureBox();
            eyeNew = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)changeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eyeOld).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eyeNew).BeginInit();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Transparent;
            backBtn.Cursor = Cursors.Hand;
            backBtn.Image = Properties.Resources.backBtn;
            backBtn.Location = new Point(21, 23);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(40, 40);
            backBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            backBtn.TabIndex = 8;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // txtChange
            // 
            txtChange.AutoSize = true;
            txtChange.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtChange.ForeColor = Color.White;
            txtChange.Location = new Point(21, 86);
            txtChange.Name = "txtChange";
            txtChange.Size = new Size(194, 37);
            txtChange.TabIndex = 9;
            txtChange.Text = "Đổi mật khẩu";
            // 
            // changeBtn
            // 
            changeBtn.Cursor = Cursors.Hand;
            changeBtn.Image = Properties.Resources.changePwdBtn;
            changeBtn.Location = new Point(12, 425);
            changeBtn.Name = "changeBtn";
            changeBtn.Size = new Size(576, 71);
            changeBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            changeBtn.TabIndex = 12;
            changeBtn.TabStop = false;
            changeBtn.Click += changeBtn_Click;
            changeBtn.MouseEnter += changeBtn_MouseEnter;
            changeBtn.MouseLeave += changeBtn_MouseLeave;
            // 
            // edtOldPwd
            // 
            edtOldPwd.BackColor = Color.Gray;
            edtOldPwd.BorderStyle = BorderStyle.None;
            edtOldPwd.Font = new Font("Roboto", 16F);
            edtOldPwd.ForeColor = Color.White;
            edtOldPwd.Location = new Point(47, 214);
            edtOldPwd.Name = "edtOldPwd";
            edtOldPwd.Size = new Size(486, 33);
            edtOldPwd.TabIndex = 11;
            edtOldPwd.Text = "Nhập mật khẩu cũ";
            edtOldPwd.Click += edtOldPwd_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.box2;
            pictureBox1.Location = new Point(12, 188);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(576, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 132);
            label1.Name = "label1";
            label1.Size = new Size(541, 25);
            label1.TabIndex = 13;
            label1.Text = "Hãy nhập mật khẩu hiện tại và mật khẩu mới bạn muốn đổi.";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.box2;
            pictureBox2.Location = new Point(12, 306);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(576, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // edtNewPwd
            // 
            edtNewPwd.BackColor = Color.Gray;
            edtNewPwd.BorderStyle = BorderStyle.None;
            edtNewPwd.Font = new Font("Roboto", 16F);
            edtNewPwd.ForeColor = Color.White;
            edtNewPwd.Location = new Point(47, 332);
            edtNewPwd.Name = "edtNewPwd";
            edtNewPwd.Size = new Size(486, 33);
            edtNewPwd.TabIndex = 11;
            edtNewPwd.Text = "Nhập mật khẩu mới";
            edtNewPwd.Click += edtNewPwd_Click_1;
            // 
            // eyeOld
            // 
            eyeOld.BackColor = Color.Transparent;
            eyeOld.Cursor = Cursors.Hand;
            eyeOld.Image = Properties.Resources.eye_close1;
            eyeOld.Location = new Point(539, 212);
            eyeOld.Name = "eyeOld";
            eyeOld.Size = new Size(40, 40);
            eyeOld.SizeMode = PictureBoxSizeMode.StretchImage;
            eyeOld.TabIndex = 14;
            eyeOld.TabStop = false;
            eyeOld.Click += eyeOld_Click;
            // 
            // eyeNew
            // 
            eyeNew.BackColor = Color.Transparent;
            eyeNew.Cursor = Cursors.Hand;
            eyeNew.Image = Properties.Resources.eye_close1;
            eyeNew.Location = new Point(539, 329);
            eyeNew.Name = "eyeNew";
            eyeNew.Size = new Size(40, 40);
            eyeNew.SizeMode = PictureBoxSizeMode.StretchImage;
            eyeNew.TabIndex = 14;
            eyeNew.TabStop = false;
            eyeNew.Click += eyeNew_Click;
            // 
            // ChangePwd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(eyeNew);
            Controls.Add(eyeOld);
            Controls.Add(label1);
            Controls.Add(changeBtn);
            Controls.Add(edtNewPwd);
            Controls.Add(edtOldPwd);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtChange);
            Controls.Add(backBtn);
            Name = "ChangePwd";
            Size = new Size(600, 1000);
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)changeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)eyeOld).EndInit();
            ((System.ComponentModel.ISupportInitialize)eyeNew).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox backBtn;
        private Label txtChange;
        private PictureBox changeBtn;
        private TextBox edtOldPwd;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private TextBox edtNewPwd;
        private PictureBox eyeOld;
        private PictureBox eyeNew;
    }
}
