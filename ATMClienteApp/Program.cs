using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMClienteApp
{
    static class Program
    {
        // Name: Dangelo Trindade Santana | dangelosantana@hotmail.com
        // Professor: Lounis Zaidi | lounis.zaidi@collegecdi.ca
        // Subject: Project Integration Level-1 PP1E
        // Date: JAN-2017
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }
    }
}
