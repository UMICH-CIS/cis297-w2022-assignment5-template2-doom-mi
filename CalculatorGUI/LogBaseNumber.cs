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
    public partial class LogBaseNumber : Form
    {
        public LogBaseNumber()
        {
            InitializeComponent();
        }

        private void solve_Click(object sender, EventArgs e)
        {
            resultDisplay.Text = string.Format("Log(" + logTextBox.Text + ") to the base " + baseTextBox.Text + " is " + Math.Log(Convert.ToDouble(logTextBox.Text), Convert.ToDouble(baseTextBox.Text)) + ".");
        }

        private void reset_Click(object sender, EventArgs e)
        {
            logTextBox.Text = "";
            baseTextBox.Text = "";
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
