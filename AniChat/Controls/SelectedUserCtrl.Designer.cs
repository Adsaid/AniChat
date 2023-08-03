namespace AniChat
{
    partial class SelectedUserCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectedUserCtrl));
            this.UserName = new System.Windows.Forms.Label();
            this.RemMbrsBtn = new System.Windows.Forms.Button();
            this.UserImageBox = new AniChat.CirclePicture_box();
            this.customPanel1 = new AniChat.CustomPanel();
            ((System.ComponentModel.ISupportInitialize)(this.UserImageBox)).BeginInit();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserName.Location = new System.Drawing.Point(46, 11);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(89, 20);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "UserName";
            // 
            // RemMbrsBtn
            // 
            this.RemMbrsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemMbrsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemMbrsBtn.BackgroundImage")));
            this.RemMbrsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RemMbrsBtn.FlatAppearance.BorderSize = 0;
            this.RemMbrsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemMbrsBtn.Location = new System.Drawing.Point(149, 2);
            this.RemMbrsBtn.Name = "RemMbrsBtn";
            this.RemMbrsBtn.Size = new System.Drawing.Size(39, 37);
            this.RemMbrsBtn.TabIndex = 2;
            this.RemMbrsBtn.UseVisualStyleBackColor = true;
            // 
            // UserImageBox
            // 
            this.UserImageBox.Image = global::AniChat.Properties.Resources.default_user_img;
            this.UserImageBox.Location = new System.Drawing.Point(0, 0);
            this.UserImageBox.Name = "UserImageBox";
            this.UserImageBox.Size = new System.Drawing.Size(40, 40);
            this.UserImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserImageBox.TabIndex = 0;
            this.UserImageBox.TabStop = false;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.customPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.customPanel1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.customPanel1.BorderRadius = 15;
            this.customPanel1.BorderSize = 2;
            this.customPanel1.Controls.Add(this.UserName);
            this.customPanel1.Controls.Add(this.RemMbrsBtn);
            this.customPanel1.Controls.Add(this.UserImageBox);
            this.customPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPanel1.Location = new System.Drawing.Point(0, 0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(186, 42);
            this.customPanel1.TabIndex = 3;
            this.customPanel1.UnderlinedStyle = false;
            // 
            // SelectedUserCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(134F, 134F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.customPanel1);
            this.Name = "SelectedUserCtrl";
            this.Size = new System.Drawing.Size(186, 42);
            ((System.ComponentModel.ISupportInitialize)(this.UserImageBox)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public CirclePicture_box UserImageBox;
        public System.Windows.Forms.Label UserName;
        public System.Windows.Forms.Button RemMbrsBtn;
        private CustomPanel customPanel1;
    }
}
