using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4Harjoitus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {

            DateTime nyt = DateTime.Now;
            DateTime synttari = ValitsePVM.Value;
            

            double erotus = Math.Round((nyt-synttari).TotalDays);



            VuosiLB.Text = Math.Ceiling(erotus / 365) + " vuotta";
            KuukausiLB.Text = Math.Ceiling(erotus * 12 / 365) + " kuukautta";
            PaivinaLB.Text = erotus + " päivää";
            TunteinaLB.Text = (erotus * 24 + " tuntia");
            MinuuttiLB.Text = (erotus * 24 * 60 + " minuuttia");

            VuosiLB.Visible = true;
            KuukausiLB.Visible = true;
            PaivinaLB.Visible = true;
            TunteinaLB.Visible = true;
            MinuuttiLB.Visible = true;
        }
    }
}
