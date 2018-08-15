/**
 * 
 * File: Program.cs
 * Developer: James Grau
 * Student Number: 991443203
 * Date: August 14, 2018
 * 
 **/

// Include needed packages
using System;
using System.Windows.Forms;

// Is the name space that this class resides in
namespace Csharp_Group_Assignment {
    // Class that runs the actual application
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // Enable visual and rendering options before calling the global home form to open
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(true);
            FormsGlobal.frmHome = new frmHome();
            Application.Run(FormsGlobal.frmHome);
        }
    }
}
