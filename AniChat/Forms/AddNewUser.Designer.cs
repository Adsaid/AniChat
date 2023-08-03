namespace AniChat
{
    partial class AddNewUser
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
            this.txtBoxRep_Pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.txtBoxLogin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.validErr_lb = new System.Windows.Forms.Label();
            this.customPanel1 = new AniChat.CustomPanel();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showPass_pb = new System.Windows.Forms.PictureBox();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPass_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxRep_Pass
            // 
            this.txtBoxRep_Pass.Font = new System.Drawing.Font("Modern No. 20", 11.82089F);
            this.txtBoxRep_Pass.Location = new System.Drawing.Point(148, 207);
            this.txtBoxRep_Pass.MaxLength = 15;
            this.txtBoxRep_Pass.Name = "txtBoxRep_Pass";
            this.txtBoxRep_Pass.Size = new System.Drawing.Size(173, 31);
            this.txtBoxRep_Pass.TabIndex = 21;
            this.txtBoxRep_Pass.UseSystemPasswordChar = true;
            this.txtBoxRep_Pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxRep_Pass_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.82089F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(40, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Repeat\r\n";
            // 
            // btnRegister
            // 
            this.btnRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Modern No. 20", 11.82089F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegister.Location = new System.Drawing.Point(10, 10);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(340, 40);
            this.btnRegister.TabIndex = 19;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.Font = new System.Drawing.Font("Modern No. 20", 11.82089F);
            this.txtBoxPass.Location = new System.Drawing.Point(148, 164);
            this.txtBoxPass.MaxLength = 15;
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.Size = new System.Drawing.Size(173, 31);
            this.txtBoxPass.TabIndex = 18;
            this.txtBoxPass.UseSystemPasswordChar = true;
            this.txtBoxPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxPass_KeyDown);
            this.txtBoxPass.Leave += new System.EventHandler(this.txtBoxPass_Leave);
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.Font = new System.Drawing.Font("Modern No. 20", 11.82089F);
            this.txtBoxLogin.Location = new System.Drawing.Point(148, 55);
            this.txtBoxLogin.MaxLength = 15;
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Size = new System.Drawing.Size(173, 31);
            this.txtBoxLogin.TabIndex = 17;
            this.txtBoxLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxLogin_KeyDown);
            this.txtBoxLogin.Leave += new System.EventHandler(this.txtBoxLogin_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 11.82089F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(40, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 11.82089F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(40, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Login";
            // 
            // validErr_lb
            // 
            this.validErr_lb.AutoSize = true;
            this.validErr_lb.Font = new System.Drawing.Font("Modern No. 20", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validErr_lb.ForeColor = System.Drawing.Color.Red;
            this.validErr_lb.Location = new System.Drawing.Point(13, 10);
            this.validErr_lb.Name = "validErr_lb";
            this.validErr_lb.Size = new System.Drawing.Size(57, 21);
            this.validErr_lb.TabIndex = 25;
            this.validErr_lb.Text = "label1";
            // 
            // customPanel1
            // 
            this.customPanel1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customPanel1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel1.BorderRadius = 10;
            this.customPanel1.BorderSize = 2;
            this.customPanel1.Controls.Add(this.btnRegister);
            this.customPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.customPanel1.Location = new System.Drawing.Point(10, 278);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.customPanel1.Size = new System.Drawing.Size(360, 60);
            this.customPanel1.TabIndex = 28;
            this.customPanel1.UnderlinedStyle = false;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Modern No. 20", 11.82089F);
            this.txtBoxEmail.Location = new System.Drawing.Point(148, 99);
            this.txtBoxEmail.MaxLength = 50;
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(173, 31);
            this.txtBoxEmail.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.82089F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(40, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Email";
            // 
            // showPass_pb
            // 
            this.showPass_pb.Image = global::AniChat.Properties.Resources.showPass_icon;
            this.showPass_pb.Location = new System.Drawing.Point(327, 164);
            this.showPass_pb.Name = "showPass_pb";
            this.showPass_pb.Size = new System.Drawing.Size(30, 30);
            this.showPass_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showPass_pb.TabIndex = 31;
            this.showPass_pb.TabStop = false;
            this.showPass_pb.Click += new System.EventHandler(this.showPass_pb_Click);
            // 
            // AddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(134F, 134F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(380, 348);
            this.Controls.Add(this.showPass_pb);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.validErr_lb);
            this.Controls.Add(this.txtBoxRep_Pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.txtBoxLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.Name = "AddNewUser";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddNewUser_FormClosed);
            this.Load += new System.EventHandler(this.AddNewUser_Load);
            this.customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showPass_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxRep_Pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.TextBox txtBoxLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label validErr_lb;
        private CustomPanel customPanel1;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox showPass_pb;
    }
}