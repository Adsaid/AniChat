using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using AniChat.AniService;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Data;
using System.Diagnostics;
using System.IO;

namespace AniChat
{
    public partial class ChatForm : Form, IServiceAniChatCallback
    {
        ServiceAniChatClient client;
        private bool isUserConn = false;
        string chat_name;
        int ID;
        int contact_id;

        private bool isVoiseMsg = false;
        private Recorder recorder;
        private VoiceMessage voiceCtr;
        private Button cansel_btn;
        private Button stop_btn;
        string pathtofile = (Application.StartupPath).Substring(0, (Application.StartupPath).IndexOf("AniChat"));

        Label currentTime_lb = null;
        Stopwatch timecount = new Stopwatch();

        public ChatForm(Image image, string name, int contact_id)
        {
            InitializeComponent();
            this.contact_id = contact_id;
            circlePicture_Userbox.Image = image;
            NameLabel.Text = name;
            Msgbox_panel.AutoScroll = true;

            Msgbox_panel.DragEnter += Msgbox_panel_DragEnter;
            Msgbox_panel.DragLeave += Msgbox_panel_DragLeave;
            Msgbox_panel.DragOver += Msgbox_panel_DragOver;
            Msgbox_panel.DragDrop += Msgbox_panel_DragDrop;
        }

        private void Msgbox_panel_DragDrop(object sender, DragEventArgs e)
        {
            List<string> paths = new List<string>();

            foreach (string obj in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                if (Directory.Exists(obj))
                {
                    paths.AddRange(Directory.GetFiles(obj, "*.*", SearchOption.AllDirectories));
                }
                else
                    paths.Add(obj);
            }
            foreach (string path in paths)
            {
                SendFile(path);
            }
        }

        private void Msgbox_panel_DragOver(object sender, DragEventArgs e)
        {
            Point cursorPos = Msgbox_panel.PointToClient(new Point(e.X, e.Y));

            if (!Msgbox_panel.ClientRectangle.Contains(cursorPos))
            {
                // The cursor is outside the FlowLayoutPanel, so trigger DragLeave
                Msgbox_panel_DragLeave(sender, e);
            }
        }

        private void Msgbox_panel_DragLeave(object sender, EventArgs e)
        {
            Point cursorPos = Msgbox_panel.PointToClient(Cursor.Position);
            if (Msgbox_panel.ClientRectangle.Contains(cursorPos))
            {
                // The cursor is still within the bounds, so don't trigger DragLeave
                return;
            }
        }

        private void Msgbox_panel_DragEnter(object sender, DragEventArgs e)
        {
            // Check if the cursor is insaid area of the FlowLayoutPanel
            Point cursorPos = Msgbox_panel.PointToClient(new Point(e.X, e.Y));
            Rectangle middleArea = new Rectangle(Msgbox_panel.Location.X, Msgbox_panel.Location.Y, Msgbox_panel.Width, Msgbox_panel.Height);

            if (!middleArea.Contains(cursorPos) && e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private async void ChatForm1_Load(object sender, EventArgs e)
        {
            MsgTextbox.Visible = true;
            chat_name = this.Name;

            client = new ServiceAniChatClient(new System.ServiceModel.InstanceContext(this));

            if (isUserConn)
            {
                DisconnectUser();
            }
            else
            {
                ConnectUser();

                //History Load
                await GetHistory();
            }

            send_pl.Visible = true;
            message_pl.Visible = true;
        }
        public void MsgCallback(string msg)
        {
            var json = JObject.Parse(msg);

            int messID = Int32.Parse(json["messID"].ToString());
            string time = DateTime.Now.ToShortTimeString();
            string username = json["username"].ToString();
            string textmess = json["message"].ToString();
            string filename = json["filename"].ToString();

            AddMess(messID, time, username, textmess, filename);

            ScrolltoLastItem();
        }

        private void ScrolltoLastItem()
        {
            if (Msgbox_panel.Controls.Count.Equals(0)) return;

            int last_index = Msgbox_panel.Controls.Count - 1;
            Msgbox_panel.Controls[last_index].Focus();
            MsgTextbox.Focus();
        }

        private void AddMess(int messID ,string time, string username, string textmess, string filename)
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
        }

        public void ConnectUser()
        {
            if (!isUserConn)
            {
                
                try
                {
                    ID = client.Connect(Info.nameUser, chat_name);
                    isUserConn = true;
                }
                catch
                {
                    MessageBox.Show("Неможливо з'єднатися Host недоступний!",
                        "Помилка з'єднання", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MsgTextbox.Visible = false;
                }
            }
        }

        public void DisconnectUser()
        {
            try
            {
                if (isUserConn)
                {
                    client.Disconnect(ID, chat_name);
                    isUserConn = false;
                }
            }
            catch (System.ServiceModel.CommunicationObjectFaultedException ex)
            {
                //ReconnectUser();
                MessageBox.Show(ex.ToString());
            }
        }
        //public void ReconnectUser()
        //{
        //    client.Close();
        //    isUserConn = false;
        //    client = new ServiceAniChatClient(new System.ServiceModel.InstanceContext(this));
        //    ConnectUser();
        //}

        private void MsgTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift == true && e.KeyCode == Keys.Enter)
            {
                btn_Send.PerformClick();
            }
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (isVoiseMsg)
            {
                isVoiseMsg = false;

                SendFile(voiceCtr.Path);
                Set_default_msgpanel_view();

                return;
            }

            if (string.IsNullOrWhiteSpace(MsgTextbox.Text))
                return;

            string text = MsgTextbox.Text;
            string time = DateTime.Now.ToShortTimeString();

            int messID = SetHistory(text, String.Empty, time);

            string Jmessage = $"'messID':'{messID}','message':'{text}','filename':'{String.Empty}','time':'{time}'";

            client.SendMsg(Jmessage, ID, chat_name);

            MsgTextbox.Clear();
            MsgTextbox.Focus();
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            string Openfilepath = OpenFile();
            SendFile(Openfilepath);
        }

        private void SendFile(string path)
        {
            string time = DateTime.Now.ToShortTimeString();
            string filenameWithEx = Path.GetFileName(path);

            if (filenameWithEx == String.Empty) return;

            int messID = SetHistory(String.Empty, path, time);

            string Jmessage = $"'messID':'{messID}','message':'{String.Empty}','filename':'{filenameWithEx}','time':'{time}'";

            client.SendMsg(Jmessage, ID, chat_name);
        }

        private string OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }

            return string.Empty;
        }

        private void ChatForm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string comm = "UPDATE `user_in_contact` SET `newMessNum` = 0 " +
             $"WHERE `userId` = {Info.idUser} AND `contactUserId` = {contact_id};";
            Task.Run(() => Info.InsertToDB(comm));

            DisconnectUser();
            isUserConn = false;
        }

        private int SetHistory(string text,string pathToFile, string time)
        {
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");

            string insertCommand =
                "INSERT INTO `chat_history` (`MFrom`, `MTo`, `Text`, `Date`, `Time`) " +
                $"VALUES ('{Info.nameUser}', '{chat_name}', '{text}', '{currentDate}', '{time}'); SELECT LAST_INSERT_ID();";

            int id = Info.InsertToDB(insertCommand);

            string updateCommand = $"UPDATE `user_in_contact` SET `newMessNum` = `newMessNum` + 1 " +
                                   $"WHERE `userId` = {contact_id} AND `contactUserId` = {Info.idUser};";

            Task.Run(() => Info.InsertToDB(updateCommand));

            if (pathToFile != null && !string.IsNullOrWhiteSpace(pathToFile))
            {
                string fileUpdateCommand = $"UPDATE `chat_history` SET `File`= @File,`Name`= @Filename,`Extension`= @Extension WHERE `IdHis` = '{id}'";
                Task.Run(() => Info.UploadFileToDB(pathToFile, fileUpdateCommand));
            }

            return id;
        }

        private async Task GetHistory()
        {
            string selectCommand = "SELECT `IdHis`,`MFrom`,`Text`,`Name`,`Extension`,`Date`,`Time` " +
                           $"FROM `chat_history` WHERE `MTo` = '{chat_name}' ORDER BY `Date`, `Time`";

            DataTable dthistory = await Task.Run(() => Info.SelectFromDB(selectCommand));

            if (dthistory != null)
            {
                foreach (DataRow row in dthistory.Rows)
                {
                    AddMess(
                        Int32.Parse(row["IdHis"].ToString()),
                        row["Time"].ToString(),
                        row["MFrom"].ToString(),
                        row["Text"].ToString(),
                        row["Name"].ToString() + row["Extension"].ToString()
                    );
                }
            }

            Msgbox_panel.Visible = true;
            ScrolltoLastItem();
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
            }));
        }

        private void microphone_btn_Click(object sender, EventArgs e)
        {  
            message_pl.Controls.Remove(btnSendFile);
            message_pl.Controls.Remove(microphone_btn);

            recorder = new Recorder();
            btn_Send.Visible = false;
            MsgTextbox.Enabled = false;
            MsgTextbox.Text = "Recording...";

            stop_btn = new Button();
            stop_btn.Dock = DockStyle.Left;
            stop_btn.Size = new Size(40, 55);
            stop_btn.BackgroundImage = Image.FromFile(pathtofile + "Images\\stopButtonicon.png");
            stop_btn.BackgroundImageLayout = ImageLayout.Zoom;
            stop_btn.FlatStyle = FlatStyle.Flat;
            stop_btn.FlatAppearance.BorderSize = 0;
            stop_btn.Click += stop_btn_Click;

            message_pl.Controls.Add(stop_btn);

            currentTime_lb = new Label();
            currentTime_lb.Text = "00:00";
            currentTime_lb.ForeColor = Color.White;
            currentTime_lb.TextAlign = ContentAlignment.MiddleRight;
            currentTime_lb.Width = 40;
            currentTime_lb.Dock = DockStyle.Right;

            message_pl.Controls.Add(currentTime_lb);

            timer1.Start();
            timecount.Start();
            recorder.StartRecording(pathtofile + "temp\\soundmessage.mp3");

        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            if (currentTime_lb != null) currentTime_lb.Dispose();

            recorder.StopRecording();
            timer1.Stop();
            timecount.Reset();

            message_pl.Controls.Remove(stop_btn);
            stop_btn.Dispose();

            message_pl.Controls.Remove(MsgTextbox);

            cansel_btn = new Button();
            cansel_btn.Dock = DockStyle.Right;
            cansel_btn.Size = new Size(40,55);
            cansel_btn.BackgroundImage = Image.FromFile(pathtofile + "Images\\cross-mark2.png");
            cansel_btn.BackgroundImageLayout = ImageLayout.Zoom;
            cansel_btn.FlatStyle = FlatStyle.Flat;
            cansel_btn.FlatAppearance.BorderSize = 0;
            cansel_btn.BackColor = Color.Transparent;
            cansel_btn.Click += Cansel_btn_Click;

            message_pl.Controls.Add(cansel_btn);

            cansel_btn.BringToFront();

            voiceCtr = new VoiceMessage(pathtofile + "temp\\soundmessage.mp3");

            message_pl.Controls.Add(voiceCtr);
            voiceCtr.Dock = DockStyle.Fill;
            voiceCtr.BringToFront();

            isVoiseMsg = true;
            btn_Send.Visible = true;
        }

        private void Cansel_btn_Click(object sender, EventArgs e)
        {
            Set_default_msgpanel_view();
        }

        private void Set_default_msgpanel_view()
        {
            isVoiseMsg = false;
            message_pl.Controls.Clear();
            voiceCtr.Dispose();
            
            MsgTextbox.Enabled = true;
            MsgTextbox.Visible = true;
            MsgTextbox.Text = String.Empty;
            message_pl.Controls.Add(MsgTextbox);
            message_pl.Controls.Add(microphone_btn);
            message_pl.Controls.Add(btnSendFile);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = timecount.Elapsed;
            currentTime_lb.Text = String.Format("{0:00}:{1:00}", elapsed.Minutes, elapsed.Seconds);
        }
    }
}
