using Crayon;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;
using System.Linq;

namespace ReallyBasicExampleProtector.Core.Protections
{
    public static class HideMethods
    {
        public static void Execute(ModuleDef mod)
        {
            int methodHidden = 0;
            foreach (TypeDef type in mod.Types.Where(x => x.HasMethods))
            {
                foreach (MethodDef method in type.Methods.Where(x => x.HasBody))
                {
                    method.Body.Instructions.Insert(0, new Instruction(OpCodes.Nop));//Useless here fr but why not ?
                    method.Body.Instructions.Insert(1, new Instruction(OpCodes.Br_S, method.Body.Instructions[1]));
                    method.Body.Instructions.Insert(2, new Instruction(OpCodes.Unaligned, (byte)0));
                    methodHidden++;
                    /* Lol so little and easy to remove :( */
                }
            }
            Logger.Info(String.Format("{0} Methods Hidden.", Output.Green(methodHidden.ToString())));
            methodHidden = 0;
        }
    }
}
