namespace AniChat
{
    partial class GroupListItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupListItem));
            this.UserNamelb = new System.Windows.Forms.Label();
            this.UserPictureBox = new AniChat.CirclePicture_box();
            this.Descr_lb = new System.Windows.Forms.Label();
            this.newMsgNum_lb = new System.Windows.Forms.Label();
            this.customPanel1 = new AniChat.CustomPanel();
            this.Item_cPl = new AniChat.CustomPanel();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).BeginInit();
            this.customPanel1.SuspendLayout();
            this.Item_cPl.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserNamelb
            // 
            this.UserNamelb.AutoSize = true;
            this.UserNamelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.97015F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNamelb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UserNamelb.Location = new System.Drawing.Point(98, 15);
            this.UserNamelb.Name = "UserNamelb";
            this.UserNamelb.Size = new System.Drawing.Size(86, 31);
            this.UserNamelb.TabIndex = 3;
            this.UserNamelb.Text = "label1";
            // 
            // UserPictureBox
            // 
            this.UserPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("UserPictureBox.Image")));
            this.UserPictureBox.Location = new System.Drawing.Point(14, 14);
            this.UserPictureBox.Name = "UserPictureBox";
            this.UserPictureBox.Size = new System.Drawing.Size(70, 70);
            this.UserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserPictureBox.TabIndex = 2;
            this.UserPictureBox.TabStop = false;
            // 
            // Descr_lb
            // 
            this.Descr_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Descr_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Descr_lb.Location = new System.Drawing.Point(103, 46);
            this.Descr_lb.Name = "Descr_lb";
            this.Descr_lb.Size = new System.Drawing.Size(189, 39);
            this.Descr_lb.TabIndex = 4;
            this.Descr_lb.Text = "label1";
            // 
            // newMsgNum_lb
            // 
            this.newMsgNum_lb.AutoSize = true;
            this.newMsgNum_lb.Font = new System.Drawing.Font("Modern No. 20", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMsgNum_lb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newMsgNum_lb.Location = new System.Drawing.Point(10, 1);
            this.newMsgNum_lb.Name = "newMsgNum_lb";
            this.newMsgNum_lb.Size = new System.Drawing.Size(20, 24);
            this.newMsgNum_lb.TabIndex = 0;
            this.newMsgNum_lb.Text = "0";
            this.newMsgNum_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customPanel1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customPanel1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel1.BorderRadius = 10;
            this.customPanel1.BorderSize = 2;
            this.customPanel1.Controls.Add(this.newMsgNum_lb);
            this.customPanel1.Location = new System.Drawing.Point(241, 16);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(40, 24);
            this.customPanel1.TabIndex = 5;
            this.customPanel1.UnderlinedStyle = false;
            this.customPanel1.Visible = false;
            // 
            // Item_cPl
            // 
            this.Item_cPl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Item_cPl.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Item_cPl.BorderRadius = 10;
            this.Item_cPl.BorderSize = 2;
            this.Item_cPl.Controls.Add(this.customPanel1);
            this.Item_cPl.Controls.Add(this.UserPictureBox);
            this.Item_cPl.Controls.Add(this.UserNamelb);
            this.Item_cPl.Controls.Add(this.Descr_lb);
            this.Item_cPl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Item_cPl.Location = new System.Drawing.Point(3, 3);
            this.Item_cPl.Name = "Item_cPl";
            this.Item_cPl.Size = new System.Drawing.Size(304, 94);
            this.Item_cPl.TabIndex = 6;
            this.Item_cPl.UnderlinedStyle = false;
            this.Item_cPl.MouseEnter += new System.EventHandler(this.Item_cPl_MouseEnter);
            this.Item_cPl.MouseLeave += new System.EventHandler(this.Item_cPl_MouseLeave);
            // 
            // GroupListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(134F, 134F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.Item_cPl);
            this.Name = "GroupListItem";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(310, 100);
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.Item_cPl.ResumeLayout(false);
            this.Item_cPl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label UserNamelb;
        public CirclePicture_box UserPictureBox;
        public System.Windows.Forms.Label Descr_lb;
        private System.Windows.Forms.Label newMsgNum_lb;
        private CustomPanel customPanel1;
        internal CustomPanel Item_cPl;
    }
}
