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
using System.IO;

namespace BDlab1
{
    public partial class Updatet2 : Form
    {
        public Updatet2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlStr = "Update medicine_aler set " + textBox1.Text + " where " + textBox2.Text;

            if (MessageBox.Show("Ви впевнені що хочете замінити запис", "Заміна", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
