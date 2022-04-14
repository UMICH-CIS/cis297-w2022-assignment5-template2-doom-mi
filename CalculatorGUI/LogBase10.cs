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
    public partial class LogBase10 : Form
    {
        public LogBase10()
        {
            InitializeComponent();
        }

        private void solve_Click(object sender, EventArgs e)
        {
            double result = Math.Log10(Convert.ToDouble(logTextBox.Text));
            logDisplay.Text = string.Format("Log(" + logTextBox.Text + ") to the base 10 is " + result + ".");
        }

        private void reset_Click(object sender, EventArgs e)
        {
            logTextBox.Text = "";
            logDisplay.Text = "";
        }

        private void back_Click(object sender, EventArgs e)
        {
            CalculatorGUIForm calculatorGui = new CalculatorGUIForm();
            Hide();
            calculatorGui.ShowDialog();
            Close();
        }
    }
}
