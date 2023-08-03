using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeyRed.Mime;

namespace AniChat
{
    public partial class MessageBoxUser_ctrl : UserControl
    {
        PictureBox loadSignpicBox = new PictureBox();
        string pathtofile = (Application.StartupPath).Substring(0, (Application.StartupPath).IndexOf("AniChat"));
        public Color BgColor { get; set; }
        public MessageBoxUser_ctrl(string username, string time, DockStyle dock, Color bgcolor)
        {
            InitializeComponent();
            panel1.Padding = new Padding(10, 0, 10, 0);
            panel1.Dock = dock;
            panel1.AutoSize = false;
            panel1.Width = Width / 3;
            panel1.BackColor = bgcolor;
            panel1.BorderColor = bgcolor;
            panel1.BorderFocusColor = bgcolor;
            BgColor = bgcolor;
            //panel1.Paint += new PaintEventHandler(panel1_Paint);
            Padding = new Padding(0, 5, 0, 5);

            int index = (Application.StartupPath).IndexOf("AniChat");
            string pathtofileIcon = (Application.StartupPath).Substring(0, index) + "Images\\DownloadSign.png";

            loadSignpicBox.Image = Image.FromFile(pathtofileIcon);
            loadSignpicBox.SizeMode = PictureBoxSizeMode.Zoom;
            loadSignpicBox.Dock = DockStyle.Top;
            loadSignpicBox.Visible = false;
            loadSignpicBox.MouseClick += LoadSignpicBox_MouseClick;

            lb_Name.Text = username;
            lb_Name.ForeColor = Color.Yellow;
            lb_Name.SendToBack();

            lb_Time.Text = time.Substring(0, 5);
            lb_Time.SendToBack();
        }

        public int MessID { get; set; }

        public string FileName { get; set; }

        public void Message(string text)
        {
            RichTextBox richTextBox = new RichTextBox();
            richTextBox.LinkClicked += new LinkClickedEventHandler(this.richTextBox_LinkClicked);
            richTextBox.AutoSize = false;
            richTextBox.Multiline = true;
            richTextBox.ReadOnly = true;
            richTextBox.Dock = DockStyle.Fill;
            richTextBox.BorderStyle = BorderStyle.None;
            richTextBox.ForeColor = Color.White;
            richTextBox.BackColor = panel1.BackColor;
            richTextBox.Font = new Font("Arial Unicode MS", 11, FontStyle.Regular);


            richTextBox.Text = text;
            AutoSizeTextMessBox(richTextBox.Text, richTextBox.Font);

            if (panel1.Width >= 600)
            {
                bool newLine = true;
                string output = "";

                for (int i = 0; i < richTextBox.Text.Length; i++)
                {
                    if (richTextBox.Text[i] == '\n')
                    {
                        newLine = false;
                    }
                    if (i != 0 && i % 70 == 0 && newLine)
                    {
                        output += '\n';
                        newLine = true;
                    }
                    output += richTextBox.Text[i];
                }

                AutoSizeTextMessBox(output, richTextBox.Font);
            }

            panel1.Controls.Add(richTextBox);

            richTextBox.BringToFront();
        }

        private void AutoSizeTextMessBox(string txt, Font font)
        {
            const int x_margin = 20;
            const int y_margin = 60;

            Size size = TextRenderer.MeasureText(txt, font);

            if (size.Width <= 120)
            {
                size.Width = 120;
            }

            panel1.Width = size.Width + x_margin;
            Height = size.Height + y_margin;

            //txt.ClientSize =
            //    new Size(size.Width + x_margin, size.Height + y_margin);
        }

        // Event raised from RichTextBox when user clicks on a link:
        private void richTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            LaunchWeblink(e.LinkText);
        }

        // Performs the actual browser launch to follow link:
        private void LaunchWeblink(string url)
        {
            if (IsHttpURL(url)) Process.Start(url);
        }

        // Simple check to make sure link is valid,
        // can be modified to check for other protocols:
        private bool IsHttpURL(string url)
        {
            return
                ((!string.IsNullOrWhiteSpace(url)) &&
                (url.ToLower().StartsWith("http")));
        }

        public async void VoiceMessage(string filename)
        {
            FileName = filename;//"test.mp3"

            string ext = Path.GetExtension(this.FileName);//".mp3"
            string finalpath = pathtofile + "temp\\" + Path.GetFileNameWithoutExtension(filename) + "_" + MessID.ToString();//"...\\test_MessID"
            
            if (!File.Exists(finalpath + ext)) //"..\\test_MessID.mp3"
            {
                await Task.Run(() => SaveFile(finalpath, Path.GetDirectoryName(finalpath)));
            }

            VoiceMessage voiceMessage = new VoiceMessage(finalpath + ext);
            voiceMessage.Dock = DockStyle.Fill;
            voiceMessage.BackColor = BgColor;
            panel1.Width = 350;
            Height = 150;
            panel1.Controls.Add(voiceMessage);
            voiceMessage.BringToFront();

            //Recognizer recognizer = new Recognizer();
            //var text = recognizer.Recognition(finalpath + ext);
        }

        public void FileMessage(string filename)
        {
            panel1.Width = 300;
            Height = 150;

            FileName = filename;

            string fileSize = GetFileSizeValue();

            string pathtofileIcon = GetFileIconImage(filename);

            PictureBox pictureBox = new PictureBox();
            
            pictureBox.Width = 60;
            pictureBox.Margin = new Padding(10, 0, 10, 0);
            pictureBox.Image = Image.FromFile(pathtofileIcon);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            if (panel1.Dock == DockStyle.Left)
            {
                pictureBox.Dock = panel1.Dock;
            }
            else
            {
                pictureBox.Dock = DockStyle.Left;
            }

            panel1.Controls.Add(pictureBox);


            Label fileSize_lb = new Label();
            fileSize_lb.Text = fileSize;
            fileSize_lb.TextAlign = ContentAlignment.MiddleCenter;

            fileSize_lb.ForeColor = Color.Black;
            fileSize_lb.BackColor = Color.GhostWhite;
            fileSize_lb.Font = new Font("Arial Unicode MS", 8, FontStyle.Bold);
            fileSize_lb.Dock = DockStyle.Bottom;

            pictureBox.Controls.Add(fileSize_lb);

            pictureBox.MouseEnter += loadSignpicBox_MouseEnter;
            loadSignpicBox.MouseLeave += loadSignpicBox_MouseLeave;
            loadSignpicBox.Dock = DockStyle.Fill;
            pictureBox.Controls.Add(loadSignpicBox);

            Label filename_lb = new Label();
            filename_lb.Text = filename;
            filename_lb.TextAlign = ContentAlignment.MiddleLeft;
            filename_lb.ForeColor = Color.White;
            filename_lb.Font = new Font("Arial Unicode MS", 10, FontStyle.Regular);
            filename_lb.Dock = DockStyle.Fill;

            panel1.Controls.Add(filename_lb);

            pictureBox.BringToFront();
            filename_lb.BringToFront();
        }

        private string GetFileSizeValue()
        {
            DataTable dataTable = Info.SelectFromDB($"SELECT LENGTH(`File`) FROM `chat_history` WHERE `IdHis` = {MessID};");
            double size = Double.Parse(dataTable.Rows[0][0].ToString());//in KB
            int count = 0;
            while (size > 1024 && count < 2)
            {
                size = size / 1024;
                count++;
            }
            string sizename = "B";
            switch (count)
            {
                case 1: sizename = "KB"; break;
                case 2: sizename = "MB"; break;
                case 3: sizename = "GB"; break;
                default:
                    break;
            }
            return size.ToString("0.0") + sizename;
        }

        private string GetFileIconImage(string filename)
        {
            string pathtofileIcon = pathtofile + "Images\\";

            string fileType = MimeTypesMap.GetMimeType(filename);

            if (fileType.Contains("image"))
            {
                pathtofileIcon += "ImageFileIcon.png";
            }
            else if (fileType.Contains("audio"))
            {
                pathtofileIcon += "AudioFileIcon.png";
            }
            else if (fileType.Contains("video"))
            {
                pathtofileIcon += "VideoFileIcon.png";
            }
            else
            {
                pathtofileIcon += "TxtFileIcon.png";
            }

            return pathtofileIcon;
        }

        private async void LoadSignpicBox_MouseClick(object sender, MouseEventArgs e)
        {
            SaveFileDialog saveFileDlg = new SaveFileDialog();
            saveFileDlg.FileName = Path.GetFileNameWithoutExtension(this.FileName);//"newfile";

            //saveFileDlg.Filter = "(*.png)|*.*";
            if (saveFileDlg.ShowDialog() != DialogResult.OK) return;

            string filePath = saveFileDlg.FileName;
            string directoryPath = Path.GetDirectoryName(filePath);

            await Task.Run(() => SaveFile(filePath, directoryPath));
        }

        private void SaveFile(string filePath, string directoryPath)
        {
            byte[] fileData = null;
            string ext = Path.GetExtension(this.FileName);
            string savePath = Path.Combine(directoryPath, filePath + ext);

            fileData = Info.DownloadFileFromDB($"SELECT `File` FROM `chat_history` WHERE `IdHis` = {this.MessID};");

            if (fileData.Equals(null)) return;

            File.WriteAllBytes(savePath, fileData);
        }

        private void loadSignpicBox_MouseEnter(object sender, EventArgs e)
        {
            loadSignpicBox.Visible = true;
        }

        private void loadSignpicBox_MouseLeave(object sender, EventArgs e)
        {
            loadSignpicBox.Visible = false;
        }

    }
}