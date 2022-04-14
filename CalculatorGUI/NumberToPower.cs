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
    /// This program implements solving the number to any power functions to a form
    /// </summary>
    /// <Student>Dominic Verardi</Student>
    /// <Class>CIS297</Class>
    /// <Semester>Winter 2022</Semester>
    /// 
    public partial class NumberToPower : Form
    {
        public NumberToPower()
        {
            InitializeComponent();
        }

        //Click Solve on form to solve for the power of any form using any two numbers
        private void solve_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(specNumberTextBox.Text);
            double power = Convert.ToDouble(powerTextBox.Text);
            double result = Math.Pow(number, power);
            resultDisplay.Text = string.Format(number + " to the power " + power + " is " + result + ".");
        }

        //Clear the form
        private void reset_Click(object sender, EventArgs e)
        {
            resultDisplay.Text = "";
            specNumberTextBox.Text = "";
            powerTextBox.Text = "";
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
