using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MADITP2._0.UserInterface.SO.SOUploadResi;
using MADITP2._0.UserInterface.SO.SOMasterProduct;

namespace MADITP2._0
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
            Application.Run(new frmLogin());
           // Application.Run(new SOUploadResiUI());
            //Application.Run(new SOMasterProductUI());
        }
    }
}
