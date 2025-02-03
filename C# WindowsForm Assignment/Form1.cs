using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__WindowsForm_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String calcTotal;
        int num1;
        int num2;
        string option;
        int result;

        private void button16_Click(object sender, EventArgs e)
        {
            option = "+";

            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            option = "/";

            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            option = "*";

            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            option = "-";

            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            result = 0;
            num1 = 0;
            num2 = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtDisplay.Text);

            if(option == "+")
            {
                result = num1 + num2;
            }

            if (option == "-")
            {
                result = num1 - num2;
            }

            if (option == "*")
            {
                result = num1 * num2;
            }

            if (option == "/")
            {
                result = num1 / num2;
            }

            txtDisplay.Text = result + "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn0.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn9.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn8.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn7.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn6.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn5.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn4.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn1.Text;
        }
    }
}
