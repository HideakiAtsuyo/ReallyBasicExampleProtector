using Crayon;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using ReallyBasicExampleProtector.Core.Helpers;
using System;

namespace ReallyBasicExampleProtector.Core.Protections
{
    public static class ProxyINT
    {
        private static int proxiedIntNumber = 0;
        public static void Execute(ModuleDef mod)
        {
            try
            {
                foreach (var type in mod.GetTypes())
                {
                    if (type.IsGlobalModuleType || type.Name.Contains("AssemblyLoader") || type.Name == "<Module>") continue;
                    foreach (var method in type.Methods)
                    {
                        if (!method.HasBody) continue;
                        var instr = method.Body.Instructions;
                        for (var i = 0; i < instr.Count; i++)
                        {
                            if (method.Body.Instructions[i].IsLdcI4())
                            {
                                var meth1 = new MethodDefUser(RenamerHelper.RandomString(Others.rdm.Next(10, 20)), MethodSig.CreateStatic(mod.CorLibTypes.Int32), MethodImplAttributes.IL | MethodImplAttributes.Managed, MethodAttributes.Public | MethodAttributes.Static | MethodAttributes.HideBySig | MethodAttributes.ReuseSlot);
                                mod.GlobalType.Methods.Add(meth1);
                                meth1.Body = new CilBody();
                                meth1.Body.Variables.Add(new Local(mod.CorLibTypes.Int32));
                                meth1.Body.Instructions.Add(Instruction.Create(OpCodes.Ldc_I4, instr[i].GetLdcI4Value()));
                                meth1.Body.Instructions.Add(Instruction.Create(OpCodes.Ret));
                                meth1.Body.SimplifyBranches();
                                meth1.Body.OptimizeBranches();
                                instr[i].OpCode = OpCodes.Call;
                                instr[i].Operand = meth1;
                                proxiedIntNumber++;
                            }
                            else if (method.Body.Instructions[i].OpCode == OpCodes.Ldc_R4)
                            {
                                var meth1 = new MethodDefUser(RenamerHelper.RandomString(Others.rdm.Next(10, 20)), MethodSig.CreateStatic(mod.CorLibTypes.Double), MethodImplAttributes.IL | MethodImplAttributes.Managed, MethodAttributes.Public | MethodAttributes.Static | MethodAttributes.HideBySig | MethodAttributes.ReuseSlot);
                                mod.GlobalType.Methods.Add(meth1);
                                meth1.Body = new CilBody();
                                meth1.Body.Variables.Add(new Local(mod.CorLibTypes.Double));
                                meth1.Body.Instructions.Add(Instruction.Create(OpCodes.Ldc_R4, (float)method.Body.Instructions[i].Operand));
                                meth1.Body.Instructions.Add(Instruction.Create(OpCodes.Ret));
                                meth1.Body.SimplifyBranches();
                                meth1.Body.OptimizeBranches();
                                instr[i].OpCode = OpCodes.Call;
                                instr[i].Operand = meth1;
                                proxiedIntNumber++;
                            }
                        }
                    }
                }
                Logger.Info(String.Format("[MindLated] Proxied {0} int.", Output.Green(proxiedIntNumber.ToString())));
                proxiedIntNumber = 0;
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
        }
    }
}
