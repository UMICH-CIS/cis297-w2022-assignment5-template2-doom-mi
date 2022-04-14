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
    /// This program implements some arithmetic functions as a calculator
    /// </summary>
    /// <Student>Dominic Verardi</Student>
    /// <Class>CIS297</Class>
    /// <Semester>Winter 2022</Semester>
    /// 

    // Displays the calculator form and buttons
    public partial class CalculatorGUIForm : Form
   {
      public CalculatorGUIForm()
      {
         InitializeComponent();
      }

        //Takes you to Remove Whitespace Form
        private void RemoveWhitespace_Click(object sender, EventArgs e)
        {
            RemoveWhitespace removeWhitespace = new RemoveWhitespace();
            Hide();
            removeWhitespace.ShowDialog();
            Close();
        }

        //Takes you to Reverse String Form
        private void ReverseString_Click(object sender, EventArgs e)
        {
            ReverseString reverseString = new ReverseString();
            Hide();
            reverseString.ShowDialog();
            Close();
        }

        //Takes you to Quotient and Remainder Form
        private void QuotientAndRemainder_Click(object sender, EventArgs e)
        {
            QuotientRemainder quotientAndRemainder = new QuotientRemainder();
            Hide();
            quotientAndRemainder.ShowDialog();
            Close();
        }

        //Takes you to Log Base 10 Form
        private void LogBase10_Click(object sender, EventArgs e)
        {
            LogBase10 logBase10 = new LogBase10();
            Hide();
            logBase10.ShowDialog();
            Close();
        }

        //Takes you to Log Base to Any Number Form
        private void LogBaseToNumber_Click(object sender, EventArgs e)
        {
            LogBaseNumber logBaseNumber = new LogBaseNumber();
            Hide();
            logBaseNumber.ShowDialog();
            Close();
        }

        //Takes you to Minimum and Maximum Form
        private void MinimumAndMaximum_Click(object sender, EventArgs e)
        {
            MinMax minMax = new MinMax();
            Hide();
            minMax.ShowDialog();
            Close();
        }

        //Takes you to Number to Any Power Form
        private void NumberToPower_Click(object sender, EventArgs e)
        {
            NumberToPower numberToPower = new NumberToPower();
            Hide();
            numberToPower.ShowDialog();
            Close();
        }

        //Takes you to Roots of Quadratic Form
        private void RootsOfQuadratic_Click(object sender, EventArgs e)
        {
            RootsOfQuad rootsOfQuad = new RootsOfQuad();
            Hide();
            rootsOfQuad.ShowDialog();
            Close();
        }

        //Takes you to Square Root Form
        private void SquareRoot_Click(object sender, EventArgs e)
        {
            SquareRoot squareRoot = new SquareRoot();
            Hide();
            squareRoot.ShowDialog();
            Close();
        }
    }
}

/**************************************************************************
 * (C) Copyright 1992-2017 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/