using System;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AniChat
{
    public partial class AddNewUser : Form
    {
        DataTable dtuserName;
        bool nuser;
        LogIn logIn = null;
        string passPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]*$";
        string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        public AddNewUser(LogIn logIn)
        {
            InitializeComponent();
            this.logIn = logIn;
        }

        private void AddNewUser_Load(object sender, EventArgs e)
        {
            validErr_lb.Visible = false;
            dtuserName = Info.SelectFromDB("SELECT Login FROM Chat_Users");
        }

        private void txtBoxLogin_Leave(object sender, EventArgs e)
        {
            validErr_lb.Visible = false;
            nuser = true;


            for (int i = 0; i < dtuserName.Rows.Count; i++)
            {
                if (String.Equals(txtBoxLogin.Text.Trim(), dtuserName.Rows[i][0].ToString()) || String.Equals(txtBoxLogin.Text, String.Empty))
                {
                    nuser = false;
                    break;
                }
            }

            if (!nuser)
            {
                ShowErr("Login не введено або вже існує");
                txtBoxLogin.Focus();
            }
        }
        private void txtBoxPass_Leave(object sender, EventArgs e)
        {
            if (txtBoxPass.Text.Length <= 6)
            {
                ShowErr("Password має бути більше 6 символів");
                txtBoxPass.Focus();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Registration();
        }


        private async void Registration()
        {
            if (String.IsNullOrWhiteSpace(txtBoxLogin.Text))
            {
                ShowErr("Поле 'Login' не заповнене !");
                return;
            }
            if (String.IsNullOrWhiteSpace(txtBoxEmail.Text))
            {
                ShowErr("Поле 'Email' не заповнене !");
                return;
            }
            if (!Regex.IsMatch(txtBoxEmail.Text, emailPattern))
            {
                ShowErr("Не коректний формат Email адресу!");
                return;
            }
            if (String.IsNullOrWhiteSpace(txtBoxPass.Text))
            {
                ShowErr ("Поле 'Password' не заповнене !");
                return;
            }
            if (!Regex.IsMatch(txtBoxPass.Text, passPattern))
            {
                ShowErr("Поле 'Password' повинно містити \n великі, малі літери та цифри!");
                return;
            }
            if (!String.Equals(txtBoxPass.Text, txtBoxRep_Pass.Text))
            {
                validErr_lb.Visible = true;
                validErr_lb.Text = "'Password' та 'Repeat' не співпадають !";
                return;
            }

            string sqlcmd = $"INSERT INTO Chat_Users (`Email`, `Login`, `Password`) VALUES ('{txtBoxEmail.Text}','{txtBoxLogin.Text}','{Info.EncriptedPassword(txtBoxPass.Text)}');";

            await Task.Run(() => Info.InsertToDB(sqlcmd));

            this.Close();
        }

        private void ShowErr(string errtext)
        {
            validErr_lb.Visible = true;
            validErr_lb.Text = errtext;
        }

        private void txtBoxLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Registration();
            else if (e.KeyCode == Keys.Escape)
                Application.Exit();
        }

        private void txtBoxPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Registration();
            else if (e.KeyCode == Keys.Escape)
                Application.Exit();
        }

        private void txtBoxRep_Pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Registration();
            else if (e.KeyCode == Keys.Escape)
                Application.Exit();
        }

        private void AddNewUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            logIn.Show();
            logIn.Load_User();
            this.Dispose();
        }

        private void showPass_pb_Click(object sender, EventArgs e)
        {
            txtBoxPass.UseSystemPasswordChar = !txtBoxPass.UseSystemPasswordChar;
            txtBoxRep_Pass.UseSystemPasswordChar = !txtBoxRep_Pass.UseSystemPasswordChar;
        }
    }
}
