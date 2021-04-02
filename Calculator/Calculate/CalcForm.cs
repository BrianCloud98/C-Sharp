using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MultiCalc
{
    public partial class CalcForm : Form
    {
        double number1;
        double number2;
        string operation;
        double total;

        public CalcForm()
        {
            InitializeComponent();
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (historyTB.Text != "" && operation != null)
            {
                number2 = Convert.ToDouble(historyTB.Text);

                switch(operation)
                {
                    case ("add"):
                        total = number1 + number2;
                        break;
                    case ("subtract"):
                        total = number1 - number2;
                        break;
                    case ("multiply"):
                        total = number1 * number2;
                        break;
                    case ("divide"):
                        total = number1 / number2;
                        break;
                }
            }

            totalTB.Text = total.ToString();
            historyTB.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            historyTB.Text += ("1").ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            historyTB.Text += ("2").ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            historyTB.Text += ("3").ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            historyTB.Text += ("4").ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            historyTB.Text += ("5").ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            historyTB.Text += ("6").ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            historyTB.Text += ("7").ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            historyTB.Text += ("8").ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            historyTB.Text += ("9").ToString();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            historyTB.Text += Convert.ToString("0");
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (historyTB.Text != "")
            {
                number1 = Convert.ToDouble(historyTB.Text);
                operation = "add";
                historyTB.Text = "";
            }
            else if (totalTB.Text != "")
            {
                number1 = total;
                operation = "add";
            }

        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (historyTB.Text != "")
            {
                number1 = Convert.ToDouble(historyTB.Text);
                operation = "subtract";
                historyTB.Text = "";
            }
            else if (totalTB.Text != "")
            {
                number1 = total;
                operation = "subtract";
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (historyTB.Text != "")
            {
                number1 = Convert.ToDouble(historyTB.Text);
                operation = "multiply";
                historyTB.Text = "";
            }
            else if (totalTB.Text != "")
            {
                number1 = total;
                operation = "multiply";
            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (historyTB.Text != "")
            {
                number1 = Convert.ToDouble(historyTB.Text);
                operation = "divide";
                historyTB.Text = "";
            }
            else if (totalTB.Text != "")
            {
                number1 = total;
                operation = "divide";
            }
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            historyTB.Text = "";
        }

        private void allClearBTN_Click(object sender, EventArgs e)
        {
            historyTB.Text = "";
            totalTB.Text = "";
            number1 = 0;
            number2 = 0;
            total = 0;
            operation = null;
        }
    }
}
