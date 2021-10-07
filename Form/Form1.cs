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


namespace Book
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public string myConnection = "datasource=localhost;username=root;password=admin; charset=utf8;";
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDataBase = new MySqlCommand("select * from login.user where User_ID='" + this.textBoxID.Text + "'and Password='" + this.textBoxPw.Text + "';", myConn);
            MySqlDataReader myReader;
            myConn.Open();//打開連線
            myReader = cmdDataBase.ExecuteReader();
            int count = 0;
            while (myReader.Read())
            {
                count = count + 1;
            }
            if (count == 1)
            {
                MessageBox.Show("成功登入!(Sucess!)");
                Program.Number = this.textBoxID.Text;
                Program.Name = string.Format( myReader["User_Name"].ToString());
               
                this.Hide();
                
                BookShop BS = new BookShop();
                
                BS.ShowDialog();
                
            }
            else if (count > 1)
            {
                MessageBox.Show("已登入!");
            }
            else
            {
                MessageBox.Show("ID或密碼錯誤!(Wrong ID or Password!)");
            }
            myConn.Close();
            

        }

        private void Register_Click(object sender, EventArgs e)
        {
            
            Register R = new Register();

            R.ShowDialog();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
