using System;
using System.Reflection;
using System.Windows.Forms;

namespace ReallyBasicExampleProtector
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static ReallyBasicExampleProtector ReallyBasicExampleProtector = new ReallyBasicExampleProtector();
        [STAThread]
        static void Main()
        {
            NativeStuff.ShowWindow(NativeStuff.consoleHandle, 0);
            Application.EnableVisualStyles();
            Application.Run(ReallyBasicExampleProtector);
        }
    }
}
