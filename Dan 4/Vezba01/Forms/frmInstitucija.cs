using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vezba01.Forms
{
    public partial class frmInstitucija : Form
    {
        public frmInstitucija()
        {
            InitializeComponent();
        }

        private void Institucija_Load(object sender, EventArgs e)
        {
            this.label4.Text = AppData.Kurzor.Naziv;
            this.label5.Text = AppData.Kurzor.Adresa;
            this.label6.Text = "Za sada nista";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PodaciInstitucije pi = new PodaciInstitucije();
            pi.ShowDialog();
        }
    }
}
