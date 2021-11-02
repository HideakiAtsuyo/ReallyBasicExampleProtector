using System;
using System.Runtime.InteropServices;

namespace ReallyBasicExampleProtector
{
    public static class NativeStuff
    {
        public static IntPtr consoleHandle = NativeStuff.GetConsoleWindow();
        /*==========Move Form==========*/
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        /*==========Move Form==========*/
        /*==========Show/Hide Console==========*/
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        /*==========Show/Hide Console==========*/
        /*==========FromAlwaysOnTop==========*/
        [DllImport("USER32.DLL")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        /*==========FromAlwaysOnTop==========*/
    }
}
