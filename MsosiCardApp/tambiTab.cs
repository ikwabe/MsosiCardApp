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
    public partial class tambiTab : UserControl
    {
        public string mboga;
        public static tambiTab _instance;
        public static tambiTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new tambiTab();
                return _instance;
            }
        }
        public tambiTab()
        {
            InitializeComponent();
        }

        private void kukuBtn_Click(object sender, EventArgs e)
        {
            mboga = kukuBtn.Text;

            //color transition

            kukuBtn.Normalcolor = Color.DarkGreen;
            nyamaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            samakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            maharageBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            njegereBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            kkMshkakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ngmbMshkakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mainiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            utumboBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            dagaaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
        }

        private void nyamaBtn_Click(object sender, EventArgs e)
        {
            mboga = nyamaBtn.Text;

            //color transition

            nyamaBtn.Normalcolor = Color.DarkGreen;
            kukuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            samakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            maharageBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            njegereBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            kkMshkakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ngmbMshkakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mainiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            utumboBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            dagaaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
        }

        private void samakiBtn_Click(object sender, EventArgs e)
        {
            mboga = samakiBtn.Text;

            //color transition

            samakiBtn.Normalcolor = Color.DarkGreen;
            nyamaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            kukuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            maharageBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            njegereBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            kkMshkakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ngmbMshkakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mainiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            utumboBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            dagaaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
        }

        private void mainiBtn_Click(object sender, EventArgs e)
        {
            mboga = mainiBtn.Text;

            //color transition

            mainiBtn.Normalcolor = Color.DarkGreen;
            nyamaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            samakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            maharageBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            njegereBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            kkMshkakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ngmbMshkakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            kukuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            utumboBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            dagaaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
        }

        private void njegereBtn_Click(object sender, EventArgs e)
        {
            mboga = njegereBtn.Text;

            //color transition

            njegereBtn.Normalcolor = Color.DarkGreen;
            nyamaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            samakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            maharageBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            kukuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            kkMshkakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ngmbMshkakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mainiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            utumboBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            dagaaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
        }

        private void utumboBtn_Click(object sender, EventArgs e)
        {
            mboga = utumboBtn.Text;

            //color transition

            utumboBtn.Normalcolor = Color.DarkGreen;
            nyamaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            samakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            maharageBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            njegereBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            kkMshkakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ngmbMshkakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mainiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            kukuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            dagaaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
        }

        private void dagaaBtn_Click(object sender, EventArgs e)
        {
            mboga = dagaaBtn.Text;

            //color transition

            dagaaBtn.Normalcolor = Color.DarkGreen;
            nyamaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            samakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            maharageBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            njegereBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            kkMshkakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ngmbMshkakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mainiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            utumboBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            kukuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
        }

        private void maharageBtn_Click(object sender, EventArgs e)
        {
            mboga = maharageBtn.Text;
            //color transition

            maharageBtn.Normalcolor = Color.DarkGreen;
            nyamaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            samakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            kukuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            njegereBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            kkMshkakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ngmbMshkakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mainiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            utumboBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            dagaaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
        }

        private void kkMshkakiBtn_Click(object sender, EventArgs e)
        {
            mboga = kkMshkakiBtn.Text;

            //color transition

            kkMshkakiBtn.Normalcolor = Color.DarkGreen;
            nyamaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            samakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            maharageBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            njegereBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            kukuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ngmbMshkakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mainiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            utumboBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            dagaaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
        }

        private void ngmbMshkakiBtn_Click(object sender, EventArgs e)
        {
            mboga = ngmbMshkakiBtn.Text;

            //color transition

            ngmbMshkakiBtn.Normalcolor = Color.DarkGreen;
            nyamaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            samakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            maharageBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            njegereBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            kkMshkakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            kukuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mainiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            utumboBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            dagaaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
        }
    }
}
