using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cs_CalcWindwForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Total;
        double num1;
        double num2;
        string option;
        double result;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn0.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = double.Parse(textBox1.Text);
            textBox1.Text = textBox1.Text + " + ";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = double.Parse(textBox1.Text);
            textBox1.Text = textBox1.Text + " - ";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = double.Parse(textBox1.Text);
            textBox1.Text = textBox1.Text + " x ";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = double.Parse(textBox1.Text);
            textBox1.Text = textBox1.Text + " / ";
        }

        private void btnAns_Click(object sender, EventArgs e)
        {
            //num2 = double.Parse(textBox1.Text);

            num2 = double.Parse(textBox1.Text.Substring(textBox1.Text.LastIndexOf(option)+ 1 ));

            if (option == "+")
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

            //try
            //{
                if (option == "/")
                {
                    result = num1 / num2;
                }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    //textBox1.Clear();
            //    //num1 = 0;
            //    //num2 = 0;
            //    //result = 0;

            //}
            
            textBox1.Text = result + "";
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            num1 = 0;
            num2 = 0;
            result = 0;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }
    }
}
