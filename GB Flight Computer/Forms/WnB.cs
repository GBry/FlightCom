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
    public partial class WnB : Form
    {
        public WnB()
        {
            InitializeComponent();




        }

        private void MainMenuButton_Conv_Click(object sender, EventArgs e)
        {
            MainMenu mmform = new MainMenu();
            this.Hide();
            mmform.Show();
        }

        private void ACSelect_TextChanged(object sender, EventArgs e)
        {

            //set initial specs
            if (ACSelect.Text == "Cessna 152")
            {
                ULNum.Text = "563";
                MGWnumLbl.Text = "1670";
                SEWNum.Text = "1112";
            }
            else if (ACSelect.Text == "Cessna 172P")
            {
                ULNum.Text = "980";
                MGWnumLbl.Text = "2400";
                SEWNum.Text = "1427";
            }
            else if (ACSelect.Text == "Tecnam P2006T")
                ULNum.Text = "";
        }

        private void WnB_Load(object sender, EventArgs e)
        {

        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            //init textboxes

            double pilotweightlb = Convert.ToDouble(PilotTB.Text);
            double crewbggkg = Convert.ToDouble(CBTB.Text);
            double oilqt = Convert.ToDouble(OilTBQt.Text);
            double oillb = Convert.ToDouble(OilTBLB.Text);
            double FuelGal = Convert.ToDouble(FuelTBGal.Text);
            double fuellb = Convert.ToDouble(FuelTBLB.Text);
            double LV = Convert.ToDouble(LVTB.Text);
            double MK = Convert.ToDouble(MKTB.Text);
            double FE = Convert.ToDouble(FETB.Text);
            double pax = Convert.ToDouble(PTB.Text);
            double paxb = Convert.ToDouble(PBTB.Text);
            double paxc = Convert.ToDouble(PCTB.Text);



            //init vars
            double pilotweightkg;
            double crewbgglb;
            
            double pilotweightfinal = 0.0;
            double crewbggfinal = 0.0;
            double AcP;
            double AvP;
            double BOW;
            double RP;
            double UsL = 0.0;
            double MGW = 0.0;
            double SEW = 0.0;
            double totalgrossweight = 0.0;

            //set initial specs
            if (ACSelect.Text == "Cessna 152")
            {
                UsL = 563.0;
                MGW = 1670.0;
                SEW = 1112.0;
            }
            else if (ACSelect.Text == "Cessna 172P")
            {
                UsL = 980.0;
                MGW = 2400.0;
                SEW = 1427.0;
            }
            else if (ACSelect.Text == "Tecnam P2006T")
                UsL = 0.0;


            MGWnumLbl.Text = Convert.ToString(MGW);
            SEWNum.Text = Convert.ToString(SEW);

            //init conversions
            pilotweightkg = pilotweightlb / 2.2;
            


            crewbgglb = crewbggkg * 2.2;
            

            if (comboboxkgpil.Text == "KG")
                pilotweightfinal = pilotweightkg;
            else if (comboboxkgpil.Text == "LBS")
                pilotweightfinal = pilotweightlb;


            if (comboboxkgcrew.Text == "KG")
                crewbggfinal = crewbggkg;
            else if (comboboxkgcrew.Text == "LBS")
                crewbggfinal = crewbgglb;



            //insert to blanks
            if (OilTBLB.Text == "0")
                OilTBLB.Text = Convert.ToString(oilqt/4*7.5);
            else if (OilTBQt.Text == "0")
                OilTBQt.Text = Convert.ToString(oillb/7.5*4);

            if (FuelTBLB.Text == "0")
                FuelTBLB.Text = Convert.ToString(FuelGal * 6);
            if (FuelTBGal.Text == "0")
                FuelTBGal.Text = Convert.ToString(fuellb / 6);

           



            //exec calculation
            BOW = Math.Round(pilotweightfinal + crewbggfinal + oillb + fuellb + LV + MK + FE);
            AcP = Math.Round(pax + paxb + paxc);
            AvP = Math.Round(UsL - BOW);
            RP = Math.Round(AvP - AcP);

            double totalresult = Math.Round(BOW + AcP);
            string totalresultstring = Convert.ToString(totalresult);
            TotalNum.Text = totalresultstring;
            totalgrossweight = SEW + BOW + AcP;

            //insert all to results
            BOWResult.Text = Convert.ToString(BOW);
            AcPResult.Text = Convert.ToString(AcP);
            AvPResult.Text = Convert.ToString(AvP);
            RPResult.Text = Convert.ToString(RP);

            if (ACSelect.Text == "Select Aircraft")
            {
                ExcLbl.Visible = true;
                ExcLbl.Text = "Select aircraft first";
            }
            else if (BOW + AcP > UsL)
            {
                ExcLbl.Visible = true;
                ExcLbl.Text = "Load exceeds maximum useful load";
            }
            else if (totalgrossweight > MGW)
            {
                ExcLbl.Visible = true;
                ExcLbl.Text = "Load exceeds Maximum Gross Weight";
            }


            else
            {
                ExcLbl.Visible = true;
                ExcLbl.Text = "Load within limits";
            }
        }
    }
}
