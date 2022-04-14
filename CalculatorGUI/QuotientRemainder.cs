using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorGUI
{
    public partial class QuotientRemainder : Form
    {
        public QuotientRemainder()
        {
            InitializeComponent();
        }

        private void solve_Click(object sender, EventArgs e)
        {
            int dividend = Convert.ToInt32(dividendTextBox.Text);
            int divisor = Convert.ToInt32(divisorTextBox.Text);
            int remainder;
            int quotient = Math.DivRem(dividend, divisor, out remainder);
            resultDisplay.Text = string.Format(dividend + " divided by " + divisor + " results in " + quotient + " as the quotient and " + remainder + " as the remainder.");
        }  

        private void reset_Click(object sender, EventArgs e)
        {
            dividendTextBox.Text = "";
            divisorTextBox.Text = "";
            resultDisplay.Text = "";
        }

        private void back_Click(object sender, EventArgs e)
        {
            CalculatorGUIForm calculatorGUI = new CalculatorGUIForm();
            Hide();
            calculatorGUI.ShowDialog();
            Close();
        }
    }
}
