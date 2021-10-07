using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book.User_Control
{
    public partial class UC_List : UserControl
    {
        DataSet ds = new DataSet();
        public UC_List()
        {
            InitializeComponent();
  
        }

        private void UC_List_Load(object sender, EventArgs e)
        {
            ds.ReadXml("book.xml");
            dataGridView1.DataSource = ds.Tables["User"];
            this.dataGridView1.Columns[2].Visible = false;
            //當買家欄位 = 此買家，將其顯示
            for (int i = 1; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells["買家帳號"].Value.ToString() == Program.Number)
                {
                    this.dataGridView1.Rows[i].Visible = true;
                }
                else
                {
                    this.dataGridView1.Rows[i].Visible = false;
                }
            }
        }

        private void btnbuy_Click(object sender, EventArgs e)
        {
            this.label2.Text = "";//已選購書單清空,用來顯示於提醒視窗
            int pri = 0;//宣告價格

            //已選購書單,用來顯示於提醒視窗
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells["買家帳號"].Value.ToString() == Program.Number)
                {
                    pri = pri + Int32.Parse(dataGridView1.Rows[i].Cells["價格"].Value.ToString());
                    this.label2.Text = this.label2.Text + dataGridView1.Rows[i].Cells["書名"].Value.ToString() + "/"
                                        + dataGridView1.Rows[i].Cells["作者"].Value.ToString() + "/"
                                        + dataGridView1.Rows[i].Cells["價格"].Value.ToString() + "\n";
                }
            }
            this.label2.Text = this.label2.Text + "\n" + "共" + pri.ToString() + "元";

            //跳出提醒視窗
            const string caption = "確定送出?";
            var result = MessageBox.Show(this.label2.Text, caption, MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)//如果按確認,寫入Xml
            {
                MessageBox.Show("確認送出,請重新刷新確認");
                ds.WriteXml("book.xml");
            }
            else//如果按取消,將買家欄重新輸入自己的帳號
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells["買家帳號"].Value.ToString() == "")
                    {
                        dataGridView1.Rows[i].Cells["買家帳號"].Value = "";
                    }
                }
            }
            this.label2.Text = "";//清空
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            //所選擇的那一欄得買家如果處理狀況 = 待處理,將其取消
            //否則聯絡管理員
            Int32 selectedRowCount = this.dataGridView1.CurrentCell.RowIndex;
            if (dataGridView1.Rows[selectedRowCount].Cells["處理"].Value.ToString() == "待處理")
            {
                dataGridView1.Rows[selectedRowCount].Cells["買家帳號"].Value = "";
                MessageBox.Show("已取消");
            }
            else if (dataGridView1.Rows[selectedRowCount].Cells["處理"].Value.ToString() == "已處理")
            {
                MessageBox.Show("請聯絡管理員取消");
            }
        }
    }
}
