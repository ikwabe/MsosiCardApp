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

        private void juiceBtn_Click(object sender, EventArgs e)
        {
            animator.Show(juicePanel);
            sodaPannel.Visible = false;
            juiceBtn.Normalcolor = Color.DarkGreen;
            sodaBtn.Normalcolor = Color.FromArgb(0, 122, 204);

            //case
            kinywaji = juiceBtn.Text;
        }

        private void sodaBtn_Click(object sender, EventArgs e)
        {
            animator.Show(sodaPannel);
            juicePanel.Visible = false;
            sodaBtn.Normalcolor = Color.DarkGreen;
            juiceBtn.Normalcolor = Color.FromArgb(0, 122, 204);

            //case
            kinywaji = sodaBtn.Text;

        }

        //soda
        private void pepsiBtn_Click(object sender, EventArgs e)
        {
            kinywaji = pepsiBtn.Text;
        }

        private void mirindaBtn_Click(object sender, EventArgs e)
        {
            kinywaji = mirindaBtn.Text;
        }

        private void svnUpBtn_Click(object sender, EventArgs e)
        {
            kinywaji = svnUpBtn.Text;
        }

        private void mntnDewBtn_Click(object sender, EventArgs e)
        {
            kinywaji = mntnDewBtn.Text;
        }

        private void cocacolaBtn_Click(object sender, EventArgs e)
        {
            kinywaji = cocacolaBtn.Text;
        }

        private void fantaBtn_Click(object sender, EventArgs e)
        {
            kinywaji = fantaBtn.Text;
        }

        private void spriteBtn_Click(object sender, EventArgs e)
        {
            kinywaji = spriteBtn.Text;
        }

        private void evervsBtn_Click(object sender, EventArgs e)
        {
            kinywaji = evervsBtn.Text;
        }

        //Juice

        private void tropicalBtn_Click(object sender, EventArgs e)
        {
            kinywaji = tropicalBtn.Text;
        }

        private void mangoBtn_Click(object sender, EventArgs e)
        {
            kinywaji = mangoBtn.Text;
        }

        private void avocadoBtn_Click(object sender, EventArgs e)
        {
            kinywaji = avocadoBtn.Text;
        }

        private void ukwajuBtn_Click(object sender, EventArgs e)
        {
            kinywaji = ukwajuBtn.Text;
        }

        private void ubuyuBtn_Click(object sender, EventArgs e)
        {
            kinywaji = ubuyuBtn.Text;
        }

        private void pineAppleBtn_Click(object sender, EventArgs e)
        {
            kinywaji = pineAppleBtn.Text;
        }

        private void pasionBtn_Click(object sender, EventArgs e)
        {
            kinywaji = pasionBtn.Text;
        }

        private void tendeBtn_Click(object sender, EventArgs e)
        {
            kinywaji = tendeBtn.Text;
        }
    }
}
