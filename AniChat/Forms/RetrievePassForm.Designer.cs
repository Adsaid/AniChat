namespace AniChat
{
    partial class RetrievePassForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailCode_tb = new System.Windows.Forms.TextBox();
            this.Email_lb = new System.Windows.Forms.Label();
            this.repeatpass_tb = new System.Windows.Forms.TextBox();
            this.repPass_lb = new System.Windows.Forms.Label();
            this.pass_tb = new System.Windows.Forms.TextBox();
            this.pass_lb = new System.Windows.Forms.Label();
            this.validErr_lb = new System.Windows.Forms.Label();
            this.emailCode_pl = new System.Windows.Forms.Panel();
            this.retrievePass_pl = new System.Windows.Forms.Panel();
            this.showPass_pb = new System.Windows.Forms.PictureBox();
            this.customPanel1 = new AniChat.CustomPanel();
            this.Retrieve_btn = new System.Windows.Forms.Button();
            this.emailCode_pl.SuspendLayout();
            this.retrievePass_pl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPass_pb)).BeginInit();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.82089F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Email with code sent to address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.82089F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Enter code:\r\n";
            // 
            // emailCode_tb
            // 
            this.emailCode_tb.Font = new System.Drawing.Font("Modern No. 20", 11.82089F);
            this.emailCode_tb.Location = new System.Drawing.Point(129, 86);
            this.emailCode_tb.MaxLength = 4;
            this.emailCode_tb.Name = "emailCode_tb";
            this.emailCode_tb.Size = new System.Drawing.Size(173, 31);
            this.emailCode_tb.TabIndex = 19;
            this.emailCode_tb.TextChanged += new System.EventHandler(this.emailCode_tb_TextChanged);
            // 
            // Email_lb
            // 
            this.Email_lb.AutoSize = true;
            this.Email_lb.Font = new System.Drawing.Font("Modern No. 20", 11.82089F);
            this.Email_lb.ForeColor = System.Drawing.Color.Yellow;
            this.Email_lb.Location = new System.Drawing.Point(12, 45);
            this.Email_lb.Name = "Email_lb";
            this.Email_lb.Size = new System.Drawing.Size(66, 24);
            this.Email_lb.TabIndex = 20;
            this.Email_lb.Text = "Email\r\n";
            // 
            // repeatpass_tb
            // 
            this.repeatpass_tb.Font = new System.Drawing.Font("Modern No. 20", 11.82089F);
            this.repeatpass_tb.Location = new System.Drawing.Point(137, 158);
            this.repeatpass_tb.MaxLength = 15;
            this.repeatpass_tb.Name = "repeatpass_tb";
            this.repeatpass_tb.Size = new System.Drawing.Size(173, 31);
            this.repeatpass_tb.TabIndex = 32;
            this.repeatpass_tb.UseSystemPasswordChar = true;
            // 
            // repPass_lb
            // 
            this.repPass_lb.AutoSize = true;
            this.repPass_lb.Font = new System.Drawing.Font("Modern No. 20", 11.82089F);
            this.repPass_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.repPass_lb.Location = new System.Drawing.Point(39, 161);
            this.repPass_lb.Name = "repPass_lb";
            this.repPass_lb.Size = new System.Drawing.Size(71, 24);
            this.repPass_lb.TabIndex = 31;
            this.repPass_lb.Text = "Repeat\r\n";
            // 
            // pass_tb
            // 
            this.pass_tb.Font = new System.Drawing.Font("Modern No. 20", 11.82089F);
            this.pass_tb.Location = new System.Drawing.Point(137, 85);
            this.pass_tb.MaxLength = 15;
            this.pass_tb.Name = "pass_tb";
            this.pass_tb.Size = new System.Drawing.Size(173, 31);
            this.pass_tb.TabIndex = 30;
            this.pass_tb.UseSystemPasswordChar = true;
            // 
            // pass_lb
            // 
            this.pass_lb.AutoSize = true;
            this.pass_lb.Font = new System.Drawing.Font("Modern No. 20", 11.82089F);
            this.pass_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pass_lb.Location = new System.Drawing.Point(39, 88);
            this.pass_lb.Name = "pass_lb";
            this.pass_lb.Size = new System.Drawing.Size(94, 24);
            this.pass_lb.TabIndex = 29;
            this.pass_lb.Text = "Password";
            // 
            // validErr_lb
            // 
            this.validErr_lb.AutoSize = true;
            this.validErr_lb.Font = new System.Drawing.Font("Modern No. 20", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validErr_lb.ForeColor = System.Drawing.Color.Red;
            this.validErr_lb.Location = new System.Drawing.Point(22, 25);
            this.validErr_lb.Name = "validErr_lb";
            this.validErr_lb.Size = new System.Drawing.Size(57, 21);
            this.validErr_lb.TabIndex = 34;
            this.validErr_lb.Text = "label1";
            this.validErr_lb.Visible = false;
            // 
            // emailCode_pl
            // 
            this.emailCode_pl.Controls.Add(this.label1);
            this.emailCode_pl.Controls.Add(this.label2);
            this.emailCode_pl.Controls.Add(this.emailCode_tb);
            this.emailCode_pl.Controls.Add(this.Email_lb);
            this.emailCode_pl.Dock = System.Windows.Forms.DockStyle.Top;
            this.emailCode_pl.Location = new System.Drawing.Point(0, 0);
            this.emailCode_pl.Name = "emailCode_pl";
            this.emailCode_pl.Size = new System.Drawing.Size(380, 150);
            this.emailCode_pl.TabIndex = 35;
            // 
            // retrievePass_pl
            // 
            this.retrievePass_pl.Controls.Add(this.showPass_pb);
            this.retrievePass_pl.Controls.Add(this.pass_lb);
            this.retrievePass_pl.Controls.Add(this.pass_tb);
            this.retrievePass_pl.Controls.Add(this.customPanel1);
            this.retrievePass_pl.Controls.Add(this.validErr_lb);
            this.retrievePass_pl.Controls.Add(this.repPass_lb);
            this.retrievePass_pl.Controls.Add(this.repeatpass_tb);
            this.retrievePass_pl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.retrievePass_pl.Location = new System.Drawing.Point(0, 150);
            this.retrievePass_pl.Name = "retrievePass_pl";
            this.retrievePass_pl.Padding = new System.Windows.Forms.Padding(10);
            this.retrievePass_pl.Size = new System.Drawing.Size(380, 198);
            this.retrievePass_pl.TabIndex = 36;
            // 
            // showPass_pb
            // 
            this.showPass_pb.Image = global::AniChat.Properties.Resources.showPass_icon;
            this.showPass_pb.Location = new System.Drawing.Point(316, 86);
            this.showPass_pb.Name = "showPass_pb";
            this.showPass_pb.Size = new System.Drawing.Size(30, 30);
            this.showPass_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showPass_pb.TabIndex = 35;
            this.showPass_pb.TabStop = false;
            this.showPass_pb.Click += new System.EventHandler(this.showPass_pb_Click);
            // 
            // customPanel1
            // 
            this.customPanel1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customPanel1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel1.BorderRadius = 10;
            this.customPanel1.BorderSize = 2;
            this.customPanel1.Controls.Add(this.Retrieve_btn);
            this.customPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.customPanel1.Location = new System.Drawing.Point(10, 128);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.customPanel1.Size = new System.Drawing.Size(360, 60);
            this.customPanel1.TabIndex = 33;
            this.customPanel1.UnderlinedStyle = false;
            // 
            // Retrieve_btn
            // 
            this.Retrieve_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Retrieve_btn.FlatAppearance.BorderSize = 0;
            this.Retrieve_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Retrieve_btn.Font = new System.Drawing.Font("Modern No. 20", 11.82089F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retrieve_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Retrieve_btn.Location = new System.Drawing.Point(10, 10);
            this.Retrieve_btn.Name = "Retrieve_btn";
            this.Retrieve_btn.Size = new System.Drawing.Size(340, 40);
            this.Retrieve_btn.TabIndex = 19;
            this.Retrieve_btn.Text = "Retrieve";
            this.Retrieve_btn.UseVisualStyleBackColor = true;
            this.Retrieve_btn.Click += new System.EventHandler(this.Retrieve_btn_Click);
            // 
            // RetrievePassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(134F, 134F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(380, 348);
            this.Controls.Add(this.retrievePass_pl);
            this.Controls.Add(this.emailCode_pl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.Name = "RetrievePassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retrieve password";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RetrievePassForm_FormClosed);
            this.Load += new System.EventHandler(this.RetrievePassForm_Load);
            this.emailCode_pl.ResumeLayout(false);
            this.emailCode_pl.PerformLayout();
            this.retrievePass_pl.ResumeLayout(false);
            this.retrievePass_pl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPass_pb)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailCode_tb;
        private System.Windows.Forms.Label Email_lb;
        private CustomPanel customPanel1;
        private System.Windows.Forms.Button Retrieve_btn;
        private System.Windows.Forms.TextBox repeatpass_tb;
        private System.Windows.Forms.Label repPass_lb;
        private System.Windows.Forms.TextBox pass_tb;
        private System.Windows.Forms.Label pass_lb;
        private System.Windows.Forms.Label validErr_lb;
        private System.Windows.Forms.Panel emailCode_pl;
        private System.Windows.Forms.Panel retrievePass_pl;
        private System.Windows.Forms.PictureBox showPass_pb;
    }
}