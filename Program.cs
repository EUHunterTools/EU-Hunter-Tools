using System;
using System.Windows.Forms;
using WpfApp1;
using ExcelWork;
using System.IO;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {

            Application.EnableVisualStyles();
           // Application.Run((Form)new LicenceForm());
           Application.Run((Form)new FormMain());


        }
    }
}
