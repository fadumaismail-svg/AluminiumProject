using System;
using System.Windows.Forms;

namespace AluminiumProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Starting the application by running Form1
            Application.Run(new Form1());
        }
    }
}