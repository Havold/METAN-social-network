namespace Instagram
{
    partial class ChatBox
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
            newText = new TextBox();
            txtForget = new Label();
            results = new FlowLayoutPanel();
            txtTenTK = new Label();
            txtTenTK2 = new Label();
            sendPer = new Label();
            revPer = new Label();
            SuspendLayout();
            // 
            // newText
            // 
            newText.Location = new Point(45, 901);
            newText.Name = "newText";
            newText.ScrollBars = ScrollBars.Vertical;
            newText.Size = new Size(387, 27);
            newText.TabIndex = 0;
            // 
            // txtForget
            // 
            txtForget.AutoSize = true;
            txtForget.Cursor = Cursors.Hand;
            txtForget.Font = new Font("Roboto", 16F, FontStyle.Bold);
            txtForget.ForeColor = Color.White;
            txtForget.Location = new Point(484, 895);
            txtForget.Name = "txtForget";
            txtForget.Size = new Size(56, 33);
            txtForget.TabIndex = 3;
            txtForget.Text = "Gửi";
            txtForget.Click += btnSend_Click;
            // 
            // results
            // 
            results.AutoScroll = true;
            results.Location = new Point(0, 60);
            results.Name = "results";
            results.Size = new Size(585, 794);
            results.TabIndex = 4;
            // 
            // txtTenTK
            // 
            txtTenTK.Font = new Font("Roboto", 12F, FontStyle.Bold);
            txtTenTK.ForeColor = Color.White;
            txtTenTK.Location = new Point(114, 11);
            txtTenTK.Name = "txtTenTK";
            txtTenTK.Size = new Size(160, 25);
            txtTenTK.TabIndex = 5;
            txtTenTK.Text = "Nguoi gui";
            // 
            // txtTenTK2
            // 
            txtTenTK2.Font = new Font("Roboto", 12F, FontStyle.Bold);
            txtTenTK2.ForeColor = Color.White;
            txtTenTK2.Location = new Point(407, 9);
            txtTenTK2.Name = "txtTenTK2";
            txtTenTK2.Size = new Size(163, 25);
            txtTenTK2.TabIndex = 5;
            txtTenTK2.Text = "Nguoi nhan";
            // 
            // sendPer
            // 
            sendPer.AutoSize = true;
            sendPer.Font = new Font("Roboto", 12F, FontStyle.Bold);
            sendPer.ForeColor = Color.White;
            sendPer.Location = new Point(12, 11);
            sendPer.Name = "sendPer";
            sendPer.Size = new Size(105, 25);
            sendPer.TabIndex = 5;
            sendPer.Text = "Người gửi:";
            // 
            // revPer
            // 
            revPer.AutoSize = true;
            revPer.Font = new Font("Roboto", 12F, FontStyle.Bold);
            revPer.ForeColor = Color.White;
            revPer.Location = new Point(296, 9);
            revPer.Name = "revPer";
            revPer.Size = new Size(105, 25);
            revPer.TabIndex = 5;
            revPer.Text = "Người gửi:";
            // 
            // ChatBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(582, 953);
            Controls.Add(txtTenTK2);
            Controls.Add(revPer);
            Controls.Add(sendPer);
            Controls.Add(txtTenTK);
            Controls.Add(results);
            Controls.Add(txtForget);
            Controls.Add(newText);
            Name = "ChatBox";
            Text = "ChatBox";
            Load += ChatBox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox newText;
        private Label txtForget;
        private FlowLayoutPanel results;
        private Label txtTenTK;
        private Label txtTenTK2;
        private Label sendPer;
        private Label revPer;
    }
}