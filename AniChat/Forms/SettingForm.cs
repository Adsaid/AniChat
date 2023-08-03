using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AniChat
{
    public partial class SettingForm : Form
    {
        string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]*$";

        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            validErr_lb.Visible = false;
            isSave_lb.Visible = false;
            LoadBio();
        }

        private async void changepass_btn_Click(object sender, EventArgs e)
        {
            validErr_lb.ForeColor = Color.Red;

            if (String.IsNullOrWhiteSpace(pass_tb.Text))
            {
                ShowErr("Поле 'Password' не заповнене !");
                return;
            }
            if (!Regex.IsMatch(pass_tb.Text, pattern))
            {
                ShowErr("Поле 'Password' повинно містити \n великі, малі літери та цифри!");
                return;
            }
            if (!String.Equals(pass_tb.Text, repeatpass_tb.Text))
            {
                validErr_lb.Visible = true;
                validErr_lb.Text = "'Password' та 'Repeat' не співпадають !";
                return;
            }

            string sqlcmd = $"UPDATE Chat_Users SET Password = '{ Info.EncriptedPassword(pass_tb.Text)}' WHERE idChat_Users = '{ Info.idUser}' ;";
            await Task.Run(() => Info.InsertToDB(sqlcmd));

            validErr_lb.Visible = true;
            validErr_lb.ForeColor = Color.YellowGreen;
            validErr_lb.Text = "Your password has been changed !";
        }

        private void ShowErr(string errtext)
        {
            validErr_lb.Visible = true;
            validErr_lb.Text = errtext;
        }

        private async Task Load_FotoProfile()
        {
            byte[] b_data = await Task.Run(() => Info.DownloadFileFromDB($"SELECT Foto FROM Chat_Users where idChat_Users = '{Info.idUser}' "));
            if (b_data != null)
            {
                using (MemoryStream memImage = new MemoryStream(b_data))
                {
                    userImage_pb.Image = Image.FromStream(memImage);
                }
            }
        }

        private async void LoadBio()
        {
            await Load_FotoProfile();
            name_lb.Text = Info.nameUser;
            rank_tb.Text = Info.Rank;
            gitHub_tb.Text = Info.GitLink;
            linkedIn_tb.Text = Info.InLink;
        }

        private async void ChangeBio()
        {
            string sqlcmd = "UPDATE Chat_Users SET " +
                $"Rank = '{rank_tb.Text}', Gitlink = '{gitHub_tb.Text}', Inlink = '{linkedIn_tb.Text}' " +
                $"WHERE idChat_Users = '{Info.idUser}' ;";

            await Task.Run(() => Info.InsertToDB(sqlcmd));

            Info.Rank = rank_tb.Text;
            Info.GitLink = gitHub_tb.Text;
            Info.InLink = linkedIn_tb.Text;
        }

        private void changeBio_btn_Click(object sender, EventArgs e)
        {
            isSave_lb.Visible = false;
            isSave_lb.Text = String.Empty;

            ChangeBio();

            isSave_lb.Visible = true;
            isSave_lb.ForeColor = Color.YellowGreen;
            isSave_lb.Text = "Your bio has been changed !";
        }

        private async void userImage_pb_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Виберіть файл";
            openFileDialog1.Filter = "img files (*.png)|*.png|img files (*.jpg)|*.jpg|bmp file (*.bmp)|*.bmp|All files (*.*)|*.*";
            openFileDialog1.InitialDirectory = Application.StartupPath;

            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            Info.pathToFoto = openFileDialog1.FileName;
            userImage_pb.Image = Image.FromFile(Info.pathToFoto);
            

            string sqlStr = $"Update Chat_Users set Foto = @File where idChat_Users = '{Info.idUser}' ";
            await Task.Run( () => Info.UploadFileToDB(Info.pathToFoto, sqlStr));
        }


    }
}
