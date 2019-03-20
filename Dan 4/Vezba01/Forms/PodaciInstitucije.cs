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
    public partial class PodaciInstitucije : Form
    {
        public PodaciInstitucije()
        {
            InitializeComponent();
        }

        private void PodaciInstitucije_Load(object sender, EventArgs e)
        {
            int x = 10;
            int y = 10;
            // Prikazi zaposlene
            foreach (var z in AppData.Kurzor.Kadrovi)
            {

                Label lbl = new Label
                {
                    Location = new Point(x, y),
                    Size = new Size(40, 10),
                    Text = z.Ime,
                };
                Controls.Add(lbl);
                y += 20;
            }
        }
    }
}
