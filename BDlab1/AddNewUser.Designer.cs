namespace BDlab1
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
            this.components = new System.ComponentModel.Container();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtNameUser = new System.Windows.Forms.TextBox();
            this.txtTypeUser = new System.Windows.Forms.TextBox();
            this.txtPassword1User = new System.Windows.Forms.TextBox();
            this.txtPassword2User = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(13, 287);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 33);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Location = new System.Drawing.Point(364, 287);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(94, 33);
            this.btnAddNewUser.TabIndex = 1;
            this.btnAddNewUser.Text = "Додати";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Користувач";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тип доступу";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Підтвердження паролю";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtNameUser
            // 
            this.txtNameUser.Location = new System.Drawing.Point(225, 47);
            this.txtNameUser.Name = "txtNameUser";
            this.txtNameUser.Size = new System.Drawing.Size(168, 22);
            this.txtNameUser.TabIndex = 7;
            this.txtNameUser.Leave += new System.EventHandler(this.txtNameUser_Leave);
            // 
            // txtTypeUser
            // 
            this.txtTypeUser.Location = new System.Drawing.Point(225, 98);
            this.txtTypeUser.Name = "txtTypeUser";
            this.txtTypeUser.Size = new System.Drawing.Size(168, 22);
            this.txtTypeUser.TabIndex = 8;
            this.txtTypeUser.Leave += new System.EventHandler(this.txtTypeUser_Leave);
            // 
            // txtPassword1User
            // 
            this.txtPassword1User.Location = new System.Drawing.Point(225, 151);
            this.txtPassword1User.Name = "txtPassword1User";
            this.txtPassword1User.Size = new System.Drawing.Size(168, 22);
            this.txtPassword1User.TabIndex = 9;
            this.txtPassword1User.UseSystemPasswordChar = true;
            // 
            // txtPassword2User
            // 
            this.txtPassword2User.Location = new System.Drawing.Point(225, 212);
            this.txtPassword2User.Name = "txtPassword2User";
            this.txtPassword2User.Size = new System.Drawing.Size(168, 22);
            this.txtPassword2User.TabIndex = 10;
            this.txtPassword2User.UseSystemPasswordChar = true;
            // 
            // AddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 332);
            this.Controls.Add(this.txtPassword2User);
            this.Controls.Add(this.txtPassword1User);
            this.Controls.Add(this.txtTypeUser);
            this.Controls.Add(this.txtNameUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddNewUser";
            this.Text = "AddNewUser";
            this.Load += new System.EventHandler(this.AddNewUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtNameUser;
        private System.Windows.Forms.TextBox txtTypeUser;
        private System.Windows.Forms.TextBox txtPassword1User;
        private System.Windows.Forms.TextBox txtPassword2User;
    }
}