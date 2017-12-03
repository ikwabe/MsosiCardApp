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

namespace MsosiCardApp
{
    public partial class userReg : Form
    {
        public userReg()
        {
            InitializeComponent();
        }
        static int centre_id;
        static int account_no;
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userNameTxt_OnValueChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = msosicard;";
            string chechAccount = "select max(account_no) from accounts";
            MySqlCommand com = new MySqlCommand(chechAccount, con);
            MySqlDataReader rd;
            DataTable table = new DataTable();
            try
            {
                con.Open();
                rd = com.ExecuteReader();
                while (rd.Read())
                {
                   try
                    {
                        int accno = int.Parse(rd.GetString("max(account_no)"));
                        account_no = accno + 1;
                    }
                    catch
                    {
                        account_no = 1;
                    }
                        
                    accountNumberLb.Text = "" + account_no;
                }
                rd.Close();
                

                 
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            con.Close();

        }
        private void phoneTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {

            }
        }
        private void userNameTxt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void balanceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {

            }
        }



        private void userReg_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = msosicard;";

            string centre = "select * from centre where centre_name = 'MSOSICARD GENERAL CENTRE' ";

            MySqlCommand com = new MySqlCommand(centre, con);
            MySqlDataAdapter ad;
            DataTable table = new DataTable();
            try
            {
                con.Open();
                ad = new MySqlDataAdapter(com);
                ad.Fill(table);

                centre_id = (int)table.Rows[0][0];

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            con.Close();
        }

        private void regUserBtn_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Today;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = msosicard;";
            string regUser = "insert into users(username,phone,joindate,centre_id) values('"+ userNameTxt.Text.ToUpper() + "','" + phoneTxt.Text + "','" + date.ToShortDateString() + "','" + centre_id + "')";
            string getUserId = "select * from users where phone = '" + phoneTxt.Text + "'";

            MySqlCommand com = new MySqlCommand(regUser, con);
            MySqlCommand com1 = new MySqlCommand(getUserId, con);
            

            MySqlDataReader rd;
            MySqlDataAdapter da;
            
            DataTable table = new DataTable();
            DataTable table1 = new DataTable();
            int user_id;
            try
            {
                con.Open();
                if (userNameTxt.Text != "" && phoneTxt.Text != "")
                {
                    string checkNumber = "select * from users where phone = '" + phoneTxt.Text + "'";
                    MySqlCommand chekcom = new MySqlCommand(checkNumber, con);

                    //checkin if the user exist
                    da = new MySqlDataAdapter(chekcom);
                    da.Fill(table1);
                    da.Dispose();

                    if(table1.Rows.Count > 0)
                    {
                        MessageBox.Show("User already registered");
                    }
                    else
                    {
                        //inserting data to users table
                        rd = com.ExecuteReader();
                        rd.Close();

                        //taking user_id from the table
                        da = new MySqlDataAdapter(com1);
                        da.Fill(table);
                        user_id = (int)table.Rows[0][0];
                        da.Dispose();

                        string account = "insert into accounts(account_no,balance,date,user_id) values('" + accountNumberLb.Text + "','" + balanceTxt.Text + "','" + date.ToShortDateString() + "','" + user_id + "')";
                        MySqlCommand com2 = new MySqlCommand(account, con);

                        if (accountNumberLb.Text != "" && balanceTxt.Text != "")
                        {
                            //inserting data to accounts table
                            rd = com2.ExecuteReader();
                            rd.Close();

                            userNameTxt.Text = null;
                            phoneTxt.Text = null;
                            balanceTxt.Text = null;
                            accountNumberLb.Text = null;
                            MessageBox.Show("User registered successful!");
                        }
                        else
                        {
                            MessageBox.Show("Balance is out of range or Account Number is not Set..!");

                        }
                    }

                }
                else
                {
                    MessageBox.Show("Please enter Username or Phone Number..!");
                }



                   
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }

            con.Close();
            

        }

       
    }
}
