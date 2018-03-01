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

        private void inHglist_Click(object sender, EventArgs e)
        {
            //hpalabel.Text = inHglist / 0.03;
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
    }
}
