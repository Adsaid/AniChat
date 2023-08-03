namespace AniChat
{
    partial class MessageBoxUser_ctrl
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
            this.panel1 = new AniChat.CustomPanel();
            this.lb_Time = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderColor = System.Drawing.Color.GhostWhite;
            this.panel1.BorderFocusColor = System.Drawing.Color.GhostWhite;
            this.panel1.BorderRadius = 15;
            this.panel1.BorderSize = 2;
            this.panel1.Controls.Add(this.lb_Time);
            this.panel1.Controls.Add(this.lb_Name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(429, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 182);
            this.panel1.TabIndex = 2;
            this.panel1.UnderlinedStyle = false;
            // 
            // lb_Time
            // 
            this.lb_Time.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Time.ForeColor = System.Drawing.Color.White;
            this.lb_Time.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_Time.Location = new System.Drawing.Point(0, 164);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(283, 18);
            this.lb_Time.TabIndex = 1;
            this.lb_Time.Text = "label2";
            this.lb_Time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_Name
            // 
            this.lb_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_Name.Font = new System.Drawing.Font("Modern No. 20", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.ForeColor = System.Drawing.Color.White;
            this.lb_Name.Location = new System.Drawing.Point(0, 0);
            this.lb_Name.Margin = new System.Windows.Forms.Padding(0);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(283, 29);
            this.lb_Name.TabIndex = 0;
            this.lb_Name.Text = "label1";
            // 
            // MessageBoxUser_ctrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(134F, 134F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MessageBoxUser_ctrl";
            this.Size = new System.Drawing.Size(712, 182);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.Label lb_Name;
        private CustomPanel panel1;
    }
}
