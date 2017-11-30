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
    public partial class othersTab : UserControl
    {
        public string mboga;
        public othersTab()
        {
            InitializeComponent();
        }

        public static othersTab _instance;
        public static othersTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new othersTab();
                return _instance;
            }
        }
        private void kukuBtn_Click(object sender, EventArgs e)
        {
            mboga = kukuBtn.Text;

            //color transition

            kukuBtn.Normalcolor = Color.DarkGreen;
            nyamaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            samakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ndiziBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mayaiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            kkMshkakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ngmbMshkakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            sousageBtn.Normalcolor = Color.FromArgb(0, 122, 204);
           
        }

        private void nyamaBtn_Click(object sender, EventArgs e)
        {
            mboga = nyamaBtn.Text;

            //color transition

            nyamaBtn.Normalcolor = Color.DarkGreen;
            kukuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            samakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ndiziBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mayaiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            kkMshkakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ngmbMshkakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            sousageBtn.Normalcolor = Color.FromArgb(0, 122, 204);
        }

        private void samakiBtn_Click(object sender, EventArgs e)
        {
            mboga = samakiBtn.Text;

            //color transition

            samakiBtn.Normalcolor = Color.DarkGreen;
            nyamaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            kukuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ndiziBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mayaiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            kkMshkakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ngmbMshkakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            sousageBtn.Normalcolor = Color.FromArgb(0, 122, 204);
        }

        private void mayaiBtn_Click(object sender, EventArgs e)
        {
            mboga = mayaiBtn.Text;

            //color transition

            mayaiBtn.Normalcolor = Color.DarkGreen;
            nyamaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            samakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ndiziBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            kukuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            kkMshkakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ngmbMshkakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            sousageBtn.Normalcolor = Color.FromArgb(0, 122, 204);
        }

        private void sousageBtn_Click(object sender, EventArgs e)
        {
            mboga = sousageBtn.Text;

            //color transition

            sousageBtn.Normalcolor = Color.DarkGreen;
            nyamaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            samakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ndiziBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mayaiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            kkMshkakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ngmbMshkakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            kukuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
        }

        private void ndiziBtn_Click(object sender, EventArgs e)
        {
            mboga = ndiziBtn.Text;

            //color transition

            ndiziBtn.Normalcolor = Color.DarkGreen;
            nyamaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            samakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            kukuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mayaiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            kkMshkakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ngmbMshkakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            sousageBtn.Normalcolor = Color.FromArgb(0, 122, 204);
        }

        private void kkMshkakiBtn_Click(object sender, EventArgs e)
        {
            mboga = kkMshkakiBtn.Text;

            //color transition

            kkMshkakiBtn.Normalcolor = Color.DarkGreen;
            nyamaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            samakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ndiziBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mayaiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            kukuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ngmbMshkakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            sousageBtn.Normalcolor = Color.FromArgb(0, 122, 204);
        }

        private void ngmbMshkakiBtn_Click(object sender, EventArgs e)
        {
            mboga = ngmbMshkakiBtn.Text;

            //color transition

            ngmbMshkakiBtn.Normalcolor = Color.DarkGreen;
            nyamaBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            samakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            ndiziBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            mayaiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            kkMshkakiBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            kukuBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            sousageBtn.Normalcolor = Color.FromArgb(0, 122, 204);
        }

        //OUT STOKE VISIBLE BUTTON START
        private void kukuOutBtn_Click(object sender, EventArgs e)
        {
            kukuInBtn.Visible = true;
            kukuOutBtn.Visible = false;
            kukuBtn.Text = "KUKU";
            kukuBtn.Enabled = true;
        }

        private void nyamaOutBtn_Click(object sender, EventArgs e)
        {
            nyamaInBtn.Visible = true;
            nyamaOutBtn.Visible = false;
            nyamaBtn.Text = "NYAMA";
            nyamaBtn.Enabled = true;
        }

        private void samakiOutBtn_Click(object sender, EventArgs e)
        {
            samakiInBtn.Visible = true;
            samakiOutBtn.Visible = false;
            samakiBtn.Text = "SAMAKI";
            samakiBtn.Enabled = true;
        }

        private void mayaiOutBtn_Click(object sender, EventArgs e)
        {
            mayaiInBtn.Visible = true;
            mayaiOutBtn.Visible = false;
            mayaiBtn.Text = "YAI";
            mayaiBtn.Enabled = true;
        }

        private void sousageOutBtn_Click(object sender, EventArgs e)
        {
            sousageInBtn.Visible = true;
            sousageOutBtn.Visible = false;
            sousageBtn.Text = "SOUSAGE";
            sousageBtn.Enabled = true;
        }

        private void ndiziOutBtn_Click(object sender, EventArgs e)
        {
            ndiziInBtn.Visible = true;
            ndiziOutBtn.Visible = false;
            ndiziBtn.Text = "NDIZI";
            ndiziBtn.Enabled = true;
        }

        private void kkMshkakiOutBtn_Click(object sender, EventArgs e)
        {
            kkMshkakiInBtn.Visible = true;
            kkMshkakiOutBtn.Visible = false;
            kkMshkakiBtn.Text = "MSHKAKI KUKU";
            kkMshkakiBtn.Enabled = true;
        }

        private void ngmbMshkakiOutBtn_Click(object sender, EventArgs e)
        {
            ngmbMshkakiInBtn.Visible = true;
            ngmbMshkakiOutBtn.Visible = false;
            ngmbMshkakiBtn.Text = "MSHKAKI NG`OMBE";
            ngmbMshkakiBtn.Enabled = true;
        }

        //OUT STOKE VISIBLE BUTTON END

            //IN STOKE VISIBLE BUTTON START
        private void kukuInBtn_Click(object sender, EventArgs e)
        {
            kukuInBtn.Visible = false;
            kukuOutBtn.Visible = true;
            kukuBtn.Text = "OUT STOKE";
            kukuBtn.Enabled = false;
        }

        private void nyamaInBtn_Click(object sender, EventArgs e)
        {
            nyamaInBtn.Visible = false;
            nyamaOutBtn.Visible = true;
            nyamaBtn.Text = "OUT STOKE";
            nyamaBtn.Enabled = false;
        }

        private void samakiInBtn_Click(object sender, EventArgs e)
        {
            samakiInBtn.Visible = false;
            samakiOutBtn.Visible = true;
            samakiBtn.Text = "OUT STOKE";
            samakiBtn.Enabled = false;
        }

        private void mayaiInBtn_Click(object sender, EventArgs e)
        {
            mayaiInBtn.Visible = false;
            mayaiOutBtn.Visible = true;
            mayaiBtn.Text = "OUT STOKE";
            mayaiBtn.Enabled = false;
        }

        private void sousageInBtn_Click(object sender, EventArgs e)
        {
            sousageInBtn.Visible = false;
            sousageOutBtn.Visible = true;
            sousageBtn.Text = "OUT STOKE";
            sousageBtn.Enabled = false;
        }

        private void ndiziInBtn_Click(object sender, EventArgs e)
        {
            ndiziInBtn.Visible = false;
            ndiziOutBtn.Visible = true;
            ndiziBtn.Text = "OUT STOKE";
            ndiziBtn.Enabled = false;
        }

        private void kkMshkakiInBtn_Click(object sender, EventArgs e)
        {
            kkMshkakiInBtn.Visible = false;
            kkMshkakiOutBtn.Visible = true;
            kkMshkakiBtn.Text = "OUT STOKE";
            kkMshkakiBtn.Enabled = false;
        }

        private void ngmbMshkakiInBtn_Click(object sender, EventArgs e)
        {
            ngmbMshkakiInBtn.Visible = false;
            ngmbMshkakiOutBtn.Visible = true;
            ngmbMshkakiBtn.Text = "OUT STOKE";
            ngmbMshkakiBtn.Enabled = false;
        }
        //IN STOKE VISIBLE BUTTON END

            //EDIT BUTTON AND DONE BUTTON

        private void editBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            doneBtn.Visible = true;

        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            doneBtn.Visible = false;
        }
        //END OF EDIT AND DONE BUTTON
    }
}
