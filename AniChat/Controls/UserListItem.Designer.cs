namespace AniChat
{
    partial class UserListItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserListItem));
            this.Item_cPl = new AniChat.CustomPanel();
            this.customPanel1 = new AniChat.CustomPanel();
            this.newMsgNum_lb = new System.Windows.Forms.Label();
            this.Rank_lb = new System.Windows.Forms.Label();
            this.UserPictureBox = new AniChat.CirclePicture_box();
            this.InLink_pb = new System.Windows.Forms.PictureBox();
            this.UserNamelb = new System.Windows.Forms.Label();
            this.gitLink_pb = new System.Windows.Forms.PictureBox();
            this.Item_cPl.SuspendLayout();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InLink_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gitLink_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // Item_cPl
            // 
            this.Item_cPl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Item_cPl.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Item_cPl.BorderRadius = 10;
            this.Item_cPl.BorderSize = 2;
            this.Item_cPl.Controls.Add(this.customPanel1);
            this.Item_cPl.Controls.Add(this.Rank_lb);
            this.Item_cPl.Controls.Add(this.UserPictureBox);
            this.Item_cPl.Controls.Add(this.InLink_pb);
            this.Item_cPl.Controls.Add(this.UserNamelb);
            this.Item_cPl.Controls.Add(this.gitLink_pb);
            this.Item_cPl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Item_cPl.Location = new System.Drawing.Point(3, 3);
            this.Item_cPl.Name = "Item_cPl";
            this.Item_cPl.Size = new System.Drawing.Size(304, 94);
            this.Item_cPl.TabIndex = 26;
            this.Item_cPl.UnderlinedStyle = false;
            this.Item_cPl.MouseEnter += new System.EventHandler(this.Item_cPl_MouseEnter);
            this.Item_cPl.MouseLeave += new System.EventHandler(this.Item_cPl_MouseLeave);
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
            this.customPanel1.Location = new System.Drawing.Point(255, 16);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(40, 24);
            this.customPanel1.TabIndex = 2;
            this.customPanel1.UnderlinedStyle = false;
            this.customPanel1.Visible = false;
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
            // Rank_lb
            // 
            this.Rank_lb.AutoSize = true;
            this.Rank_lb.Font = new System.Drawing.Font("Modern No. 20", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rank_lb.ForeColor = System.Drawing.Color.Yellow;
            this.Rank_lb.Location = new System.Drawing.Point(103, 49);
            this.Rank_lb.Name = "Rank_lb";
            this.Rank_lb.Size = new System.Drawing.Size(57, 21);
            this.Rank_lb.TabIndex = 25;
            this.Rank_lb.Text = "label1";
            // 
            // UserPictureBox
            // 
            this.UserPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("UserPictureBox.Image")));
            this.UserPictureBox.Location = new System.Drawing.Point(14, 14);
            this.UserPictureBox.Name = "UserPictureBox";
            this.UserPictureBox.Size = new System.Drawing.Size(70, 70);
            this.UserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserPictureBox.TabIndex = 0;
            this.UserPictureBox.TabStop = false;
            // 
            // InLink_pb
            // 
            this.InLink_pb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InLink_pb.Image = ((System.Drawing.Image)(resources.GetObject("InLink_pb.Image")));
            this.InLink_pb.Location = new System.Drawing.Point(265, 61);
            this.InLink_pb.Name = "InLink_pb";
            this.InLink_pb.Size = new System.Drawing.Size(30, 30);
            this.InLink_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InLink_pb.TabIndex = 24;
            this.InLink_pb.TabStop = false;
            this.InLink_pb.Click += new System.EventHandler(this.InLink_pb_Click);
            // 
            // UserNamelb
            // 
            this.UserNamelb.AutoSize = true;
            this.UserNamelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.97015F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNamelb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UserNamelb.Location = new System.Drawing.Point(90, 16);
            this.UserNamelb.Name = "UserNamelb";
            this.UserNamelb.Size = new System.Drawing.Size(144, 31);
            this.UserNamelb.TabIndex = 1;
            this.UserNamelb.Text = "UserName";
            // 
            // gitLink_pb
            // 
            this.gitLink_pb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gitLink_pb.Image = ((System.Drawing.Image)(resources.GetObject("gitLink_pb.Image")));
            this.gitLink_pb.Location = new System.Drawing.Point(229, 61);
            this.gitLink_pb.Name = "gitLink_pb";
            this.gitLink_pb.Size = new System.Drawing.Size(30, 30);
            this.gitLink_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gitLink_pb.TabIndex = 23;
            this.gitLink_pb.TabStop = false;
            this.gitLink_pb.Click += new System.EventHandler(this.gitLink_pb_Click);
            // 
            // UserListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(134F, 134F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.Item_cPl);
            this.Name = "UserListItem";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(310, 100);
            this.Load += new System.EventHandler(this.UserListItem_Load);
            this.Item_cPl.ResumeLayout(false);
            this.Item_cPl.PerformLayout();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InLink_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gitLink_pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public CirclePicture_box UserPictureBox;
        public System.Windows.Forms.Label UserNamelb;
        private CustomPanel customPanel1;
        private System.Windows.Forms.Label newMsgNum_lb;
        private System.Windows.Forms.PictureBox InLink_pb;
        private System.Windows.Forms.PictureBox gitLink_pb;
        public System.Windows.Forms.Label Rank_lb;
        internal CustomPanel Item_cPl;
    }
}
