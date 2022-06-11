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
    public partial class t2medecine_aler : Form
    {
        int rowEdit = -1;
        int colEdit = -1;
        public t2medecine_aler()
        {
            InitializeComponent();
        }

        private void t2medecine_aler_Load(object sender, EventArgs e)
        {
            this.Height = 300;
            h.bs1 = new BindingSource();
            h.bs1.DataSource = h.myfunDt("SELECT * FROM medicine_aler");
            dataGridView1.DataSource = h.bs1;
            t2medecine_alerFormatDGV();
            bindingNavigator1.BindingSource = h.bs1;

            h.bs1.Sort = dataGridView1.Columns[1].Name;

            DataTable minmaxValue = h.myfunDt("SELECT MIN(date_of),MAX(date_of)," +
                "MIN(idmedicine),MAX(idmedicine) FROM sqlist19_1_km.medicine_aler");

            dtpIn.Value = Convert.ToDateTime(minmaxValue.Rows[0][0].ToString());
            dtpOut.Value = Convert.ToDateTime(minmaxValue.Rows[0][1].ToString());

            tbxidIn.Text = minmaxValue.Rows[0][2].ToString();
            tbxidOut.Text = minmaxValue.Rows[0][3].ToString();

            minmaxValue = h.myfunDt("SELECT distinct medicine FROM medicine_aler");
            cbxMed.Items.Add("");
            for (int i = 0; i < minmaxValue.Rows.Count; i++)
                cbxMed.Items.Add(minmaxValue.Rows[i][0].ToString());
        }

        private void t2medecine_alerFormatDGV()
        {
            // Увімкнення зміни розмірів у заголовках стовпців (полів)
            dataGridView1.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridView1.ColumnHeadersHeight = 60;
            dataGridView1.Columns[0].Width = 25;
            dataGridView1.Rows[1].Height = 80;

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
            dataGridView1.Columns[0].HeaderText = "idmedicine";
            dataGridView1.Columns[1].HeaderText = "medicine";
            dataGridView1.Columns[2].HeaderText = "date_of";

            //шрифт всього DataGridView (дані з заголовками)
            dataGridView1.Font = new Font("Verdana", 7, FontStyle.Bold);

            // вирівнювання заголовків стовпців (полів)
            dataGridView1.Columns[1].HeaderCell.Style.Alignment =
            DataGridViewContentAlignment.MiddleCenter;

            // вирівнювання даних в стовпці
            dataGridView1.Columns[1].DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleRight;

         if(int.Parse(h.typeUser) > 2)
         {
             dataGridView1.ReadOnly = true;
         }

        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
        if(dataGridView1.CurrentCell.EditType !=
            typeof(DataGridViewTextBoxEditingControl)) return;
            rowEdit = dataGridView1.CurrentCell.RowIndex;
            colEdit = dataGridView1.CurrentCell.ColumnIndex;
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
                this.Height = 270;
            }
        }

        private void btnOkFilter_Click(object sender, EventArgs e)
        {
            string strFilter = "idmedicine > 0";

            strFilter += "AND (date_of >= '" + dtpIn.Value.ToString("yyyy-MM-dd") + "'" +
            " AND date_of <= ' " + dtpOut.Value.ToString("yyyy-MM-dd") + "') ";

            if ((tbxidIn.Text != "") && (tbxidOut.Text != ""))
            {
                strFilter += "AND (idmedicine >= '" + int.Parse(tbxidIn.Text) +
                    "' AND idmedicine <= '" + int.Parse(tbxidOut.Text) + "')";
            }
            else if ((tbxidIn.Text == "") && (tbxidOut.Text != ""))
                strFilter += " AND (idmedicine <= '" + int.Parse(tbxidOut.Text) + "')";
            else if ((tbxidIn.Text != "") && (tbxidOut.Text == ""))
                strFilter += "AND (idmedicine >= '" + int.Parse(tbxidIn.Text) + "')";

            if (cbxMed.Text != "")
                strFilter += "AND (medicine LIKE '%" + cbxMed.Text + "%') ";

            h.bs1.Filter = strFilter;
        }

        private void btnCanselFilter_Click(object sender, EventArgs e)
        {
            h.bs1.Filter = "";
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Addtot2 f1add = new Addtot2();
            f1add.ShowDialog();
            h.bs1.DataSource = h.myfunDt("SELECT * FROM sqlist19_1_km.medicine_aler");
            dataGridView1.DataSource = h.bs1;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            h.curVal0 = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            h.keyName = dataGridView1.Columns[0].Name;

            Deletet2 f3 = new Deletet2();
            f3.ShowDialog();

            h.bs1.DataSource = h.myfunDt("SELECT * FROM sqlist19_1_km.medicine_aler");
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

            if (curColName == "medicine" || curColName == "date_of")
            {
                newCurCellVal = "'" + newCurCellVal + "'";
            }
            string sqlStr = "UPDATE medicine_aler set " + curColName + " = " + newCurCellVal + " where " + curColName0 + " = " + h.curVal0;

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
            
            Updatet2 f4 = new Updatet2();
            f4.ShowDialog();

            h.bs1.DataSource = h.myfunDt("SELECT * FROM sqlist19_1_km.medicine_aler");
            dataGridView1.DataSource = h.bs1;
        }

        

    }

}

