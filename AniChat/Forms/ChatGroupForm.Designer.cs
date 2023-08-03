namespace AniChat
{
    partial class ChatGroupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatGroupForm));
            this.DataUserpanel = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.circlePicture_Userbox = new AniChat.CirclePicture_box();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.message_pl = new AniChat.CustomPanel();
            this.MsgTextbox = new System.Windows.Forms.TextBox();
            this.microphone_btn = new System.Windows.Forms.Button();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.GroupMenupl = new System.Windows.Forms.Panel();
            this.MemberTLPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AdminPanel = new System.Windows.Forms.Panel();
            this.underscore_Delete_pl = new System.Windows.Forms.Panel();
            this.underscore_Add_pl = new System.Windows.Forms.Panel();
            this.delete_swich_lb = new System.Windows.Forms.Label();
            this.add_swich_lb = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.delete_gp_btn = new System.Windows.Forms.Button();
            this.HeadersMenulb = new System.Windows.Forms.Label();
            this.Msgbox_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.send_pl = new AniChat.CustomPanel();
            this.btn_Send = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DataUserpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circlePicture_Userbox)).BeginInit();
            this.message_pl.SuspendLayout();
            this.GroupMenupl.SuspendLayout();
            this.AdminPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.send_pl.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataUserpanel
            // 
            this.DataUserpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.DataUserpanel.Controls.Add(this.btnMenu);
            this.DataUserpanel.Controls.Add(this.NameLabel);
            this.DataUserpanel.Controls.Add(this.circlePicture_Userbox);
            this.DataUserpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataUserpanel.Location = new System.Drawing.Point(0, 0);
            this.DataUserpanel.Name = "DataUserpanel";
            this.DataUserpanel.Size = new System.Drawing.Size(1180, 70);
            this.DataUserpanel.TabIndex = 5;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenu.BackgroundImage")));
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Modern No. 20", 11.82089F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenu.Location = new System.Drawing.Point(1108, 19);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(60, 32);
            this.btnMenu.TabIndex = 9;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.message_pl.Location = new System.Drawing.Point(350, 437);
            this.message_pl.Name = "message_pl";
            this.message_pl.Padding = new System.Windows.Forms.Padding(10);
            this.message_pl.Size = new System.Drawing.Size(500, 80);
            this.message_pl.TabIndex = 5;
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
            // GroupMenupl
            // 
            this.GroupMenupl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.GroupMenupl.Controls.Add(this.MemberTLPanel);
            this.GroupMenupl.Controls.Add(this.AdminPanel);
            this.GroupMenupl.Controls.Add(this.panel2);
            this.GroupMenupl.Dock = System.Windows.Forms.DockStyle.Right;
            this.GroupMenupl.Location = new System.Drawing.Point(830, 70);
            this.GroupMenupl.Name = "GroupMenupl";
            this.GroupMenupl.Size = new System.Drawing.Size(350, 478);
            this.GroupMenupl.TabIndex = 2;
            // 
            // MemberTLPanel
            // 
            this.MemberTLPanel.ColumnCount = 1;
            this.MemberTLPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MemberTLPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemberTLPanel.Location = new System.Drawing.Point(0, 79);
            this.MemberTLPanel.Name = "MemberTLPanel";
            this.MemberTLPanel.RowCount = 1;
            this.MemberTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MemberTLPanel.Size = new System.Drawing.Size(350, 399);
            this.MemberTLPanel.TabIndex = 2;
            // 
            // AdminPanel
            // 
            this.AdminPanel.Controls.Add(this.underscore_Delete_pl);
            this.AdminPanel.Controls.Add(this.underscore_Add_pl);
            this.AdminPanel.Controls.Add(this.delete_swich_lb);
            this.AdminPanel.Controls.Add(this.add_swich_lb);
            this.AdminPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdminPanel.Location = new System.Drawing.Point(0, 40);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(350, 39);
            this.AdminPanel.TabIndex = 1;
            // 
            // underscore_Delete_pl
            // 
            this.underscore_Delete_pl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.underscore_Delete_pl.BackColor = System.Drawing.Color.DodgerBlue;
            this.underscore_Delete_pl.Location = new System.Drawing.Point(192, 28);
            this.underscore_Delete_pl.Name = "underscore_Delete_pl";
            this.underscore_Delete_pl.Size = new System.Drawing.Size(62, 5);
            this.underscore_Delete_pl.TabIndex = 15;
            // 
            // underscore_Add_pl
            // 
            this.underscore_Add_pl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.underscore_Add_pl.BackColor = System.Drawing.Color.DodgerBlue;
            this.underscore_Add_pl.Location = new System.Drawing.Point(108, 28);
            this.underscore_Add_pl.Name = "underscore_Add_pl";
            this.underscore_Add_pl.Size = new System.Drawing.Size(50, 5);
            this.underscore_Add_pl.TabIndex = 14;
            // 
            // delete_swich_lb
            // 
            this.delete_swich_lb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_swich_lb.AutoSize = true;
            this.delete_swich_lb.Font = new System.Drawing.Font("Modern No. 20", 11.82089F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_swich_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_swich_lb.Location = new System.Drawing.Point(188, 3);
            this.delete_swich_lb.Name = "delete_swich_lb";
            this.delete_swich_lb.Size = new System.Drawing.Size(67, 24);
            this.delete_swich_lb.TabIndex = 13;
            this.delete_swich_lb.Text = "Delete";
            this.delete_swich_lb.Click += new System.EventHandler(this.delete_swich_lb_Click);
            // 
            // add_swich_lb
            // 
            this.add_swich_lb.AutoSize = true;
            this.add_swich_lb.Font = new System.Drawing.Font("Modern No. 20", 11.82089F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_swich_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_swich_lb.Location = new System.Drawing.Point(111, 3);
            this.add_swich_lb.Name = "add_swich_lb";
            this.add_swich_lb.Size = new System.Drawing.Size(47, 24);
            this.add_swich_lb.TabIndex = 12;
            this.add_swich_lb.Text = "Add";
            this.add_swich_lb.Click += new System.EventHandler(this.add_swich_lb_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.delete_gp_btn);
            this.panel2.Controls.Add(this.HeadersMenulb);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(350, 40);
            this.panel2.TabIndex = 0;
            // 
            // delete_gp_btn
            // 
            this.delete_gp_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete_gp_btn.BackgroundImage")));
            this.delete_gp_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete_gp_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.delete_gp_btn.FlatAppearance.BorderSize = 0;
            this.delete_gp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_gp_btn.Font = new System.Drawing.Font("Modern No. 20", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_gp_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.delete_gp_btn.Location = new System.Drawing.Point(313, 3);
            this.delete_gp_btn.Name = "delete_gp_btn";
            this.delete_gp_btn.Size = new System.Drawing.Size(34, 34);
            this.delete_gp_btn.TabIndex = 14;
            this.delete_gp_btn.UseVisualStyleBackColor = true;
            this.delete_gp_btn.Click += new System.EventHandler(this.delete_gp_btn_Click);
            // 
            // HeadersMenulb
            // 
            this.HeadersMenulb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HeadersMenulb.AutoSize = true;
            this.HeadersMenulb.Font = new System.Drawing.Font("Modern No. 20", 16.1194F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadersMenulb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HeadersMenulb.Location = new System.Drawing.Point(114, 5);
            this.HeadersMenulb.Name = "HeadersMenulb";
            this.HeadersMenulb.Size = new System.Drawing.Size(123, 31);
            this.HeadersMenulb.TabIndex = 8;
            this.HeadersMenulb.Text = "Members";
            // 
            // Msgbox_panel
            // 
            this.Msgbox_panel.AllowDrop = true;
            this.Msgbox_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Msgbox_panel.BackColor = System.Drawing.Color.Transparent;
            this.Msgbox_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Msgbox_panel.Location = new System.Drawing.Point(50, 75);
            this.Msgbox_panel.Name = "Msgbox_panel";
            this.Msgbox_panel.Size = new System.Drawing.Size(1100, 355);
            this.Msgbox_panel.TabIndex = 1;
            this.Msgbox_panel.Visible = false;
            this.Msgbox_panel.WrapContents = false;
            this.Msgbox_panel.SizeChanged += new System.EventHandler(this.Msgbox_panel_SizeChanged);
            // 
            // send_pl
            // 
            this.send_pl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.send_pl.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.send_pl.BorderFocusColor = System.Drawing.Color.HotPink;
            this.send_pl.BorderRadius = 15;
            this.send_pl.BorderSize = 2;
            this.send_pl.Controls.Add(this.btn_Send);
            this.send_pl.Location = new System.Drawing.Point(865, 442);
            this.send_pl.Name = "send_pl";
            this.send_pl.Padding = new System.Windows.Forms.Padding(10);
            this.send_pl.Size = new System.Drawing.Size(70, 70);
            this.send_pl.TabIndex = 6;
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
            this.btn_Send.TabIndex = 4;
            this.btn_Send.UseVisualStyleBackColor = false;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(10, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 45);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ChatGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(134F, 134F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1180, 548);
            this.Controls.Add(this.GroupMenupl);
            this.Controls.Add(this.Msgbox_panel);
            this.Controls.Add(this.DataUserpanel);
            this.Controls.Add(this.message_pl);
            this.Controls.Add(this.send_pl);
            this.Name = "ChatGroupForm";
            this.Text = "ChatGroupForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatGroup_FormClosed);
            this.Load += new System.EventHandler(this.ChatGroupForm_Load);
            this.DataUserpanel.ResumeLayout(false);
            this.DataUserpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circlePicture_Userbox)).EndInit();
            this.message_pl.ResumeLayout(false);
            this.message_pl.PerformLayout();
            this.GroupMenupl.ResumeLayout(false);
            this.AdminPanel.ResumeLayout(false);
            this.AdminPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.send_pl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel Msgbox_panel;
        private System.Windows.Forms.Panel DataUserpanel;
        private System.Windows.Forms.Label NameLabel;
        private CirclePicture_box circlePicture_Userbox;
        private System.Windows.Forms.Panel GroupMenupl;
        private System.Windows.Forms.Panel AdminPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label HeadersMenulb;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.TableLayoutPanel MemberTLPanel;
        private System.Windows.Forms.Panel underscore_Delete_pl;
        private System.Windows.Forms.Panel underscore_Add_pl;
        private System.Windows.Forms.Label delete_swich_lb;
        private System.Windows.Forms.Label add_swich_lb;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button delete_gp_btn;
        private CustomPanel message_pl;
        private System.Windows.Forms.TextBox MsgTextbox;
        private System.Windows.Forms.Button microphone_btn;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Timer timer1;
        private CustomPanel send_pl;
    }
}