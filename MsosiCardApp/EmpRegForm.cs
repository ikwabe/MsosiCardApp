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
    public partial class EmpRegForm : Form
    {
        public EmpRegForm()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void phoneTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {

            }
        }
        static int centre_id;
        private void EmpRegForm_Load(object sender, EventArgs e)
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
        }

        private void regEmpBtn_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Today;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = msosicard;";

            string regEmp = "insert into employee(emp_name,address,phone,role,centre_id,date) values ('" + empNameTxt.Text.ToUpper() + "', '" + addressTxt.Text + "', '" + phoneTxt.Text + "','" + roleCombo.Text + "','" + centre_id + "','" + date + "')";
            string userlogin = "insert into login(username,password,category) values('" + userNameTxt.Text + "', 'msosi1234','"+ roleCombo.Text +"')";
            MySqlCommand com = new MySqlCommand(regEmp, con);
            MySqlCommand com1 = new MySqlCommand(userlogin, con);
            MySqlDataReader rd;
            try
            {
                con.Open();
                if(empNameTxt.Text != "" && addressTxt.Text != "" && phoneTxt.Text != "" && roleCombo.Text != "" && userNameTxt.Text != "")
                {
                    //insert into employee table
                    rd = com.ExecuteReader();
                    rd.Close();

                    //insert into login table
                    rd = com1.ExecuteReader();
                    rd.Close();

                    empNameTxt.Text = null;
                    phoneTxt.Text = null;
                    addressTxt.Text = null;
                    userNameTxt.Text = null;
                    MessageBox.Show("Employee Added");
                }
                else
                {
                    MessageBox.Show("Some Particulars are missing..!");
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
