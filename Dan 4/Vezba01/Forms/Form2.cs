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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // da li cuvati u posebnoj klasi ili prosledjivati?
            //List<string> something = new List<string>();
            //something.Add("Csaba");
            //something.Add("Denes");
            //something.Add("Zoltan");

            int top = 20;

            foreach (var item in AppData.Institucije)
            {
                Label lblMy = new Label
                {
                    Text = item.Naziv,
                    Location = new Point(10, top),
                    TextAlign = ContentAlignment.MiddleLeft,

                };

                Button btnMy = new Button
                {
                    Text = "Otvori",
                    Location = new Point(150, top),
                    Size = new Size(60, 25),
                };

                //btnMy.Click += (o, ea) =>
                //{
                //    btnMy.Text = item.Naziv;
                //    btnMy.Width = 100;
                //};

                btnMy.Click += (o, ea) =>
                {
                    AppData.Kurzor = item;
                    frmInstitucija moja = new frmInstitucija();
                    moja.ShowDialog();
                };

                Controls.Add(btnMy);
                Controls.Add(lblMy);
                top += 30;
            }
        }
    }
}
