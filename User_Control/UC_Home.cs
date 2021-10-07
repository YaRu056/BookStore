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
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();//宣告DataGridView
        
        private Bitmap MyImage;
        private void UC_Home_Load(object sender, EventArgs e)
        {
            this.label2.Text = "";//已選購書單清空
            int pri = 0;//宣告價格變數

            //讀取Xml檔
            ds.ReadXml("book.xml");
            dataGridView1.DataSource = ds.Tables["User"];

            //當買家欄位 != 其他買家，將其顯示加讓買家選購
           for (int i = 1; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells["買家帳號"].Value.ToString() == ""
                    || dataGridView1.Rows[i].Cells["買家帳號"].Value.ToString() == "範例"
                    || dataGridView1.Rows[i].Cells["買家帳號"].Value.ToString() == Program.Number
                    )
                {
                    this.dataGridView1.Rows[i].Visible = true;
                }
                else
                {
                    this.dataGridView1.Rows[i].Visible = false;
                }
            }

            //將處理那一行隱藏
            this.dataGridView1.Columns[9].Visible = false;
            this.dataGridView1.Columns[2].Visible = false;
            bool check = true;
            //計算已選購書籍的總價格
            for (int i = 1; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells["買家帳號"].Value.ToString() == Program.Number)
                {
                    check = false;
                    pri = pri + Int32.Parse(dataGridView1.Rows[i].Cells["價格"].Value.ToString());
                    this.sum_label.Text = "共" + pri + "元";
                    this.label2.Text = this.label2.Text + dataGridView1.Rows[i].Cells["書名"].Value.ToString() + "/"
                                        + dataGridView1.Rows[i].Cells["作者"].Value.ToString() + "/"
                                        + dataGridView1.Rows[i].Cells["價格"].Value.ToString() + "\n";
                }

            }
            if (check) 
            {
                pri = 0;
                this.sum_label.Text = "共" + pri + "元";

            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool ok = false;//判斷是否搜尋到資料
            DataSet ds = new DataSet();//宣告DataGridView
            ds.ReadXml("book.xml");
            dataGridView1.DataSource = ds.Tables["User"];

            for (int i = 1; i < dataGridView1.Rows.Count - 1; i++)//判斷輸入資料是否相符,只要一個字一樣就可以
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(dataGridView1.Rows[i].Cells["書名"].Value.ToString(), this.textBox1.Text, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    || System.Text.RegularExpressions.Regex.IsMatch(dataGridView1.Rows[i].Cells["作者"].Value.ToString(), this.textBox1.Text, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                {
                    this.dataGridView1.Rows[i].Visible = true;
                    ok = true;
                }
                else if (dataGridView1.Rows[i].Cells["書名"].Value.ToString() == "範例")
                {
                    this.dataGridView1.Rows[i].Visible = true;
                }
                else
                {
                    this.dataGridView1.Rows[i].Visible = false;

                }
            }
            if (ok == false)//如果未搜尋到
            {
                MessageBox.Show("查無資料");
                for (int i = 1; i < dataGridView1.Rows.Count - 1; i++)//重新載入
                {
                    if (dataGridView1.Rows[i].Cells["買家帳號"].Value.ToString() == ""
                        || dataGridView1.Rows[i].Cells["買家帳號"].Value.ToString() == "範例"
                        || dataGridView1.Rows[i].Cells["買家帳號"].Value.ToString() == Program.Number
                        )
                    {
                        this.dataGridView1.Rows[i].Visible = true;
                    }
                    else
                    {
                        this.dataGridView1.Rows[i].Visible = false;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            int pri = 0;//宣告價格變數

            //將選購書籍顯示到已選購清單
            for (int i = 1; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells["買家帳號"].Value.ToString() == Program.Number)
                {
                    
                    pri += Int32.Parse( dataGridView1.Rows[i].Cells["價格"].Value.ToString());
                    this.sum_label.Text = "共" + pri + "元";
                    this.label2.Text = this.label2.Text + dataGridView1.Rows[i].Cells["書名"].Value.ToString() + "/"
                                        + dataGridView1.Rows[i].Cells["作者"].Value.ToString() + "/"
                                        + dataGridView1.Rows[i].Cells["價格"].Value.ToString() + "\n";
                }
                this.timer1.Enabled = false;//停止更新
            }
        }

        private void sure_button_Click(object sender, EventArgs e)
        {
            this.label2.Text = "";//已選購書單清空
            //所選擇的那一欄得買家如果沒有人,則此書的買家欄位 =  自己的帳號
            Int32 selectedRowCount = this.dataGridView1.CurrentCell.RowIndex;
            if (dataGridView1.Rows[selectedRowCount].Cells["買家帳號"].Value.ToString() == "")
            {
                dataGridView1.Rows[selectedRowCount].Cells["買家帳號"].Value = Program.Number;
            }
            //開啟timer更新
            this.timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label2.Text = "";//已選購書單清空

            //所選擇的那一欄得買家如果帳號 = 自己的帳號 且 處理欄 != 已處理,將其清零取消
            //否則聯絡管理員
            Int32 selectedRowCount = this.dataGridView1.CurrentCell.RowIndex;
            if (dataGridView1.Rows[selectedRowCount].Cells["買家帳號"].Value.ToString() == Program.Number
                && dataGridView1.Rows[selectedRowCount].Cells["處理"].Value.ToString() != "已處理")
            {
                dataGridView1.Rows[selectedRowCount].Cells["買家帳號"].Value = "";
                dataGridView1.Rows[selectedRowCount].Cells["處理"].Value = "";

                int pri = 0;//宣告價格變數

                bool check = true;
                //將選購書籍顯示到已選購清單
                for (int i = 1; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells["買家帳號"].Value.ToString() == Program.Number)
                    {
                        check = false;
                        pri += Int32.Parse(dataGridView1.Rows[i].Cells["價格"].Value.ToString());
                        this.sum_label.Text = "共" + pri + "元";
                        this.label2.Text = this.label2.Text + dataGridView1.Rows[i].Cells["書名"].Value.ToString() + "/"
                                            + dataGridView1.Rows[i].Cells["作者"].Value.ToString() + "/"
                                            + dataGridView1.Rows[i].Cells["價格"].Value.ToString() + "\n";
                    }
                }
                if (check)
                {
                    pri = 0;
                    this.sum_label.Text = "共" + pri + "元";

                }
                this.timer1.Enabled = true;//啟動時間更新
            }
            else if (dataGridView1.Rows[selectedRowCount].Cells["處理"].Value.ToString() == "已處理")
            {
                MessageBox.Show("請聯絡管理員取消");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ds.WriteXml("book.xml");//寫入更新Xml
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount = this.dataGridView1.CurrentCell.RowIndex;

            if (dataGridView1.Rows[selectedRowCount].Cells["圖片"].Value.ToString() != "")
            {
                this.pictureBox1.Image = Image.FromFile(dataGridView1.Rows[selectedRowCount].Cells["圖片"].Value.ToString());
            }
            else
            {
                this.pictureBox1.Image = (Image)MyImage;
            }
        }
    }
}
