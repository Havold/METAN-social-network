namespace Instagram
{
    partial class FindFragment
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
            findTxt = new TextBox();
            findIcon = new PictureBox();
            findInput = new PictureBox();
            listUser = new FlowLayoutPanel();
            txtEdit = new Label();
            userProfile = new UserProfile();
            ((System.ComponentModel.ISupportInitialize)findIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)findInput).BeginInit();
            SuspendLayout();
            // 
            // findTxt
            // 
            findTxt.BackColor = Color.Gray;
            findTxt.BorderStyle = BorderStyle.None;
            findTxt.Font = new Font("Roboto", 12F);
            findTxt.ForeColor = Color.White;
            findTxt.Location = new Point(77, 41);
            findTxt.Name = "findTxt";
            findTxt.Size = new Size(491, 25);
            findTxt.TabIndex = 20;
            findTxt.Text = "Tìm kiếm";
            findTxt.Click += findTxt_Click;
            findTxt.TextChanged += SearchBox_TextChanged;
            // 
            // findIcon
            // 
            findIcon.BackColor = Color.Transparent;
            findIcon.Cursor = Cursors.Hand;
            findIcon.Image = Properties.Resources.find_gray;
            findIcon.Location = new Point(31, 37);
            findIcon.Name = "findIcon";
            findIcon.Size = new Size(30, 30);
            findIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            findIcon.TabIndex = 18;
            findIcon.TabStop = false;
            // 
            // findInput
            // 
            findInput.Image = Properties.Resources.box2;
            findInput.Location = new Point(14, 29);
            findInput.Name = "findInput";
            findInput.Size = new Size(576, 47);
            findInput.SizeMode = PictureBoxSizeMode.StretchImage;
            findInput.TabIndex = 19;
            findInput.TabStop = false;
            // 
            // listUser
            // 
            listUser.AutoScroll = true;
            listUser.Location = new Point(3, 135);
            listUser.Name = "listUser";
            listUser.Size = new Size(600, 791);
            listUser.TabIndex = 21;
            // 
            // txtEdit
            // 
            txtEdit.AutoSize = true;
            txtEdit.Font = new Font("Roboto", 14F, FontStyle.Bold);
            txtEdit.ForeColor = Color.White;
            txtEdit.Location = new Point(3, 91);
            txtEdit.Name = "txtEdit";
            txtEdit.Size = new Size(319, 29);
            txtEdit.TabIndex = 22;
            txtEdit.Text = "Những người bạn có thể biết";
            // 
            // userProfile
            // 
            userProfile.BackColor = Color.Black;
            userProfile.Location = new Point(0, 0);
            userProfile.Name = "userProfile";
            userProfile.Size = new Size(606, 920);
            userProfile.TabIndex = 23;
            userProfile.Visible = false;
            // 
            // FindFragment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(userProfile);
            Controls.Add(txtEdit);
            Controls.Add(listUser);
            Controls.Add(findTxt);
            Controls.Add(findIcon);
            Controls.Add(findInput);
            Name = "FindFragment";
            Size = new Size(606, 926);
            ((System.ComponentModel.ISupportInitialize)findIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)findInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox findTxt;
        private PictureBox findIcon;
        private PictureBox findInput;
        private FlowLayoutPanel listUser;
        private Label txtEdit;
        private UserProfile userProfile;
    }
}
