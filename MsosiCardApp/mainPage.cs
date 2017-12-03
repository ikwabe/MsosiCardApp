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
        public string fullOderName;
        public int qnt;

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            othersTab.Instance.Visible = false;
           
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
            otherBtn.BackColor = Color.FromArgb(0, 122, 204);
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
            othersTab.Instance.Visible = false;
           
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
            otherBtn.BackColor = Color.FromArgb(0, 122, 204);
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
            othersTab.Instance.Visible = false;
           
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
            otherBtn.BackColor = Color.FromArgb(0, 122, 204);
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
            othersTab.Instance.Visible = false;
           
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
            otherBtn.BackColor = Color.FromArgb(0, 122, 204);
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
            othersTab.Instance.Visible = false;
           
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
            otherBtn.BackColor = Color.FromArgb(0, 122, 204);
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
            othersTab.Instance.Visible = false;
           
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
            otherBtn.BackColor = Color.FromArgb(0, 122, 204);
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
            othersTab.Instance.Visible = false;
           
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
            otherBtn.BackColor = Color.FromArgb(0, 122, 204);
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
            othersTab.Instance.Visible = false;
           
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
            otherBtn.BackColor = Color.FromArgb(0, 122, 204);
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

        private void enterBtn_Click(object sender, EventArgs e)
        {

            switch (chakula)
            {
                //Drinks Menu
                case "DRINKS":
                    switch (drinksTab.Instance.kinywaji)
                    {
                        //soda part
                        case "PEPSI":
                            fullOderName = "PEPSI";
                            break;

                        case "MIRINDA":
                            fullOderName = "MIRINDA";
                            break;

                        case "7 UP":
                            fullOderName = "7 UP";
                            break;

                        case "MOUNTAIN DEW":
                            fullOderName = "MOUNTAIN DEW";
                            break;

                        case "COCACOLA":
                            fullOderName = "COCACOLA";
                            break;

                        case "FANTA":
                            fullOderName = "FANTA";
                            break;

                        case "SPRITE":
                            fullOderName = "SPRITE";
                            break;

                        case "EVERVESS":
                            fullOderName = "EVERVESS";
                            break;


                        //Juice part
                        case "TROPICAL JUICE":
                            fullOderName = "TROPICAL JUICE";
                            break;

                        case "MANGO JUICE":
                            fullOderName = "MANGO JUICE";
                            break;

                        case "AVOCADO JUICE":
                            fullOderName = "AVOCADO JUICE";
                            break;

                        case "UKWAJU JUICE":
                            fullOderName = "UKWAJU JUICE";
                            break;

                        case "UBUYU JUICE":
                            fullOderName = "UBUYU JUICE";
                            break;

                        case "PINE-APPLE JUICE":
                            fullOderName = "PINE-APPLE JUICE";
                            break;

                        case "PASSION JUICE":
                            fullOderName = "PASSION JUICE";
                            break;

                        case "TENDE JUICE":
                            fullOderName = "TENDE JUICE";
                            break;



                        default:
                            MessageBox.Show("Sorry, There is an error occured..!");
                            break;
                    }
                    break; //end of drinks




                //Chakula Menu

                //wali menu start
                case "WALI":
                    switch (waliTab.Instance.mboga)
                    {
                        //mboga part
                        case "KUKU":
                            fullOderName = chakula + " KUKU";
                            break;

                        case "NYAMA":
                            fullOderName = chakula + " NYAMA";
                            break;

                        case "SAMAKI":
                            fullOderName = chakula + " SAMAKI";
                            break;

                        case "MAINI":
                            fullOderName = chakula + " MAINI";
                            break;

                        case "NJEGERE":
                            fullOderName = chakula + " NJEGERE";
                            break;

                        case "UTUMBO":
                            fullOderName = chakula + " UTUMBO";
                            break;

                        case "DAGAA":
                            fullOderName = chakula + " DAGAA";
                            break;

                        case "MSHKAKI KUKU":
                            fullOderName = chakula + " MSHKAKI KUKU";
                            break;

                        case "MSHKAKI NG`OMBE":
                            fullOderName = chakula + " MSHKAKI NG`OMBE";
                            break;

                        case "MAHARAGWE":
                            fullOderName = chakula + " MAHARAGWE";
                            break;

                        default:
                            MessageBox.Show("Sorry, There is an error occured..!");
                            break;

                    }
                    break;

                //wali menu end


                //ugali menu start
                case "UGALI":
                    switch (ugaliTab.Instance.mboga)
                    {
                        //mboga part
                        case "KUKU":
                            fullOderName = chakula + " KUKU";
                            break;

                        case "NYAMA":
                            fullOderName = chakula + " NYAMA";
                            break;

                        case "SAMAKI":
                            fullOderName = chakula + " SAMAKI";
                            break;

                        case "MAINI":
                            fullOderName = chakula + " MAINI";
                            break;

                        case "NJEGERE":
                            fullOderName = chakula + " NJEGERE";
                            break;

                        case "UTUMBO":
                            fullOderName = chakula + " UTUMBO";
                            break;

                        case "DAGAA":
                            fullOderName = chakula + " DAGAA";
                            break;

                        case "MSHKAKI KUKU":
                            fullOderName = chakula + " MSHKAKI KUKU";
                            break;

                        case "MSHKAKI NG`OMBE":
                            fullOderName = chakula + " MSHKAKI NG`OMBE";
                            break;

                        case "MAHARAGWE":
                            fullOderName = chakula + " MAHARAGWE";
                            break;

                        default:
                            MessageBox.Show("Sorry, There is an error occured..!");
                            break;

                    }
                    break;

                //ugali menu end


                //pilau menu start
                case "PILAU":
                    switch (pilauTab.Instance.mboga)
                    {
                        //mboga part
                        case "KUKU":
                            fullOderName = chakula + " KUKU";
                            break;

                        case "NYAMA":
                            fullOderName = chakula + " NYAMA";
                            break;

                        case "SAMAKI":
                            fullOderName = chakula + " SAMAKI";
                            break;

                        case "MAINI":
                            fullOderName = chakula + " MAINI";
                            break;

                        case "NJEGERE":
                            fullOderName = chakula + " NJEGERE";
                            break;

                        case "UTUMBO":
                            fullOderName = chakula + " UTUMBO";
                            break;

                        case "DAGAA":
                            fullOderName = chakula + " DAGAA";
                            break;

                        case "MSHKAKI KUKU":
                            fullOderName = chakula + " MSHKAKI KUKU";
                            break;

                        case "MSHKAKI NG`OMBE":
                            fullOderName = chakula + " MSHKAKI NG`OMBE";
                            break;

                        case "MAHARAGWE":
                            fullOderName = chakula + " MAHARAGWE";
                            break;

                        default:
                            MessageBox.Show("Sorry, There is an error occured..!");
                            break;

                    }
                    break;

                //pilau menu end

                //ndizi menu start
                case "NDIZI":
                    switch (ndiziTab.Instance.mboga)
                    {
                        //mboga part
                        case "KUKU":
                            fullOderName = chakula + " KUKU";
                            break;

                        case "NYAMA":
                            fullOderName = chakula + " NYAMA";
                            break;

                        case "SAMAKI":
                            fullOderName = chakula + " SAMAKI";
                            break;

                        case "MAINI":
                            fullOderName = chakula + " MAINI";
                            break;

                        case "NJEGERE":
                            fullOderName = chakula + " NJEGERE";
                            break;

                        case "UTUMBO":
                            fullOderName = chakula + " UTUMBO";
                            break;

                        case "DAGAA":
                            fullOderName = chakula + " DAGAA";
                            break;

                        case "MSHKAKI KUKU":
                            fullOderName = chakula + " MSHKAKI KUKU";
                            break;

                        case "MSHKAKI NG`OMBE":
                            fullOderName = chakula + " MSHKAKI NG`OMBE";
                            break;

                        case "MAHARAGWE":
                            fullOderName = chakula + " MAHARAGWE";
                            break;

                        default:
                            MessageBox.Show("Sorry, There is an error occured..!");
                            break;

                    }
                    break;

                //ndizi menu end

                //viazi menu start
                case "VIAZI":
                    switch (viaziTab.Instance.mboga)
                    {
                        //mboga part
                        case "KUKU":
                            fullOderName = chakula + " KUKU";
                            break;

                        case "NYAMA":
                            fullOderName = chakula + " NYAMA";
                            break;

                        case "SAMAKI":
                            fullOderName = chakula + " SAMAKI";
                            break;

                        case "MAINI":
                            fullOderName = chakula + " MAINI";
                            break;

                        case "NJEGERE":
                            fullOderName = chakula + " NJEGERE";
                            break;

                        case "UTUMBO":
                            fullOderName = chakula + " UTUMBO";
                            break;

                        case "DAGAA":
                            fullOderName = chakula + " DAGAA";
                            break;

                        case "MSHKAKI KUKU":
                            fullOderName = chakula + " MSHKAKI KUKU";
                            break;

                        case "MSHKAKI NG`OMBE":
                            fullOderName = chakula + " MSHKAKI NG`OMBE";
                            break;

                        case "MAHARAGWE":
                            fullOderName = chakula + " MAHARAGWE";
                            break;

                        default:
                            MessageBox.Show("Sorry, There is an error occured..!");
                            break;

                    }
                    break;

                //viazi menu end

                //tambi menu start
                case "TAMBI":
                    switch (tambiTab.Instance.mboga)
                    {
                        //mboga part
                        case "KUKU":
                            fullOderName = chakula + " KUKU";
                            break;

                        case "NYAMA":
                            fullOderName = chakula + " NYAMA";
                            break;

                        case "SAMAKI":
                            fullOderName = chakula + " SAMAKI";
                            break;

                        case "MAINI":
                            fullOderName = chakula + " MAINI";
                            break;

                        case "NJEGERE":
                            fullOderName = chakula + " NJEGERE";
                            break;

                        case "UTUMBO":
                            fullOderName = chakula + " UTUMBO";
                            break;

                        case "DAGAA":
                            fullOderName = chakula + " DAGAA";
                            break;

                        case "MSHKAKI KUKU":
                            fullOderName = chakula + " MSHKAKI KUKU";
                            break;

                        case "MSHKAKI NG`OMBE":
                            fullOderName = chakula + " MSHKAKI NG`OMBE";
                            break;

                        case "MAHARAGWE":
                            fullOderName = chakula + " MAHARAGWE";
                            break;

                        default:
                            MessageBox.Show("Sorry, There is an error occured..!");
                            break;

                    }
                    break;

                //tambi menu end


                //chips menu start
                case "CHIPS":
                    switch (chipsTab.Instance.aina)
                    {
                       //Aina part

                        //KAVU START
                        case "KAVU":
                            if (chipsTab.Instance.mboga == null) {
                                fullOderName = chakula + " KAVU";
                            }
                            else
                            {
                                switch (chipsTab.Instance.mboga)
                                {

                                    //mboga part
                                    case "NYAMA":
                                        fullOderName = chakula + " KAVU " + chipsTab.Instance.mboga;
                                        break;

                                    case "KUKU":
                                        fullOderName = chakula + " KAVU " + chipsTab.Instance.mboga;
                                        break;

                                    case "SAMAKI":
                                        fullOderName = chakula + " KAVU " + chipsTab.Instance.mboga;
                                        break;

                                    case "MAINI":
                                        fullOderName = chakula + " KAVU " + chipsTab.Instance.mboga;
                                        break;

                                    case "MSHKAKI KUKU":
                                        fullOderName = chakula + " KAVU " + chipsTab.Instance.mboga;
                                        break;

                                    case "MSHKAKI NG`OMBE":
                                        fullOderName = chakula + " KAVU " + chipsTab.Instance.mboga;
                                        break;

                                    default:
                                        MessageBox.Show("Sorry, There is an error occured..!");
                                        break;

                                }
                            }
                           
                            break;
                        //END OF KAVU CASE

                        //MAYAI START
                        case "MAYAI":
                            if (chipsTab.Instance.mboga == null)
                            {
                                fullOderName = chakula + " MAYAI";
                            }
                            else
                            {
                                switch (chipsTab.Instance.mboga)
                                {
                                    //mboga part
                                    case "NYAMA":
                                        fullOderName = chakula + " MAYAI " + chipsTab.Instance.mboga;
                                        break;

                                    case "KUKU":
                                        fullOderName = chakula + " MAYAI " + chipsTab.Instance.mboga;
                                        break;

                                    case "SAMAKI":
                                        fullOderName = chakula + " MAYAI " + chipsTab.Instance.mboga;
                                        break;

                                    case "MAINI":
                                        fullOderName = chakula + " MAYAI " + chipsTab.Instance.mboga;
                                        break;

                                    case "MSHKAKI KUKU":
                                        fullOderName = chakula + " MAYAI " + chipsTab.Instance.mboga;
                                        break;

                                    case "MSHKAKI NG`OMBE":
                                        fullOderName = chakula + " MAYAI " + chipsTab.Instance.mboga;
                                        break;

                                    default:
                                        MessageBox.Show("Sorry, There is an error occured..!");
                                        break;

                                }
                            }
                          
                            break;
                            //END OF MAYAI CASE


                    }
                    break;

                //chips menu end

                //Others menu start
                case "OTHERS":
                    switch (othersTab.Instance.mboga)
                    {
                        //mboga part

                        case "KUKU":
                            fullOderName = "KUKU";
                            break;

                        case "NYAMA CHOMA":
                            fullOderName = "NYAMA CHOMA";
                            break;

                        case "SAMAKI":
                            fullOderName = "SAMAKI";
                            break;

                        case "SOUSAGE":
                            fullOderName = "SOUSAGE";
                            break;

                        case "MAYAI":
                            fullOderName ="YAI";
                            break;

                        case "NDIZI CHOMA":
                            fullOderName = "NDIZI CHOMA";
                            break;

                        case "MSHKAKI KUKU":
                            fullOderName = chakula + " MSHKAKI KUKU";
                            break;

                        case "MSHKAKI NG`OMBE":
                            fullOderName = chakula + " MSHKAKI NG`OMBE";
                            break;

                        default:
                            MessageBox.Show("Sorry, There is an error occured..!");
                            break;

                    }
                    break;

                    //Others menu end


            }
            try
            {
                qnt = int.Parse(qntTxt.Text);
                if(qnt == 0)
                {
                    MessageBox.Show("0 error, Please select appropriate number(s) of order(s).");
                }
                else
                {
                    MessageBox.Show(fullOderName + " " + qnt);
                }
                
            }
            catch
            {
                MessageBox.Show("Please Enter the Quantity of the Product");
            }
            



           

        } //end of enter button

        //SUBMIT BUTTON
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
            othersTab.Instance.Visible = false;
            fullOderName = null;


            //color transition

            pilauBtn.Normalcolor = Color.FromArgb(0, 122, 204);
            drinksBtn.BackColor = Color.FromArgb(0, 122, 204);
            chipsBtn.BackColor = Color.FromArgb(0, 122, 204);
            waliBtn.BackColor = Color.FromArgb(0, 122, 204);
            ugaliBtn.BackColor = Color.FromArgb(0, 122, 204);
            tambiBtn.BackColor = Color.FromArgb(0, 122, 204);
            viaziBtn.BackColor = Color.FromArgb(0, 122, 204);
            ndiziBtn.BackColor = Color.FromArgb(0, 122, 204);
            otherBtn.BackColor = Color.FromArgb(0, 122, 204);


        } //END OF SUBMIT BUTTON

        private void otherBtn_Click(object sender, EventArgs e)
        {
            holizotalTransEffect.ShowSync(othersTab.Instance);
            menuPanel.Controls.Add(othersTab.Instance);
            othersTab.Instance.Dock = DockStyle.Fill;
            othersTab.Instance.Visible = true;
            pilauTab.Instance.Visible = false;
            viaziTab.Instance.Visible = false;
            ugaliTab.Instance.Visible = false;
            drinksTab.Instance.Visible = false;
            waliTab.Instance.Visible = false;
            chipsTab.Instance.Visible = false;
            ndiziTab.Instance.Visible = false;
            tambiTab.Instance.Visible = false;
            submitBtn.Visible = true;

           

            //taking the name of the menu
            chakula = otherBtn.Text;

            //submit and done button
            submitBtn.Visible = true;
            doneBtn.Visible = false;

            //color transition

            otherBtn.Normalcolor = Color.Purple;
            pilauBtn.BackColor = Color.FromArgb(0, 122, 204);
            drinksBtn.BackColor = Color.FromArgb(0, 122, 204);
            chipsBtn.BackColor = Color.FromArgb(0, 122, 204);
            waliBtn.BackColor = Color.FromArgb(0, 122, 204);
            ugaliBtn.BackColor = Color.FromArgb(0, 122, 204);
            tambiBtn.BackColor = Color.FromArgb(0, 122, 204);
            viaziBtn.BackColor = Color.FromArgb(0, 122, 204);
            ndiziBtn.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            editMenu edM = new editMenu();
            edM.Show();
        }
    }
}
