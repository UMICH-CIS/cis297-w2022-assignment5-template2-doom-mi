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
    /// <summary>
    /// This program implements solving for the Quotient and Remainder functions to a form
    /// </summary>
    /// <Student>Dominic Verardi</Student>
    /// <Class>CIS297</Class>
    /// <Semester>Winter 2022</Semester>
    /// 
    public partial class QuotientRemainder : Form
    {
        public QuotientRemainder()
        {
            InitializeComponent();
        }

        //Click Solve on form to solve for the Quotient and Remainder
        private void solve_Click(object sender, EventArgs e)
        {
            int dividend = Convert.ToInt32(dividendTextBox.Text);
            int divisor = Convert.ToInt32(divisorTextBox.Text);
            int remainder;
            int quotient = Math.DivRem(dividend, divisor, out remainder);
            resultDisplay.Text = string.Format(dividend + " divided by " + divisor + " results in " + quotient + " as the quotient and " + remainder + " as the remainder.");
        }

        //Clear the form
        private void reset_Click(object sender, EventArgs e)
        {
            dividendTextBox.Text = "";
            divisorTextBox.Text = "";
            resultDisplay.Text = "";
        }

        //Go back to Calculator GUI
        private void back_Click(object sender, EventArgs e)
        {
            CalculatorGUIForm calculatorGUI = new CalculatorGUIForm();
            Hide();
            calculatorGUI.ShowDialog();
            Close();
        }
    }
}
