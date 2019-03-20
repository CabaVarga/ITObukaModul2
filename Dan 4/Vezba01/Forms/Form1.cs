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
    public partial class Form1 : Form
    {
        public List<Institucija> Institucije { get; private set; }

        public void DodajListuInstitucija(List<Institucija> li)
        {
            Institucije = li;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            // this.Hide();
            f2.ShowDialog();
            f2.Activate();
        }
    }
}
