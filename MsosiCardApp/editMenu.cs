using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MsosiCardApp
{
    public partial class editMenu : Form
    {
        public editMenu()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addFoodBtn_Click(object sender, EventArgs e)
        {
           
            addFoodTab.Instance.Dock = DockStyle.Fill;
            controlPanel.Controls.Add(addFoodTab.Instance);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
           
        }
    }
}
