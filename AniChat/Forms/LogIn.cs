using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniChat
{
    public partial class LogIn : Form
    {
        string IPSQLserver = "localhost";//"193.93.216.145";
        string LogSQLserver = "root";//"sqlist19_1_km";
        string PasSQLserver = "12345";//"ist19_km";
        string DBserver = "ani_chatbd";

        public string[,] matrix;
        string email;
        DataTable dt;

        public LogIn()
        {
            InitializeComponent();
        }

        private async void LogIn_Load(object sender, EventArgs e)
        {
            Info.ConStr = "server = " + IPSQLserver + 
                "; characterset = cp1251;" +
                "user = " + LogSQLserver + "; database = " + 
                DBserver + "; password = " + PasSQLserver;

            await Task.Run(() => Load_User());

            retrieve_PassLb.Visible = false;
            validErr_lb.Visible = false;

            txtBoxPass.UseSystemPasswordChar = true;
            txtBoxLogin.Focus();
        }

        public void Load_User()
        {
            dt = Info.SelectFromDB("Select * from Chat_Users");
            int count = dt.Rows.Count;

            matrix = new string[count, 7];
            for (int i = 0; i < count; i++)
            {
                matrix[i, 0] = dt.Rows[i].Field<int>("idChat_Users").ToString();
                matrix[i, 1] = dt.Rows[i].Field<string>("Email");
                matrix[i, 2] = dt.Rows[i].Field<string>("Login");
                matrix[i, 3] = dt.Rows[i].Field<string>("Password");
                matrix[i, 4] = dt.Rows[i].Field<string>("Rank");
                matrix[i, 5] = dt.Rows[i].Field<string>("Gitlink");
                matrix[i, 6] = dt.Rows[i].Field<string>("Inlink");
            }
        }

        private void Avtorization()
        {
            bool flUser = false;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (String.Equals(txtBoxLogin.Text.ToUpper(), matrix[i, 2].ToUpper()))
                {
                    flUser = true;

                    Info.idUser = int.Parse(matrix[i, 0]);
                    email = matrix[i, 1];
                    Info.nameUser = matrix[i, 2];

                    if (String.Equals(Info.EncriptedPassword(txtBoxPass.Text), matrix[i, 3]))
                    {
                        Info.Rank = matrix[i, 4];
                        Info.GitLink = matrix[i, 5];
                        Info.InLink = matrix[i, 6];
                        txtBoxLogin.Text = string.Empty;
                        txtBoxPass.Text = string.Empty;

                        this.Hide();

                        MainForm mf = new MainForm();
                        mf.ShowDialog();
                        dt.Dispose();
                    }
                    else
                    {
                        ShowErr("Невірний password !");
                        txtBoxPass.Text = String.Empty;
                        txtBoxPass.Focus();

                        retrieve_PassLb.Visible = true;
                    }
                }
            }
            if (!flUser)
            {
                ShowErr("Невірний login !");

                retrieve_PassLb.Visible = false;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Avtorization();
        }

        private void ShowErr(string errtext)
        {
            validErr_lb.Visible = true;
            validErr_lb.Text = errtext;
        }

        private void txtBoxLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Avtorization();
            else if (e.KeyCode == Keys.Escape)
                Application.Exit();
        }

        private void txtBoxPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Avtorization();
            else if (e.KeyCode == Keys.Escape)
                Application.Exit();
        }

        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
                Application.Exit();
        }

        private void label_reg_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewUser new_user = new AddNewUser(this);
            new_user.ShowDialog();
        }

        private void retrieve_PassLb_Click(object sender, EventArgs e)
        {
            this.Hide();
            RetrievePassForm new_user = new RetrievePassForm(this, email);
            new_user.ShowDialog();
        }

        private void showPass_pb_Click(object sender, EventArgs e)
        {
            txtBoxPass.UseSystemPasswordChar = !txtBoxPass.UseSystemPasswordChar;
        }
    }
}
