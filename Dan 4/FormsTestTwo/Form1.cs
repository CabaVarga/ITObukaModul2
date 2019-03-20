using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsTestTwo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> something = new List<string>();
            something.Add("Csaba");
            something.Add("Denes");
            something.Add("Zoltan");

            int top = 20;

            foreach (var item in something)
            {
                Label lblMy = new Label
                {
                    Text = item,
                    Location = new Point(10, top),
                    TextAlign = ContentAlignment.MiddleLeft,

            };

                Button btnMy = new Button
                {
                    Text = "Add",
                    Location = new Point(90, top),
                    Size = new Size(50, 25),
                };

                btnMy.Click += (o, ea) =>
                {
                    btnMy.Text = item;
                    btnMy.Width = 100;
                };

                Controls.Add(btnMy);
                Controls.Add(lblMy);
                top += 30;
            }
        }
    }
}
