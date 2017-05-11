using PLMED.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLMED
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

            try
            {
                string text = System.IO.File.ReadAllText("connection.txt");
                Utility.CUSTOM_STRING = text;
            } catch
            {

            }
            Application.Run(new LoginForm());
        }
    }
}
