using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button btnMy = new Button();
            btnMy.Text = "Add";
            btnMy.Location = new System.Drawing.Point(90, 25);
            btnMy.Size = new System.Drawing.Size(50, 25);
            Controls.Add(btnMy);
        }
    }
}
