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
using System.IO;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;

namespace BDlab1
{
    public partial class t1alergologia : Form
    {
        int rowEdit = -1;
        int colEdit = -1;
        DataTable dt;

        public t1alergologia()
        {
            InitializeComponent();
        }

        private void t1alergologia_Load(object sender, EventArgs e)
        {
            this.Height = 301;

            if (int.Parse(h.typeUser) == 3)
            {
                bindingNavigatorAddNewItem.Visible = false;
                bindingNavigatorDeleteItem.Visible = false;
                toolStripButton1.Visible = false;
                dataGridView1.ReadOnly = true;
            }

            h.bs1 = new BindingSource();
            h.bs1.DataSource = h.myfunDt("SELECT * FROM alergologia");
            dataGridView1.DataSource = h.bs1;
            dt = (DataTable)h.bs1.DataSource;
            t1alergologiaFormatDGV();
            bindingNavigator1.BindingSource = h.bs1;

            h.bs1.Sort = dataGridView1.Columns[1].Name;

            DataTable minmaxValue = h.myfunDt("SELECT MIN(intzavd),MAX(intzavd)," +
                "MIN(idalergologia),MAX(idalergologia) FROM sqlist19_1_km.alergologia");
            dtpIn.Value = Convert.ToDateTime(minmaxValue.Rows[0][0].ToString());
            dtpOut.Value = Convert.ToDateTime(minmaxValue.Rows[0][1].ToString());

            tbxidIn.Text = minmaxValue.Rows[0][2].ToString();
            tbxidOut.Text = minmaxValue.Rows[0][3].ToString();

            minmaxValue = h.myfunDt("SELECT distinct vudu FROM alergologia");
            cbxVudu.Items.Add("");
            for (int i = 0; i < minmaxValue.Rows.Count; i++)
                cbxVudu.Items.Add(minmaxValue.Rows[i][0].ToString());

            minmaxValue = h.myfunDt("SELECT distinct sumptomu FROM alergologia");
            cbxSump.Items.Add("");
            for (int i = 0; i < minmaxValue.Rows.Count; i++)
                cbxSump.Items.Add(minmaxValue.Rows[i][0].ToString());

            this.dataGridView1.Columns["foto"].Visible = false;

        }

        private void t1alergologiaFormatDGV()
        {
            // Увімкнення зміни розмірів у заголовках стовпців (полів)
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridView1.ColumnHeadersHeight = 60;
            dataGridView1.Columns[0].Width = 25;
            dataGridView1.Rows[3].Height = 80;

            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;

            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.GridColor = Color.Black;

            dataGridView1.RowsDefaultCellStyle.BackColor = Color.Gainsboro;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Yellow;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkViolet;
            dataGridView1.Font = new Font("Black", 7, FontStyle.Bold);
            dataGridView1.ForeColor = Color.Black;

            // назви полів (стовпців)
            dataGridView1.Columns[0].HeaderText = "idalergologia";
            dataGridView1.Columns[1].HeaderText = "vudu";
            dataGridView1.Columns[2].HeaderText = "Zbudnuku";
            dataGridView1.Columns[3].HeaderText = "sumptomu";
            dataGridView1.Columns[4].HeaderText = "medecine";
            dataGridView1.Columns[5].HeaderText = "intzavd";

            //шрифт всього DataGridView (дані з заголовками)
            dataGridView1.Font = new Font("Black", 7, FontStyle.Bold);

            // вирівнювання заголовків стовпців (полів)
            dataGridView1.Columns[1].HeaderCell.Style.Alignment =
            DataGridViewContentAlignment.MiddleCenter;

            // вирівнювання даних в стовпці
            dataGridView1.Columns[1].DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleRight;

            if (int.Parse(h.typeUser) > 2)
            {
                dataGridView1.ReadOnly = true;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
        if(dataGridView1.CurrentCell.EditType !=
            typeof(DataGridViewTextBoxEditingControl)) return;
            rowEdit = dataGridView1.CurrentCell.RowIndex;
            colEdit = dataGridView1.CurrentCell.ColumnIndex;
            this.dataGridView1.Columns["foto"].Visible = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (colEdit == -1) return;

            var c = colEdit;
            var r = rowEdit;

            dataGridView1.CurrentCell = dataGridView1[c,r];
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            this.Close();

            else
            {
                int ri,ci;
                if (e.KeyCode == Keys.Enter)
                {
                    ri = dataGridView1.CurrentCell.RowIndex;
                    ci = dataGridView1.CurrentCell.ColumnIndex;
                    e.SuppressKeyPress = true;

                    if(dataGridView1.Columns.Count > ci+1)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[ri].Cells[ci+1];
                        return;
                    }
                    else
                    {
                        if(dataGridView1.Rows.Count > ri+1)
                            dataGridView1.CurrentCell = dataGridView1.Rows[ri + 1].Cells[0];
                    }
                }
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && (e.ColumnIndex >= 4 && e.ColumnIndex <= 21))
            {
                e.PaintBackground(e.CellBounds, true);
                e.Graphics.TranslateTransform(e.CellBounds.Left, e.CellBounds.Bottom);
                e.Graphics.RotateTransform(270);
                e.Graphics.DrawString(e.FormattedValue.ToString(), e.CellStyle.Font, Brushes.Black, 5, 5);
                e.Graphics.ResetTransform();
                e.Graphics.ResetTransform();
                e.Handled = true;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (btnFind.Checked)
            {
                txtBNV.Visible = true;
                label1.Visible = true;

                label1.Text = " ";
            }

            else
            {
                txtBNV.Text = " ";
                txtBNV.Visible = false;
                label1.Visible = false;
                dataGridView1.ClearSelection();
            }
        }

        private void txtBNV_TextChanged(object sender, EventArgs e)
        {
            if (btnFind.Checked)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(txtBNV.Text))
                            {
                                dataGridView1.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }

        private void txtBNV_Leave(object sender, EventArgs e)
        {
            txtBNV.Visible = false;
            txtBNV.Text = " ";
            label1.Visible = false;
            dataGridView1.ClearSelection();
            btnFind.Checked = false;

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (btnFilter.Checked)
            {
                this.Height = 530;
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
                h.bs1.Filter = " ";
                this.Height = 301;
            }
        }

        private void btnOkFilter_Click(object sender, EventArgs e)
        {
            string strFilter = "idalergologia > 0";

            strFilter += "AND (intzavd >= '" + dtpIn.Value.ToString("yyyy-MM-dd") + "'" +
            " AND intzavd <= ' " + dtpOut.Value.ToString("yyyy-MM-dd") + "') ";

            if ((tbxidIn.Text != "") && (tbxidOut.Text != ""))
            {
                strFilter += "AND (idalergologia >= '" + int.Parse(tbxidIn.Text) +
                    "' AND idalergologia <= '" + int.Parse(tbxidOut.Text) + "')";
            }
            else if ((tbxidIn.Text == "") && (tbxidOut.Text != ""))
                strFilter += " AND (idalergologia <= '" + int.Parse(tbxidOut.Text) + "')";
            else if ((tbxidIn.Text != "") && (tbxidOut.Text == ""))
                strFilter += "AND (idalergologia >= '" + int.Parse(tbxidIn.Text) + "')";

            if (cbxVudu.Text != "")
                strFilter += "AND (vudu LIKE '%" + cbxVudu.Text + "%') ";
            if (cbxSump.Text != "")
                strFilter += "AND (sumptomu LIKE '%" + cbxSump.Text + "%') ";

            h.bs1.Filter = strFilter;
        }

        private void btnCanselFilter_Click(object sender, EventArgs e)
        {
            h.bs1.Filter = "";
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Addtot1 f1add = new Addtot1();
            f1add.ShowDialog();
            h.bs1.DataSource = h.myfunDt("SELECT * FROM sqlist19_1_km.alergologia");
            dataGridView1.DataSource = h.bs1;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            h.curVal0 = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            h.keyName = dataGridView1.Columns[0].Name;

            Deletet1 f3 = new Deletet1();
            f3.ShowDialog();

            h.bs1.DataSource = h.myfunDt("SELECT * FROM sqlist19_1_km.alergologia");
            dataGridView1.DataSource = h.bs1;
        }

        private void dataGridView1_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            int curColidx = dataGridView1.CurrentCellAddress.X;
            int curRowidx = dataGridView1.CurrentCellAddress.Y;

            string curColName0 = dataGridView1.Columns[0].Name;
            string curColName = dataGridView1.Columns[curColidx].Name;
            h.curVal0 = dataGridView1[0, curRowidx].Value.ToString();

            string newCurCellVal = e.Value.ToString();

            if (curColName == "vudu" || curColName == "Zbudnuku" || curColName == "sumptomu")
            {
                newCurCellVal = "'" + newCurCellVal + "'";
            }
            string sqlStr = "UPDATE alergologia set " + curColName + " = " + newCurCellVal + " where " + curColName0 + " = " + h.curVal0;

            using (MySqlConnection con = new MySqlConnection(h.ConStr))
            {
                MySqlCommand cmd = new MySqlCommand(sqlStr, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            h.curVal0 = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            h.keyName = dataGridView1.Columns[0].Name;

            Updatet1 f4 = new Updatet1();
            f4.ShowDialog();

            h.bs1.DataSource = h.myfunDt ("SELECT * FROM sqlist19_1_km.alergologia");
            dataGridView1.DataSource = h.bs1;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rIndx = dataGridView1.CurrentCell.RowIndex;
            if (rIndx < dataGridView1.RowCount - 1)
            {
                byte[] a = (byte[])dataGridView1.Rows[rIndx].Cells[6].Value;
                MemoryStream memImage = new MemoryStream(a);
                pictureBox1.Image = Image.FromStream(memImage);
                memImage.Close();
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void btnOLE_DB_Click(object sender, EventArgs e)
        {
            string fileName = Application.StartupPath + @"\Report\File2_xls.xls";
            if (File.Exists(fileName)) File.Delete(fileName);

            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + fileName + "; " +
                "Extended Properties =\"Excel 8.0; CharacterSet=1251; HDR=NO\"";
            string commandCreateoledb = "CREATE TABLE [MySheet] (" + dt.Columns[0].ColumnName + "] int";
            for (int i = 1; i < (dt.Columns.Count); i++)
            {
                commandCreateoledb += ", [" + dt.Columns[i].ColumnName + "] string";
            }
            commandCreateoledb += ")";


            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                using (OleDbCommand cmd = new OleDbCommand(commandCreateoledb, conn))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();

                        for (int i = 0; i < (dt.Rows.Count); i++)
                        {
                            cmd.CommandText = "insert into [MySheet$] values(" + Convert.ToString(dt.Rows[i][0]);

                            for (int j = 1; j < (dt.Columns.Count); j++)
                            {
                                if (dt.Columns[j].DataType.ToString() == "System.String")
                                    cmd.CommandText += ", '" + Convert.ToString(dt.Rows[i][j]) + "'";
                                else if (dt.Columns[j].DataType.ToString() == "System.Int32")
                                    cmd.CommandText += ", '" + Convert.ToInt32(dt.Rows[i][j]) + "'";
                                else if (dt.Columns[j].DataType.ToString() == "System.DateTime")
                                    cmd.CommandText += ", '" + Convert.ToDateTime(dt.Rows[i][j]) + "'";
                                else
                                    cmd.CommandText += ", 'NULL'";
                            }
                            cmd.CommandText += ")";
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Таблиця MySheet уже існуе");
                    }
                }
                conn.Close();
            }
            MessageBox.Show("File 'File2_xls.xls' is created");
        }

        private void btnStream_Click(object sender, EventArgs e)
        {
            var ec1251 = Encoding.GetEncoding(1251);
            string extend;
            if (radioButton2.Checked)
                extend = "tsv";
            else if (radioButton3.Checked)
                extend = "doc";
            else if (radioButton4.Checked)
                extend = "xls";
            else
                extend = "txt";

            string path = Application.StartupPath + @"\Report\";
            string filePath = path + "File_" + extend + "." + extend;

            StreamWriter wr = new StreamWriter(filePath, false, encoding: ec1251);

            try
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    wr.Write(dt.Columns[i].ToString().ToUpper() + "\t");
                }
                wr.WriteLine();

                for (int i = 0; i < (dt.Rows.Count); i++)
                {
                    for (int j = 0; j < (dt.Columns.Count); j++)
                    {
                        if (dt.Rows[i][j] != null)
                        {
                            wr.Write(Convert.ToString(dt.Rows[i][j]) + "\t");
                        }
                        else
                        {
                            wr.Write("\t");
                        }
                    }
                    wr.WriteLine();
                }
                wr.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            MessageBox.Show("File1_" + extend + "." + extend + " is created");
        }

        private void format_File3(Excel.Worksheet sheet)
        {
            int r1 = 1;
            int c1 = 1;
            int r2 = dt.Rows.Count +1;
            int c2 = dt.Columns.Count;

            Excel.Range range0 = (Excel.Range)sheet.Range[sheet.Cells[9, 2], sheet.Cells[9, 2]];
            Excel.Range range1 = (Excel.Range)sheet.Range[sheet.Cells[r1, c1], sheet.Cells[r2, c2]];
            Excel.Range range2 = (Excel.Range)sheet.Range[sheet.Cells[10, 1], sheet.Cells[10, 1]];

            range1.Font.Background = true;
            range1.Font.Size = 12;
            range1.Font.Color = ColorTranslator.ToOle(Color.Black);
            range1.Font.Name = "Arial";

            range1.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            range1.Borders.Weight = Excel.XlBorderWeight.xlThin;
            range1.Borders.Color = ColorTranslator.ToOle(Color.Red);

            range1.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            range1.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;

            range1.ColumnWidth = 20;
            range0.RowHeight = 35;

            range1.EntireColumn.AutoFit();
            range1.EntireRow.AutoFit();

            range1.Interior.Color = ColorTranslator.ToOle(Color.Yellow);
            range2.Merge(Type.Missing);
        }

        private void btnCom_Click(object sender, EventArgs e)
        {
            string fileName = Application.StartupPath + @"\Report\File3_.xls.xls";

            Excel.Application excel = new Excel.Application();
            excel.SheetsInNewWorkbook = 2;
            excel.Workbooks.Add(Type.Missing);
            Excel.Workbook workbook = excel.Workbooks[1];
            Excel.Worksheet sheet = workbook.Worksheets.get_Item(1);
            sheet.Name = "Читачі";

            for (int j = 0; j < dt.Columns.Count; j++)
            {
                sheet.Cells[1, j + 1].Value = dt.Columns[j].ColumnName;
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    if (dt.Columns[j].DataType.ToString() == "System.Byte[]")
                    {
                        sheet.Cells[i + 2, j + 1].Value = "NULL";
                    }
                    else
                    {
                        sheet.Cells[i + 2, j + 1].Value = dt.Rows[i][j];
                    }
                }
            }
            format_File3(sheet);

            excel.DisplayAlerts = false;
            excel.Application.ActiveWorkbook.SaveAs(fileName, Excel.XlSaveAsAccessMode.xlNoChange);
            excel.Quit();
            MessageBox.Show("File 'File3_xls.xls' is created");
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            string fileName = Application.StartupPath + @"\Report\File4_.xml.xml";
            dt.WriteXml(fileName);
            dt.WriteXml(fileName, XmlWriteMode.WriteSchema);
            MessageBox.Show("File 'File4_.xml' is created");
        }

        private void txtBNV_Click(object sender, EventArgs e)
        {

        }


    }

}
