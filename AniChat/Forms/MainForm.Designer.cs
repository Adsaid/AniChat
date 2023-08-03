namespace AniChat
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.ContactListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Swich_list_panel = new System.Windows.Forms.Panel();
            this.Search_tb = new System.Windows.Forms.TextBox();
            this.GPTBot_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddGroupBtn = new System.Windows.Forms.Button();
            this.underscore_Group_pl = new System.Windows.Forms.Panel();
            this.underscore_Contact_pl = new System.Windows.Forms.Panel();
            this.contact_swich_btn = new System.Windows.Forms.Button();
            this.group_swich_btn = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.control_panel = new System.Windows.Forms.Panel();
            this.Setting_menu = new AniChat.CirclePicture_box();
            this.circlePicture_box1 = new AniChat.CirclePicture_box();
            this.panel_form_out = new System.Windows.Forms.Panel();
            this.panel_Menu.SuspendLayout();
            this.Swich_list_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.control_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Setting_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circlePicture_box1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.AutoScroll = true;
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel_Menu.Controls.Add(this.ContactListPanel);
            this.panel_Menu.Controls.Add(this.Swich_list_panel);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 60);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(350, 788);
            this.panel_Menu.TabIndex = 4;
            this.panel_Menu.SizeChanged += new System.EventHandler(this.panel_Menu_SizeChanged);
            // 
            // ContactListPanel
            // 
            this.ContactListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ContactListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactListPanel.Location = new System.Drawing.Point(0, 60);
            this.ContactListPanel.Name = "ContactListPanel";
            this.ContactListPanel.Size = new System.Drawing.Size(350, 728);
            this.ContactListPanel.TabIndex = 7;
            // 
            // Swich_list_panel
            // 
            this.Swich_list_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Swich_list_panel.Controls.Add(this.Search_tb);
            this.Swich_list_panel.Controls.Add(this.GPTBot_btn);
            this.Swich_list_panel.Controls.Add(this.pictureBox1);
            this.Swich_list_panel.Controls.Add(this.AddGroupBtn);
            this.Swich_list_panel.Controls.Add(this.underscore_Group_pl);
            this.Swich_list_panel.Controls.Add(this.underscore_Contact_pl);
            this.Swich_list_panel.Controls.Add(this.contact_swich_btn);
            this.Swich_list_panel.Controls.Add(this.group_swich_btn);
            this.Swich_list_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Swich_list_panel.Location = new System.Drawing.Point(0, 0);
            this.Swich_list_panel.Name = "Swich_list_panel";
            this.Swich_list_panel.Size = new System.Drawing.Size(350, 60);
            this.Swich_list_panel.TabIndex = 10;
            // 
            // Search_tb
            // 
            this.Search_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_tb.Location = new System.Drawing.Point(51, 14);
            this.Search_tb.Name = "Search_tb";
            this.Search_tb.Size = new System.Drawing.Size(254, 29);
            this.Search_tb.TabIndex = 8;
            this.Search_tb.Visible = false;
            this.Search_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_tb_KeyDown);
            // 
            // GPTBot_btn
            // 
            this.GPTBot_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GPTBot_btn.BackgroundImage = global::AniChat.Properties.Resources.bot;
            this.GPTBot_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GPTBot_btn.FlatAppearance.BorderSize = 0;
            this.GPTBot_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GPTBot_btn.Location = new System.Drawing.Point(307, 10);
            this.GPTBot_btn.Name = "GPTBot_btn";
            this.GPTBot_btn.Size = new System.Drawing.Size(40, 40);
            this.GPTBot_btn.TabIndex = 15;
            this.GPTBot_btn.UseVisualStyleBackColor = true;
            this.GPTBot_btn.Click += new System.EventHandler(this.GPTBot_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AniChat.Properties.Resources.search_icon;
            this.pictureBox1.Location = new System.Drawing.Point(9, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AddGroupBtn
            // 
            this.AddGroupBtn.BackgroundImage = global::AniChat.Properties.Resources.add_flat_icon;
            this.AddGroupBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddGroupBtn.FlatAppearance.BorderSize = 0;
            this.AddGroupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddGroupBtn.Location = new System.Drawing.Point(244, 13);
            this.AddGroupBtn.Name = "AddGroupBtn";
            this.AddGroupBtn.Size = new System.Drawing.Size(40, 40);
            this.AddGroupBtn.TabIndex = 12;
            this.AddGroupBtn.UseVisualStyleBackColor = true;
            this.AddGroupBtn.Click += new System.EventHandler(this.AddGroupBtn_Click);
            // 
            // underscore_Group_pl
            // 
            this.underscore_Group_pl.BackColor = System.Drawing.Color.DodgerBlue;
            this.underscore_Group_pl.Location = new System.Drawing.Point(181, 38);
            this.underscore_Group_pl.Name = "underscore_Group_pl";
            this.underscore_Group_pl.Size = new System.Drawing.Size(62, 3);
            this.underscore_Group_pl.TabIndex = 11;
            // 
            // underscore_Contact_pl
            // 
            this.underscore_Contact_pl.BackColor = System.Drawing.Color.DodgerBlue;
            this.underscore_Contact_pl.Location = new System.Drawing.Point(78, 38);
            this.underscore_Contact_pl.Name = "underscore_Contact_pl";
            this.underscore_Contact_pl.Size = new System.Drawing.Size(73, 3);
            this.underscore_Contact_pl.TabIndex = 10;
            // 
            // contact_swich_btn
            // 
            this.contact_swich_btn.FlatAppearance.BorderSize = 0;
            this.contact_swich_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contact_swich_btn.Font = new System.Drawing.Font("Modern No. 20", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_swich_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.contact_swich_btn.Location = new System.Drawing.Point(71, 14);
            this.contact_swich_btn.Name = "contact_swich_btn";
            this.contact_swich_btn.Size = new System.Drawing.Size(86, 29);
            this.contact_swich_btn.TabIndex = 13;
            this.contact_swich_btn.Text = "Contact";
            this.contact_swich_btn.UseVisualStyleBackColor = true;
            this.contact_swich_btn.Click += new System.EventHandler(this.contact_swich_btn_Click);
            // 
            // group_swich_btn
            // 
            this.group_swich_btn.FlatAppearance.BorderSize = 0;
            this.group_swich_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.group_swich_btn.Font = new System.Drawing.Font("Modern No. 20", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_swich_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.group_swich_btn.Location = new System.Drawing.Point(170, 14);
            this.group_swich_btn.Name = "group_swich_btn";
            this.group_swich_btn.Size = new System.Drawing.Size(86, 29);
            this.group_swich_btn.TabIndex = 14;
            this.group_swich_btn.Text = "Group";
            this.group_swich_btn.UseVisualStyleBackColor = true;
            this.group_swich_btn.Click += new System.EventHandler(this.group_swich_btn_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Modern No. 20", 16.1194F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.NameLabel.Location = new System.Drawing.Point(68, 15);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(84, 31);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Name";
            // 
            // control_panel
            // 
            this.control_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.control_panel.Controls.Add(this.NameLabel);
            this.control_panel.Controls.Add(this.Setting_menu);
            this.control_panel.Controls.Add(this.circlePicture_box1);
            this.control_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.control_panel.Location = new System.Drawing.Point(0, 0);
            this.control_panel.Name = "control_panel";
            this.control_panel.Size = new System.Drawing.Size(1480, 60);
            this.control_panel.TabIndex = 3;
            // 
            // Setting_menu
            // 
            this.Setting_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Setting_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Setting_menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.Setting_menu.Image = global::AniChat.Properties.Resources.setting_icon;
            this.Setting_menu.Location = new System.Drawing.Point(1422, 0);
            this.Setting_menu.Name = "Setting_menu";
            this.Setting_menu.Size = new System.Drawing.Size(58, 60);
            this.Setting_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Setting_menu.TabIndex = 7;
            this.Setting_menu.TabStop = false;
            this.Setting_menu.Click += new System.EventHandler(this.Setting_menu_Click);
            // 
            // circlePicture_box1
            // 
            this.circlePicture_box1.Image = ((System.Drawing.Image)(resources.GetObject("circlePicture_box1.Image")));
            this.circlePicture_box1.Location = new System.Drawing.Point(12, 4);
            this.circlePicture_box1.Name = "circlePicture_box1";
            this.circlePicture_box1.Size = new System.Drawing.Size(50, 50);
            this.circlePicture_box1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circlePicture_box1.TabIndex = 6;
            this.circlePicture_box1.TabStop = false;
            // 
            // panel_form_out
            // 
            this.panel_form_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel_form_out.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_form_out.BackgroundImage")));
            this.panel_form_out.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_form_out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_form_out.Location = new System.Drawing.Point(350, 60);
            this.panel_form_out.Name = "panel_form_out";
            this.panel_form_out.Size = new System.Drawing.Size(1130, 788);
            this.panel_form_out.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(134F, 134F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1480, 848);
            this.Controls.Add(this.panel_form_out);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.control_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AniChat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.SizeChanged += new System.EventHandler(this.mainForm_SizeChanged);
            this.panel_Menu.ResumeLayout(false);
            this.Swich_list_panel.ResumeLayout(false);
            this.Swich_list_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.control_panel.ResumeLayout(false);
            this.control_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Setting_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circlePicture_box1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_form_out;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Panel control_panel;
        private System.Windows.Forms.Label NameLabel;
        private CirclePicture_box circlePicture_box1;
        private CirclePicture_box Setting_menu;
        private System.Windows.Forms.FlowLayoutPanel ContactListPanel;
        private System.Windows.Forms.Panel Swich_list_panel;
        private System.Windows.Forms.TextBox Search_tb;
        private System.Windows.Forms.Panel underscore_Group_pl;
        private System.Windows.Forms.Panel underscore_Contact_pl;
        private System.Windows.Forms.Button AddGroupBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button contact_swich_btn;
        private System.Windows.Forms.Button group_swich_btn;
        private System.Windows.Forms.Button GPTBot_btn;
    }
}

