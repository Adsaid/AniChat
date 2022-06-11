using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace BDlab1
{
    public partial class LogIn : Form
    {
        public string[,] matrix;
        DataTable dt;

        public LogIn()
        {
            InitializeComponent();

            string IPSQLserver = "193.93.216.145";
            string LogSQLserver = "sqlist19_1_km";
            string PasSQLserver = "ist19_km";

            h.ConStr = "server = " + IPSQLserver + "; characterset = cp1251;" +
                "user = " + LogSQLserver + "; database = " + LogSQLserver + "; password = " + PasSQLserver;

            dt = h.myfunDt("Select * from userName");
            int count = dt.Rows.Count;

            matrix = new string[count, 4];
            for (int i = 0; i < count; i++)
            {
                matrix[i, 0] = dt.Rows[i].Field<int>("id").ToString();
                matrix[i, 1] = dt.Rows[i].Field<string>("UserName");
                matrix[i, 2] = dt.Rows[i].Field<int>("Type").ToString();
                matrix[i, 3] = dt.Rows[i].Field<string>("Password");
                cbxUser.Items.Add(matrix[i, 1]);
            }
            cbxUser.Text = matrix[0, 1];
            txtPassword.UseSystemPasswordChar = true;
            cbxUser.Focus();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void Avtorization()
        {
            bool flUser = false;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (String.Equals(cbxUser.Text.ToUpper(), matrix[i, 1].ToUpper()))
                {
                    flUser = true;
                    if (String.Equals(h.EncriptedPassword(txtPassword.Text), matrix[i, 3]))
                    {
                        h.nameUser = matrix[i, 1];
                        h.typeUser = matrix[i, 2];
                        cbxUser.Text = "";
                        txtPassword.Text = "";
                        this.Hide();
                        mainForm f0 = new mainForm();
                        f0.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Введіть правельний пароль !", "Помилка авторизації", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPassword.Text = "";
                        txtPassword.Focus();
                    }
                }
            }
            if (!flUser)
            {
                MessageBox.Show("Користувач "+cbxUser+" не зареестрований в системі !","\nЗверніться до Адмімістратора ...",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
                cbxUser.Text = "";
                cbxUser.Focus();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Avtorization();
            //txtHesh.Text = h.EncriptedPassword(txtPassword.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbxUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Avtorization();
            else if (e.KeyCode == Keys.Escape)
                Application.Exit();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
        }

        private void btnOk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Avtorization();
        }

        private void btnExit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
        }

        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
                Application.Exit();
        }

        private void btnOk_KeyPress(object sender, KeyPressEventArgs e)
        {
        }


    }

    static class h
    {
        public static string ConStr { get; set; }
        public static string typeUser { get; set; }
        public static string nameUser { get; set; }
        public static BindingSource bs1 { get; set; }
        public static string curVal0 { get; set; }
        public static string keyName { get; set; }
        public static string pathToFoto { get; set; }

        public static DataTable myfunDt(string commandString)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(h.ConStr))
            {
                MySqlCommand cmd = new MySqlCommand(commandString, con);
                try
                {
                    con.Open();
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            dt.Load(dr);
                        }
                    }
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Неможливо з'єднатися з SQL-сервером!","Помилка з'єднання", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return dt;
        }

        public static string EncriptedPassword(string s)
        {
            if (string.Compare(s, "null", true) == 0)
                return "NULL";
            byte[] bytes = Encoding.Unicode.GetBytes(s);
            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
            byte[] byteHach = CSP.ComputeHash(bytes);
            string hash = string.Empty;
            foreach (byte b in byteHach)
                hash += String.Format("{0:x2}",b);
            return hash;
        }
    }
}
