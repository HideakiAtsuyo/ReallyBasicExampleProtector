using System;
using System.Text;

namespace ReallyBasicExampleProtector
{
    class Settings
    {
        public static string MBHATitle = "github.com/HideakiAtsuyo", whatAbadKindOfWatermark = Convert.ToBase64String(Encoding.UTF8.GetBytes(MBHATitle));

        /* ObfSettings */
        public static bool randomRenaming = false, b64Names = false;
    }
}
