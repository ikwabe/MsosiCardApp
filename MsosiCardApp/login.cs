using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MySql.Data.MySqlClient;

namespace MsosiCardApp
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        public static BunifuMaterialTextbox userNameTxt;
        private void login_Load(object sender, EventArgs e)
        {
            userNameTxt = new BunifuMaterialTextbox();
            userNameTxt.Size = new Size(318, 45);
            userNameTxt.BackColor = Color.FromArgb(64, 64, 64);
            userNameTxt.ForeColor = Color.FromArgb(240, 240, 240);
            userNameTxt.Font = new Font("Cambria", 11);
            userNameTxt.Location = new Point(112, 58);
            panel3.Controls.Add(userNameTxt);
            
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Today;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server = localhost; user = root; password = ikwabe04; database = msosicard;";
            string signIn = "select username,password from login where username = '" + userNameTxt.Text + "' and password = '" + passwordTxt.Text + "'";

            MySqlCommand com = new MySqlCommand(signIn, con);
            try
            {
                con.Open();
                MySqlDataReader reader;
                DataTable table = new DataTable();
                reader = com.ExecuteReader();
                table.Load(reader);
                reader.Close();

                if (table.Rows.Count > 0)
                {
                    passwordTxt.Enabled = false;
                    centreReg cntre = new centreReg();
                    cntre.Show();
                    this.Hide();
                }
                else
                {
                    label3.Text = "Wrong Password or Username.";
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
