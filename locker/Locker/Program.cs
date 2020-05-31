using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Locker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!Directory.Exists(appData+"/.locker"))
            {
                Directory.CreateDirectory(appData+"/.locker");//check into directory security later
                Application.Run(new Setup());
            }
            else
            {
                Application.Run(new Welcome());
            }
            
        }
    }
}
