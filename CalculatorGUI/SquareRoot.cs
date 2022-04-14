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
    public partial class SquareRoot : Form
    {
        public SquareRoot()
        {
            InitializeComponent();
        }

        private void solve_Click(object sender, EventArgs e)
        {
            double number7 = double.Parse(numberTextBox.Text);
            numberDisplay.Text = string.Format("Square root of {0} is {1}.", number7, Math.Sqrt(number7));
        }

        private void reset_Click(object sender, EventArgs e)
        {
            numberDisplay.Text = "";
            numberTextBox.Text = "";
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
