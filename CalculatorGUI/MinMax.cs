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
    /// This program implements solving minimum and maximum of any two numbers functions to a form
    /// </summary>
    /// <Student>Dominic Verardi</Student>
    /// <Class>CIS297</Class>
    /// <Semester>Winter 2022</Semester>
    /// 
    public partial class MinMax : Form
    {
        public MinMax()
        {
            InitializeComponent();
        }

        //Click Solve on form to solve for a minimum and maximum of any two numbers
        private void solve_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(maximumTextBox.Text);
            int secondNumber = Convert.ToInt32(minimumTextBox.Text);
            int min = Math.Min(firstNumber, secondNumber);
            int max = Math.Max(firstNumber, secondNumber);
            resultDisplay.Text = string.Format("Minimum of " + firstNumber + " and " + secondNumber + " is " + min + ". Maximum of " + firstNumber + " and " + secondNumber + " is " + max + ".");
        }

        //Clear the form
        private void reset_Click(object sender, EventArgs e)
        {
            resultDisplay.Text = "";
            minimumTextBox.Text = "";
            maximumTextBox.Text = "";
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
