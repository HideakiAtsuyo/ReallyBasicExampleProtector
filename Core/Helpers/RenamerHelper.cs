using dnlib.DotNet;
using System;
using System.Linq;
using System.Text;

namespace ReallyBasicExampleProtector.Core.Helpers
{
    public static class RenamerHelper
    {
        public static string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789&~#'{([-|`_^@)]=}+$£¤%*,?;.:/!§<>";
        public static string b64Renamer(string str) => Convert.ToBase64String(Encoding.UTF8.GetBytes(str));
        public static string RandomString(int length) => new string (Enumerable.Repeat(chars, length).Select(s => s[Others.rdm.Next(s.Length)]).ToArray());
        public static string weirdRenamer(MDToken mdToken, string name)
        {
            int notBreak = Others.rdm.Next(1, 999999);
            if (Settings.b64Names)
                return b64Renamer(String.Format("-_-{0}<([ᅠ{1}|{2}|{3}ᅠ])>{4}-_-", mdToken, notBreak, name, notBreak, mdToken));
            else
                return String.Format("-_-{0}<([ᅠ{1}|{2}|{3}ᅠ])>{4}-_-", mdToken, notBreak, name, notBreak, mdToken);
        }
    }
}
