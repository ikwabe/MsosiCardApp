using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MsosiCardApp
{
    public partial class chipsTab : UserControl
    {
        public string mboga;
        public static chipsTab _instance;
        public static chipsTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new chipsTab();
                return _instance;
            }
        }
        public chipsTab()
        {
            InitializeComponent();
        }



        private void kukuBtn_Click(object sender, EventArgs e)
        {
            mboga = kukuBtn.Text;

        }

        private void nyamaBtn_Click(object sender, EventArgs e)
        {
            mboga = nyamaBtn.Text;

        }

        private void samakiBtn_Click(object sender, EventArgs e)
        {
            mboga = samakiBtn.Text;
        }

        private void mainiBtn_Click(object sender, EventArgs e)
        {
            mboga = mainiBtn.Text;
        }

        private void kkMshkakiBtn_Click(object sender, EventArgs e)
        {
            mboga = kkMshkakiBtn.Text;
        }

        private void ngmbMshkakiBtn_Click(object sender, EventArgs e)
        {
            mboga = ngmbMshkakiBtn.Text;
        }

       
        private void kavuBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            animator.ShowSync(panel1);
            kavuBtn.Normalcolor = Color.DarkGreen;
            mayaiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
           if(panel1.Visible == false)
            {
                panel1.Visible = true;
            }
        }

        
        private void mayaiBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            animator.ShowSync(panel1);
            mayaiBtn.Normalcolor = Color.DarkGreen;
            kavuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }


        }
    }
}
