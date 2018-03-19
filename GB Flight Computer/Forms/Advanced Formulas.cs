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
    public partial class Advanced_Formulas : Form
    {
        public Advanced_Formulas()
        {
            InitializeComponent();
            
        }

        private void convbutton_AF_Click(object sender, EventArgs e)
        {
            Converter convform = new Converter();
            convform.Show();


        }

        private void MainMenuButton_Conv_Click(object sender, EventArgs e)
        {
            MainMenu mmform = new MainMenu();
            this.Hide();
            mmform.Show();
            
        }
        /*
        
            ----------------------------START CLOUD HEIGHT---------------------------------------

        */
        private double cfconst = 2.0;

        private void cfcombobox_ch_TextChanged(object sender, EventArgs e)
        {

            if (cfcombobox_ch.Text == "C")
                cfconst = 2.0;
            else if (cfcombobox_ch.Text == "F")
                cfconst = 3.5;


        }

        private void calcbuttonch_Click(object sender, EventArgs e)
        {


            double chres = 0.0;
            double gtch = 0.0;
            double dpch = 0.0;
            //get input
            gtch = Convert.ToDouble(CH_GTTB.Text);
            dpch = Convert.ToDouble(CH_DPTB.Text);
            chres = ((gtch - dpch) / cfconst) * 1000;
            //insert to blanks
            CH_CHTB.Text = Convert.ToString((Math.Round(chres)));


        }

        private void CH_GTTB_Click(object sender, EventArgs e)
        {
            if (CH_GTTB.Text == "0")
                CH_GTTB.Text = "";


        }

        private void CH_DPTB_Click(object sender, EventArgs e)
        {
            if (CH_DPTB.Text == "0")
                CH_DPTB.Text = "";
        }

        /*

           ----------------------------END CLOUD HEIGHT---------------------------------------
           ----------------------------START TOC/TOD------------------------------------------

       */

        private void crzaltclimbtoc_Click(object sender, EventArgs e)
        {
            if (crzaltclimbtoc.Text == "0")
                crzaltclimbtoc.Text = "";
        }

        private void roctoc_TextChanged(object sender, EventArgs e)
        {
            if (roctoc.Text == "0")
                roctoc.Text = "";
        }

        private void rodtod_TextChanged(object sender, EventArgs e)
        {
            if (rodtod.Text == "0")
                rodtod.Text = "";
        }



        private void astod_TextChanged(object sender, EventArgs e)
        {
            if (astod.Text == "0")
                astod.Text = "";
        }

        private void astoc_TextChanged(object sender, EventArgs e)
        {
            if (astoc.Text == "0")
                astoc.Text = "";
        }



        private void crzalttodtb_TextChanged(object sender, EventArgs e)
        {
            if (crzalttodtb.Text == "0")
                crzalttodtb.Text = "";

        }

        private void calcbuttontoctod_Click(object sender, EventArgs e)
        {
            //init vars
            double crzalttoc = 0.0;
            double crzalttod = 0.0;
            double roc = 0.0;
            double rod = 0.0;
            double toctimeresult = 0.0;
            double todtimeresult = 0.0;
            double tocnmresult = 0.0;
            double todnmresult = 0.0;
            double tocas = 0.0;
            double todas = 0.0;
            double zonedist = 0.0;
            double zonedistres = 0.0;
            double zonegs = 0.0;
            double zonetimeres = 0.0;
            double zonetimehres = 0.0;
            double zonetimemres = 0.0;
            double toctoddistoutput = 0.0;

            //init input
            crzalttoc = Convert.ToDouble(crzaltclimbtoc.Text);
            crzalttod = Convert.ToDouble(crzalttodtb.Text);
            roc = Convert.ToDouble(roctoc.Text);
            rod = Convert.ToDouble(rodtod.Text);
            tocas = Convert.ToDouble(astoc.Text);
            todas = Convert.ToDouble(astod.Text);
            zonedist = Convert.ToDouble(zonedisttb.Text);
            zonegs = Convert.ToDouble(gstbzone.Text);
            
            


            //init calc
            toctimeresult = crzalttoc / roc;
            todtimeresult = crzalttod / rod;
            tocnmresult = (toctimeresult / 60) * tocas;
            todnmresult = (todtimeresult / 60) * todas;
            if (toctodselector.Text == "TOC Distance")
            {
                zonedistres = zonedist - tocnmresult;
                toctoddistoutput = tocnmresult;
            }
            else if (toctodselector.Text == "TOD Distance")
            {
                zonedistres = zonedist - todnmresult;
                toctoddistoutput = todnmresult;
            }
            zonetimeres = zonedistres / zonegs;
            zonetimehres = Math.Truncate(zonetimeres);
            zonetimemres = (zonetimeres - Math.Truncate(zonetimeres)) * 60;
            //output
            toctimereslbl.Text = Convert.ToString(Math.Round(toctimeresult,1));
            todtimereslbl.Text = Convert.ToString(Math.Round(todtimeresult,1));
            tocnmreslbl.Text = Convert.ToString(Math.Round(tocnmresult,2));
            todnmreslbl.Text = Convert.ToString(Math.Round(todnmresult,2));
            zonedistreslbl.Text = Convert.ToString(Math.Round(zonedistres, 2));
            toctoddist.Text = Convert.ToString(Math.Round(tocnmresult, 2));
            timelabelzone.Text=Convert.ToString(Math.Round(zonetimeres,2));
            timehlabelzoneres.Text = Convert.ToString(zonetimehres);
            timemlabelzoneres.Text = Convert.ToString(Math.Truncate(zonetimemres));
            toctoddist.Text = Convert.ToString(Math.Round(toctoddistoutput, 2));

        }

        private void toctodselector_TextChanged(object sender, EventArgs e)
        {

        }

        /*

           ----------------------------END TOC/TOD---------------------------------------
           ----------------------------START FL/PA/GT/OAT------------------------------------------

       */
        private bool simple;

        private void simpformbutton_Click(object sender, EventArgs e)
        {
            simple = !simple;
            if (simple == true)
            {
                simpformbutton.BackColor = Color.FromArgb(255, 0, 125, 255);
                //fl
                timesthousandfl.Text = "x500";
                timesthousandfl.Top -= 22;
                fldivider.Visible = false;
                divtwofl.Visible = false;
                //pa
                divtwolblpa.Visible = false;
                timesthousandlblpa.Left += 30;
                timesthousandlblpa.Text = "x500";
                padivider.Visible = false;
                parclslblpa.Left -= 65;
                //gt
                timestwogt.Visible = false;
                thousandlabelgt.Text = "500";
                //oat
                timestwooat.Visible = false;
                divthousandoat.Text = "500";


            }

            if (simple == false)
            {
                simpformbutton.BackColor = Color.Gray;
                //fl
                timesthousandfl.Text = "x1000";
                timesthousandfl.Top += 22;
                fldivider.Visible = true;
                divtwofl.Visible = true;
                //pa
                divtwolblpa.Visible = true;
                timesthousandlblpa.Left -= 30;
                padivider.Visible = true;
                timesthousandlblpa.Text = "x1000";
                parclslblpa.Left += 65;
                //gt
                timestwogt.Visible = true;
                thousandlabelgt.Text = "1000";
                //oat
                timestwooat.Visible = true;
                divthousandoat.Text = "1000";
            }
        }

        private void calcbuttonflpagtoat_Click(object sender, EventArgs e)
        {
            //init vars
            double gtinputfl = 0.0;
            double flres1 = 0.0;

            double oatinputfl = 0.0;
            double painputfl = 0.0;
            double flres2 = 0.0;

            double gtinputpa = 0.0;
            double oatinputpa = 0.0;
            double pares = 0.0;

            double painputgt = 0.0;
            double oatinputgt = 0.0;
            double gtres = 0.0;

            double gtinputoat = 0.0;
            double painputoat = 0.0;
            double oatres = 0.0;

            //init input
            // input part, input, equation
            gtinputfl = Convert.ToDouble(gttbfl.Text);
            oatinputfl = Convert.ToDouble(oattbfl.Text);
            painputfl = Convert.ToDouble(patbfl.Text);
            gtinputpa = Convert.ToDouble(gttbpa.Text);
            oatinputpa = Convert.ToDouble(oattbpa.Text);
            painputgt = Convert.ToDouble(patbgt.Text);
            oatinputgt = Convert.ToDouble(oattbgt.Text);
            gtinputoat = Convert.ToDouble(gttboat.Text);
            painputoat = Convert.ToDouble(patboat.Text);

            //init calc
            flres1 = gtinputfl * 500;
            flres2 = (oatinputfl / 2) + 1000 + painputfl;
            pares = (gtinputpa - oatinputpa) * 500;
            gtres = (painputgt / 500) + oatinputgt;
            oatres = gtinputoat - (painputoat / 500);

            //insert results
            flreslbl1.Text = Convert.ToString(Math.Round(flres1));
            flreslbl2.Text = Convert.ToString(Math.Round(flres2));
            pareslbl.Text = Convert.ToString(Math.Round(pares));
            gtreslbl.Text = Convert.ToString(Math.Round(gtres));
            oatreslbl.Text = Convert.ToString(Math.Round(oatres));


        }
        /*

                   ----------------------------END FL/PA/GT/OAT---------------------------------------
                   -------------------------START RADIUS OF ACTION------------------------------------

       */
        private double gsores = 0.0;
        private double gsbres = 0.0;
        private double wind = 0.0;
        private double tas = 0.0;
        private double gphinput = 0.0;
        private double fobinput = 0.0;
        private double tasinput = 0.0;
        private double windinput = 0.0;
        private double fuelres = 0.0;
        private double radistres = 0.0;
        private double ratimeres = 0.0;
        private double ratimeresh = 0.0;
        private double ratimeresm = 0.0;


        private void calcbuttonra_Click(object sender, EventArgs e)
        {
            //init vars


            //get input
            tasinput = Convert.ToDouble(tastb.Text);
            windinput = Convert.ToDouble(windtb.Text);
            gphinput = Convert.ToDouble(gphtb.Text);
            fobinput = Convert.ToDouble(fobtb.Text);
            //init calc
            if (windtypecb.Text == "Headwind")

            {
                gsores = tasinput - windinput;
                gsbres = tasinput + windinput;
            }
            else if (windtypecb.Text == "Tailwind")

            {
                gsores = tasinput + windinput;
                gsbres = tasinput - windinput;
            }

            else if (windtypecb.Text == "Crosswind")
            {
                gsores = tasinput;
                gsbres = tasinput;
            }

            else if (windtypecb.Text == "Calm")
            {
                gsores = tasinput;
                gsbres = tasinput;
            }

            fuelres = fobinput / gphinput;
            radistres = (gsores * gsbres) / (gsores + gsbres) * fuelres;
            ratimeres = radistres / gsores;
            ratimeresh = Math.Truncate(ratimeres);
            ratimeresm = (ratimeres - (Math.Truncate(ratimeres))) * 60;

            //output

            raoutput();
        }



        private void windtypecb_TextChanged(object sender, EventArgs e)
        {
            plusminussignra();
        }

   

        private void formulabutton_Click(object sender, EventArgs e)
        {

        }
        

        public void plusminussignra()
        {
            if (windtypecb.Text == "Headwind"
                && wind != 0)

            {
                plusminuslabelgsb.Text = "-";
                plusminuslabelgso.Text = "+";


                windgsb.Text = Convert.ToString(wind);
                windgso.Text = Convert.ToString(wind);
            }
            else if (windtypecb.Text == "Headwind" && wind == 0)
            {
                plusminuslabelgsb.Text = "-";
                plusminuslabelgso.Text = "+";
                windgsb.Text = "Wind";
                windgso.Text = "Wind";
            }

            else if (windtypecb.Text == "Tailwind" && wind != 0)

            {
                plusminuslabelgsb.Text = "+";
                plusminuslabelgso.Text = "-";

                windgsb.Text = Convert.ToString(wind);
                windgso.Text = Convert.ToString(wind);
            }
            else if (windtypecb.Text == "Tailwind" && wind == 0)
            {
                plusminuslabelgsb.Text = "+";
                plusminuslabelgso.Text = "-";
                windgsb.Text = "Wind";
                windgso.Text = "Wind";
            }
            else if (windtypecb.Text == "Crosswind")
            {
                plusminuslabelgsb.Text = "=";
                plusminuslabelgso.Text = "=";
                windgsb.Text = "TAS";
                windgso.Text = "TAS";
            }

            else if (windtypecb.Text == "Calm")
            {
                plusminuslabelgsb.Text = "=";
                plusminuslabelgso.Text = "=";
                windgsb.Text = "TAS";
                windgso.Text = "TAS";
            }

        }

        private void RAResetbutton_Click(object sender, EventArgs e)
        {
          gsores = 0.0;
          gsbres = 0.0;
          wind = 0.0;
          tas = 0.0;
          gphinput = 0.0;
          fobinput = 0.0;
          tasinput = 0.0;
          windinput = 0.0;
          fuelres = 0.0;
          radistres = 0.0;
          ratimeres = 0.0;
          ratimeresh = 0.0;
          ratimeresm = 0.0;
            fobtb.Text = "0";
            gphtb.Text = "0";
            tastb.Text = "0";
            windtb.Text = "0";
          raoutput();

    }

        public void raoutput()
        {

            freslbl.Text = Convert.ToString(Math.Round(fuelres));
            radistlbl.Text = radistreslbl.Text = Convert.ToString(Math.Round(radistres));
            ratimereslbl.Text = Convert.ToString(Math.Round(ratimeres,2));
            ratimereslblh.Text = Convert.ToString(Math.Round(ratimeresh));
            ratimereslblm.Text = Convert.ToString(Math.Round(ratimeresm));
            windgsb.Text = windgso.Text = Convert.ToString(Math.Round(windinput));
            taslabelgsb.Text = taslabelgso.Text = Convert.ToString(Math.Round(tasinput));

            gsoeq1.Text = gsoeq2.Text = gsoeq3.Text = gsoreslbl.Text = Convert.ToString(Math.Round(gsores));

            gsbeq1.Text = gsbeq2.Text = gsbreslbl.Text = Convert.ToString(Math.Round(gsbres));

            wind = Convert.ToDouble(windgsb.Text);
            tas = tasinput;


        }
        /*----------------------------END RADIUS OF ACTION---------------------------------
          -------------------------START SPEED PROBLEMS------------------------------------*/

        private bool showvstformula;
        private void showformulavst_Click(object sender, EventArgs e)
        {
            showvstformula = !showvstformula;
            if (showvstformula == true)
            {
                formulavst.Visible = true;
                showformulavst.BackColor = Color.FromArgb(255, 0, 125, 255);
            }
            else if (showvstformula == false)
            {
                showformulavst.BackColor = Color.Gray;
                formulavst.Visible = false;
            }
        }

        private void SDTPage_Click(object sender, EventArgs e)
        {

        }

        public double sresnmsvst = 0.0;
        public double sressmsvst = 0.0;
        public double sreskmsvst = 0.0;
        public double vresktvvst = 0.0;
        public double vreskphvvst = 0.0;
        public double vresmphvvst = 0.0;
        public double hrestvst = 0.0;
        public double mrestvst = 0.0;
        public double srestvst = 0.0;
        public double vinputsvst = 0.0;
        public double tinputsvst = 0.0;
        public double sinputvvst = 0.0;
        public double tinputvvst = 0.0;
        public double sinputtvst = 0.0;
        public double vinputtvst = 0.0;

        private void calcbuttonvst_Click(object sender, EventArgs e)
        {

            //input S
            vinputsvst = Convert.ToDouble(vtbsvst.Text);
            tinputsvst = Convert.ToDouble(ttbsvst.Text);

            //input V
            sinputvvst = Convert.ToDouble(stbvvst.Text);
            tinputvvst = Convert.ToDouble(ttbvvst.Text);

            //input T
            sinputtvst = Convert.ToDouble(stbtvst.Text);
            vinputtvst = Convert.ToDouble(vtbtvst.Text);

            //init calc

            calcsvst();
            calcvvst();
            calctvst();

        }
        
           //METHOD FOR CALC V IN VST TAB 
        public void calcvvst()
        {
                if (scbvvst.Text == "NM" && tcbvvst.Text == "H")
            {
                vresktvvst = sinputvvst / tinputvvst;
                vreskphvvst = vresktvvst * 0.540003;
                vresmphvvst = vresktvvst * 0.868974;
            }
            else if (scbvvst.Text == "KM" && tcbvvst.Text == "H")
            {
                vreskphvvst = sinputvvst / tinputvvst;
                vresktvvst = vreskphvvst * 1.85184;
                vresmphvvst = vreskphvvst * 1.6092;
            }
            else if (scbvvst.Text == "SM" && tcbvvst.Text == "H")
            {
                vresmphvvst = sinputvvst / tinputvvst;
                vresktvvst = vresmphvvst * 1.150783;
                vreskphvvst = vresmphvvst * 0.621427;
            }
            if (scbvvst.Text == "NM" && tcbvvst.Text == "M")
            {
                vresktvvst = sinputvvst / tinputvvst / 60;
                vreskphvvst = vresktvvst * 0.540003;
                vresmphvvst = vresktvvst * 0.868974;
            }
            else if (scbvvst.Text == "KM" && tcbvvst.Text == "M")
            {
                vreskphvvst = sinputvvst / tinputvvst / 60;
                vresktvvst = vreskphvvst * 1.85184;
                vresmphvvst = vreskphvvst * 1.6092;
            }
            else if (scbvvst.Text == "SM" && tcbvvst.Text == "M")
            {
                vresmphvvst = sinputvvst / tinputvvst / 60;
                vresktvvst = vresmphvvst * 1.150783;
                vreskphvvst = vresmphvvst * 0.621427;
            }
            if (scbvvst.Text == "NM" && tcbvvst.Text == "S")
            {
                vresktvvst = sinputvvst / tinputvvst / 3600;
                vreskphvvst = vresktvvst * 0.540003;
                vresmphvvst = vresktvvst * 0.868974;
            }
            else if (scbvvst.Text == "KM" && tcbvvst.Text == "S")
            {
                vreskphvvst = sinputvvst / tinputvvst / 3600;
                vresktvvst = vreskphvvst * 1.85184;
                vresmphvvst = vreskphvvst * 1.6092;
            }
            else if (scbvvst.Text == "SM" && tcbvvst.Text == "S")
            {
                vresmphvvst = sinputvvst / tinputvvst / 3600;
                vresktvvst = vresmphvvst * 1.150783;
                vreskphvvst = vresmphvvst * 0.621427;
            }
            //output
            ktreslblvvst.Text = Convert.ToString(Math.Round(vresktvvst, 2));
            mphreslblvvst.Text = Convert.ToString(Math.Round(vresmphvvst, 2));
            kphreslblvvst.Text = Convert.ToString(Math.Round(vreskphvvst, 2));
        }

       //METHOD FOR CALC S IN VST TAB 
    public void calcsvst()
        { 
            if (vcbsvst.Text == "kts." && tcbsvst.Text == "H")
            {
                sresnmsvst = vinputsvst * tinputsvst;
                sressmsvst = (sresnmsvst * 1.150779);
                sreskmsvst = (sresnmsvst * 1.852);
            }
            else if (vcbsvst.Text == "KPH" && tcbsvst.Text == "H")
            {
                sreskmsvst = (vinputsvst * tinputsvst);
                sresnmsvst = sreskmsvst * 0.539957;
                sressmsvst = sreskmsvst * 0.621371;
            }
            else if (vcbsvst.Text == "MPH" && tcbsvst.Text == "H")
            {
                sressmsvst = (vinputsvst * tinputsvst);
                sreskmsvst = sressmsvst * 1.609344;
                sresnmsvst = sressmsvst * 0.868976;
            }
            else if (vcbsvst.Text == "kts." && tcbsvst.Text == "M")
            {
                sresnmsvst = vinputsvst * (tinputsvst / 60);
                sressmsvst = (sresnmsvst * 1.150779);
                sreskmsvst = (sresnmsvst * 1.852);
            }
            else if (vcbsvst.Text == "KPH" && tcbsvst.Text == "M")
            {
                sreskmsvst = vinputsvst * (tinputsvst / 60);
                sresnmsvst = sreskmsvst * 0.539957;
                sressmsvst = sreskmsvst * 0.621371;
            }
            else if (vcbsvst.Text == "MPH" && tcbsvst.Text == "M")
            {
                sressmsvst = vinputsvst * (tinputsvst / 60);
                sreskmsvst = sressmsvst * 1.609344;
                sresnmsvst = sressmsvst * 0.868976;
            }
            else if (vcbsvst.Text == "kts." && tcbsvst.Text == "S")
            {
                sresnmsvst = vinputsvst * (tinputsvst / 3600);
                sressmsvst = (sresnmsvst * 1.150779);
                sreskmsvst = (sresnmsvst * 1.852);
            }
            else if (vcbsvst.Text == "KPH" && tcbsvst.Text == "S")
            {
                sreskmsvst = vinputsvst * (tinputsvst / 3600);
                sresnmsvst = sreskmsvst * 0.539957;
                sressmsvst = sreskmsvst * 0.621371;
            }
            else if (vcbsvst.Text == "MPH" && tcbsvst.Text == "S")
            {
                sressmsvst = vinputsvst * (tinputsvst / 3600);
                sreskmsvst = sressmsvst * 1.609344;
                sresnmsvst = sressmsvst * 0.868976;
            }
            //output
            nmreslblsvst.Text = (Convert.ToString(Math.Round(sresnmsvst, 2)));
            kmreslblsvst.Text = (Convert.ToString(Math.Round(sreskmsvst, 2)));
            smreslblsvst.Text = (Convert.ToString(Math.Round(sressmsvst, 2)));
        }

        //method for calc T in VST tab
        private void calctvst()
        {
            if (scbtvst.Text == "NM" && vcbtvst.Text == "kts.")
                hrestvst = sinputtvst / vinputtvst;
            else if (scbtvst.Text == "KM" && vcbtvst.Text == "kts.")
                hrestvst = sinputtvst * 0.539957 / vinputtvst;
            else if (scbtvst.Text == "SM" && vcbtvst.Text == "kts.")
                hrestvst = sinputtvst * 0.868976 / vinputtvst;
            else if (scbtvst.Text == "NM" && vcbtvst.Text == "KPH")
                hrestvst = sinputtvst * 1.852 / vinputtvst;
            else if (scbtvst.Text == "KM" && vcbtvst.Text == "KPH")
                hrestvst = sinputtvst / vinputtvst;
            else if (scbtvst.Text == "SM" && vcbtvst.Text == "KPH")
                hrestvst = sinputtvst * 1.609344 / vinputtvst;
            else if (scbtvst.Text == "NM" && vcbtvst.Text == "MPH")
                hrestvst = sinputtvst * 1.150779 / vinputtvst;
            else if (scbtvst.Text == "KM" && vcbtvst.Text == "MPH")
                hrestvst = sinputtvst * 0.621371 / vinputtvst;
            else if (scbtvst.Text == "SM" && vcbtvst.Text == "MPH")
                hrestvst = sinputtvst / vinputtvst;
        
            // Convert to HMS
            mrestvst = (hrestvst - Math.Truncate(hrestvst)) * 60;
            srestvst = (mrestvst - Math.Truncate(mrestvst)) * 60;



            //output
            hreslbltvst.Text = Convert.ToString(Math.Truncate(hrestvst));
            mreslbltvst.Text = Convert.ToString(Math.Truncate(mrestvst));
            sreslbltvst.Text = Convert.ToString(Math.Truncate(srestvst));
            
        }
        private void vcbsvst_TextChanged(object sender, EventArgs e)
        {
            calcsvst();
            
        }

        private void tcbsvst_TextChanged(object sender, EventArgs e)
        {
            calcsvst();
        }

        private void scbvvst_TextChanged(object sender, EventArgs e)
        {
            calcvvst();
        }

        private void tcbvvst_TextChanged(object sender, EventArgs e)
        {
            calcvvst();
        }

        private void scbtvst_TextChanged(object sender, EventArgs e)
        {
            calctvst();
        }

        private void vcbtvst_TextChanged(object sender, EventArgs e)
        {
            calctvst();
        }

        
    }

}
    
