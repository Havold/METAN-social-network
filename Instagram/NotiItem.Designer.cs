namespace Instagram
{
    partial class NotiItem
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
            avatar = new PictureBox();
            txtNoti = new TextBox();
            backgroundItem = new Panel();
            point = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)avatar).BeginInit();
            backgroundItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)point).BeginInit();
            SuspendLayout();
            // 
            // avatar
            // 
            avatar.BackColor = Color.Transparent;
            avatar.Cursor = Cursors.Hand;
            avatar.Location = new Point(14, 14);
            avatar.Name = "avatar";
            avatar.Size = new Size(100, 100);
            avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            avatar.TabIndex = 1;
            avatar.TabStop = false;
            avatar.Click += Item_Click;
            // 
            // txtNoti
            // 
            txtNoti.AllowDrop = true;
            txtNoti.BackColor = Color.Black;
            txtNoti.BorderStyle = BorderStyle.None;
            txtNoti.Cursor = Cursors.Hand;
            txtNoti.Font = new Font("Roboto", 10F);
            txtNoti.ForeColor = Color.White;
            txtNoti.Location = new Point(119, 25);
            txtNoti.Multiline = true;
            txtNoti.Name = "txtNoti";
            txtNoti.ReadOnly = true;
            txtNoti.Size = new Size(401, 65);
            txtNoti.TabIndex = 2;
            txtNoti.Text = "mia_diepnguyen đã gửi một yêu cầu follow đến bạn lúc";
            txtNoti.Click += Item_Click;
            // 
            // backgroundItem
            // 
            backgroundItem.Controls.Add(point);
            backgroundItem.Cursor = Cursors.Hand;
            backgroundItem.Location = new Point(8, 8);
            backgroundItem.Name = "backgroundItem";
            backgroundItem.Size = new Size(562, 117);
            backgroundItem.TabIndex = 20;
            backgroundItem.Click += Item_Click;
            backgroundItem.MouseEnter += backgroundItem_MouserEnter;
            backgroundItem.MouseLeave += backgroundItem_MouseLeave;
            // 
            // point
            // 
            point.Image = Properties.Resources.circke3;
            point.Location = new Point(530, 45);
            point.Name = "point";
            point.Size = new Size(14, 14);
            point.SizeMode = PictureBoxSizeMode.StretchImage;
            point.TabIndex = 21;
            point.TabStop = false;
            point.Visible = false;
            // 
            // NotiItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(txtNoti);
            Controls.Add(avatar);
            Controls.Add(backgroundItem);
            Name = "NotiItem";
            Size = new Size(570, 125);
            ((System.ComponentModel.ISupportInitialize)avatar).EndInit();
            backgroundItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)point).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox avatar;
        private TextBox txtNoti;
        private Panel backgroundItem;
        private PictureBox point;
    }
}
