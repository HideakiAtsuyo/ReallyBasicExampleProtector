using Crayon;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using ReallyBasicExampleProtector.Core.Helpers;
using System;
using System.Linq;

namespace ReallyBasicExampleProtector.Core.Protections
{
    public static class AntiDump
    {
        public static void Execute(ModuleDef mod)
        {
            try
            {
                var typeModule = ModuleDefMD.Load(typeof(AntiDump).Module);
                var cctor = mod.GlobalType.FindOrCreateStaticConstructor();
                var members = InjectHelper.Inject(typeModule.ResolveTypeDef(MDToken.ToRID(typeof(Runtime.AntiDump).MetadataToken)), mod.GlobalType, mod);
                var init = (MethodDef)members.Single(method => method.Name == "AntiDumpLmao");
                cctor.Body.Instructions.Insert(0, Instruction.Create(OpCodes.Call, init));
                foreach (IDnlibDef member in members)
                    member.Name = "SGlkZVRoaXNGdW5ueUFEdQ";
                Logger.Info(String.Format("[ConfuserEx] Injected {0} !", Output.Green("Anti-Dump")));
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
        }
    }
}
