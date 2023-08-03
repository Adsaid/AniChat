namespace AniChat
{
    partial class VoiceMessage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoiceMessage));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeline_pB = new System.Windows.Forms.ProgressBar();
            this.currentTime_lb = new System.Windows.Forms.Label();
            this.endTime_lb = new System.Windows.Forms.Label();
            this.playPause_btn = new System.Windows.Forms.Button();
            this.soundAnim_picb = new System.Windows.Forms.PictureBox();
            this.timeLine_pl = new System.Windows.Forms.Panel();
            this.customPanel1 = new AniChat.CustomPanel();
            ((System.ComponentModel.ISupportInitialize)(this.soundAnim_picb)).BeginInit();
            this.timeLine_pl.SuspendLayout();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeline_pB
            // 
            this.timeline_pB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timeline_pB.Dock = System.Windows.Forms.DockStyle.Top;
            this.timeline_pB.Location = new System.Drawing.Point(38, 0);
            this.timeline_pB.Name = "timeline_pB";
            this.timeline_pB.Size = new System.Drawing.Size(260, 8);
            this.timeline_pB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.timeline_pB.TabIndex = 1;
            this.timeline_pB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.timeline_pB_MouseDown);
            // 
            // currentTime_lb
            // 
            this.currentTime_lb.AutoSize = true;
            this.currentTime_lb.Dock = System.Windows.Forms.DockStyle.Left;
            this.currentTime_lb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.currentTime_lb.Location = new System.Drawing.Point(0, 0);
            this.currentTime_lb.Name = "currentTime_lb";
            this.currentTime_lb.Size = new System.Drawing.Size(38, 16);
            this.currentTime_lb.TabIndex = 2;
            this.currentTime_lb.Text = "00:00";
            // 
            // endTime_lb
            // 
            this.endTime_lb.AutoSize = true;
            this.endTime_lb.Dock = System.Windows.Forms.DockStyle.Right;
            this.endTime_lb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.endTime_lb.Location = new System.Drawing.Point(298, 0);
            this.endTime_lb.Name = "endTime_lb";
            this.endTime_lb.Size = new System.Drawing.Size(38, 16);
            this.endTime_lb.TabIndex = 3;
            this.endTime_lb.Text = "00:00";
            // 
            // playPause_btn
            // 
            this.playPause_btn.BackColor = System.Drawing.Color.Black;
            this.playPause_btn.BackgroundImage = global::AniChat.Properties.Resources.PlayButton;
            this.playPause_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playPause_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playPause_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.playPause_btn.FlatAppearance.BorderSize = 0;
            this.playPause_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playPause_btn.Location = new System.Drawing.Point(10, 10);
            this.playPause_btn.Name = "playPause_btn";
            this.playPause_btn.Size = new System.Drawing.Size(50, 77);
            this.playPause_btn.TabIndex = 6;
            this.playPause_btn.UseVisualStyleBackColor = false;
            this.playPause_btn.Click += new System.EventHandler(this.playPause_btn_Click);
            // 
            // soundAnim_picb
            // 
            this.soundAnim_picb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soundAnim_picb.Enabled = false;
            this.soundAnim_picb.Image = ((System.Drawing.Image)(resources.GetObject("soundAnim_picb.Image")));
            this.soundAnim_picb.Location = new System.Drawing.Point(60, 10);
            this.soundAnim_picb.Margin = new System.Windows.Forms.Padding(0);
            this.soundAnim_picb.Name = "soundAnim_picb";
            this.soundAnim_picb.Size = new System.Drawing.Size(336, 61);
            this.soundAnim_picb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.soundAnim_picb.TabIndex = 4;
            this.soundAnim_picb.TabStop = false;
            // 
            // timeLine_pl
            // 
            this.timeLine_pl.BackColor = System.Drawing.Color.Black;
            this.timeLine_pl.Controls.Add(this.timeline_pB);
            this.timeLine_pl.Controls.Add(this.currentTime_lb);
            this.timeLine_pl.Controls.Add(this.endTime_lb);
            this.timeLine_pl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.timeLine_pl.Location = new System.Drawing.Point(60, 71);
            this.timeLine_pl.Margin = new System.Windows.Forms.Padding(0);
            this.timeLine_pl.Name = "timeLine_pl";
            this.timeLine_pl.Size = new System.Drawing.Size(336, 16);
            this.timeLine_pl.TabIndex = 5;
            this.timeLine_pl.Visible = false;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.Black;
            this.customPanel1.BorderColor = System.Drawing.Color.Black;
            this.customPanel1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel1.BorderRadius = 10;
            this.customPanel1.BorderSize = 2;
            this.customPanel1.Controls.Add(this.soundAnim_picb);
            this.customPanel1.Controls.Add(this.timeLine_pl);
            this.customPanel1.Controls.Add(this.playPause_btn);
            this.customPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPanel1.Location = new System.Drawing.Point(5, 5);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.customPanel1.Size = new System.Drawing.Size(406, 97);
            this.customPanel1.TabIndex = 7;
            this.customPanel1.UnderlinedStyle = false;
            // 
            // VoiceMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(134F, 134F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.customPanel1);
            this.Name = "VoiceMessage";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(416, 107);
            ((System.ComponentModel.ISupportInitialize)(this.soundAnim_picb)).EndInit();
            this.timeLine_pl.ResumeLayout(false);
            this.timeLine_pl.PerformLayout();
            this.customPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar timeline_pB;
        private System.Windows.Forms.Label currentTime_lb;
        private System.Windows.Forms.Label endTime_lb;
        private System.Windows.Forms.PictureBox soundAnim_picb;
        private System.Windows.Forms.Button playPause_btn;
        private System.Windows.Forms.Panel timeLine_pl;
        private CustomPanel customPanel1;
    }
}
