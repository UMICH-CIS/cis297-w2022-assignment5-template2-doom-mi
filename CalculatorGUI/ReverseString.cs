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
    public partial class ReverseString : Form
    {
        public ReverseString()
        {
            InitializeComponent();
        }

        private void reverse_Click(object sender, EventArgs e)
        {
            char[] arrayReversed = yourString.Text.ToCharArray();
            Array.Reverse(arrayReversed);
            modifiedString.Text = new string (arrayReversed);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            yourString.Text = "";
            modifiedString.Text = "";
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
