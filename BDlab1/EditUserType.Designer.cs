namespace BDlab1
{
    partial class EditUserType
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
            this.btnEditTypeUser = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNameUser = new System.Windows.Forms.ComboBox();
            this.cmbTypeUser = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnEditTypeUser
            // 
            this.btnEditTypeUser.Location = new System.Drawing.Point(287, 229);
            this.btnEditTypeUser.Name = "btnEditTypeUser";
            this.btnEditTypeUser.Size = new System.Drawing.Size(94, 33);
            this.btnEditTypeUser.TabIndex = 14;
            this.btnEditTypeUser.Text = "Змінити";
            this.btnEditTypeUser.UseVisualStyleBackColor = true;
            this.btnEditTypeUser.Click += new System.EventHandler(this.btnEditTypeUser_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 229);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 33);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Користувач";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Типи доступу";
            // 
            // cmbNameUser
            // 
            this.cmbNameUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNameUser.FormattingEnabled = true;
            this.cmbNameUser.Location = new System.Drawing.Point(189, 45);
            this.cmbNameUser.Name = "cmbNameUser";
            this.cmbNameUser.Size = new System.Drawing.Size(155, 24);
            this.cmbNameUser.TabIndex = 17;
            // 
            // cmbTypeUser
            // 
            this.cmbTypeUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeUser.FormattingEnabled = true;
            this.cmbTypeUser.Location = new System.Drawing.Point(189, 127);
            this.cmbTypeUser.Name = "cmbTypeUser";
            this.cmbTypeUser.Size = new System.Drawing.Size(155, 24);
            this.cmbTypeUser.TabIndex = 18;
            // 
            // EditUserType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 274);
            this.Controls.Add(this.cmbTypeUser);
            this.Controls.Add(this.cmbNameUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditTypeUser);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditUserType";
            this.Text = "EditUserType";
            this.Load += new System.EventHandler(this.EditUserType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditTypeUser;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNameUser;
        private System.Windows.Forms.ComboBox cmbTypeUser;
    }
}