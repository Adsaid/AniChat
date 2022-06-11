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
    public partial class Addtot2 : Form
    {
        public Addtot2()
        {
            InitializeComponent();
        }

        private void BtnADD_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(h.ConStr))
            {
                string tb1 = txBId.Text;
                string tb2 = txBvudu.Text;
                string tb6 = txBDate.Text;

                string sql = "INSERT INTO medicine_aler " +
                    "(idmedicine,medicine,date_of)" +
                    "VALUES(@TK1,@TK2,@TK6)";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@TK1", tb1);
                cmd.Parameters.AddWithValue("@TK2", tb2);
                cmd.Parameters.AddWithValue("@TK6", tb6);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Запис успішно додано");

            }
            this.Close();
        }


    }
}
