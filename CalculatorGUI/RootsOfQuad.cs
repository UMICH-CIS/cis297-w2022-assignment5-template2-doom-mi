using ConsoleQuadraticEquation;
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
    /// This program implements solving finding the roots of the quadratic equation functions to a form
    /// </summary>
    /// <Student>Dominic Verardi</Student>
    /// <Class>CIS297</Class>
    /// <Semester>Winter 2022</Semester>
    /// 
    public partial class RootsOfQuad : Form
    {
        public RootsOfQuad()
        {
            InitializeComponent();
        }

        //Click the solve button to find the roots of the quadratic equation
        private void solve_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(coefficient1TextBox.Text);
            int b = Convert.ToInt32(coefficient2TextBox.Text);
            int c = Convert.ToInt32(constantTextBox.Text);
            QuadraticEquation2 quadraticEquation = new QuadraticEquation2(a, b, c);
            resultDisplay.Text = quadraticEquation.DisplaySolution();
        }

        //Clear the form
        private void reset_Click(object sender, EventArgs e)
        {
            resultDisplay.Text = "";
            coefficient1TextBox.Text = "";
            coefficient2TextBox.Text = "";
            constantTextBox.Text = "";
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
