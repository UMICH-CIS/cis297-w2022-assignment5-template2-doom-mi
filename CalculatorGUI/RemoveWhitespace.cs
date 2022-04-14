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
    /// This program implements removing the whitespace of a string to a form
    /// </summary>
    /// <Student>Dominic Verardi</Student>
    /// <Class>CIS297</Class>
    /// <Semester>Winter 2022</Semester>
    /// 
    public partial class RemoveWhitespace : Form
    {
        public RemoveWhitespace()
        {
            InitializeComponent();
        }

        //Click the remove button to remove the whitespace of a string
        private void button1_Click(object sender, EventArgs e)
        {
            modifiedString.Text = yourTextBox.Text.Replace(" ", "");
        }

        //Clear the form
        private void button2_Click(object sender, EventArgs e)
        {
            modifiedString.Text = "";
            yourTextBox.Text = "";
        }

        //Go back to Calculator GUI
        private void button3_Click(object sender, EventArgs e)
        {
            CalculatorGUIForm calculatorGUI = new CalculatorGUIForm();
            Hide();
            calculatorGUI.ShowDialog();
            Close();
        }
    }
}
