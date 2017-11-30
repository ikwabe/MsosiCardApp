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
    public partial class centreReg : Form
    {
        public centreReg()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void regCentBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = msosicard;";

            string regcentre = "insert into centre(centre_name) values ('" + centNameTxt.Text.ToUpper() + "')";

            MySqlCommand com = new MySqlCommand(regcentre, con);
            MySqlDataReader rd;
            try
            {
                con.Open();
                if(centNameTxt.Text != "")
                {
                    rd = com.ExecuteReader();
                    rd.Close();
                    centNameTxt.Text = null;
                    MessageBox.Show("Centre Added");
                }
                else
                {
                    MessageBox.Show("The Centre Name is not Set.!");
                }
               

            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void empRegBtn_Click(object sender, EventArgs e)
        {
            EmpRegForm emp = new EmpRegForm();
            this.Hide();
            emp.Show();
        }
    }
}
