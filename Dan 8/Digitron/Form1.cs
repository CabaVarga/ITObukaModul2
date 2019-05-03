using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digitron
{
    public partial class Form1 : Form
    {
        private int rezultat;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rezultat = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string curr = txtRenamed.Text;
            if (curr == "0")
            {
                curr = "1";
            }
            else
            {
                curr = curr + "1";
            }
            txtRenamed.Text = curr;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string curr = txtRenamed.Text;
            if (curr == "0")
            {
                curr = "2";
            }
            else
            {
                curr = curr + "2";
            }
            txtRenamed.Text = curr;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string curr = txtRenamed.Text;
            if (curr == "0")
            {
                curr = "3";
            }
            else
            {
                curr = curr + "3";
            }
            txtRenamed.Text = curr;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Klik na jednako");
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtRenamed.Text = txtRenamed.Text + "5";
            Console.WriteLine("Pritisnut taster");
        }
    }
}
