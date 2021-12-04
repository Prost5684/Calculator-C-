using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Operators currentOperator = Operators.Equal;
        private double firstNumber = 0;
        private double secondNumber = 0;
        private double memory = 0;

        public Form()
        {
            InitializeComponent();
            txtScreen.Text = "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtScreen.Text);
            currentOperator = Operators.Add;
            txtScreen.Text = "0";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtScreen.Text);
            currentOperator = Operators.Sub;
            txtScreen.Text = "0";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtScreen.Text);
            currentOperator = Operators.Mult;
            txtScreen.Text = "0";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtScreen.Text);
            currentOperator = Operators.Div;
            txtScreen.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScreen.Text = "0";
            currentOperator = Operators.Equal;
            firstNumber = 0;
            secondNumber = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text.Length == 1) txtScreen.Text = "0";
            else txtScreen.Text = txtScreen.Text.Remove(txtScreen.Text.Length - 1);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            secondNumber = Convert.ToDouble(txtScreen.Text);
            if(currentOperator != Operators.Equal)
                txtScreen.Text = Calculate(firstNumber, currentOperator, secondNumber).ToString();
        }

        private double Calculate(double firstValue, Operators currentOperator, double secondValue)
        {
            double result = 0;

            switch (currentOperator)
            {
                case Operators.Add:
                    result = firstValue + secondValue;
                    return result;
                case Operators.Sub:
                    result = firstValue - secondValue;
                    return result;
                case Operators.Mult:
                    result = firstValue * secondValue;
                    return result;
                case Operators.Div:
                    result = firstValue / secondValue;
                    return result;
            }

            return 0;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text != "0") txtScreen.Text += "0";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "1";
            else txtScreen.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "2";
            else txtScreen.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "3";
            else txtScreen.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "4";
            else txtScreen.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "5";
            else txtScreen.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "6";
            else txtScreen.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "7";
            else txtScreen.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "8";
            else txtScreen.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "9";
            else txtScreen.Text += "9";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!txtScreen.Text.Contains(".")) txtScreen.Text += ".";
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text != "0") txtScreen.Text = (Convert.ToDouble(txtScreen.Text) * -1).ToString();
        }

        private void btnMemStore_Click(object sender, EventArgs e)
        {
            memory = Convert.ToDouble(txtScreen.Text);
        }

        private void btnMemAdd_Click(object sender, EventArgs e)
        {
            memory += Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
        }

        private void btnMemSub_Click(object sender, EventArgs e)
        {
            memory -= Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
        }

        private void btnMemRecall_Click(object sender, EventArgs e)
        {
            txtScreen.Text = memory.ToString();
        }

        private void btnMemClear_Click(object sender, EventArgs e)
        {
            memory = 0;
        }
    }
}
