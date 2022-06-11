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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a1 = new About();
            a1.ShowDialog();
        }

        private void калькулятор1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calcul c1 = new Calcul();
            c1.ShowDialog();
        }

        private void калькулятор2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator c2 = new Calculator();
            c2.ShowDialog();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
                Application.Exit();
        }

        private void Table1_Click(object sender, EventArgs e)
        {
            t1alergologia f1 = new t1alergologia();
            f1.ShowDialog();
            
        }

        private void Table2_Click(object sender, EventArgs e)
        {
            t2medecine_aler f2 = new t2medecine_aler();
            f2.ShowDialog();
            
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            if (int.Parse(h.typeUser) > 1)
                адмніструванняToolStripMenuItem.Visible = false;
        }

        private void додатиКористувачаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewUser a1 = new AddNewUser();
            a1.ShowDialog();
        }

        private void видалитиКористувачаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteUser a2 = new DeleteUser();
            a2.ShowDialog();
        }

        private void змінитиПарольКористувачаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUserPassword a3 = new EditUserPassword();
            a3.ShowDialog();
        }

        private void змінитиТипДоступуКористувачаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUserType a4 = new EditUserType();
            a4.ShowDialog();
        }

        private void резервнеКопіюванняБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(h.ConStr);
            MySqlCommand cmd = new MySqlCommand("copyTablesBD", con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Немае зеднання з сервером!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Резервне копіювання успішно завершено!");
        }

        private void резервнеВідновленняБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(h.ConStr);
            MySqlCommand cmd = new MySqlCommand("restoreTablesBD", con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Немае зеднання з сервером!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Відновлення БД успішно завершено!");
        }
    }
}
