using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace salesperson_menu
{
    internal static class Program
    {
        public static readonly List<Salesperson> Salespersons = new List<Salesperson>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
