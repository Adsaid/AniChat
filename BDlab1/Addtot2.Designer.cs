namespace BDlab1
{
    partial class Addtot2
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
            this.txBDate = new System.Windows.Forms.TextBox();
            this.txBvudu = new System.Windows.Forms.TextBox();
            this.txBId = new System.Windows.Forms.TextBox();
            this.BtnCansel = new System.Windows.Forms.Button();
            this.BtnADD = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txBDate
            // 
            this.txBDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txBDate.Location = new System.Drawing.Point(248, 154);
            this.txBDate.Name = "txBDate";
            this.txBDate.Size = new System.Drawing.Size(232, 27);
            this.txBDate.TabIndex = 24;
            // 
            // txBvudu
            // 
            this.txBvudu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txBvudu.Location = new System.Drawing.Point(248, 97);
            this.txBvudu.Name = "txBvudu";
            this.txBvudu.Size = new System.Drawing.Size(232, 27);
            this.txBvudu.TabIndex = 23;
            // 
            // txBId
            // 
            this.txBId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txBId.Location = new System.Drawing.Point(248, 44);
            this.txBId.Name = "txBId";
            this.txBId.Size = new System.Drawing.Size(232, 27);
            this.txBId.TabIndex = 22;
            // 
            // BtnCansel
            // 
            this.BtnCansel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCansel.Location = new System.Drawing.Point(404, 407);
            this.BtnCansel.Name = "BtnCansel";
            this.BtnCansel.Size = new System.Drawing.Size(107, 40);
            this.BtnCansel.TabIndex = 21;
            this.BtnCansel.Text = "Відміна";
            this.BtnCansel.UseVisualStyleBackColor = true;
            // 
            // BtnADD
            // 
            this.BtnADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnADD.Location = new System.Drawing.Point(80, 407);
            this.BtnADD.Name = "BtnADD";
            this.BtnADD.Size = new System.Drawing.Size(107, 40);
            this.BtnADD.TabIndex = 20;
            this.BtnADD.Text = "Додати";
            this.BtnADD.UseVisualStyleBackColor = true;
            this.BtnADD.Click += new System.EventHandler(this.BtnADD_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(22, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Назва препарата";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Номер ліків";
            // 
            // Addtot2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 480);
            this.Controls.Add(this.txBDate);
            this.Controls.Add(this.txBvudu);
            this.Controls.Add(this.txBId);
            this.Controls.Add(this.BtnCansel);
            this.Controls.Add(this.BtnADD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Addtot2";
            this.Text = "Додавання записів в таблицю Medecine_aler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txBDate;
        private System.Windows.Forms.TextBox txBvudu;
        private System.Windows.Forms.TextBox txBId;
        private System.Windows.Forms.Button BtnCansel;
        private System.Windows.Forms.Button BtnADD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}