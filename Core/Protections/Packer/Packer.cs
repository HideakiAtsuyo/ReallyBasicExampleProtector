using Crayon;
using dnlib.DotNet;
using dnlib.DotNet.Writer;
using ReallyBasicExampleProtector.Core.Helpers;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace ReallyBasicExampleProtector.Core.Protections
{
    public static class Packer
    {
        public static void Execute(ModuleDef mod)
        {
            //Not Sure To Include One In The Example

            Logger.Info(String.Format("{0} with success !", Output.Green("Packed")));
        }
    }
}
