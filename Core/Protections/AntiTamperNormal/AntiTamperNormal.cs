using Crayon;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using dnlib.DotNet.Writer;
using ReallyBasicExampleProtector.Core.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReallyBasicExampleProtector.Core.Protections
{
    public class AntiTamperNormal
    {
        public void Execute(ModuleDef mod, string protectedLocation)
        {
            try
            {
                //Not Sure To Include One In The Example

                Logger.Info(String.Format("Injected and applied {0} !", Output.Green("Anti-Tamper")));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
        }
    }
}