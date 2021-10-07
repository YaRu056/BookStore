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
    public partial class UC_Sell : UserControl
    {
        DataSet ds = new DataSet();
        string PicPath;
        Image picture;
        private Bitmap MyImage;
        private string ID="",USName="";
       // private int row;
       // private string check;
        public UC_Sell()
        {
            InitializeComponent();
        }
        private void UC_Sell_Load(object sender, EventArgs e)
        {
            ID = Program.Number;
            USName = Program.Name;
            ds.ReadXml("book.xml");
            dataGridView1.DataSource = ds.Tables["User"];
            
           /* DataGridView checkdata = new DataGridView();
            row = dataGridView1.Rows.Count;
            label7.Text = row.ToString();
            int i = 1;
            label7.Text = checkdata.Rows. .Cells[0].Value.ToString();
            foreach (DataGridViewRow dr in dataGridView1.Rows) //自己帳號只可看見自己所販賣的書
              {
                check = dr.Cells[0].Value.ToString();
                if (check == ID)//判斷每個帳號是否為自己帳號
                {
                    dr.Visible = true; //帳號為自己的帳號，設為可視(Visible只是在dataGridView1中隱藏，不會影響索引值)
                }
                else 
                {
                    dr.Visible = false;
                }

              } */
            dataGridView1.Columns[2].Visible = false;//隱藏圖片的路徑資料列
            this.comboBox2.Visible = false;
            DataColumn dc = ds.Tables["User"].Columns["書名"];//在User DataTable建立書名為主鍵
            ds.Tables["User"].Constraints.Add("PK_書名", dc, true); //主鍵名稱為"PK_書名"

        }
        private void btnPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Open Image";
            openFileDialog1.Filter = "JPeg Image|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                picture = Image.FromFile(openFileDialog1.FileName);
            }
            
        }
        public Boolean checkTextBoxesValues()
        {
            if (textBoxBook.Text == "" || textBoxAuthor.Text == "" || textBoxQuantity.Text == "" || textBoxPrice.Text == "" || textBoxNote.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!checkTextBoxesValues())
            {
                this.pictureBox1.BackColor = Color.WhiteSmoke;
                DataRow dr;
                dr = ds.Tables["User"].Rows.Find(textBoxBook.Text); //是否"書名"和textBoxBook.Text重複

                if (dr == null) // 若無重複
                {
                    string CorrectFileName = textBoxBook.Text;//取得書名作為圖片檔名
                    PicPath = "\\images\\" + CorrectFileName;//建立圖片路徑的字串
                    picture.Save(Application.StartupPath + PicPath);//以PicPath字串作為檔名存檔

                    DataRow bookRow = ds.Tables["User"].NewRow();
                    bookRow["帳號"] =ID;
                    bookRow["賣家名稱"] = USName;
                    bookRow["圖片"] = Application.StartupPath + PicPath;
                    bookRow["書名"] = textBoxBook.Text;
                    bookRow["作者"] = textBoxAuthor.Text;
                    bookRow["價格"] = textBoxPrice.Text;
                    bookRow["數量"] = textBoxQuantity.Text;
                    bookRow["註記"] = textBoxNote.Text;
                    bookRow["處理"] = "待處理";

                    ds.Tables["User"].Rows.Add(bookRow);
                    MessageBox.Show("書名" + "這筆記錄已在記憶體中新增完成");
                    
                }
                else //若重複
                {
                    MessageBox.Show("書名" + "重複新增，記憶體已有此筆資料");
                }
               /* for (int i = 1; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells["帳號"].Value.ToString() == "CBE107047")//判斷每個帳號是否為ID(自己帳號)
                    {
                        this.dataGridView1.Rows[i].Visible = true; //帳號為ID，設為可視
                        //須注意Visible只是在dataGridView1中隱藏，不會影響索引值
                        
                    }
                    else
                    {
                        this.dataGridView1.Rows[i].Visible = false; //帳號非ID，設為不可視
                    }

                }*/
                
            }
            else 
            {
                MessageBox.Show("請確實完整填寫資料!");

            }
            textBoxBook.Text = "";
            textBoxPrice.Text = "";
            textBoxAuthor.Text = "";
            textBoxQuantity.Text = "";
            textBoxNote.Text = "";
            pictureBox1.Image= (Image)MyImage;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            DataRow dr;
            dr = ds.Tables["User"].Rows.Find(textBoxBook.Text); //是否"書名"和textBoxBook.Text重複
            if (dr == null) // 若無重複
            {
                MessageBox.Show("找不到此書");
            }
            else
            {
                if (!checkTextBoxesValues())
                {
                    string path = dr["圖片"].ToString();
                    System.IO.File.Delete(path);

                    string CorrectFileName = textBoxBook.Text;//取得書名作為圖片檔名
                    PicPath = "\\images\\" + CorrectFileName;//建立圖片路徑的字串
                    picture.Save(Application.StartupPath + PicPath);//以PicPath字串作為檔名存檔
                    dr["書名"] = textBoxBook.Text;
                    dr["作者"] = textBoxAuthor.Text;
                    dr["價格"] = textBoxPrice.Text;
                    dr["數量"] = textBoxQuantity.Text;
                    dr["註記"] = textBoxNote.Text;
                    dr["圖片"] = Application.StartupPath + PicPath;
                    MessageBox.Show("書名" + "這筆記錄已在記憶體中更新完成");
                }
                else
                {
                    MessageBox.Show("請確實完整填寫資料!");

                }
                textBoxBook.Text = "";
                textBoxPrice.Text = "";
                textBoxAuthor.Text = "";
                textBoxQuantity.Text = "";
                textBoxNote.Text = "";
                pictureBox1.Image = (Image)MyImage;
                
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ds.WriteXml("book.xml"); //同時更新XML檔
            MessageBox.Show("此為最新資料");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Int32 selectedRowCount = this.dataGridView1.CurrentCell.RowIndex;

            if (dataGridView1.Rows[selectedRowCount].Cells["圖片"].Value.ToString() != "")
            {
                this.pictureBox2.Image = Image.FromFile(dataGridView1.Rows[selectedRowCount].Cells["圖片"].Value.ToString());
            }
            else 
            {
                this.pictureBox2.Image = (Image)MyImage;
            }
            if (dataGridView1.Rows[selectedRowCount].Cells["買家帳號"].Value.ToString() == "")
            {
                this.comboBox2.Visible = false;
            }
            else
            {
                this.comboBox2.Visible = true;
            }
        }

      

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32 selectedRowCount = this.dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[selectedRowCount].Cells["處理"].Value = comboBox2.Text.ToString();
        }


       
    }
}
