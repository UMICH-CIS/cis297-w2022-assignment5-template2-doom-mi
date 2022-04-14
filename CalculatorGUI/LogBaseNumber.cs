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
    /// This program implements Log Base to Any Number functions to a form
    /// </summary>
    /// <Student>Dominic Verardi</Student>
    /// <Class>CIS297</Class>
    /// <Semester>Winter 2022</Semester>
    /// 

    public partial class LogBaseNumber : Form
    {
        public LogBaseNumber()
        {
            InitializeComponent();
        }

        //Click Solve on form to solve for Log Base to Any Number of any number
        private void solve_Click(object sender, EventArgs e)
        {
            resultDisplay.Text = string.Format("Log(" + logTextBox.Text + ") to the base " + baseTextBox.Text + " is " + Math.Log(Convert.ToDouble(logTextBox.Text), Convert.ToDouble(baseTextBox.Text)) + ".");
        }

        //Clear the form
        private void reset_Click(object sender, EventArgs e)
        {
            logTextBox.Text = "";
            baseTextBox.Text = "";
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
