using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace b1ac
{
    internal static class Program
    {
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        [STAThread]
        private static void Main()
        {
            File.Move(AppDomain.CurrentDomain.FriendlyName, RandomString(5) + ".exe");
            Thread.Sleep(500);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainform());
        }
        private static Random random = new Random();
    }
}
