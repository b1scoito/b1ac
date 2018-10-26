using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace b1ac
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainform());
        }
    }
}
