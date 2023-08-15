using AppCloud_TSMIT.Controller;
using System;
using System.Windows.Forms;

namespace AppCloud_TSMIT
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_MenuLogin());
        }
    }
}
