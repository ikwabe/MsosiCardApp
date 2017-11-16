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
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
        }
        public string chakula;
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            qntTxt.Text += Btn1.Text;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            qntTxt.Text += Btn2.Text;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            qntTxt.Text += Btn3.Text;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            qntTxt.Text += Btn4.Text;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            qntTxt.Text += Btn5.Text;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            qntTxt.Text += Btn6.Text;
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            qntTxt.Text += Btn7.Text;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            qntTxt.Text += Btn8.Text;
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            qntTxt.Text += Btn9.Text;
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            qntTxt.Text += Btn0.Text;
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            string s = qntTxt.Text;

            if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
            }
            else
            {
                s = "";
            }

            qntTxt.Text = s;
        }

        private void drinksBtn_Click(object sender, EventArgs e)
        {
            verticalTransEffect.ShowSync(drinksTab.Instance);
            menuPanel.Controls.Add(drinksTab.Instance);
            drinksTab.Instance.Dock = DockStyle.Fill;
            drinksTab.Instance.Visible = true;
            waliTab.Instance.Visible = false;
            chipsTab.Instance.Visible = false;
            ugaliTab.Instance.Visible = false;
            ndiziTab.Instance.Visible = false;
            viaziTab.Instance.Visible = false;
            tambiTab.Instance.Visible = false;
            pilauTab.Instance.Visible = false;
            submitBtn.Visible = true;

            //taking the name of the menu
            chakula = drinksBtn.Text;

           

            //submit and done button
            submitBtn.Visible = true;
            doneBtn.Visible = false;

            //color transition

            drinksBtn.Normalcolor = Color.Purple;
            waliBtn.BackColor = Color.FromArgb(0, 122, 204);
            ugaliBtn.BackColor = Color.FromArgb(0, 122, 204);
            chipsBtn.BackColor = Color.FromArgb(0, 122, 204);
            ndiziBtn.BackColor = Color.FromArgb(0, 122, 204);
            pilauBtn.BackColor = Color.FromArgb(0, 122, 204);
            tambiBtn.BackColor = Color.FromArgb(0, 122, 204);
            viaziBtn.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void waliBtn_Click(object sender, EventArgs e)
        {
            holizotalTransEffect.ShowSync(waliTab.Instance);
            menuPanel.Controls.Add(waliTab.Instance);
            waliTab.Instance.Dock = DockStyle.Fill;
            drinksTab.Instance.Visible = false;
            waliTab.Instance.Visible = true;
            chipsTab.Instance.Visible = false;
            ugaliTab.Instance.Visible = false;
            ndiziTab.Instance.Visible = false;
            viaziTab.Instance.Visible = false;
            tambiTab.Instance.Visible = false;
            pilauTab.Instance.Visible = false;
            submitBtn.Visible = true;

            //taking the name of the menu
            chakula = waliBtn.Text;
            

            //submit and done button
            submitBtn.Visible = true;
            doneBtn.Visible = false;

            //color transition

            waliBtn.Normalcolor = Color.Purple;
            drinksBtn.BackColor = Color.FromArgb(0, 122, 204);
            ugaliBtn.BackColor = Color.FromArgb(0, 122, 204);
            chipsBtn.BackColor = Color.FromArgb(0, 122, 204);
            ndiziBtn.BackColor = Color.FromArgb(0, 122, 204);
            pilauBtn.BackColor = Color.FromArgb(0, 122, 204);
            tambiBtn.BackColor = Color.FromArgb(0, 122, 204);
            viaziBtn.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void chipsBtn_Click(object sender, EventArgs e)
        {
            verticalTransEffect.ShowSync(chipsTab.Instance);
            menuPanel.Controls.Add(chipsTab.Instance);
            chipsTab.Instance.Dock = DockStyle.Fill;
            chipsTab.Instance.Visible = true;
            drinksTab.Instance.Visible = false;
            waliTab.Instance.Visible = false;
            ugaliTab.Instance.Visible = false;
            ndiziTab.Instance.Visible = false;
            viaziTab.Instance.Visible = false;
            tambiTab.Instance.Visible = false;
            pilauTab.Instance.Visible = false;
            submitBtn.Visible = true;

            //taking the name of the menu
            chakula = chipsBtn.Text;

            //submit and done button
            submitBtn.Visible = true;
            doneBtn.Visible = false;

            //color transition

            chipsBtn.Normalcolor = Color.Purple;
            drinksBtn.BackColor = Color.FromArgb(0, 122, 204);
            ugaliBtn.BackColor = Color.FromArgb(0, 122, 204);
            waliBtn.BackColor = Color.FromArgb(0, 122, 204);
            ndiziBtn.BackColor = Color.FromArgb(0, 122, 204);
            pilauBtn.BackColor = Color.FromArgb(0, 122, 204);
            tambiBtn.BackColor = Color.FromArgb(0, 122, 204);
            viaziBtn.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void ugaliBtn_Click(object sender, EventArgs e)
        {
            holizotalTransEffect.ShowSync(ugaliTab.Instance);
            menuPanel.Controls.Add(ugaliTab.Instance);
            ugaliTab.Instance.Dock = DockStyle.Fill;
            ugaliTab.Instance.Visible = true;
            drinksTab.Instance.Visible = false;
            waliTab.Instance.Visible = false;
            chipsTab.Instance.Visible = false;
            ndiziTab.Instance.Visible = false;
            viaziTab.Instance.Visible = false;
            tambiTab.Instance.Visible = false;
            pilauTab.Instance.Visible = false;
            submitBtn.Visible = true;

            //taking the name of the menu
            chakula = ugaliBtn.Text;

            //submit and done button
            submitBtn.Visible = true;
            doneBtn.Visible = false;

            //color transition

            ugaliBtn.Normalcolor = Color.Purple;
            drinksBtn.BackColor = Color.FromArgb(0, 122, 204);
            chipsBtn.BackColor = Color.FromArgb(0, 122, 204);
            waliBtn.BackColor = Color.FromArgb(0, 122, 204);
            ndiziBtn.BackColor = Color.FromArgb(0, 122, 204);
            pilauBtn.BackColor = Color.FromArgb(0, 122, 204);
            tambiBtn.BackColor = Color.FromArgb(0, 122, 204);
            viaziBtn.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void ndiziBtn_Click(object sender, EventArgs e)
        {
            verticalTransEffect.ShowSync(ndiziTab.Instance);
            menuPanel.Controls.Add(ndiziTab.Instance);
            ndiziTab.Instance.Dock = DockStyle.Fill;
            ndiziTab.Instance.Visible = true;
            chipsTab.Instance.Visible = false;
            drinksTab.Instance.Visible = false;
            waliTab.Instance.Visible = false;
            ugaliTab.Instance.Visible = false;
            viaziTab.Instance.Visible = false;
            tambiTab.Instance.Visible = false;
            pilauTab.Instance.Visible = false;
            submitBtn.Visible = true;

            //taking the name of the menu
            chakula = ndiziBtn.Text;

            //submit and done button
            submitBtn.Visible = true;
            doneBtn.Visible = false;

            //color transition

            ndiziBtn.Normalcolor = Color.Purple;
            drinksBtn.BackColor = Color.FromArgb(0, 122, 204);
            chipsBtn.BackColor = Color.FromArgb(0, 122, 204);
            waliBtn.BackColor = Color.FromArgb(0, 122, 204);
            ugaliBtn.BackColor = Color.FromArgb(0, 122, 204);
            pilauBtn.BackColor = Color.FromArgb(0, 122, 204);
            tambiBtn.BackColor = Color.FromArgb(0, 122, 204);
            viaziBtn.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void viaziBtn_Click(object sender, EventArgs e)
        {
            holizotalTransEffect.ShowSync(viaziTab.Instance);
            menuPanel.Controls.Add(viaziTab.Instance);
            viaziTab.Instance.Dock = DockStyle.Fill;
            viaziTab.Instance.Visible = true;
            ugaliTab.Instance.Visible = false;
            drinksTab.Instance.Visible = false;
            waliTab.Instance.Visible = false;
            chipsTab.Instance.Visible = false;
            ndiziTab.Instance.Visible = false;
            tambiTab.Instance.Visible = false;
            pilauTab.Instance.Visible = false;
            submitBtn.Visible = true;

            //taking the name of the menu
            chakula = viaziBtn.Text;

            //submit and done button
            submitBtn.Visible = true;
            doneBtn.Visible = false;

            //color transition

            viaziBtn.Normalcolor = Color.Purple;
            drinksBtn.BackColor = Color.FromArgb(0, 122, 204);
            chipsBtn.BackColor = Color.FromArgb(0, 122, 204);
            waliBtn.BackColor = Color.FromArgb(0, 122, 204);
            ugaliBtn.BackColor = Color.FromArgb(0, 122, 204);
            pilauBtn.BackColor = Color.FromArgb(0, 122, 204);
            tambiBtn.BackColor = Color.FromArgb(0, 122, 204);
            ndiziBtn.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void tambiBtn_Click(object sender, EventArgs e)
        {
            verticalTransEffect.ShowSync(tambiTab.Instance);
            menuPanel.Controls.Add(tambiTab.Instance);
            tambiTab.Instance.Dock = DockStyle.Fill;
            tambiTab.Instance.Visible = true;
            ndiziTab.Instance.Visible = false;
            chipsTab.Instance.Visible = false;
            drinksTab.Instance.Visible = false;
            waliTab.Instance.Visible = false;
            ugaliTab.Instance.Visible = false;
            viaziTab.Instance.Visible = false;
            pilauTab.Instance.Visible = false;
            submitBtn.Visible = true;

            //taking the name of the menu
            chakula = tambiBtn.Text;

            //submit and done button
            submitBtn.Visible = true;
            doneBtn.Visible = false;

            //color transition

            tambiBtn.Normalcolor = Color.Purple;
            drinksBtn.BackColor = Color.FromArgb(0, 122, 204);
            chipsBtn.BackColor = Color.FromArgb(0, 122, 204);
            waliBtn.BackColor = Color.FromArgb(0, 122, 204);
            ugaliBtn.BackColor = Color.FromArgb(0, 122, 204);
            pilauBtn.BackColor = Color.FromArgb(0, 122, 204);
            viaziBtn.BackColor = Color.FromArgb(0, 122, 204);
            ndiziBtn.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void pilauBtn_Click(object sender, EventArgs e)
        {
            holizotalTransEffect.ShowSync(pilauTab.Instance);
            menuPanel.Controls.Add(pilauTab.Instance);
            pilauTab.Instance.Dock = DockStyle.Fill;
            pilauTab.Instance.Visible = true;
            viaziTab.Instance.Visible = false;
            ugaliTab.Instance.Visible = false;
            drinksTab.Instance.Visible = false;
            waliTab.Instance.Visible = false;
            chipsTab.Instance.Visible = false;
            ndiziTab.Instance.Visible = false;
            tambiTab.Instance.Visible = false;
            submitBtn.Visible = true;

            //taking the name of the menu
            chakula = pilauBtn.Text;

            //submit and done button
            submitBtn.Visible = true;
            doneBtn.Visible = false;

            //color transition

            pilauBtn.Normalcolor = Color.Purple;
            drinksBtn.BackColor = Color.FromArgb(0, 122, 204);
            chipsBtn.BackColor = Color.FromArgb(0, 122, 204);
            waliBtn.BackColor = Color.FromArgb(0, 122, 204);
            ugaliBtn.BackColor = Color.FromArgb(0, 122, 204);
            tambiBtn.BackColor = Color.FromArgb(0, 122, 204);
            viaziBtn.BackColor = Color.FromArgb(0, 122, 204);
            ndiziBtn.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            animate.Start();
            submitBtn.Visible = false;

            //reset everything after submit

            tambiTab.Instance.Visible = false;
            ndiziTab.Instance.Visible = false;
            chipsTab.Instance.Visible = false;
            drinksTab.Instance.Visible = false;
            waliTab.Instance.Visible = false;
            ugaliTab.Instance.Visible = false;
            viaziTab.Instance.Visible = false;
            pilauTab.Instance.Visible = false;


            //color transition

            pilauBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            drinksBtn.BackColor = Color.FromArgb(0, 122, 204);
            chipsBtn.BackColor = Color.FromArgb(0, 122, 204);
            waliBtn.BackColor = Color.FromArgb(0, 122, 204);
            ugaliBtn.BackColor = Color.FromArgb(0, 122, 204);
            tambiBtn.BackColor = Color.FromArgb(0, 122, 204);
            viaziBtn.BackColor = Color.FromArgb(0, 122, 204);
            ndiziBtn.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void animate_Tick(object sender, EventArgs e)
        {
            animate.Stop();
            doneEffectTrans.ShowSync(doneBtn);  
        }

        private void mainPage_Load(object sender, EventArgs e)
        {
            submitBtn.Visible = false;
        }
    }
}
