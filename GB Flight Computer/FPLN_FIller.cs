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
    public partial class FPLN_FIller : Form
    {
        public FPLN_FIller()
        {
            InitializeComponent();
        }

        private void textupdatesfpln()
        {


            routetb.Text = 
            secondalt.Text = DeptAero.Text;
        }

        private void DeptAero_TextChanged(object sender, EventArgs e)
        {
            textupdatesfpln();
        }

        private void roundrobinbut_Click(object sender, EventArgs e)
        {
            textupdatesfpln();
            otherinfotb.Text = "Round Robin Cross Country Flight";
            routetb.Text = DeptAero.Text + "-" + destaero.Text + "-" + DeptAero.Text;
        }

        private void AAADefs_Click(object sender, EventArgs e)
        {
            DeptAero.Text = "RPUI";
            destaero.Text = "RPUS";
            FlightRulescb.Text = "V";
            FlightTypeCB.Text = "G";
            eethtb.Text = "03";
            eetmtb.Text = "00";
            altaerotb.Text = "RPUG";
            waketurbcb.Text = "L";
            eqptTB.Text = "S/C";
            speedunittb.Text = "N";
            crzspdtb.Text = "085";
            EndHTB.Text = "04";
            EndMTB.Text = "00";
            otherinfotb.Text = "";
            ownerphonetb.Text = "+63478113787";
            HomeBaseTB.Text = "AAA Academy, Iba Airport, Zambales";
            closefplntb.Text = "RPUI";
            closefplnbytb.Text = "PIC";
            routetb.Text = "";
            crgquanttb.Text = "NIL";
            crgtypetb.Text = "NIL";
            crgweighttb.Text = "NIL";
            PSGRTB.Text = "Gregorius Bryan (Indonesian)";
            
            
        }

        private void Clearbut_Click(object sender, EventArgs e)
        {
            DeptAero.Text = "";
            destaero.Text = "";
            FlightRulescb.Text = "V";
            FlightTypeCB.Text = "G";
            eethtb.Text = "00";
            eetmtb.Text = "00";
            altaerotb.Text = "";
            waketurbcb.Text = "L";
            eqptTB.Text = "S/C";
            speedunittb.Text = "N";
            crzspdtb.Text = "0";
            EndHTB.Text = "00";
            EndMTB.Text = "00";
            routetb.Text = "";
        }

        private void mmbutton_Click(object sender, EventArgs e)
        {
            MainMenu mmn = new MainMenu();
            this.Hide();
            mmn.Show();

        }
    }
}
