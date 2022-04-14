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
    /// This program implements reversing a string functions to a form
    /// </summary>
    /// <Student>Dominic Verardi</Student>
    /// <Class>CIS297</Class>
    /// <Semester>Winter 2022</Semester>
    /// 
    public partial class ReverseString : Form
    {
        public ReverseString()
        {
            InitializeComponent();
        }

        //Click the reverse button to reverse a string
        private void reverse_Click(object sender, EventArgs e)
        {
            char[] arrayReversed = yourString.Text.ToCharArray();
            Array.Reverse(arrayReversed);
            modifiedString.Text = new string (arrayReversed);
        }

        //Clear the form
        private void reset_Click(object sender, EventArgs e)
        {
            yourString.Text = "";
            modifiedString.Text = "";
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
