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
    public partial class ugaliTab : UserControl
    {
        public string mboga;
        public static ugaliTab _instance;
        public static ugaliTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ugaliTab();
                return _instance;
            }
        }
        public ugaliTab()
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

        private void njegereBtn_Click(object sender, EventArgs e)
        {
            mboga = njegereBtn.Text;
        }

        private void utumboBtn_Click(object sender, EventArgs e)
        {
            mboga = utumboBtn.Text;
        }

        private void dagaaBtn_Click(object sender, EventArgs e)
        {
            mboga = dagaaBtn.Text;
        }

        private void kkMshkakiBtn_Click(object sender, EventArgs e)
        {
            mboga = kkMshkakiBtn.Text;
        }

        private void ngmbMshkakiBtn_Click(object sender, EventArgs e)
        {
            mboga = ngmbMshkakiBtn.Text;
        }

        private void maharageBtn_Click(object sender, EventArgs e)
        {
            mboga = maharageBtn.Text;
        }
    }
}
