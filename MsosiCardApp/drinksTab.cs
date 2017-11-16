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
        static int count = 1;
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

           
        }

        private void sodaBtn_Click(object sender, EventArgs e)
        {
            animator.Show(sodaPannel);
            juicePanel.Visible = false;
            sodaBtn.Normalcolor = Color.DarkGreen;
            juiceBtn.Normalcolor = Color.FromArgb(0, 122, 204);

           

        }

        //soda
        private void pepsiBtn_Click(object sender, EventArgs e)
        {
           if(count % 2 == 1)
            {
                kinywaji = pepsiBtn.Text;

                //color transition
                pepsiBtn.Normalcolor = Color.DarkGreen;
                mirindaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
                svnUpBtn.Normalcolor = Color.FromArgb(0, 122, 204);
                mntnDewBtn.Normalcolor = Color.FromArgb(0, 122, 204);
                cocacolaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
                fantaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
                spriteBtn.Normalcolor = Color.FromArgb(0, 122, 204);
                evervsBtn.Normalcolor = Color.FromArgb(0, 122, 204);
                tropicalBtn.Normalcolor = Color.FromArgb(0, 122, 204);
                mangoBtn.Normalcolor = Color.FromArgb(0, 122, 204);
                avocadoBtn.Normalcolor = Color.FromArgb(0, 122, 204);
                ukwajuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
                ubuyuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
                pineAppleBtn.Normalcolor = Color.FromArgb(0, 122, 204);
                pasionBtn.Normalcolor = Color.FromArgb(0, 122, 204);
                tendeBtn.Normalcolor = Color.FromArgb(0, 122, 204);


               
            }
           else
            {
                kinywaji = null;
                pepsiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            }
                
                count++;
           
        }
         
        private void mirindaBtn_Click(object sender, EventArgs e)
        {
            kinywaji = mirindaBtn.Text;

            //color transition
            mirindaBtn.Normalcolor = Color.DarkGreen;
            pepsiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            svnUpBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mntnDewBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            cocacolaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            fantaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            spriteBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            evervsBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            tropicalBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mangoBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            avocadoBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ukwajuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ubuyuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pineAppleBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pasionBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            tendeBtn.Normalcolor = Color.FromArgb(0, 122, 204);
        }

        private void svnUpBtn_Click(object sender, EventArgs e)
        {
            kinywaji = svnUpBtn.Text;

            //color transition
            svnUpBtn.Normalcolor = Color.DarkGreen;
            mirindaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pepsiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mntnDewBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            cocacolaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            fantaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            spriteBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            evervsBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            tropicalBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mangoBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            avocadoBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ukwajuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ubuyuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pineAppleBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pasionBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            tendeBtn.Normalcolor = Color.FromArgb(0, 122, 204);
        }

        private void mntnDewBtn_Click(object sender, EventArgs e)
        {
            kinywaji = mntnDewBtn.Text;

            //color transition
            mntnDewBtn.Normalcolor = Color.DarkGreen;
            mirindaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            svnUpBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pepsiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            cocacolaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            fantaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            spriteBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            evervsBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            tropicalBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mangoBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            avocadoBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ukwajuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ubuyuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pineAppleBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pasionBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            tendeBtn.Normalcolor = Color.FromArgb(0, 122, 204);
        }

        private void cocacolaBtn_Click(object sender, EventArgs e)
        {
            kinywaji = cocacolaBtn.Text;

            //color transition
            cocacolaBtn.Normalcolor = Color.DarkGreen;
            mirindaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            svnUpBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mntnDewBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pepsiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            fantaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            spriteBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            evervsBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            tropicalBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mangoBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            avocadoBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ukwajuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ubuyuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pineAppleBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pasionBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            tendeBtn.Normalcolor = Color.FromArgb(0, 122, 204);
        }

        private void fantaBtn_Click(object sender, EventArgs e)
        {
            kinywaji = fantaBtn.Text;

            //color transition
            fantaBtn.Normalcolor = Color.DarkGreen;
            mirindaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            svnUpBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mntnDewBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            cocacolaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pepsiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            spriteBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            evervsBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            tropicalBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mangoBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            avocadoBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ukwajuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ubuyuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pineAppleBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pasionBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            tendeBtn.Normalcolor = Color.FromArgb(0, 122, 204);
        }

        private void spriteBtn_Click(object sender, EventArgs e)
        {
            kinywaji = spriteBtn.Text;

            //color transition
            spriteBtn.Normalcolor = Color.DarkGreen;
            mirindaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            svnUpBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mntnDewBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            cocacolaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            fantaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pepsiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            evervsBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            tropicalBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mangoBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            avocadoBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ukwajuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ubuyuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pineAppleBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pasionBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            tendeBtn.Normalcolor = Color.FromArgb(0, 122, 204);
        }

        private void evervsBtn_Click(object sender, EventArgs e)
        {
            kinywaji = evervsBtn.Text;

            //color transition
            evervsBtn.Normalcolor = Color.DarkGreen;
            mirindaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            svnUpBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mntnDewBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            cocacolaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            fantaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            spriteBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pepsiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            tropicalBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mangoBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            avocadoBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ukwajuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ubuyuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pineAppleBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pasionBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            tendeBtn.Normalcolor = Color.FromArgb(0, 122, 204);
        }

        //Juice

        private void tropicalBtn_Click(object sender, EventArgs e)
        {
            kinywaji = tropicalBtn.Text;

            //color transition
            tropicalBtn.Normalcolor = Color.DarkGreen;
            mangoBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            avocadoBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ukwajuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ubuyuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pineAppleBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pasionBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            tendeBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mirindaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            svnUpBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mntnDewBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            cocacolaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            fantaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            spriteBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pepsiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            evervsBtn.Normalcolor = Color.FromArgb(0, 122, 204);
        }

        private void mangoBtn_Click(object sender, EventArgs e)
        {
            kinywaji = mangoBtn.Text;

            //color transition
            mangoBtn.Normalcolor = Color.DarkGreen;
            tropicalBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            avocadoBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ukwajuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ubuyuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pineAppleBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pasionBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            tendeBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mirindaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            svnUpBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mntnDewBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            cocacolaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            fantaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            spriteBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pepsiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            evervsBtn.Normalcolor = Color.FromArgb(0, 122, 204);
        }

        private void avocadoBtn_Click(object sender, EventArgs e)
        {
            kinywaji = avocadoBtn.Text;

            //color transition
            avocadoBtn.Normalcolor = Color.DarkGreen;
            mangoBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            tropicalBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ukwajuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ubuyuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pineAppleBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pasionBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            tendeBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mirindaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            svnUpBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mntnDewBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            cocacolaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            fantaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            spriteBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pepsiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            evervsBtn.Normalcolor = Color.FromArgb(0, 122, 204);
        }

        private void ukwajuBtn_Click(object sender, EventArgs e)
        {
            kinywaji = ukwajuBtn.Text;

            //color transition
            ukwajuBtn.Normalcolor = Color.DarkGreen;
            mangoBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            avocadoBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            tropicalBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ubuyuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pineAppleBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pasionBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            tendeBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mirindaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            svnUpBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mntnDewBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            cocacolaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            fantaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            spriteBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pepsiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            evervsBtn.Normalcolor = Color.FromArgb(0, 122, 204);
        }

        private void ubuyuBtn_Click(object sender, EventArgs e)
        {
            kinywaji = ubuyuBtn.Text;

            //color transition
            ubuyuBtn.Normalcolor = Color.DarkGreen;
            mangoBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            avocadoBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ukwajuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            tropicalBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pineAppleBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pasionBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            tendeBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mirindaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            svnUpBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mntnDewBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            cocacolaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            fantaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            spriteBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pepsiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            evervsBtn.Normalcolor = Color.FromArgb(0, 122, 204);
        }

        private void pineAppleBtn_Click(object sender, EventArgs e)
        {
            kinywaji = pineAppleBtn.Text;

            //color transition
            pineAppleBtn.Normalcolor = Color.DarkGreen;
            mangoBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            avocadoBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ukwajuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ubuyuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            tropicalBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pasionBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            tendeBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mirindaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            svnUpBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mntnDewBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            cocacolaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            fantaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            spriteBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pepsiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            evervsBtn.Normalcolor = Color.FromArgb(0, 122, 204);
        }

        private void pasionBtn_Click(object sender, EventArgs e)
        {
            kinywaji = pasionBtn.Text;

            //color transition
            pasionBtn.Normalcolor = Color.DarkGreen;
            mangoBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            avocadoBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ukwajuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ubuyuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pineAppleBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            tropicalBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            tendeBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mirindaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            svnUpBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mntnDewBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            cocacolaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            fantaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            spriteBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pepsiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            evervsBtn.Normalcolor = Color.FromArgb(0, 122, 204);
        }

        private void tendeBtn_Click(object sender, EventArgs e)
        {
            kinywaji = tendeBtn.Text;

            //color transition
            tendeBtn.Normalcolor = Color.DarkGreen;
            mangoBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            avocadoBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ukwajuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ubuyuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pineAppleBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pasionBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            tropicalBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mirindaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            svnUpBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mntnDewBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            cocacolaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            fantaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            spriteBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            pepsiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            evervsBtn.Normalcolor = Color.FromArgb(0, 122, 204);
        }
    }
}
