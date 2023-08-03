namespace AniChat
{
    partial class ChatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.DataUserpanel = new System.Windows.Forms.Panel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Msgbox_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.message_pl = new AniChat.CustomPanel();
            this.MsgTextbox = new System.Windows.Forms.TextBox();
            this.microphone_btn = new System.Windows.Forms.Button();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.send_pl = new AniChat.CustomPanel();
            this.btn_Send = new System.Windows.Forms.Button();
            this.circlePicture_Userbox = new AniChat.CirclePicture_box();
            this.DataUserpanel.SuspendLayout();
            this.message_pl.SuspendLayout();
            this.send_pl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circlePicture_Userbox)).BeginInit();
            this.SuspendLayout();
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
            this.DataUserpanel.TabIndex = 2;
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Msgbox_panel
            // 
            this.Msgbox_panel.AllowDrop = true;
            this.Msgbox_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Msgbox_panel.BackColor = System.Drawing.Color.Transparent;
            this.Msgbox_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Msgbox_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Msgbox_panel.Location = new System.Drawing.Point(50, 75);
            this.Msgbox_panel.Name = "Msgbox_panel";
            this.Msgbox_panel.Size = new System.Drawing.Size(1100, 355);
            this.Msgbox_panel.TabIndex = 1;
            this.Msgbox_panel.Visible = false;
            this.Msgbox_panel.WrapContents = false;
            this.Msgbox_panel.SizeChanged += new System.EventHandler(this.Msgbox_panel_SizeChanged);
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
            this.message_pl.Controls.Add(this.microphone_btn);
            this.message_pl.Controls.Add(this.btnSendFile);
            this.message_pl.Location = new System.Drawing.Point(351, 438);
            this.message_pl.Name = "message_pl";
            this.message_pl.Padding = new System.Windows.Forms.Padding(10);
            this.message_pl.Size = new System.Drawing.Size(500, 80);
            this.message_pl.TabIndex = 4;
            this.message_pl.UnderlinedStyle = true;
            this.message_pl.Visible = false;
            // 
            // MsgTextbox
            // 
            this.MsgTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MsgTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MsgTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MsgTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MsgTextbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MsgTextbox.Location = new System.Drawing.Point(50, 10);
            this.MsgTextbox.Multiline = true;
            this.MsgTextbox.Name = "MsgTextbox";
            this.MsgTextbox.Size = new System.Drawing.Size(400, 60);
            this.MsgTextbox.TabIndex = 1;
            this.MsgTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MsgTextbox_KeyDown);
            // 
            // microphone_btn
            // 
            this.microphone_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.microphone_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("microphone_btn.BackgroundImage")));
            this.microphone_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.microphone_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.microphone_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.microphone_btn.FlatAppearance.BorderSize = 0;
            this.microphone_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.microphone_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.microphone_btn.Location = new System.Drawing.Point(10, 10);
            this.microphone_btn.Name = "microphone_btn";
            this.microphone_btn.Size = new System.Drawing.Size(40, 60);
            this.microphone_btn.TabIndex = 3;
            this.microphone_btn.UseVisualStyleBackColor = false;
            this.microphone_btn.Click += new System.EventHandler(this.microphone_btn_Click);
            // 
            // btnSendFile
            // 
            this.btnSendFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSendFile.BackgroundImage = global::AniChat.Properties.Resources.paperclip;
            this.btnSendFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSendFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSendFile.FlatAppearance.BorderSize = 0;
            this.btnSendFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnSendFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendFile.Location = new System.Drawing.Point(450, 10);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(40, 60);
            this.btnSendFile.TabIndex = 2;
            this.btnSendFile.UseVisualStyleBackColor = false;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // send_pl
            // 
            this.send_pl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.send_pl.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.send_pl.BorderFocusColor = System.Drawing.Color.HotPink;
            this.send_pl.BorderRadius = 15;
            this.send_pl.BorderSize = 2;
            this.send_pl.Controls.Add(this.btn_Send);
            this.send_pl.Location = new System.Drawing.Point(866, 443);
            this.send_pl.Name = "send_pl";
            this.send_pl.Padding = new System.Windows.Forms.Padding(10);
            this.send_pl.Size = new System.Drawing.Size(70, 70);
            this.send_pl.TabIndex = 5;
            this.send_pl.UnderlinedStyle = false;
            this.send_pl.Visible = false;
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
            this.circlePicture_Userbox.Image = ((System.Drawing.Image)(resources.GetObject("circlePicture_Userbox.Image")));
            this.circlePicture_Userbox.Location = new System.Drawing.Point(28, 10);
            this.circlePicture_Userbox.Name = "circlePicture_Userbox";
            this.circlePicture_Userbox.Size = new System.Drawing.Size(50, 50);
            this.circlePicture_Userbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circlePicture_Userbox.TabIndex = 8;
            this.circlePicture_Userbox.TabStop = false;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(134F, 134F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1180, 548);
            this.Controls.Add(this.message_pl);
            this.Controls.Add(this.send_pl);
            this.Controls.Add(this.Msgbox_panel);
            this.Controls.Add(this.DataUserpanel);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatForm1_FormClosed);
            this.Load += new System.EventHandler(this.ChatForm1_Load);
            this.DataUserpanel.ResumeLayout(false);
            this.DataUserpanel.PerformLayout();
            this.message_pl.ResumeLayout(false);
            this.message_pl.PerformLayout();
            this.send_pl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circlePicture_Userbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox MsgTextbox;
        private System.Windows.Forms.Panel DataUserpanel;
        private System.Windows.Forms.Label NameLabel;
        private CirclePicture_box circlePicture_Userbox;
        private System.Windows.Forms.FlowLayoutPanel Msgbox_panel;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Button btn_Send;
        private CustomPanel message_pl;
        private System.Windows.Forms.Button microphone_btn;
        private System.Windows.Forms.Timer timer1;
        private CustomPanel send_pl;
    }
}