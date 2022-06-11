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
    public partial class EditUserPassword : Form
    {
        DataTable dtuserName;
        public EditUserPassword()
        {
            InitializeComponent();
        }

        private void EditUserPassword_Load(object sender, EventArgs e)
        {
            dtuserName = h.myfunDt("SELECT * FROM userName");

            for (int i = 0; i < dtuserName.Rows.Count; i++)
            {
                cmbNameUser.Items.Add(dtuserName.Rows[i][1].ToString());
            }
            cmbNameUser.Text = dtuserName.Rows[0][1].ToString();
        }

        private void btnEditPaswordUser_Click(object sender, EventArgs e)
        {
            if (String.Equals(txtPassword1User.Text, txtPassword2User.Text) && txtPassword1User.Text != "")
            {
                string sqlcmd = "UPDATE userName SET Password = '" +
                    h.EncriptedPassword(txtPassword1User.Text) +
                    "'WHERE UserName = '" + cmbNameUser.Text + "'";
                MySqlConnection con = new MySqlConnection(h.ConStr);
                MySqlCommand cmdAdd = new MySqlCommand(sqlcmd, con);
                con.Open();
                cmdAdd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Пароль користувача '" + cmbNameUser.Text + "' успішно змінено!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Паролі не співпадають або не введені !","Помилка!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtPassword1User.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
