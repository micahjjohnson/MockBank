using System;
using System.Windows.Forms;

namespace Banking
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

            MasterBank master = new MasterBank();
            MasterForm masterForm = new MasterForm(master);

            Application.Run(masterForm.getMainForm());
        }
    }
}
