using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        double a = 0;
        double b = 0;
        double resultOf = 0;
        string aS = "";
        string aB = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            string temp = label1.Text;
            if (temp.Length > 7)
            {
                label1.Text = label1.Text;
            }
            else
                label1.Text = label1.Text + "7";
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button button1 = (Button)sender;
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            string temp = label1.Text;
            if (temp.Length > 7 )
            {
                label1.Text = label1.Text;
            }
            else
                label1.Text = label1.Text + button1.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button button2 = (Button)sender;
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            string temp = label1.Text;
            if (temp.Length > 7)
            {
                label1.Text = label1.Text;
            }
            else
                label1.Text = label1.Text + button2.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button button3 = (Button)sender;
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            string temp = label1.Text;
            if (temp.Length > 7)
            {
                label1.Text = label1.Text;
            }
            else
                label1.Text = label1.Text + button3.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button4 = (Button)sender;
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            string temp = label1.Text;
            if (temp.Length > 7)
            {
                label1.Text = label1.Text;
            }
            else
                label1.Text = label1.Text + button4.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button5 = (Button)sender;
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            string temp = label1.Text;
            if (temp.Length > 7)
            {
                label1.Text = label1.Text;
            }
            else
                label1.Text = label1.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button6 = (Button)sender;
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            string temp = label1.Text;
            if (temp.Length > 7)
            {
                label1.Text = label1.Text;
            }
            else
                label1.Text = label1.Text + button6.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button8 = (Button)sender;
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            string temp = label1.Text;
            if (temp.Length > 7)
            {
                label1.Text = label1.Text;
            }
            else
                label1.Text = label1.Text + button8.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button9 = (Button)sender;

            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            string temp = label1.Text;
            if (temp.Length > 7)
            {
                label1.Text = label1.Text;
            }
            else
                label1.Text = label1.Text + button9.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }
    }
}
