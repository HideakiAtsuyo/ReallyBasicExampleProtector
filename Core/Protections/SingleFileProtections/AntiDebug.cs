using Crayon;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using ReallyBasicExampleProtector.Core.Helpers;
using System;
using System.Linq;

namespace ReallyBasicExampleProtector.Core.Protections
{
    public static class AntiDebug
    {
        public static void Execute(ModuleDef mod)
        {
            try
            {
                var typeModule = ModuleDefMD.Load(typeof(AntiDebug).Module);
                var cctor = mod.GlobalType.FindOrCreateStaticConstructor();
                var members = InjectHelper.Inject(typeModule.ResolveTypeDef(MDToken.ToRID(typeof(Runtime.AntiDebug).MetadataToken)), mod.GlobalType, mod);
                var AntiDebug = (MethodDef)members.Single(method => method.Name == "AntiDebugLmao");
                cctor.Body.Instructions.Insert(0, Instruction.Create(OpCodes.Call, AntiDebug));
                foreach (IDnlibDef member in members)
                    member.Name = "SGlkZVRoaXNGdW5ueUFEZQ";
                Logger.Info(String.Format("Injected {0} !", Output.Green("Anti-Debug")));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
        }
    }
}
