using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniChat
{
    public partial class RetrievePassForm : Form
    {
        string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]*$";

        LogIn logIn = null;
        string email;
        string code;

        public RetrievePassForm(LogIn logIn, string email)
        {
            InitializeComponent();

            this.logIn = logIn;
            this.email = email;
        }

        private async void RetrievePassForm_Load(object sender, EventArgs e)
        {
            Email_lb.Text = email;
            retrievePass_pl.Visible = false;
            this.Height = 200;
            await Task.Run(() => SendCodetoEmail());
        }

        private void SendCodetoEmail()
        {
            SmtpEmail sendEmail = new SmtpEmail();

            Random rnd = new Random();
            code = rnd.Next(1000, 9999).ToString();

            string text = $"<h2>Dear {Info.nameUser}!</h2>" +
                "<p>The recovery code is</p>" +
                $"<h2>{code}</h2>" +
                "<h2>WARNING!</h2>" +
                "<p>Do not share this code with anyone.</p>";

            sendEmail.Send(email, "AniChat Security", text);

        }

        private void emailCode_tb_TextChanged(object sender, EventArgs e)
        {
            if (emailCode_tb.Text.Length.Equals(emailCode_tb.MaxLength))
            {
                if (emailCode_tb.Text == code)
                {
                    emailCode_pl.Visible = false;
                    retrievePass_pl.Visible = true;
                    this.Height = 400;
                }
            }
        }

        private void Retrieve_btn_Click(object sender, EventArgs e)
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
                validErr_lb.Text = "'Password' та 'Repeat' не співпадають !";
                return;
            }

            string sqlcmd = $"UPDATE Chat_Users SET Password = '{Info.EncriptedPassword(pass_tb.Text)}' WHERE idChat_Users = '{Info.idUser}' ;";
            Info.InsertToDB(sqlcmd);

            MessageBox.Show("Your password has been changed !");

            this.Close();
        }

        private void ShowErr(string errtext)
        {
            validErr_lb.Visible = true;
            validErr_lb.Text = errtext;
        }

        private void RetrievePassForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            logIn.Load_User();
            logIn.Show();
            this.Dispose();
        }

        private void showPass_pb_Click(object sender, EventArgs e)
        {
            pass_tb.UseSystemPasswordChar = !pass_tb.UseSystemPasswordChar;
            repeatpass_tb.UseSystemPasswordChar = !repeatpass_tb.UseSystemPasswordChar;
        }
    }
}
