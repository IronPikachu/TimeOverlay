using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Overlay
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Form1 first = new Form1();
            
            //var th = new Thread(() => Application.Run(first));

            //th.Start();
            Application.Run(new Form2());
            //th.Join();
        }
    }
}
