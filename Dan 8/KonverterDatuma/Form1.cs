using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonverterDatuma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKonvert_Click(object sender, EventArgs e)
        {
            string txt = this.tbxUlaz.Text;
            DateTime dt;
            bool success = DateTime.TryParse(txt, out dt);
            if (success)
            {
                this.tbxIzlaz.Text = String.Format("{0:D4}-{1:D2}-{2:D2}", dt.Year, dt.Month, dt.Day);
                Clipboard.SetText(String.Format("{0:D4}-{1:D2}-{2:D2}", dt.Year, dt.Month, dt.Day));
            }
        }

        private void tbxUlaz_MouseClick(object sender, MouseEventArgs e)
        {
            this.tbxUlaz.ResetText();
        }
    }
}
