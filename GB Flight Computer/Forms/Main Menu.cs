using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;

namespace GB_Flight_Computer
{
    public partial class MainMenu : MaterialForm
    {
        public MainMenu()
        {
            InitializeComponent();
            var skinMgr = MaterialSkinManager.Instance;
            skinMgr.AddFormToManage(this);
            skinMgr.Theme = MaterialSkinManager.Themes.LIGHT;
            skinMgr.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            

        
        }

        private void ConvButton_Main_Click(object sender, EventArgs e)
        {



            Converter convform = new Converter();
            this.Hide();           
            convform.Show();
           
            

        }

        private void WBButton_Main_Click(object sender, EventArgs e)
        {
            WnB wnbform = new WnB();
            this.Hide();
            wnbform.Show();
        }
        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void POHButtonMain_Click(object sender, EventArgs e)
        {
            POH pohform = new POH();
            this.Hide();
            pohform.Show();
        }

        private void FAButton_Main_Click(object sender, EventArgs e)
        {
            NextWPFreq_Lbl faform = new NextWPFreq_Lbl();
            this.Hide();
            faform.Show();
        }

        private void AFButton_main_Click(object sender, EventArgs e)
        {
            Advanced_Formulas afform = new Advanced_Formulas();
            this.Hide();
            afform.Show();
        }

        private void NavlogMkr_Button_Click(object sender, EventArgs e)
        {
            Navlog_Maker nvlmkr = new Navlog_Maker();
            this.Hide();
            nvlmkr.Show();
        }
    }
    
}
