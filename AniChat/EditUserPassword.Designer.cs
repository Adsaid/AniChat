namespace AniChat
{
    partial class EditUserPassword
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
            this.txtPassword2User = new System.Windows.Forms.TextBox();
            this.txtPassword1User = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.btnEditPaswordUser = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbNameUser = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtPassword2User
            // 
            this.txtPassword2User.Location = new System.Drawing.Point(242, 142);
            this.txtPassword2User.Name = "txtPassword2User";
            this.txtPassword2User.Size = new System.Drawing.Size(168, 22);
            this.txtPassword2User.TabIndex = 20;
            this.txtPassword2User.UseSystemPasswordChar = true;
            // 
            // txtPassword1User
            // 
            this.txtPassword1User.Location = new System.Drawing.Point(242, 81);
            this.txtPassword1User.Name = "txtPassword1User";
            this.txtPassword1User.Size = new System.Drawing.Size(168, 22);
            this.txtPassword1User.TabIndex = 19;
            this.txtPassword1User.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(26, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Підтвердження паролю";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = " Новий пароль";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUser.Location = new System.Drawing.Point(26, 26);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(107, 20);
            this.labelUser.TabIndex = 13;
            this.labelUser.Text = "Користувач";
            // 
            // btnEditPaswordUser
            // 
            this.btnEditPaswordUser.Location = new System.Drawing.Point(381, 211);
            this.btnEditPaswordUser.Name = "btnEditPaswordUser";
            this.btnEditPaswordUser.Size = new System.Drawing.Size(94, 33);
            this.btnEditPaswordUser.TabIndex = 12;
            this.btnEditPaswordUser.Text = "Змінити";
            this.btnEditPaswordUser.UseVisualStyleBackColor = true;
            this.btnEditPaswordUser.Click += new System.EventHandler(this.btnEditPaswordUser_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(30, 211);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 33);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmbNameUser
            // 
            this.cmbNameUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNameUser.FormattingEnabled = true;
            this.cmbNameUser.Location = new System.Drawing.Point(242, 26);
            this.cmbNameUser.Name = "cmbNameUser";
            this.cmbNameUser.Size = new System.Drawing.Size(168, 24);
            this.cmbNameUser.TabIndex = 21;
            // 
            // EditUserPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 465);
            this.Controls.Add(this.cmbNameUser);
            this.Controls.Add(this.txtPassword2User);
            this.Controls.Add(this.txtPassword1User);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.btnEditPaswordUser);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditUserPassword";
            this.Text = "EditUserPassword";
            this.Load += new System.EventHandler(this.EditUserPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword2User;
        private System.Windows.Forms.TextBox txtPassword1User;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button btnEditPaswordUser;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmbNameUser;
    }
}