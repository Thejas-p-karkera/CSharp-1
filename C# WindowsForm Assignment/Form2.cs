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
    public partial class Form2 : Form
    {
        bool checker;
        int plusOne;

        void Enable_false()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }

        void score()
        {
            if(btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
            {
                btn1.BackColor = Color.Green;
                btn2.BackColor = Color.Green;
                btn3.BackColor = Color.Green;

                MessageBox.Show("The winner is player X");
                plusOne = int.Parse(lblplyrX.Text);
                lblplyrX.Text = Convert.ToString(plusOne + 1);
                Enable_false();
            }

            if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X")
            {
                btn4.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn6.BackColor = Color.Green;

                MessageBox.Show("The winner is player X");
                plusOne = int.Parse(lblplyrX.Text);
                lblplyrX.Text = Convert.ToString(plusOne + 1);
                Enable_false();
            }

            if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
            {
                btn7.BackColor = Color.Green;
                btn8.BackColor = Color.Green;
                btn9.BackColor = Color.Green;

                MessageBox.Show("The winner is player X");
                plusOne = int.Parse(lblplyrX.Text);
                lblplyrX.Text = Convert.ToString(plusOne + 1);
                Enable_false();
            }

            if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X")
            {
                btn1.BackColor = Color.Green;
                btn4.BackColor = Color.Green;
                btn7.BackColor = Color.Green;

                MessageBox.Show("The winner is player X");
                plusOne = int.Parse(lblplyrX.Text);
                lblplyrX.Text = Convert.ToString(plusOne + 1);
                Enable_false();
            }

            if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
            {
                btn2.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn8.BackColor = Color.Green;

                MessageBox.Show("The winner is player X");
                plusOne = int.Parse(lblplyrX.Text);
                lblplyrX.Text = Convert.ToString(plusOne + 1);
                Enable_false();
            }

            if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
            {
                btn3.BackColor = Color.Green;
                btn6.BackColor = Color.Green;
                btn9.BackColor = Color.Green;

                MessageBox.Show("The winner is player X");
                plusOne = int.Parse(lblplyrX.Text);
                lblplyrX.Text = Convert.ToString(plusOne + 1);
                Enable_false();
            }

            if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
            {
                btn1.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn9.BackColor = Color.Green;

                MessageBox.Show("The winner is player X");
                plusOne = int.Parse(lblplyrX.Text);
                lblplyrX.Text = Convert.ToString(plusOne + 1);
                Enable_false();
            }

            if (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            {
                btn3.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn7.BackColor = Color.Green;

                MessageBox.Show("The winner is player X");
                plusOne = int.Parse(lblplyrX.Text);
                lblplyrX.Text = Convert.ToString(plusOne + 1);
                Enable_false();
            }

            //=========================================================================

            if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O")
            {
                btn1.BackColor = Color.Green;
                btn2.BackColor = Color.Green;
                btn3.BackColor = Color.Green;

                MessageBox.Show("The winner is player O");
                plusOne = int.Parse(lblplyrO.Text);
                lblplyrO.Text = Convert.ToString(plusOne + 1);
                Enable_false();
            }

            if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O")
            {
                btn4.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn6.BackColor = Color.Green;

                MessageBox.Show("The winner is player O");
                plusOne = int.Parse(lblplyrO.Text);
                lblplyrO.Text = Convert.ToString(plusOne + 1);
                Enable_false();
            }

            if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
            {
                btn7.BackColor = Color.Green;
                btn8.BackColor = Color.Green;
                btn9.BackColor = Color.Green;

                MessageBox.Show("The winner is player O");
                plusOne = int.Parse(lblplyrO.Text);
                lblplyrO.Text = Convert.ToString(plusOne + 1);
                Enable_false();
            }

            if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O")
            {
                btn1.BackColor = Color.Green;
                btn4.BackColor = Color.Green;
                btn7.BackColor = Color.Green;

                MessageBox.Show("The winner is player O");
                plusOne = int.Parse(lblplyrO.Text);
                lblplyrO.Text = Convert.ToString(plusOne + 1);
                Enable_false();
            }

            if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")
            {
                btn2.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn8.BackColor = Color.Green;

                MessageBox.Show("The winner is player O");
                plusOne = int.Parse(lblplyrO.Text);
                lblplyrO.Text = Convert.ToString(plusOne + 1);
                Enable_false();
            }

            if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
            {
                btn3.BackColor = Color.Green;
                btn6.BackColor = Color.Green;
                btn9.BackColor = Color.Green;

                MessageBox.Show("The winner is player O");
                plusOne = int.Parse(lblplyrO.Text);
                lblplyrO.Text = Convert.ToString(plusOne + 1);
                Enable_false();
            }

            if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O")
            {
                btn1.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn9.BackColor = Color.Green;

                MessageBox.Show("The winner is player O");
                plusOne = int.Parse(lblplyrO.Text);
                lblplyrO.Text = Convert.ToString(plusOne + 1);
                Enable_false();
            }

            if (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            {
                btn3.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn7.BackColor = Color.Green;

                MessageBox.Show("The winner is player O");
                plusOne = int.Parse(lblplyrO.Text);
                lblplyrO.Text = Convert.ToString(plusOne + 1);
                Enable_false();
            }

        }
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(checker == false)
            {
                btn1.Text = "X";
                checker = true;
            }
            else
            {
                btn1.Text = "O";
                checker = false;
            }
            score();
            btn1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn2.Text = "X";
                checker = true;
            }
            else
            {
                btn2.Text = "O";
                checker = false;
            }
            score();
            btn2.Enabled = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn3.Text = "X";
                checker = true;
            }
            else
            {
                btn3.Text = "O";
                checker = false;
            }
            score();
            btn3.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn4.Text = "X";
                checker = true;
            }
            else
            {
                btn4.Text = "O";
                checker = false;
            }
            score();
            btn4.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn5.Text = "X";
                checker = true;
            }
            else
            {
                btn5.Text = "O";
                checker = false;
            }
            score();
            btn5.Enabled = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn6.Text = "X";
                checker = true;
            }
            else
            {
                btn6.Text = "O";
                checker = false;
            }
            score();
            btn6.Enabled = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn7.Text = "X";
                checker = true;
            }
            else
            {
                btn7.Text = "O";
                checker = false;
            }
            score();
            btn7.Enabled = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn8.Text = "X";
                checker = true;
            }
            else
            {
                btn8.Text = "O";
                checker = false;
            }
            score();
            btn8.Enabled = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn9.Text = "X";
                checker = true;
            }
            else
            {
                btn9.Text = "O";
                checker = false;
            }
            score();
            btn9.Enabled = false;
        }

        private void btnNG_Click(object sender, EventArgs e)
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            lblplyrX.Text = "0";
            lblplyrO.Text = "0";

            btn1.BackColor = Color.White;
            btn2.BackColor = Color.White;
            btn3.BackColor = Color.White;
            btn4.BackColor = Color.White;
            btn5.BackColor = Color.White;
            btn6.BackColor = Color.White;
            btn7.BackColor = Color.White;
            btn8.BackColor = Color.White;
            btn9.BackColor = Color.White;

            checker = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            btnNG.Enabled = true;

            btn1.BackColor = Color.White;
            btn2.BackColor = Color.White;
            btn3.BackColor = Color.White;
            btn4.BackColor = Color.White;
            btn5.BackColor = Color.White;
            btn6.BackColor = Color.White;
            btn7.BackColor = Color.White;
            btn8.BackColor = Color.White;
            btn9.BackColor = Color.White;

            checker = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Confirm exit?");

                if(iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
