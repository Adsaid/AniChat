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
    public partial class Addtot1 : Form
    {
        public Addtot1()
        {
            InitializeComponent();
        }

        private void BtnADD_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(h.ConStr))
            {
                string tb1 = txBId.Text;
                string tb2 = txBvudu.Text;
                string tb3 = txBSump.Text;
                string tb4 = txBZbud.Text;
                string tb5 = txBMedId.Text;
                string tb6 = txBDate.Text;

                string strFileName = h.pathToFoto;
                FileStream fs = new FileStream(strFileName, FileMode.Open, FileAccess.Read);
                int FileSize = (Int32)fs.Length;
                byte[] rawData = new byte[FileSize];
                fs.Read(rawData, 0 , FileSize);
                fs.Close();

                string sql = "INSERT INTO alergologia " +
                    "(idalergologia,vudu,Zbudnuku,sumptomu,medicine,intzavd,foto)" +
                    "VALUES(@TK1,@TK2,@TK3,@TK4,@TK5,@TK6,@File)";
                MySqlCommand cmd = new MySqlCommand(sql,con);

                cmd.Parameters.AddWithValue("@TK1", tb1);
                cmd.Parameters.AddWithValue("@TK2", tb2);
                cmd.Parameters.AddWithValue("@TK3", tb3);
                cmd.Parameters.AddWithValue("@TK4", tb4);
                cmd.Parameters.AddWithValue("@TK5", tb5);
                cmd.Parameters.AddWithValue("@TK6", tb6);

                //cmd.Parameters.AddWithValue("@FineName",strFileName);
                cmd.Parameters.AddWithValue("@File",rawData);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Запис успішно додано");

            }
            this.Close();
        }

        private void BtnCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Addtot1_Load(object sender, EventArgs e)
        {
            h.pathToFoto = Application.StartupPath + @"\" + "img247.jpg";
            pictureBox1.Image = Image.FromFile(h.pathToFoto);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Виберіть файл";
            openFileDialog1.Filter = "img files (*.jpg)|*.jpg|bmp file (*.bmp)|*.bmp|All files (*.*)|*.*";
            openFileDialog1.InitialDirectory = Application.StartupPath;

            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            {
                h.pathToFoto = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(h.pathToFoto);
            }
        }
    }
}
