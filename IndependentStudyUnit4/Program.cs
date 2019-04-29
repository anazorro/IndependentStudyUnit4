using System;
using System.Windows.Forms;

namespace IndependentStudyUnit4
{
    static class Program
    {
        /// <summary>
        /// Author: 21903356
        /// 
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EntryForm());
        }
    }
}
