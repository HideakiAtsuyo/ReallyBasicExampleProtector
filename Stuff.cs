using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ReallyBasicExampleProtector
{
    public static class Stuff
    {
        private static string[] allowed = { ".exe", ".dll" };
        public static string fileType = string.Empty;
        public static bool verifyIfAllowed(string x)
        {
            if (!allowed.Any(s => x.EndsWith(s)))
            {
                MessageBox.Show(String.Format("Only \"{0}\" are allowed", string.Join(", ", allowed).Replace(".", string.Empty)));
                return false;
            }
            fileType = Path.GetExtension(x);
            return true;
        }
        public static bool verifyIfExist(string x)
        {
            if (!File.Exists(x))
            {   
                MessageBox.Show(String.Format("The file \"{0}\" doesn't exist", getFileName(x)));
                return false;
            }
            return true;
        }
        public static string getFileName(string x)
        {
            string[] fileSplit = x.Split('\\');
            return fileSplit[fileSplit.Length - 1].ToString();
        }
    }
}
