using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using MaterialSkin;
using MaterialSkin.Controls;

namespace langues
{
    public partial class Form1 :MaterialForm
    {
        MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "English":
                    System.Threading.Thread.CurrentThread.CurrentUICulture =
              System.Globalization.CultureInfo.GetCultureInfo("en");
this.RightToLeft = RightToLeft.No;
                    this.RightToLeftLayout = false;

 break;
                case "Français":
                    System.Threading.Thread.CurrentThread.CurrentUICulture =
    System.Globalization.CultureInfo.GetCultureInfo("fr");
                    this.RightToLeft = RightToLeft.No;
                    this.RightToLeftLayout = false;
                    break;
                case "عربي":
                    System.Threading.Thread.CurrentThread.CurrentUICulture =
    System.Globalization.CultureInfo.GetCultureInfo("ar");
                    this.RightToLeft = RightToLeft.Yes;
                    this.RightToLeftLayout = true;
                    break;

            }
            this.Controls.Clear();
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog(); 

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green400, Primary.Green500,
                Primary.Green500, Accent.LightGreen200,
                TextShade.WHITE
            );
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSkinManager.Theme == MaterialSkinManager.Themes.DARK)
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            else
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

        }
    }
}
