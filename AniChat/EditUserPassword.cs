using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AniChat
{
    public partial class EditUserPassword : Form
    {
        DataTable dtuserName;
        string sqlcmd;
        public EditUserPassword()
        {
            InitializeComponent();
        }

        private void EditUserPassword_Load(object sender, EventArgs e)
        {
            cmbNameUser.Visible = false;
            labelUser.Visible = false;

            if(Info.nameUser == "admin")
            {
                cmbNameUser.Visible = true;
                labelUser.Visible = true;

                dtuserName = Info.SelectFromDB("SELECT * FROM Chat_Users");

                for (int i = 0; i < dtuserName.Rows.Count; i++)
                {
                    cmbNameUser.Items.Add(dtuserName.Rows[i][1].ToString());
                }
                cmbNameUser.Text = dtuserName.Rows[0][1].ToString();
            }
            else
            {
                cmbNameUser.Visible = false;
                labelUser.Visible = false;
            }
            
        }

        private void btnEditPaswordUser_Click(object sender, EventArgs e)
        {
            if (String.Equals(txtPassword1User.Text, txtPassword2User.Text) && txtPassword1User.Text != "")
            {
                if(Info.nameUser == "admin")
                {
                    sqlcmd = "UPDATE Chat_Users SET Password = '" +
                    Info.EncriptedPassword(txtPassword1User.Text) +
                    "'WHERE Login = '" + cmbNameUser.Text + "'";
                }
                else
                {
                    sqlcmd = "UPDATE Chat_Users SET Password = '" +
                    Info.EncriptedPassword(txtPassword1User.Text) +
                    "'WHERE Login = '" + Info.nameUser + "'";
                }

                MySqlConnection con = new MySqlConnection(Info.ConStr);
                MySqlCommand cmdAdd = new MySqlCommand(sqlcmd, con);
                con.Open();
                cmdAdd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Пароль користувача успішно змінено!",
                    "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Паролі не співпадають або не введені !",
                    "Помилка!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtPassword1User.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
