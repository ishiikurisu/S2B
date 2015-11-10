using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Window : Form
    {
        Calculator Calc;
        Operator Op;
        string LastOperation;

        public Window()
        {
            InitializeComponent();
            this.Calc = new Calculator();
            this.Op = new Operator();
            this.LastOperation = "";
        }

        private void operate(string numberString, string operation)
        {
            double number = double.Parse(numberString );

            if (this.LastOperation.Length == 0)
            {
                this.Calc.Add(number);
                this.LastOperation = operation;
            }
            else
            {
                switch (operation)
                {
                    case "+":
                        this.Calc.Add(number);
                        break;
                    case "-":
                        this.Calc.Subtract(number);
                        break;
                    case "*":
                        this.Calc.Multiply(number);
                        break;
                    case "/":
                        this.Calc.Divide(number);
                        break;
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Calc.ResetAccumulator();
            this.Op.Flush();
            txtVisor.Text = "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            this.Op.Push(".");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.operate(this.Op.Flush(), this.LastOperation);
            txtVisor.Text = this.Calc.GetAccumulator().ToString();
            LastOperation = "";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.Op.Push("0");
            txtVisor.Text = this.Op.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.Op.Push("1");
            txtVisor.Text = this.Op.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Op.Push("2");
            txtVisor.Text = this.Op.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.Op.Push("3");
            txtVisor.Text = this.Op.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.Op.Push("4");
            txtVisor.Text = this.Op.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.Op.Push("5");
            txtVisor.Text = this.Op.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.Op.Push("6");
            txtVisor.Text = this.Op.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.Op.Push("7");
            txtVisor.Text = this.Op.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.Op.Push("8");
            txtVisor.Text = this.Op.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.Op.Push("9");
            txtVisor.Text = this.Op.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /* plus button */
            this.operate(this.Op.Flush(), "+");
            this.LastOperation = "+";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            /* minus button */
            this.operate(this.Op.Flush(), "-");
            this.LastOperation = "-";
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            /*times button*/
            this.operate(this.Op.Flush(), "*");
            this.LastOperation = "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            this.operate(this.Op.Flush(), "/");
            this.LastOperation = "/";
        }
    }
}
