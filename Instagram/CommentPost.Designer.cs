namespace Instagram
{
    partial class CommentPost
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
            txtCmt = new Label();
            panel1 = new Panel();
            send = new Label();
            edtCmt = new TextBox();
            pbAvatar = new PictureBox();
            listCmt = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).BeginInit();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Transparent;
            backBtn.Cursor = Cursors.Hand;
            backBtn.Image = Properties.Resources.backBtn;
            backBtn.Location = new Point(17, 16);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(40, 40);
            backBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            backBtn.TabIndex = 9;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // txtCmt
            // 
            txtCmt.AutoSize = true;
            txtCmt.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCmt.ForeColor = Color.White;
            txtCmt.Location = new Point(85, 19);
            txtCmt.Name = "txtCmt";
            txtCmt.Size = new Size(143, 37);
            txtCmt.TabIndex = 8;
            txtCmt.Text = "Bình luận";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(send);
            panel1.Controls.Add(edtCmt);
            panel1.Controls.Add(pbAvatar);
            panel1.Location = new Point(3, 845);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 72);
            panel1.TabIndex = 10;
            // 
            // send
            // 
            send.AutoSize = true;
            send.Cursor = Cursors.Hand;
            send.Font = new Font("Roboto", 16F, FontStyle.Bold);
            send.ForeColor = Color.White;
            send.Location = new Point(524, 22);
            send.Name = "send";
            send.Size = new Size(56, 33);
            send.TabIndex = 2;
            send.Text = "Gửi";
            send.Click += send_Click;
            send.MouseEnter += send_MouseEnter;
            send.MouseLeave += send_MouseLeave;
            // 
            // edtCmt
            // 
            edtCmt.AllowDrop = true;
            edtCmt.BackColor = Color.Black;
            edtCmt.BorderStyle = BorderStyle.None;
            edtCmt.Font = new Font("Roboto", 10F);
            edtCmt.ForeColor = Color.White;
            edtCmt.Location = new Point(90, 19);
            edtCmt.Multiline = true;
            edtCmt.Name = "edtCmt";
            edtCmt.Size = new Size(375, 49);
            edtCmt.TabIndex = 1;
            edtCmt.Text = "Hãy chia sẻ cảm nhận của bạn nào...";
            edtCmt.Click += edtCmt_Click;
            // 
            // pbAvatar
            // 
            pbAvatar.Image = Properties.Resources.avatar_3;
            pbAvatar.Location = new Point(20, 8);
            pbAvatar.Name = "pbAvatar";
            pbAvatar.Size = new Size(60, 60);
            pbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAvatar.TabIndex = 0;
            pbAvatar.TabStop = false;
            // 
            // listCmt
            // 
            listCmt.AutoScroll = true;
            listCmt.Location = new Point(3, 84);
            listCmt.Name = "listCmt";
            listCmt.Size = new Size(600, 755);
            listCmt.TabIndex = 11;
            // 
            // CommentPost
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(listCmt);
            Controls.Add(panel1);
            Controls.Add(backBtn);
            Controls.Add(txtCmt);
            Name = "CommentPost";
            Size = new Size(606, 920);
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox backBtn;
        private Label txtCmt;
        private Panel panel1;
        private FlowLayoutPanel listCmt;
        private Label send;
        private TextBox edtCmt;
        private PictureBox pbAvatar;
    }
}
