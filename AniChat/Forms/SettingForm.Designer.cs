namespace AniChat
{
    partial class SettingForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.FotoTip = new System.Windows.Forms.ToolTip(this.components);
            this.userImage_pb = new AniChat.CirclePicture_box();
            this.changePass_cpl = new AniChat.CustomPanel();
            this.validErr_lb = new System.Windows.Forms.Label();
            this.customPanel1 = new AniChat.CustomPanel();
            this.changepass_btn = new System.Windows.Forms.Button();
            this.repeatpass_tb = new System.Windows.Forms.TextBox();
            this.pass_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserBio_cpl = new AniChat.CustomPanel();
            this.isSave_lb = new System.Windows.Forms.Label();
            this.customPanel2 = new AniChat.CustomPanel();
            this.changeBio_btn = new System.Windows.Forms.Button();
            this.linkedIn_tb = new System.Windows.Forms.TextBox();
            this.gitHub_tb = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rank_tb = new System.Windows.Forms.TextBox();
            this.Rank_lb = new System.Windows.Forms.Label();
            this.name_lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userImage_pb)).BeginInit();
            this.changePass_cpl.SuspendLayout();
            this.customPanel1.SuspendLayout();
            this.UserBio_cpl.SuspendLayout();
            this.customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userImage_pb
            // 
            this.userImage_pb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.userImage_pb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userImage_pb.Image = global::AniChat.Properties.Resources.default_user_img;
            this.userImage_pb.Location = new System.Drawing.Point(86, 22);
            this.userImage_pb.Margin = new System.Windows.Forms.Padding(0);
            this.userImage_pb.Name = "userImage_pb";
            this.userImage_pb.Size = new System.Drawing.Size(100, 100);
            this.userImage_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userImage_pb.TabIndex = 0;
            this.userImage_pb.TabStop = false;
            this.FotoTip.SetToolTip(this.userImage_pb, "Change foto profile");
            this.userImage_pb.Click += new System.EventHandler(this.userImage_pb_Click);
            // 
            // changePass_cpl
            // 
            this.changePass_cpl.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.changePass_cpl.BorderFocusColor = System.Drawing.Color.HotPink;
            this.changePass_cpl.BorderRadius = 10;
            this.changePass_cpl.BorderSize = 2;
            this.changePass_cpl.Controls.Add(this.validErr_lb);
            this.changePass_cpl.Controls.Add(this.customPanel1);
            this.changePass_cpl.Controls.Add(this.repeatpass_tb);
            this.changePass_cpl.Controls.Add(this.pass_tb);
            this.changePass_cpl.Controls.Add(this.label2);
            this.changePass_cpl.Controls.Add(this.label5);
            this.changePass_cpl.Controls.Add(this.label1);
            this.changePass_cpl.Location = new System.Drawing.Point(347, 24);
            this.changePass_cpl.Name = "changePass_cpl";
            this.changePass_cpl.Size = new System.Drawing.Size(430, 300);
            this.changePass_cpl.TabIndex = 2;
            this.changePass_cpl.UnderlinedStyle = false;
            // 
            // validErr_lb
            // 
            this.validErr_lb.AutoSize = true;
            this.validErr_lb.Font = new System.Drawing.Font("Modern No. 20", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validErr_lb.ForeColor = System.Drawing.Color.Red;
            this.validErr_lb.Location = new System.Drawing.Point(20, 55);
            this.validErr_lb.Name = "validErr_lb";
            this.validErr_lb.Size = new System.Drawing.Size(57, 21);
            this.validErr_lb.TabIndex = 26;
            this.validErr_lb.Text = "label1";
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.customPanel1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customPanel1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel1.BorderRadius = 10;
            this.customPanel1.BorderSize = 2;
            this.customPanel1.Controls.Add(this.changepass_btn);
            this.customPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.customPanel1.Location = new System.Drawing.Point(0, 242);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.customPanel1.Size = new System.Drawing.Size(430, 58);
            this.customPanel1.TabIndex = 3;
            this.customPanel1.UnderlinedStyle = false;
            // 
            // changepass_btn
            // 
            this.changepass_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changepass_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changepass_btn.FlatAppearance.BorderSize = 0;
            this.changepass_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changepass_btn.Font = new System.Drawing.Font("Modern No. 20", 11.82089F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changepass_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changepass_btn.Location = new System.Drawing.Point(10, 10);
            this.changepass_btn.Name = "changepass_btn";
            this.changepass_btn.Size = new System.Drawing.Size(410, 38);
            this.changepass_btn.TabIndex = 20;
            this.changepass_btn.Text = "Save";
            this.changepass_btn.UseVisualStyleBackColor = true;
            this.changepass_btn.Click += new System.EventHandler(this.changepass_btn_Click);
            // 
            // repeatpass_tb
            // 
            this.repeatpass_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.repeatpass_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.repeatpass_tb.Font = new System.Drawing.Font("Modern No. 20", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatpass_tb.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.repeatpass_tb.Location = new System.Drawing.Point(165, 163);
            this.repeatpass_tb.MaxLength = 15;
            this.repeatpass_tb.Name = "repeatpass_tb";
            this.repeatpass_tb.Size = new System.Drawing.Size(187, 22);
            this.repeatpass_tb.TabIndex = 24;
            // 
            // pass_tb
            // 
            this.pass_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pass_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass_tb.Font = new System.Drawing.Font("Modern No. 20", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_tb.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.pass_tb.Location = new System.Drawing.Point(165, 107);
            this.pass_tb.MaxLength = 15;
            this.pass_tb.Name = "pass_tb";
            this.pass_tb.Size = new System.Drawing.Size(187, 22);
            this.pass_tb.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.82089F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(50, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Repeat\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 11.82089F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(50, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.1194F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Change password";
            // 
            // UserBio_cpl
            // 
            this.UserBio_cpl.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.UserBio_cpl.BorderFocusColor = System.Drawing.Color.HotPink;
            this.UserBio_cpl.BorderRadius = 10;
            this.UserBio_cpl.BorderSize = 2;
            this.UserBio_cpl.Controls.Add(this.isSave_lb);
            this.UserBio_cpl.Controls.Add(this.customPanel2);
            this.UserBio_cpl.Controls.Add(this.linkedIn_tb);
            this.UserBio_cpl.Controls.Add(this.gitHub_tb);
            this.UserBio_cpl.Controls.Add(this.pictureBox2);
            this.UserBio_cpl.Controls.Add(this.pictureBox1);
            this.UserBio_cpl.Controls.Add(this.rank_tb);
            this.UserBio_cpl.Controls.Add(this.Rank_lb);
            this.UserBio_cpl.Controls.Add(this.name_lb);
            this.UserBio_cpl.Controls.Add(this.userImage_pb);
            this.UserBio_cpl.Location = new System.Drawing.Point(24, 24);
            this.UserBio_cpl.Name = "UserBio_cpl";
            this.UserBio_cpl.Size = new System.Drawing.Size(300, 454);
            this.UserBio_cpl.TabIndex = 1;
            this.UserBio_cpl.UnderlinedStyle = false;
            // 
            // isSave_lb
            // 
            this.isSave_lb.AutoSize = true;
            this.isSave_lb.Font = new System.Drawing.Font("Modern No. 20", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isSave_lb.ForeColor = System.Drawing.Color.Red;
            this.isSave_lb.Location = new System.Drawing.Point(24, 359);
            this.isSave_lb.Name = "isSave_lb";
            this.isSave_lb.Size = new System.Drawing.Size(87, 21);
            this.isSave_lb.TabIndex = 27;
            this.isSave_lb.Text = "isSave_lb";
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.customPanel2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customPanel2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel2.BorderRadius = 10;
            this.customPanel2.BorderSize = 2;
            this.customPanel2.Controls.Add(this.changeBio_btn);
            this.customPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.customPanel2.Location = new System.Drawing.Point(0, 396);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.customPanel2.Size = new System.Drawing.Size(300, 58);
            this.customPanel2.TabIndex = 25;
            this.customPanel2.UnderlinedStyle = false;
            // 
            // changeBio_btn
            // 
            this.changeBio_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeBio_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeBio_btn.FlatAppearance.BorderSize = 0;
            this.changeBio_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeBio_btn.Font = new System.Drawing.Font("Modern No. 20", 11.82089F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBio_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeBio_btn.Location = new System.Drawing.Point(10, 10);
            this.changeBio_btn.Name = "changeBio_btn";
            this.changeBio_btn.Size = new System.Drawing.Size(280, 38);
            this.changeBio_btn.TabIndex = 20;
            this.changeBio_btn.Text = "Save";
            this.changeBio_btn.UseVisualStyleBackColor = true;
            this.changeBio_btn.Click += new System.EventHandler(this.changeBio_btn_Click);
            // 
            // linkedIn_tb
            // 
            this.linkedIn_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.linkedIn_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.linkedIn_tb.Font = new System.Drawing.Font("Modern No. 20", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkedIn_tb.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.linkedIn_tb.Location = new System.Drawing.Point(105, 314);
            this.linkedIn_tb.MaxLength = 200;
            this.linkedIn_tb.Name = "linkedIn_tb";
            this.linkedIn_tb.Size = new System.Drawing.Size(180, 22);
            this.linkedIn_tb.TabIndex = 24;
            // 
            // gitHub_tb
            // 
            this.gitHub_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.gitHub_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gitHub_tb.Font = new System.Drawing.Font("Modern No. 20", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gitHub_tb.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gitHub_tb.Location = new System.Drawing.Point(105, 259);
            this.gitHub_tb.MaxLength = 200;
            this.gitHub_tb.Name = "gitHub_tb";
            this.gitHub_tb.Size = new System.Drawing.Size(180, 22);
            this.gitHub_tb.TabIndex = 23;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(28, 305);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // rank_tb
            // 
            this.rank_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.rank_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rank_tb.Font = new System.Drawing.Font("Modern No. 20", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rank_tb.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rank_tb.Location = new System.Drawing.Point(105, 200);
            this.rank_tb.MaxLength = 15;
            this.rank_tb.Name = "rank_tb";
            this.rank_tb.Size = new System.Drawing.Size(180, 22);
            this.rank_tb.TabIndex = 19;
            // 
            // Rank_lb
            // 
            this.Rank_lb.AutoSize = true;
            this.Rank_lb.Font = new System.Drawing.Font("Modern No. 20", 13.97015F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rank_lb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Rank_lb.Location = new System.Drawing.Point(23, 197);
            this.Rank_lb.Name = "Rank_lb";
            this.Rank_lb.Size = new System.Drawing.Size(74, 29);
            this.Rank_lb.TabIndex = 7;
            this.Rank_lb.Text = "Rank";
            // 
            // name_lb
            // 
            this.name_lb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.name_lb.AutoSize = true;
            this.name_lb.Font = new System.Drawing.Font("Modern No. 20", 16.1194F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.name_lb.Location = new System.Drawing.Point(89, 137);
            this.name_lb.Name = "name_lb";
            this.name_lb.Size = new System.Drawing.Size(84, 31);
            this.name_lb.TabIndex = 6;
            this.name_lb.Text = "Name";
            this.name_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(134F, 134F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(789, 582);
            this.Controls.Add(this.changePass_cpl);
            this.Controls.Add(this.UserBio_cpl);
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userImage_pb)).EndInit();
            this.changePass_cpl.ResumeLayout(false);
            this.changePass_cpl.PerformLayout();
            this.customPanel1.ResumeLayout(false);
            this.UserBio_cpl.ResumeLayout(false);
            this.UserBio_cpl.PerformLayout();
            this.customPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CirclePicture_box userImage_pb;
        private CustomPanel UserBio_cpl;
        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Label Rank_lb;
        private System.Windows.Forms.TextBox rank_tb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox linkedIn_tb;
        private System.Windows.Forms.TextBox gitHub_tb;
        private CustomPanel changePass_cpl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox repeatpass_tb;
        private System.Windows.Forms.TextBox pass_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private CustomPanel customPanel1;
        private System.Windows.Forms.Button changepass_btn;
        private System.Windows.Forms.Label validErr_lb;
        private System.Windows.Forms.ToolTip FotoTip;
        private CustomPanel customPanel2;
        private System.Windows.Forms.Button changeBio_btn;
        private System.Windows.Forms.Label isSave_lb;
    }
}