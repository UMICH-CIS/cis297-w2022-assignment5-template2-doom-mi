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
   public partial class CalculatorGUIForm : Form
   {
      public CalculatorGUIForm()
      {
         InitializeComponent();
      }

        private void RemoveWhitespace_Click(object sender, EventArgs e)
        {
            RemoveWhitespace removeWhitespace = new RemoveWhitespace();
            Hide();
            removeWhitespace.ShowDialog();
            Close();
        }

        private void ReverseString_Click(object sender, EventArgs e)
        {
            ReverseString reverseString = new ReverseString();
            Hide();
            reverseString.ShowDialog();
            Close();
        }

        private void QuotientAndRemainder_Click(object sender, EventArgs e)
        {
            QuotientRemainder quotientAndRemainder = new QuotientRemainder();
            Hide();
            quotientAndRemainder.ShowDialog();
            Close();
        }

        private void LogBase10_Click(object sender, EventArgs e)
        {
            LogBase10 logBase10 = new LogBase10();
            Hide();
            logBase10.ShowDialog();
            Close();
        }

        private void LogBaseToNumber_Click(object sender, EventArgs e)
        {
            LogBaseNumber logBaseNumber = new LogBaseNumber();
            Hide();
            logBaseNumber.ShowDialog();
            Close();
        }

        private void MinimumAndMaximum_Click(object sender, EventArgs e)
        {
            MinMax minMax = new MinMax();
            Hide();
            minMax.ShowDialog();
            Close();
        }

        private void NumberToPower_Click(object sender, EventArgs e)
        {
            NumberToPower numberToPower = new NumberToPower();
            Hide();
            numberToPower.ShowDialog();
            Close();
        }

        private void RootsOfQuadratic_Click(object sender, EventArgs e)
        {
            RootsOfQuad rootsOfQuad = new RootsOfQuad();
            Hide();
            rootsOfQuad.ShowDialog();
            Close();
        }

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