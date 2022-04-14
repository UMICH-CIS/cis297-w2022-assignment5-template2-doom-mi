using System;
using System.Collections.Generic;
using System.Linq;
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

    static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault( false );
         Application.Run( new CalculatorGUIForm() );
      }
   }
}
