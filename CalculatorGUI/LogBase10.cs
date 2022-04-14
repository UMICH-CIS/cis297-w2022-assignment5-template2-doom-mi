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
    /// This program implements Log Base 10 functions to a form
    /// </summary>
    /// <Student>Dominic Verardi</Student>
    /// <Class>CIS297</Class>
    /// <Semester>Winter 2022</Semester>
    /// 
    public partial class LogBase10 : Form
    {
        public LogBase10()
        {
            InitializeComponent();
        }

        //Click Solve on form to solve for Log Base 10 of a number
        private void solve_Click(object sender, EventArgs e)
        {
            double result = Math.Log10(Convert.ToDouble(logTextBox.Text));
            logDisplay.Text = string.Format("Log(" + logTextBox.Text + ") to the base 10 is " + result + ".");
        }

        //Clear the form
        private void reset_Click(object sender, EventArgs e)
        {
            logTextBox.Text = "";
            logDisplay.Text = "";
        }

        //Go back to Calculator GUI
        private void back_Click(object sender, EventArgs e)
        {
            CalculatorGUIForm calculatorGui = new CalculatorGUIForm();
            Hide();
            calculatorGui.ShowDialog();
            Close();
        }
    }
}
