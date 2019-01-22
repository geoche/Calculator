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
    public partial class Calculator : Form
    {

        Double value = 0;
        String operation = "";
        bool operationPressed = false;

        public Calculator()
        {
            InitializeComponent();
        }


        private void button18_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
           
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            value = Double.Parse(textBox.Text);
            operationPressed = true;
        }

        private void button_click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || (operationPressed))
                textBox.Clear();
            Button button = (Button)sender;
            textBox.Text = textBox.Text + button.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void result_click_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox.Text = (value + Double.Parse(textBox.Text)).ToString();
                    break;
                case "-":
                    textBox.Text = (value - Double.Parse(textBox.Text)).ToString();
                    break;
                case "/":
                    textBox.Text = (value / Double.Parse(textBox.Text)).ToString();
                    break;
                case "*":
                    textBox.Text = (value * Double.Parse(textBox.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}