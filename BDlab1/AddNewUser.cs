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
    public partial class AddNewUser : Form
    {
        DataTable dtuserName;
        bool nuser;

        public AddNewUser()
        {
            InitializeComponent();
        }

        private void AddNewUser_Load(object sender, EventArgs e)
        {
            dtuserName = h.myfunDt("SELECT * FROM userName");
        }

        private void txtNameUser_Leave(object sender, EventArgs e)
        {
            nuser = true;
            if (btnExit.Focused)
                this.Close();
            else
            {
                for (int i = 0; i < dtuserName.Rows.Count; i++)
                {
                    if (String.Equals(txtNameUser.Text.Trim(), dtuserName.Rows[i][1].ToString()) || (String.Equals(txtNameUser.Text, "")))
                    {
                        nuser = false;
                        break;
                    }
                }
            }

            if (!nuser)
            {
                MessageBox.Show("Імя користувача не введено або вже існує", "УВАГА!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNameUser.Focus();
            }
        }

        private void txtTypeUser_Leave(object sender, EventArgs e)
        {
            int g;
            nuser = true;
            if (btnExit.Focused)
                this.Close();
            else
            {
                if (!int.TryParse(txtTypeUser.Text, out g))
                    nuser = false;
                else if ((int.Parse(txtTypeUser.Text) < 0) || (int.Parse(txtTypeUser.Text) > 3))
                    nuser = false;
            }
            if (!nuser)
            {
                MessageBox.Show("Не вірний тип користувача!", "УВАГА!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTypeUser.Focus();
            }
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            if (txtNameUser.Text != "")
            {
                if (txtTypeUser.Text != "")
                {
                    if (String.Equals(txtPassword1User.Text, txtPassword2User.Text))
                    {
                        string sqlcmd = "INSERT INTO userName (UserName,Type,Password)" + "VALUES (@P1,@P2,@P3)";
                        MySqlConnection con = new MySqlConnection(h.ConStr);
                        MySqlCommand cmdAdd = new MySqlCommand(sqlcmd, con);
                        cmdAdd.Parameters.AddWithValue("@P1", txtNameUser.Text);
                        cmdAdd.Parameters.AddWithValue("@P2", txtTypeUser.Text);
                        cmdAdd.Parameters.AddWithValue("@P3", h.EncriptedPassword(txtPassword1User.Text));
                        con.Open();
                        cmdAdd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Нового користувача '" + txtNameUser.Text + "' успішно додано");
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Паралі не співпадають!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword1User.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Тип доступу не заповнено!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTypeUser.Focus();
                }
            }
            else
            {
                MessageBox.Show("Поле 'Користувач' не заповнене", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNameUser.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
