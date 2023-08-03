using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;

namespace AniChat
{
    public partial class VoiceMessage : UserControl
    {
        string pathtofileIcon = (Application.StartupPath).Substring(0, (Application.StartupPath).IndexOf("AniChat")) + "Images\\";
        AxWindowsMediaPlayer player = null;
        public VoiceMessage(string path)
        {
            Path = path;
            InitializeComponent();
        }

        public string Path { get; set; }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player == null) return;

            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying && player.playState != WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                timeline_pB.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                timeline_pB.Value = (int)player.Ctlcontrols.currentPosition;

                currentTime_lb.Text = player.Ctlcontrols.currentPositionString;
                endTime_lb.Text = player.Ctlcontrols.currentItem.durationString;
            }
        }

        private void playPause_btn_Click(object sender, EventArgs e)
        {
            if(player == null)
            {
                player = new AxWindowsMediaPlayer();
                player.PlayStateChange += Player_PlayStateChange;

                Controls.Add(player);
                player.uiMode = "invisible";
                player.URL = Path;
                player.Ctlcontrols.stop();
                timeLine_pl.Visible = true;
            }

            if (soundAnim_picb.Enabled)
            {
                playPause_btn.BackgroundImage = Image.FromFile(pathtofileIcon + "PlayButton.png");
                soundAnim_picb.Enabled = false;
                timer1.Stop();
                player.Ctlcontrols.pause();
            }
            else
            {
                playPause_btn.BackgroundImage = Image.FromFile(pathtofileIcon + "PauseButton.png");
                soundAnim_picb.Enabled = true;
                timer1.Start();
                player.Ctlcontrols.play();
            }
            
        }

        private void Player_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            if ((WMPLib.WMPPlayState)e.newState == WMPLib.WMPPlayState.wmppsStopped)
            {
                soundAnim_picb.Enabled = false;
            }
        }

        private void timeline_pB_MouseDown(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / timeline_pB.Width;
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying) return;
            
            playPause_btn.BackgroundImage = Image.FromFile(pathtofileIcon + "PauseButton.png");
            soundAnim_picb.Enabled = true;
            timer1.Start();
            player.Ctlcontrols.play();
        }
    }
}
