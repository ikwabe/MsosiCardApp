using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
namespace MsosiCardApp
{
    public partial class drinksTab : UserControl
    {
        public string kinywaji;
        
        public static drinksTab _instance;
        public static drinksTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new drinksTab();
                return _instance;
            }
        }
        public drinksTab()
        {
            InitializeComponent();
        }
        BunifuFlatButton[] bt;
        FlowLayoutPanel flwPn = new FlowLayoutPanel();
        private void drinksTab_Load(object sender, EventArgs e)
        {
            
            bt = new BunifuFlatButton[2];
            for(int j = 0; j < 2; j++)
            {
               
                bt[j] = new BunifuFlatButton();
                bt[j].Name = "btn" + j.ToString();
                bt[j].TextFont = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                bt[j].Width = 200;
                bt[j].Height = 60;
                bt[j].Iconimage = null;
                bt[j].BorderRadius = 5;
                bt[j].Normalcolor = Color.FromArgb(0, 122, 204);
                bt[j].TextAlign = ContentAlignment.MiddleCenter;
                bt[j].Click += new EventHandler(bt_Click);
                if (j == 0)
                {
                    bt[j].Text = "JUICE";
                   
                }
                else
                {
                    
                   
                    bt[j].Text = "SODA";
                }
                flowLayoutPanel1.Controls.Add(bt[j]);
               
               
            }

        }
        int i = 1;
        private void bt_Click(object sender, EventArgs e)
        {
            bool check = true;
            timer1.Start();

            var button = sender as BunifuFlatButton;
            while(check == true)
            {
                BunifuFlatButton bt = new BunifuFlatButton();

                bt.Name = "btn" + i.ToString();
                bt.TextFont = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                bt.Width = 380;
                bt.Height = 40;
                bt.Iconimage = null;
                bt.BorderRadius = 5;
                bt.Normalcolor = Color.FromArgb(0, 122, 204);
                bt.TextAlign = ContentAlignment.MiddleCenter;
                if (button.Text == "JUICE")
                {
                    
                    bt.Text = "JUICE YA " + i.ToString();
                    flowLayoutPanel2.Controls.Add(bt);
                }
                else
                {
                    bt.Text = "SODA YA " + i.ToString();
                    flwPn.Visible = false;
                    flwPn.Dock = DockStyle.Fill;
                    flwPn.FlowDirection = FlowDirection.TopDown;
                    flwPn.WrapContents = false;
                    flwPn.Controls.Add(bt);
                    panel1.Controls.Add(flwPn);
                }
                
                
                check = false;
                
            }
            i++;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            animator.ShowSync(flwPn);
            
               
        }
    }
}
