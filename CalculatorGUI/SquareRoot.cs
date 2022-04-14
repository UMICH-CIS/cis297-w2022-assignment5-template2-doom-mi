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
    /// This program implements solving the square root of a number functions to a form
    /// </summary>
    /// <Student>Dominic Verardi</Student>
    /// <Class>CIS297</Class>
    /// <Semester>Winter 2022</Semester>
    /// 
    public partial class SquareRoot : Form
    {
        public SquareRoot()
        {
            InitializeComponent();
        }

        //Click solve to solve for the square root of a number
        private void solve_Click(object sender, EventArgs e)
        {
            double number7 = double.Parse(numberTextBox.Text);
            numberDisplay.Text = string.Format("Square root of {0} is {1}.", number7, Math.Sqrt(number7));
        }

        //Clear the form
        private void reset_Click(object sender, EventArgs e)
        {
            numberDisplay.Text = "";
            numberTextBox.Text = "";
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
