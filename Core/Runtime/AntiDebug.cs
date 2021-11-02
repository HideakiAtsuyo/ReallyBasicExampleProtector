using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace ReallyBasicExampleProtector.Core.Runtime
{
    public static class AntiDebug
    {
        [DllImport("ntdll.dll", CharSet = CharSet.Auto, EntryPoint = "NtQueryInformationProcess")]
        private static extern int NtQueryInformationProcess(IntPtr hello, int world, int[] vive, int ntdll, ref int oof);
        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true, EntryPoint = "CheckRemoteDebuggerPresent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, [MarshalAs(UnmanagedType.Bool)] ref bool isDebuggerPresent);

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true, EntryPoint = "IsDebuggerPresent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool IsDebuggerPresent();

        public static void AntiDebugLmao()
        {
            var array = new int[6];
            var num = 0;
            var intPtr = Process.GetCurrentProcess().Handle;
            bool idp = false;
            string[] lmao = { "Y", "2", "9", "t", "c", "G", "x", "1", "c", "1", "9", "w", "c", "m", "9", "m", "Y", "X", "B", "p", "X", "3", "B", "y", "b", "2", "Z", "p", "b", "G", "V", "y", "Y", "2", "9", "t", "c", "G", "F", "0", "a", "W", "J", "p", "b", "G", "l", "0", "e", "X", "N","l","d","H","R","p","b","m","c","=" };

            CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref idp);

            if (Debugger.IsLogging() || Debugger.IsAttached || IsDebuggerPresent() || Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String(string.Join("", lmao)))) != null || string.Compare(Environment.GetEnvironmentVariable("COR_ENABLE_PROFILING"), "1", StringComparison.Ordinal) == 0 || Environment.OSVersion.Platform != PlatformID.Win32NT || NtQueryInformationProcess(intPtr, 31, array, 4, ref num) == 0 && array[0] != 1 || NtQueryInformationProcess(intPtr, 30, array, 4, ref num) == 0 && array[0] != 0 || NtQueryInformationProcess(intPtr, 0, array, 24, ref num) != 0 || idp)
                Environment.Exit(0);
            //With one of the protections(idk if i removed it) the program "detect a debugger" if i'm correct
        }
    }
}
