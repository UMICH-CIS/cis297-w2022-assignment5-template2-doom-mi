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
    public partial class NumberToPower : Form
    {
        public NumberToPower()
        {
            InitializeComponent();
        }

        private void solve_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(specNumberTextBox.Text);
            double power = Convert.ToDouble(powerTextBox.Text);
            double result = Math.Pow(number, power);
            resultDisplay.Text = string.Format(number + " to the power " + power + " is " + result + ".");
        }

        private void reset_Click(object sender, EventArgs e)
        {
            resultDisplay.Text = "";
            specNumberTextBox.Text = "";
            powerTextBox.Text = "";
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
