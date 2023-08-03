using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniChat
{
    public partial class BotsForm : Form
    {
        string apiKey = "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";
        ChatGPTClient chatGPTClient = null;
        int Id = 0;
        public BotsForm(string name)
        {
            InitializeComponent();
            NameLabel.Text = name;
        }

        private void BotsForm_Load(object sender, EventArgs e)
        {
           chatGPTClient = new ChatGPTClient(apiKey);
        }

        private async void btn_Send_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MsgTextbox.Text))
                return;

            string msg = MsgTextbox.Text;

            AddMess(Id++, DateTime.Now.ToShortTimeString(), Info.nameUser, msg, String.Empty);

            MsgTextbox.Clear();

            if (chatGPTClient == null)
                return;

            string response = await Task.Run(() => chatGPTClient.SendMessage(msg));

            AddMess(Id++, DateTime.Now.ToShortTimeString(), "ChatGPT", response, String.Empty);

            MsgTextbox.Focus();

        }

        private void MsgTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift == true && e.KeyCode == Keys.Enter)
            {
                btn_Send.PerformClick();
            }
        }

        private void AddMess(int messID, string time, string username, string textmess, string filename)
        {
            MessageBoxUser_ctrl msgBox = null;

            if (username.Equals(Info.nameUser))
            {
                msgBox = new MessageBoxUser_ctrl(String.Empty, time, DockStyle.Right, Color.FromArgb(2, 160, 255));
                msgBox.MessID = messID;

                CtrMessProp(textmess, filename, msgBox);
            }
            else
            {
                msgBox = new MessageBoxUser_ctrl(username, time, DockStyle.Left, Color.FromArgb(45, 45, 45));
                msgBox.MessID = messID;

                CtrMessProp(textmess, filename, msgBox);
            }
        }

        private void CtrMessProp(string textmess, string filename, MessageBoxUser_ctrl msgBox)
        {

            msgBox.Width = Msgbox_panel.Width - 50;

            //Text message
            if (textmess != String.Empty && filename == String.Empty)
                msgBox.Message(textmess);

            //Voice message
            else if (filename == "soundmessage.mp3")
                msgBox.VoiceMessage(filename);

            //File message
            else
                msgBox.FileMessage(filename);

            Msgbox_panel.Controls.Add(msgBox);
            ScrolltoLastItem();
        }

        private void ScrolltoLastItem()
        {
            if (Msgbox_panel.Controls.Count.Equals(0)) return;

            int last_index = Msgbox_panel.Controls.Count - 1;
            Msgbox_panel.Controls[last_index].Focus();
            MsgTextbox.Focus();
        }

        private async void Msgbox_panel_SizeChanged(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                Parallel.ForEach(Msgbox_panel.Controls.OfType<MessageBoxUser_ctrl>(), (msgBox) =>
                {
                    Invoke((MethodInvoker)(() =>
                    {
                        msgBox.Width = ((Panel)sender).Width - 50;
                    }));
                });
            });

            Invoke((MethodInvoker)(() =>
            {
                Msgbox_panel.HorizontalScroll.Maximum = 0;
                Msgbox_panel.PerformLayout();
                message_pl.PerformLayout();
            }));
        }
    }
}
