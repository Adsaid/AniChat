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
    public partial class Updatet1 : Form
    {
        public Updatet1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlStr;

            if ((checkBox1.Checked == true) && (checkBox2.Checked == false))
            {
                sqlStr = "Update alergologia set " + textBox1.Text + " where " + textBox2.Text;
                if (MessageBox.Show("Ви впевнені що хочете замінити запис", "Заміна", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (MySqlConnection con = new MySqlConnection(h.ConStr))
                    {
                        MySqlCommand cmd = new MySqlCommand(sqlStr, con);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Редагування запису пройшло вдало");
                    }
                }
            }

            if((checkBox1.Checked == false)&&(checkBox2.Checked == true))
            {
                int FileSize;
                byte[] rawData;
                FileStream fs;
                string strFileName;

                strFileName = h.pathToFoto;
                fs = new FileStream(strFileName, FileMode.Open, FileAccess.Read);
                FileSize = (Int32)fs.Length;
                rawData = new byte[FileSize];
                fs.Read(rawData, 0, FileSize);
                fs.Close();

                sqlStr = "Update alergologia set " + " foto = @File " + " where " + textBox2.Text;

                
                    if (MessageBox.Show("Ви впевнені що хочете замінити запис", "Заміна", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (MySqlConnection con = new MySqlConnection(h.ConStr))
                        {
                            MySqlCommand cmd = new MySqlCommand(sqlStr, con);
                            //cmd.Parameters.AddWithValue("@FileName", strFileName);
                            cmd.Parameters.AddWithValue("@File", rawData);

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Редагування запису пройшло вдало");
                        }
                    }
            }

            if ((checkBox1.Checked == true) && (checkBox2.Checked == true))
            {
                int FileSize;
                byte[] rawData;
                FileStream fs;
                string strFileName;

                strFileName = h.pathToFoto;
                fs = new FileStream(strFileName, FileMode.Open, FileAccess.Read);
                FileSize = (Int32)fs.Length;
                rawData = new byte[FileSize];
                fs.Read(rawData, 0, FileSize);
                fs.Close();

                sqlStr = "Update alergologia set "+ textBox1.Text + " foto = @File " + " where " + textBox2.Text;


                if (MessageBox.Show("Ви впевнені що хочете замінити запис", "Заміна", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (MySqlConnection con = new MySqlConnection(h.ConStr))
                    {
                        MySqlCommand cmd = new MySqlCommand(sqlStr, con);
                        //cmd.Parameters.AddWithValue("@FileName", strFileName);
                        cmd.Parameters.AddWithValue("@File", rawData);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Редагування запису пройшло вдало");
                    }
                }
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
            /*string sqlStr = "Update alergologia set " + textBox1.Text + " where " + textBox2.Text;
            MessageBox.Show(sqlStr);

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
            this.Close();*/


        

        private void Updatet1_Load(object sender, EventArgs e)
        {
            h.pathToFoto = Application.StartupPath + @"\" + "img247.jpg";
            pictureBox1.Image = Image.FromFile(h.pathToFoto);
            textBox2.Text = h.keyName + " = " + h.curVal0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label1.Visible = true;
                textBox1.Visible = true;
                button1.Visible = true;
            }
            else if (checkBox1.Checked == false)
            {
                label1.Visible = true;
                textBox1.Visible = true;
                if(checkBox2.Checked == false)
                {
                    button1.Visible = false;
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked == true)
            {
                panel2.Visible = true;
                label3.Visible = true;
                button3.Visible = true;
                pictureBox1.Visible = true;
                button1.Visible = true;
            }
            else if (checkBox2.Checked == false)
            {
                panel2.Visible = false;
                label3.Visible = false;
                button3.Visible = false;
                pictureBox1.Visible = false;
                if (checkBox1.Checked == false)
                {
                    button1.Visible = true;
                }
            }
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
