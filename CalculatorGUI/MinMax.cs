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
    public partial class MinMax : Form
    {
        public MinMax()
        {
            InitializeComponent();
        }

        private void solve_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(maximumTextBox.Text);
            int secondNumber = Convert.ToInt32(minimumTextBox.Text);
            int min = Math.Min(firstNumber, secondNumber);
            int max = Math.Max(firstNumber, secondNumber);
            resultDisplay.Text = string.Format("Minimum of " + firstNumber + " and " + secondNumber + " is " + min + ". Maximum of " + firstNumber + " and " + secondNumber + " is " + max + ".");
        }

        private void reset_Click(object sender, EventArgs e)
        {
            resultDisplay.Text = "";
            minimumTextBox.Text = "";
            maximumTextBox.Text = "";
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
