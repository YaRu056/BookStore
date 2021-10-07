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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
         public Boolean checkTextBoxesValues()
         {
             if (textBoxPw.Text == "" || textBoxID.Text == "" || textBoxName.Text == "" || textBoxNumber.Text == "" || textBoxEM.Text == "")
             {
                 return true;
             }
             else
             {
                 return false;
             }
         }
         public Boolean checkUserid()
         {
             string con = "datasource=localhost;username=root;password=admin;charset=utf8;";
             MySqlConnection Database = new MySqlConnection(con);
             Database.Open();


             String userID = textBoxID.Text;

             DataTable table = new DataTable();

             MySqlDataAdapter adapter = new MySqlDataAdapter();

             MySqlCommand command = new MySqlCommand("SELECT * FROM login.user WHERE `User_ID` = @uid", Database);

             command.Parameters.Add("@uid", MySqlDbType.VarChar).Value = userID;

             adapter.SelectCommand = command;

             adapter.Fill(table);

             // check if this username already exists in the database
             if (table.Rows.Count > 0)
             {
                 return true;
             }
             else
             {
                 return false;
             }

         }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string con = "datasource=localhost;username=root;password=admin;charset=utf8;";
                string Query = "insert into login.user(User_ID, Password, User_Name, User_Number, User_EM) VALUES ('" + this.textBoxID.Text + "','" + this.textBoxPw.Text + "','" + this.textBoxName.Text + "','" + this.textBoxNumber.Text + "','" + this.textBoxEM.Text + "');";
                MySqlConnection Database = new MySqlConnection(con);
                Database.Open(); 
                
                MySqlCommand cmd = new MySqlCommand(Query, Database);
                /*command.Parameters.Add("@uid", MySqlDbType.VarChar).Value = textBoxID.Text;
                command.Parameters.Add("@upw", MySqlDbType.VarChar).Value = textBoxPw.Text;
                command.Parameters.Add("@una", MySqlDbType.VarChar).Value = textBoxName.Text;
                command.Parameters.Add("@unu", MySqlDbType.VarChar).Value = textBoxNumber.Text;
                command.Parameters.Add("@uem", MySqlDbType.Text).Value = textBoxEM.Text;
                */

                if (!checkTextBoxesValues())
                {
                    // check if the password equal the confirm password
                    if (textBoxPw.Text.Equals(textBoxConfirmPw.Text))
                    {
                        // check if this username already exists
                        if (checkUserid())
                        {
                            MessageBox.Show("ID已存在，請重新輸入ID", "ID錯誤", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                        else
                        {
                            // execute the query
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("註冊成功!", "註冊成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                Login f = new Login();
                                f.Show();
                            }
                            else
                            {
                                MessageBox.Show("錯誤");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("確認密碼錯誤", "密碼錯誤", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("請輸入內容", "內容錯誤", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                
            }

            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }


        }


        }
}
