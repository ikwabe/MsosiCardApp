using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MsosiCardApp
{
    public partial class addFoodTab : UserControl
    {
        public addFoodTab()
        {
            InitializeComponent();
        }

        public static addFoodTab _instance;
        public static addFoodTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new addFoodTab();
                return _instance;
            }
        }

        private void insertData()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = msosicard;";

            string addMainMenu = "insert into main_mess (mess_name) values('" + mainFoodTxt.Text.ToUpper() + "') ";
            string addSubMenu = "insert into sub_mess (mess_name) values('" + subFoodTxt.Text.ToUpper() + "') ";

            MySqlCommand com = new MySqlCommand(addMainMenu, con);
            MySqlCommand com1 = new MySqlCommand(addSubMenu, con);

            MySqlDataReader rd;
            try
            {
                con.Open();

                if (mainFoodTxt.Text != "" && subFoodTxt.Text != "")
                {
                    rd = com.ExecuteReader();
                    rd.Close();
                    rd = com1.ExecuteReader();
                    rd.Close();
                    mainFoodTxt.Text = "";
                    subFoodTxt.Text = "";
                }
                else if (mainFoodTxt.Text != "" && subFoodTxt.Text == "")
                {
                    rd = com.ExecuteReader();
                    rd.Close();
                    mainFoodTxt.Text = "";
                    subFoodTxt.Text = "";
                }
                else if (mainFoodTxt.Text == "" && subFoodTxt.Text != "")
                {
                    rd = com1.ExecuteReader();
                    rd.Close();
                    mainFoodTxt.Text = "";
                    subFoodTxt.Text = "";
                }
                else
                {
                    MessageBox.Show("Error");
                    mainFoodTxt.Text = "";
                    subFoodTxt.Text = "";
                }

                timer1.Start();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            con.Close();
        }

        private void addNewFoodBtn_Click(object sender, EventArgs e)
        {
            insertData();
        }

        private void loadMenu()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = msosicard;";

            string LoadMainMenu = "select mess_name 'MAIN FOOD' from main_mess ";
            string LoadSubMenu = "select mess_name 'SUB FOOD' from sub_mess";

            MySqlCommand com = new MySqlCommand(LoadMainMenu, con);
            MySqlCommand com1 = new MySqlCommand(LoadSubMenu, con);

            MySqlDataReader rd;
            DataTable table = new DataTable();
            DataTable table1 = new DataTable();

            try
            {
                con.Open();

                //taking main food from the table
                rd = com.ExecuteReader();
                table.Load(rd);
                rd.Close();

                //taking sub food from table
                rd = com1.ExecuteReader();
                table1.Load(rd);
                rd.Close();

                mainFoodGrid.DataSource = table;
                subFoodGrid.DataSource = table1;


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            con.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            loadMenu();

        }

        private void mainFoodTxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void addFoodTab_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void mainFoodTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                insertData();
            }
            else
            {

            }
        }

        private void searchMainTxt_OnValueChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = msosicard;";

            string LoadMainMenu = "select mess_name 'MAIN FOOD' from main_mess where mess_name like '"+ searchMainTxt.Text +"%' ";
            MySqlCommand com = new MySqlCommand(LoadMainMenu, con);

            MySqlDataReader rd;
            DataTable table = new DataTable();

            try
            {
                con.Open();

                //taking main food from the table
                rd = com.ExecuteReader();
                table.Load(rd);
                rd.Close();

                mainFoodGrid.DataSource = table;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            con.Close();
        }

        private void searchSubTxt_OnValueChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = msosicard;";

            string LoadSubMenu = "select mess_name 'MAIN FOOD' from sub_mess where mess_name like '" + searchSubTxt.Text + "%' ";
            MySqlCommand com = new MySqlCommand(LoadSubMenu, con);

            MySqlDataReader rd;
            DataTable table = new DataTable();

            try
            {
                con.Open();

                //taking main food from the table
                rd = com.ExecuteReader();
                table.Load(rd);
                rd.Close();

                subFoodGrid.DataSource = table;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            con.Close();

        }
    }
}
