namespace AniChat
{
    partial class BotsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BotsForm));
            this.Msgbox_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.DataUserpanel = new System.Windows.Forms.Panel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.message_pl = new AniChat.CustomPanel();
            this.MsgTextbox = new System.Windows.Forms.TextBox();
            this.send_pl = new AniChat.CustomPanel();
            this.btn_Send = new System.Windows.Forms.Button();
            this.circlePicture_Userbox = new AniChat.CirclePicture_box();
            this.DataUserpanel.SuspendLayout();
            this.message_pl.SuspendLayout();
            this.send_pl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circlePicture_Userbox)).BeginInit();
            this.SuspendLayout();
            // 
            // Msgbox_panel
            // 
            this.Msgbox_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Msgbox_panel.BackColor = System.Drawing.Color.Transparent;
            this.Msgbox_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Msgbox_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Msgbox_panel.Location = new System.Drawing.Point(50, 90);
            this.Msgbox_panel.Name = "Msgbox_panel";
            this.Msgbox_panel.Size = new System.Drawing.Size(1100, 355);
            this.Msgbox_panel.TabIndex = 6;
            this.Msgbox_panel.WrapContents = false;
            this.Msgbox_panel.SizeChanged += new System.EventHandler(this.Msgbox_panel_SizeChanged);
            // 
            // DataUserpanel
            // 
            this.DataUserpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.DataUserpanel.Controls.Add(this.NameLabel);
            this.DataUserpanel.Controls.Add(this.circlePicture_Userbox);
            this.DataUserpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataUserpanel.Location = new System.Drawing.Point(0, 0);
            this.DataUserpanel.Name = "DataUserpanel";
            this.DataUserpanel.Size = new System.Drawing.Size(1180, 70);
            this.DataUserpanel.TabIndex = 7;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Modern No. 20", 16.1194F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NameLabel.Location = new System.Drawing.Point(100, 20);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(84, 31);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Name";
            // 
            // message_pl
            // 
            this.message_pl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.message_pl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(125)))), ((int)(((byte)(236)))));
            this.message_pl.BorderFocusColor = System.Drawing.Color.HotPink;
            this.message_pl.BorderRadius = 10;
            this.message_pl.BorderSize = 2;
            this.message_pl.Controls.Add(this.MsgTextbox);
            this.message_pl.Location = new System.Drawing.Point(351, 453);
            this.message_pl.Name = "message_pl";
            this.message_pl.Padding = new System.Windows.Forms.Padding(10);
            this.message_pl.Size = new System.Drawing.Size(500, 80);
            this.message_pl.TabIndex = 8;
            this.message_pl.UnderlinedStyle = true;
            // 
            // MsgTextbox
            // 
            this.MsgTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MsgTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MsgTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MsgTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MsgTextbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MsgTextbox.Location = new System.Drawing.Point(10, 10);
            this.MsgTextbox.Multiline = true;
            this.MsgTextbox.Name = "MsgTextbox";
            this.MsgTextbox.Size = new System.Drawing.Size(480, 60);
            this.MsgTextbox.TabIndex = 1;
            this.MsgTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MsgTextbox_KeyDown);
            // 
            // send_pl
            // 
            this.send_pl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.send_pl.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.send_pl.BorderFocusColor = System.Drawing.Color.HotPink;
            this.send_pl.BorderRadius = 15;
            this.send_pl.BorderSize = 2;
            this.send_pl.Controls.Add(this.btn_Send);
            this.send_pl.Location = new System.Drawing.Point(866, 458);
            this.send_pl.Name = "send_pl";
            this.send_pl.Padding = new System.Windows.Forms.Padding(10);
            this.send_pl.Size = new System.Drawing.Size(70, 70);
            this.send_pl.TabIndex = 9;
            this.send_pl.UnderlinedStyle = false;
            // 
            // btn_Send
            // 
            this.btn_Send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn_Send.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Send.BackgroundImage")));
            this.btn_Send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Send.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Send.FlatAppearance.BorderSize = 0;
            this.btn_Send.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Send.Location = new System.Drawing.Point(10, 10);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(50, 50);
            this.btn_Send.TabIndex = 3;
            this.btn_Send.UseVisualStyleBackColor = false;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // circlePicture_Userbox
            // 
            this.circlePicture_Userbox.Image = global::AniChat.Properties.Resources.bot;
            this.circlePicture_Userbox.Location = new System.Drawing.Point(28, 10);
            this.circlePicture_Userbox.Name = "circlePicture_Userbox";
            this.circlePicture_Userbox.Size = new System.Drawing.Size(50, 50);
            this.circlePicture_Userbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circlePicture_Userbox.TabIndex = 8;
            this.circlePicture_Userbox.TabStop = false;
            // 
            // BotsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1180, 548);
            this.Controls.Add(this.DataUserpanel);
            this.Controls.Add(this.Msgbox_panel);
            this.Controls.Add(this.send_pl);
            this.Controls.Add(this.message_pl);
            this.Name = "BotsForm";
            this.Text = "BotsForm";
            this.Load += new System.EventHandler(this.BotsForm_Load);
            this.DataUserpanel.ResumeLayout(false);
            this.DataUserpanel.PerformLayout();
            this.message_pl.ResumeLayout(false);
            this.message_pl.PerformLayout();
            this.send_pl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circlePicture_Userbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPanel message_pl;
        private System.Windows.Forms.TextBox MsgTextbox;
        private CustomPanel send_pl;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.FlowLayoutPanel Msgbox_panel;
        private System.Windows.Forms.Panel DataUserpanel;
        private System.Windows.Forms.Label NameLabel;
        private CirclePicture_box circlePicture_Userbox;
    }
}