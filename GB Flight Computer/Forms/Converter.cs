using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GB_Flight_Computer
{
    public partial class Converter : Form
    {
        public Converter()
        {
            InitializeComponent();
            inHglistbox.SelectedIndex = 492;
            hpalistbox.SelectedIndex = 166;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainMenuButton_Conv_Click(object sender, EventArgs e)
        {
            MainMenu mmform = new MainMenu();
            this.Hide();
            mmform.Show();
        }

        

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="0")
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                
            //init vars

            double timehinit = 0.0;
            double timehcalc = timehinit;
            double timemres = 0.0;
            double timemcalc = 0.0;
            double timesres = 0.0;
            double timescalc = 0.0;
            double timedsres = 0.0;
            double timedscalc = 0.0;
            double timecsres = 0.0;
            double timecscalc = 0.0;
            double timemsres = 0.0;
            double timemscalc = 0.0;

            //unit selector
            /*if (timeunitselector.Text == "H")
                timehinit = Convert.ToDouble(textBox1.Text);
            else if (timeunitselector.Text == "M")
                timemcalc = Convert.ToDouble(textBox1.Text);
            else if (timeunitselector.Text == "S")
                timescalc = Convert.ToDouble(textBox1.Text);
            else if (timeunitselector.Text == "DS")
                timedscalc = Convert.ToDouble(textBox1.Text);
            else if (timeunitselector.Text == "CS")
                timecscalc = Convert.ToDouble(textBox1.Text);
            else if (timeunitselector.Text == "MS")
                timemscalc = Convert.ToDouble(textBox1.Text);
                */

            
                // init calc
                timehcalc = timehinit;
            timemcalc = ((timehcalc - Math.Truncate(timehcalc)) * 60);
            timescalc = ((timemcalc - Math.Truncate(timemcalc)) * 60);
            timedscalc = ((timescalc - Math.Truncate(timescalc)) * 60);
            timecscalc = ((timedscalc - Math.Truncate(timedscalc)) * 60);
            timemscalc = ((timecscalc - Math.Truncate(timecscalc)) * 60);

            timemres = Math.Truncate(timemcalc);
            timesres = Math.Truncate(timescalc);
            timedsres = Math.Truncate(timedscalc);
            timecsres = Math.Truncate(timecscalc);
            timemsres = Math.Truncate(timemscalc);
          
            TimeHNum.Visible = true;
            TimeMNum.Visible = true;
            TimeSNum.Visible = true;
            TimeDSNum.Visible = true;
            TimeCSNum.Visible = true;
            TimeMSNum.Visible = true;
            TimeHNum.Text = Convert.ToString(Math.Truncate(timehcalc));
            TimeMNum.Text = Convert.ToString(Math.Truncate(timemres));
            TimeSNum.Text = Convert.ToString(Math.Truncate(timesres));
            TimeDSNum.Text = Convert.ToString(Math.Truncate (timedsres));
            TimeCSNum.Text = Convert.ToString(Math.Truncate(timecsres));
            TimeMSNum.Text = Convert.ToString(Math.Truncate(timemsres));
            
        }

        private void howcomebuttonfuel_Click(object sender, EventArgs e)
        {
            if (howcomefuellbl.Visible == true)
                howcomefuellbl.Visible = false;
            else if (howcomefuellbl.Visible == false)
                howcomefuellbl.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LBResLbl.Text =Convert.ToString(Math.Round( Convert.ToDouble(GalTB.Text)*6));
            Galreslbl.Text = Convert.ToString(Math.Round(Convert.ToDouble(LBTB.Text) / 6));
        }
        
        private void GalTB_Click(object sender, EventArgs e)
        {
            if (GalTB.Text == "0")
                GalTB.Text = "";
        }

        private void LBTB_Click(object sender, EventArgs e)
        {
            if (LBTB.Text == "0")
                LBTB.Text = "";
        }
        private void c172fullfuelint_Click(object sender, EventArgs e)
        {
            GalTB.Text = "68";
            LBTB.Text = "408";
            LBResLbl.Text = "408";
            Galreslbl.Text = "68";
        }
        private void c152fullfuel_Click(object sender, EventArgs e)
        {
            GalTB.Text = "24";
            LBTB.Text = "144";
            LBResLbl.Text = "144";
            Galreslbl.Text = "24";
        }

        private void calcbuttonoil_Click(object sender, EventArgs e)
        {
            oilgalresult1.Text = Convert.ToString(Math.Round(Convert.ToDouble(qtoiltb.Text) / 4));
            oilgalresult2.Text = oilgalresult1.Text;
            oillbres.Text = Convert.ToString(Math.Round(Convert.ToDouble(oilgalresult1.Text) * 7.5));

            oilgalres3.Text = Convert.ToString(Math.Round(Convert.ToDouble(lboiltb.Text) / 7.5));
            oilgalres4.Text = oilgalres3.Text;
            oilqtres.Text = Convert.ToString(Math.Round(Convert.ToDouble(oilgalres3.Text) * 4));
            

        }

        private void howcomebuttonoil_Click(object sender, EventArgs e)
        {
            if (howcomeoillbl.Visible == true)
                howcomeoillbl.Visible = false;
            else if (howcomeoillbl.Visible == false)
                howcomeoillbl.Visible = true;
        }

        private void qtoiltb_Click(object sender, EventArgs e)
        {
            if (qtoiltb.Text == "0")
                qtoiltb.Text = "";
        }

        private void lboiltb_Click(object sender, EventArgs e)
        {
            if (lboiltb.Text == "0")
                lboiltb.Text = "";

        }

        private void c152fulloil_Click(object sender, EventArgs e)
        {
            qtoiltb.Text = "7";
            lboiltb.Text = "13.125";
            calcbuttonoil_Click(calcbuttonoil, null);
        }

        private void c172fulloil_Click(object sender, EventArgs e)
        {
            qtoiltb.Text = "8";
            lboiltb.Text = "15";
        }

        private void afcbutton_Click(object sender, EventArgs e)
        {
            Advanced_Formulas advform = new Advanced_Formulas();
            advform.Show();
        }

        private void cbdistinput_TextChanged(object sender, EventArgs e)
        {
            calcdist();
        }
        private void tbdistinput_TextChanged(object sender, EventArgs e)
        {
            calcdist();
        }
        private void calcdist()
        {
            //init vars and input
            double distinput = Convert.ToDouble(tbdistinput.Text);
            double kmmult = 0.0;
            double nmmult = 0.0;
            double smmult = 0.0;
            double kmres = 0.0;
            double nmres = 0.0;
            double smres = 0.0;
            //if cb
            if (cbdistinput.Text == "KM")
            {
                kmmult = 1.0;
                nmmult = 0.539957;
                smmult = 0.621371;
            }
            else if (cbdistinput.Text == "NM")
            {
                kmmult = 1.852;
                nmmult = 1.0;
                smmult = 1.150779;
            }
            else if (cbdistinput.Text == "SM")
            {
                kmmult = 1.609344;
                nmmult = 0.868976;
                smmult = 1.0;
            }
            //calc
            kmres = distinput * kmmult;
            nmres = distinput * nmmult;
            smres = distinput * smmult;
            //output
            kmreslbl.Text = Convert.ToString(kmres);
            nmreslbl.Text = Convert.ToString(nmres);
            smreslbl.Text = Convert.ToString(smres);
            multkmlbl.Text = Convert.ToString(kmmult);
            multnmlbl.Text = Convert.ToString(nmmult);
            multsmlbl.Text = Convert.ToString(smmult);

            

        }
        //END DISTANCE CONVERTER==================================
        //START ALTIMETER SETTING CONVERTER=======================
        private void inHglist_SelectedValueChanged(object sender, EventArgs e)
        {
            hpareslbl.Text = Convert.ToString(Math.Round((Convert.ToDouble(inHglistbox.Text)) * 33.8639 ,3));
            
        }
        private void hpalistbox_SelectedValueChanged(object sender, EventArgs e)
        {
            inhgreslbl.Text= Convert.ToString(Math.Round((Convert.ToDouble(hpalistbox.Text)) / 33.8639 , 3));
        }
        private void inhgconv()
        {

        }
        private void tempcalc()
        {
            double tempinput = Convert.ToDouble(inputtemp.Text);
            int botconst = 0;
            int topconst = 0;
            int plusconst1 = 0;
            int plusconst2 = 0;
            double tempres = 0.0;

            if (cbtemp1.Text == "C" && cbtempres.Text == "C")
            {
                topconst = 1;
                botconst = 1;
                plusconsttemp1.Visible = false;
                plusconsttemp2.Visible = false;
                plussymtemp1.Visible = false;
                plussymtemp2.Visible = false;
                plusconst1 = 0;
                plusconst2 = 0;
                multlbltemp.Visible = true;
                parlbltemp2.Visible = false;
                parlbltemp3.Visible = true;
                tempres = tempinput;



            }
            else if (cbtemp1.Text == "C" && cbtempres.Text == "F")
            {
                topconst = 9;
                botconst = 5;
                plusconst1 = 0;
                plusconst2 = 32;
                plusconsttemp1.Visible = false;
                plusconsttemp2.Visible = true;
                plussymtemp1.Visible = false;
                plussymtemp2.Visible = true;
                multlbltemp.Visible = true;
                parlbltemp2.Visible = false;
                parlbltemp3.Visible = true;
                tempres = (tempinput * 9 / 5) + 32;
            }
            else if (cbtemp1.Text == "C" && cbtempres.Text == "R")
            {
                topconst = 4;
                botconst = 5;
                plusconst1 = 0;
                plusconst2 = 0;
                plusconsttemp1.Visible = false;
                plusconsttemp2.Visible = true;
                plussymtemp1.Visible = false;
                plussymtemp2.Visible = true;
                multlbltemp.Visible = true;
                parlbltemp2.Visible = false;
                parlbltemp3.Visible = true;
                tempres = tempinput * 4 / 5;
            }
            else if (cbtemp1.Text == "C" && cbtempres.Text == "K")
            {
                topconst = 1;
                botconst = 1;
                plusconst1 = 0;
                plusconst2 = 273;
                plusconsttemp1.Visible = false;
                plusconsttemp2.Visible = true;
                plussymtemp1.Visible = false;
                plussymtemp2.Visible = true;
                multlbltemp.Visible = true;
                parlbltemp2.Visible = false;
                parlbltemp3.Visible = true;
                tempres = tempinput + 273;

            }
            else if (cbtemp1.Text == "F" && cbtempres.Text == "C")
            {
                topconst = 5;
                botconst = 9;
                plusconst1 = -32;
                plusconst2 = 0;
                plusconsttemp1.Visible = true;
                plusconsttemp2.Visible = false;
                plussymtemp1.Visible = false;
                plussymtemp2.Visible = false;
                parlbltemp2.Visible = true;
                parlbltemp3.Visible = false;
                tempres = (tempinput - 32) * 5 / 9;
            }
            else if (cbtemp1.Text == "F" && cbtempres.Text == "F")
            {
                topconst = 1;
                botconst = 1;
                plusconst1 = 0;
                plusconst2 = 0;
                plusconsttemp1.Visible = false;
                plusconsttemp2.Visible = false;
                plussymtemp1.Visible = false;
                plussymtemp2.Visible = false;
                parlbltemp2.Visible = false;
                parlbltemp3.Visible = true;
                tempres = tempinput;
            }
            else if (cbtemp1.Text == "F" && cbtempres.Text == "R")
            {
                topconst = 4;
                botconst = 9;
                plusconst1 = -32;
                plusconst2 = 0;
                plusconsttemp1.Visible = true;
                plusconsttemp2.Visible = false;
                plussymtemp1.Visible = false;
                plussymtemp2.Visible = false;
                parlbltemp2.Visible = true;
                parlbltemp3.Visible = false;
                tempres = (tempinput - 32) * 4 / 9;

            }
            else if (cbtemp1.Text == "F" && cbtempres.Text == "K")
            {
                topconst = 5;
                botconst = 9;
                plusconst1 = -32;
                plusconst2 = +273;
                plusconsttemp1.Visible = true;
                plusconsttemp2.Visible = true;
                plussymtemp1.Visible = false;
                plussymtemp2.Visible = true;
                parlbltemp2.Visible = true;
                parlbltemp3.Visible = false;
                tempres = (((tempinput - 32) * 5 / 9) + 273);
            }
            else if (cbtemp1.Text == "R" && cbtempres.Text == "C")
            {
                topconst = 5;
                botconst = 4;
                plusconst1 = 0;
                plusconst2 = 0;
                plusconsttemp1.Visible = false;
                plusconsttemp2.Visible = false;
                plussymtemp1.Visible = false;
                plussymtemp2.Visible = false;
                parlbltemp2.Visible = false;
                parlbltemp3.Visible = true;
                tempres = tempinput * 5 / 4;
            }
            else if (cbtemp1.Text == "R" && cbtempres.Text == "F")
            {
                topconst = 9;
                botconst = 4;
                plusconst1 = 0;
                plusconst2 = +32;
                plusconsttemp1.Visible = false;
                plusconsttemp2.Visible = true;
                plussymtemp1.Visible = false;
                plussymtemp2.Visible = true;
                parlbltemp2.Visible = true;
                parlbltemp3.Visible = false;
                tempres = (tempinput * 9 / 4) + 32;
            }
            else if (cbtemp1.Text == "R" && cbtempres.Text == "R")
            {
                topconst = 1;
                botconst = 1;
                plusconst1 = 0;
                plusconst2 = 0;
                plusconsttemp1.Visible = false;
                plusconsttemp2.Visible = false;
                plussymtemp1.Visible = false;
                plussymtemp2.Visible = false;
                parlbltemp2.Visible = true;
                parlbltemp3.Visible = false;
                tempres = tempinput;

            }
            else if (cbtemp1.Text == "R" && cbtempres.Text == "K")
            {
                topconst = 5;
                botconst = 4;
                plusconst1 = 0;
                plusconst2 = +273;
                plusconsttemp1.Visible = false;
                plusconsttemp2.Visible = true;
                plussymtemp1.Visible = false;
                plussymtemp2.Visible = true;
                parlbltemp2.Visible = false;
                parlbltemp3.Visible = true;
                tempres = (tempinput * 5 / 4) + 273;
            }
            else if (cbtemp1.Text == "K" && cbtempres.Text == "C")
            {
                topconst = 1;
                botconst = 1;
                plusconst1 = 0;
                plusconst2 = -273;
                plusconsttemp1.Visible = false;
                plusconsttemp2.Visible = true;
                plussymtemp1.Visible = false;
                plussymtemp2.Visible = true;
                parlbltemp2.Visible = false;
                parlbltemp3.Visible = true;
                tempres = tempinput - 273;
            }
            else if (cbtemp1.Text == "K" && cbtempres.Text == "F")
            {
                topconst = 9;
                botconst = 5;
                plusconst1 = -273;
                plusconst2 = +32;
                plusconsttemp1.Visible = true;
                plusconsttemp2.Visible = true;
                plussymtemp1.Visible = false;
                plussymtemp2.Visible = true;
                parlbltemp2.Visible = true;
                parlbltemp3.Visible = false;
                tempres = ((tempinput - 273) * 9 / 5) + 32;
            }
            else if (cbtemp1.Text == "K" && cbtempres.Text == "R")
            {
                topconst = 4;
                botconst = 5;
                plusconst1 = -273;
                plusconst2 = 0;
                plusconsttemp1.Visible = true;
                plusconsttemp2.Visible = false;
                plussymtemp1.Visible = false;
                plussymtemp2.Visible = false;
                parlbltemp2.Visible = true;
                parlbltemp3.Visible = false;
                tempres = (tempinput - 273) * 4 / 5;
            }
            else if (cbtemp1.Text == "K" && cbtempres.Text == "K")
            {
                topconst = 1;
                botconst = 1;
                plusconst1 = 0;
                plusconst2 = 0;
                plusconsttemp1.Visible = false;
                plusconsttemp2.Visible = false;
                plussymtemp1.Visible = false;
                plussymtemp2.Visible = false;
                parlbltemp2.Visible = false;
                parlbltemp3.Visible = true;
                tempres = tempinput;
            }
            //output
            
            resrawlbl.Text = Convert.ToString(tempres);
            tempreslbl.Text = Convert.ToString(Math.Round(tempres, 2));
            plusconsttemp1.Text = Convert.ToString(plusconst1);
            plusconsttemp2.Text = Convert.ToString(plusconst2);
            tempconsttop.Text = Convert.ToString(topconst);
            tempconstbot.Text = Convert.ToString(botconst);
            
        }
        
        private void inputtemp_TextChanged(object sender, EventArgs e)
        {
            tempcalc();
        }

        private void cbtemp1_TextChanged(object sender, EventArgs e)
        {
            tempcalc();
        }

        private void cbtempres_TextChanged(object sender, EventArgs e)
        {
            tempcalc();
        }

        //END TEMPERATURE CONVERTER==================================
        //START IAS TAS CONVERTER====================================

        private void iastascalc()
        {
            double tasres = 0.0;
            double iasinput = 0.0;
            double painput = 0.0;
            iasinput = Convert.ToDouble(iasinputiastas.Text);
            painput = Convert.ToDouble(painputiastas.Text);
            tasres = iasinput + ((iasinput * 0.02) * painput / 1000);
            tasreslbl.Text = Convert.ToString(Math.Round(tasres, 2));
            iaslbliastas.Text = Convert.ToString(Math.Round(iasinput, 2));
        }

        private void iasinputiastas_TextChanged(object sender, EventArgs e)
        {
            iastascalc();
        }

        private void painputiastas_TextChanged(object sender, EventArgs e)
        {
            iastascalc();
        }

        private void speedconvertcalc()
        {
            double distmult = 0.0;
            double timemult = 0.0;
            double timeinput = 0.0;
            double distinput = 0.0;
            double distres = 0.0;
            double timeres = 0.0;
            double speedres = 0.0;
            int timemultgui = 60;
            double distmultgui = 0.0;

            

            if (timeunitinputspeedconv.Text == "H" && timeunitresspeedconv.Text == "H")
            {
                multlblbotspeedconv.Text = "x";
                timemult = timeinput;

            }
            else if (timeunitinputspeedconv.Text == "H" && timeunitresspeedconv.Text == "M")
            {
                multlblbotspeedconv.Text = "x";
                timemult = timeinput * 60;
            }
            else if (timeunitinputspeedconv.Text == "H" && timeunitresspeedconv.Text == "S")
            {
                multlblbotspeedconv.Text = "x";
                timemult = timeinput * 3600;
            }
            else if (timeunitinputspeedconv.Text == "M" && timeunitresspeedconv.Text == "H")
            {
                multlblbotspeedconv.Text = "÷";
                timemult = timeinput / 60;
            }
            else if (timeunitinputspeedconv.Text == "M" && timeunitresspeedconv.Text == "M")
            {
                multlblbotspeedconv.Text = "x";
                timemult = timeinput;
            }
            else if (timeunitinputspeedconv.Text == "M" && timeunitresspeedconv.Text == "S")
            {
                multlblbotspeedconv.Text = "x";
                timemult = timeinput * 60;
            }
            else if (timeunitinputspeedconv.Text == "S" && timeunitresspeedconv.Text == "H")
            {
                multlblbotspeedconv.Text = "÷";
               timemult = timeinput / 3600;
            }
            else if (timeunitinputspeedconv.Text == "S" && timeunitresspeedconv.Text == "M")
            {
                multlblbotspeedconv.Text = "÷";
               timemult = timeinput / 60;
            }
            else if (timeunitinputspeedconv.Text == "S" && timeunitresspeedconv.Text == "S")
            {
                multlblbotspeedconv.Text = "x";
               timemult = timeinput;
            }

            if (distunitinputspeedconv.Text == "KM" && distunitinputspeedconv.Text == "KM")
            {
                multlbltopspeedconv.Text = "x";
                distmult = distinput;
                distmultgui = 1;
            }
            else if (distunitinputspeedconv.Text == "KM" && distunitinputspeedconv.Text == "M")
            {
                multlbltopspeedconv.Text = "x";
                distmult = distinput*1000;
                distmultgui = 1000;
            }
            else if (distunitinputspeedconv.Text == "KM" && distunitinputspeedconv.Text == "NM")
            {
                multlbltopspeedconv.Text = "x";
                distmult = distinput * 1.852;
                distmultgui = 1.852;
            }

            //output
            distres = distmult;
            timeres = timemult;
            speedres = distmult / timemult;
            distmultspeedconv.Text = Convert.ToString(distmultgui);
            timemultspeedconv.Text = Convert.ToString(timemultgui);
            speedresspeedconv.Text =Convert.ToString(Math.Round(speedres,2));
            rawspeedresspeedconv.Text = Convert.ToString(speedres);



        }

        private void distunitinputspeedconv_TextChanged(object sender, EventArgs e)
        {
            speedconvertcalc();
        }

        private void timeunitinputspeedconv_TextChanged(object sender, EventArgs e)
        {
            speedconvertcalc();
        }

        private void distunitresspeedconv_TextChanged(object sender, EventArgs e)
        {
            speedconvertcalc();
        }

        private void timeunitresspeedconv_TextChanged(object sender, EventArgs e)
        {
            speedconvertcalc();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            speedconvertcalc();
        }
    }
}
