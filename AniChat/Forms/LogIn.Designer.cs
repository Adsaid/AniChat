namespace AniChat
{
    partial class LogIn
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
            this.btnLogIn = new System.Windows.Forms.Button();
            this.Reg_Lb = new System.Windows.Forms.Label();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.txtBoxLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.validErr_lb = new System.Windows.Forms.Label();
            this.customPanel1 = new AniChat.CustomPanel();
            this.retrieve_PassLb = new System.Windows.Forms.Label();
            this.showPass_pb = new System.Windows.Forms.PictureBox();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPass_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogIn
            // 
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Modern No. 20", 11.82089F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogIn.Location = new System.Drawing.Point(10, 10);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(340, 40);
            this.btnLogIn.TabIndex = 21;
            this.btnLogIn.Text = "LogIn";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Reg_Lb
            // 
            this.Reg_Lb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Reg_Lb.AutoSize = true;
            this.Reg_Lb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reg_Lb.Font = new System.Drawing.Font("Modern No. 20", 11.82089F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reg_Lb.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Reg_Lb.Location = new System.Drawing.Point(275, 10);
            this.Reg_Lb.Name = "Reg_Lb";
            this.Reg_Lb.Size = new System.Drawing.Size(100, 24);
            this.Reg_Lb.TabIndex = 20;
            this.Reg_Lb.Text = "➡Sign up";
            this.Reg_Lb.Click += new System.EventHandler(this.label_reg_Click);
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.Font = new System.Drawing.Font("Modern No. 20", 11.82089F);
            this.txtBoxPass.Location = new System.Drawing.Point(147, 192);
            this.txtBoxPass.MaxLength = 15;
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.Size = new System.Drawing.Size(173, 31);
            this.txtBoxPass.TabIndex = 19;
            this.txtBoxPass.UseSystemPasswordChar = true;
            this.txtBoxPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxPass_KeyDown);
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.Font = new System.Drawing.Font("Modern No. 20", 11.82089F);
            this.txtBoxLogin.Location = new System.Drawing.Point(147, 117);
            this.txtBoxLogin.MaxLength = 15;
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Size = new System.Drawing.Size(173, 31);
            this.txtBoxLogin.TabIndex = 18;
            this.txtBoxLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxLogin_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.82089F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(40, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 11.82089F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(40, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Login";
            // 
            // validErr_lb
            // 
            this.validErr_lb.AutoSize = true;
            this.validErr_lb.Font = new System.Drawing.Font("Modern No. 20", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validErr_lb.ForeColor = System.Drawing.Color.Red;
            this.validErr_lb.Location = new System.Drawing.Point(35, 35);
            this.validErr_lb.Name = "validErr_lb";
            this.validErr_lb.Size = new System.Drawing.Size(57, 21);
            this.validErr_lb.TabIndex = 26;
            this.validErr_lb.Text = "label1";
            this.validErr_lb.Visible = false;
            // 
            // customPanel1
            // 
            this.customPanel1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customPanel1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel1.BorderRadius = 10;
            this.customPanel1.BorderSize = 2;
            this.customPanel1.Controls.Add(this.btnLogIn);
            this.customPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.customPanel1.Location = new System.Drawing.Point(10, 328);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.customPanel1.Size = new System.Drawing.Size(360, 60);
            this.customPanel1.TabIndex = 27;
            this.customPanel1.UnderlinedStyle = false;
            // 
            // retrieve_PassLb
            // 
            this.retrieve_PassLb.AutoSize = true;
            this.retrieve_PassLb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retrieve_PassLb.Font = new System.Drawing.Font("Modern No. 20", 11.82089F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retrieve_PassLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.retrieve_PassLb.Location = new System.Drawing.Point(205, 244);
            this.retrieve_PassLb.Name = "retrieve_PassLb";
            this.retrieve_PassLb.Size = new System.Drawing.Size(170, 24);
            this.retrieve_PassLb.TabIndex = 28;
            this.retrieve_PassLb.Text = "Forgot password ?";
            this.retrieve_PassLb.Visible = false;
            this.retrieve_PassLb.Click += new System.EventHandler(this.retrieve_PassLb_Click);
            // 
            // showPass_pb
            // 
            this.showPass_pb.Image = global::AniChat.Properties.Resources.showPass_icon;
            this.showPass_pb.Location = new System.Drawing.Point(327, 192);
            this.showPass_pb.Name = "showPass_pb";
            this.showPass_pb.Size = new System.Drawing.Size(30, 30);
            this.showPass_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showPass_pb.TabIndex = 29;
            this.showPass_pb.TabStop = false;
            this.showPass_pb.Click += new System.EventHandler(this.showPass_pb_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(380, 398);
            this.Controls.Add(this.showPass_pb);
            this.Controls.Add(this.retrieve_PassLb);
            this.Controls.Add(this.validErr_lb);
            this.Controls.Add(this.Reg_Lb);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.txtBoxLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(400, 450);
            this.MinimumSize = new System.Drawing.Size(400, 450);
            this.Name = "LogIn";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogIn_FormClosed);
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showPass_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label Reg_Lb;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.TextBox txtBoxLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label validErr_lb;
        private CustomPanel customPanel1;
        private System.Windows.Forms.Label retrieve_PassLb;
        private System.Windows.Forms.PictureBox showPass_pb;
    }
}