using dnlib.DotNet;
using System;

namespace ReallyBasicExampleProtector.Core.Protections
{
    public static class Example
    {
        public static void Execute(ModuleDef mod)
        {
            try
            {
                //Usage of mod (Module in the Program class)
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
