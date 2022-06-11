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

namespace BDlab1
{
    public partial class Deletet1 : Form
    {
        public Deletet1()
        {
            InitializeComponent();
        }

        private void Deletet1_Load(object sender, EventArgs e)
        {
            textBox1.Text = h.keyName + " = " + h.curVal0;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            string sqlStr = "delete from alergologia where " + textBox1.Text;

            if (MessageBox.Show("Ви впевнені що хочете видалити запис", "Видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (MySqlConnection con = new MySqlConnection(h.ConStr))
                {
                    MySqlCommand cmd = new MySqlCommand(sqlStr, con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            this.Close();
        }

        private void Cansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
