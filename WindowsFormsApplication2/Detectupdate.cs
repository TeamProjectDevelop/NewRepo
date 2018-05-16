using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApplication2
{
    public partial class Detectupdate : Form
    {
        public Detectupdate()
        {
            InitializeComponent();
            DataTable dtData = new DataTable();
            dtData.Columns.Add("软件名称");
            dtData.Columns.Add("本地软件版本");
            dtData.Columns.Add("最新软件版本");

            DataRow drData;
            drData = dtData.NewRow();
            drData[0] = "软件A";
            drData[1] = "1.0";
            drData[2] = "2.0";
            dtData.Rows.Add(drData);

            DataRow drData1;
            drData1 = dtData.NewRow();
            drData1[0] = "软件B";
            drData1[1] = "2.0";
            drData1[2] = "3.0";
            dtData.Rows.Add(drData1);

            DataRow drData3;
            drData3 = dtData.NewRow();
            drData3[0] = "软件C";
            drData3[1] = "3.0";
            drData3[2] = "4.0";
            dtData.Rows.Add(drData3);

            DataRow drData4;
            drData4 = dtData.NewRow();
            drData4[0] = "软件D";
            drData4[1] = "5.0";
            drData4[2] = "6.0";
            dtData.Rows.Add(drData4);

            DataRow drData5;
            drData5 = dtData.NewRow();
            drData5[0] = "软件E";
            drData5[1] = "6.0";
            drData5[2] = "7.0";
            dtData.Rows.Add(drData5);

            this.dataGridView1.DataSource = dtData;

            DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn();
            //设定列的名字
            //在所有按钮上表示"点击阅览"
            column.HeaderText = "是否更新";
            column.TrueValue = true;
            column.FalseValue = false;
            //向DataGridView追加
            this.dataGridView1.Columns.Add(column);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                for (int i = 0; i < this.dataGridView1.RowCount; i++)
                {
                    if (this.dataGridView1.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")//或者=="False"
                    {
                        this.dataGridView1.Rows[i].Cells[0].Value = false;
                    }
                    else
                    {
                        this.dataGridView1.Rows[i].Cells[0].Value = true;
                    }
                }
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                for (int i = 0; i < this.dataGridView1.RowCount; i++)
                {
                    if (this.dataGridView1.Rows[i].Cells[0].EditedFormattedValue.ToString() == "False")//或者=="False"
                    {
                        this.dataGridView1.Rows[i].Cells[0].Value = true;
                        this.button1.Text = "取消全选";
                    }
                    else
                    {
                        this.dataGridView1.Rows[i].Cells[0].Value = false;
                        this.button1.Text = "全选";
                }
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Updating updating = new Updating();
            updating.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dataGridView1.RowCount; i++)
            {
                if (this.dataGridView1.Rows[i].Cells[0].EditedFormattedValue.ToString() == "False")//或者=="False"
                {
                    this.button2.Enabled = false;
                }
                else
                {
                    this.button2.Enabled = true;
                    break;
                }
            }
        }
    }
}
