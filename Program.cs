using System;
using System.Windows.Forms;

namespace _4_Column_Shopping_List
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Modern WinForms startup pattern for high-DPI awareness on .NET Core / .NET 5+
            try
            {
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
            }
            catch
            {
                // SetHighDpiMode may not be available on older runtimes; ignore if unavailable
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
