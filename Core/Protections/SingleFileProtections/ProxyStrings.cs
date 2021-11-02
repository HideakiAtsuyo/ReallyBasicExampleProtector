using Crayon;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using ReallyBasicExampleProtector.Core.Helpers;
using System;

namespace ReallyBasicExampleProtector.Core.Protections
{
    public static class ProxyStrings
    {
        private static int proxiedStringsNumber = 0;
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
                        foreach (var t in instr)
                        {
                            if (t.OpCode != OpCodes.Ldstr) continue;
                            var meth1 = new MethodDefUser(RenamerHelper.RandomString(Others.rdm.Next(10, 20)), MethodSig.CreateStatic(mod.CorLibTypes.String), MethodImplAttributes.IL | MethodImplAttributes.Managed, MethodAttributes.Public | MethodAttributes.Static | MethodAttributes.HideBySig | MethodAttributes.ReuseSlot);
                            mod.GlobalType.Methods.Add(meth1);
                            meth1.Body = new CilBody();
                            meth1.Body.Variables.Add(new Local(mod.CorLibTypes.String, "text"));
                            meth1.Body.Variables.Add(new Local(mod.CorLibTypes.String));

                            meth1.Body.Instructions.Insert(0, Instruction.Create(OpCodes.Nop));
                            meth1.Body.Instructions.Insert(1, Instruction.Create(OpCodes.Ldstr, t.Operand.ToString()));
                            meth1.Body.Instructions.Insert(2, Instruction.Create(OpCodes.Stloc_0));
                            meth1.Body.Instructions.Insert(3, Instruction.Create(OpCodes.Ldloc_0));
                            meth1.Body.Instructions.Insert(4, Instruction.Create(OpCodes.Dup));
                            //meth1.Body.Instructions.Insert(5, Instruction.Create(OpCodes.Brtrue_S, meth1.Body.Instructions[7]));
                            meth1.Body.Instructions.Insert(5, Instruction.Create(OpCodes.Nop)); //Replaced
                            meth1.Body.Instructions.Insert(6, Instruction.Create(OpCodes.Pop));
                            meth1.Body.Instructions.Insert(7, Instruction.Create(OpCodes.Ldstr, Settings.whatAbadKindOfWatermark));
                            meth1.Body.Instructions.Insert(8, Instruction.Create(OpCodes.Stloc_1));
                            //meth1.Body.Instructions.Insert(9, Instruction.Create(OpCodes.Br_S, meth1.Body.Instructions[10]));
                            meth1.Body.Instructions.Insert(9, Instruction.Create(OpCodes.Nop)); //Replaced
                            meth1.Body.Instructions.Insert(10, Instruction.Create(OpCodes.Ldloc_1));
                            meth1.Body.Instructions.Insert(11, Instruction.Create(OpCodes.Ret));

                            //meth1.Body.Instructions.RemoveAt(5);
                            if (meth1.Body.Instructions[5].OpCode == OpCodes.Nop)
                            {
                                meth1.Body.Instructions.RemoveAt(5);
                                meth1.Body.Instructions[5].OpCode = OpCodes.Brtrue_S;
                                meth1.Body.Instructions[5].Operand = meth1.Body.Instructions[7];
                            }
                            meth1.Body.Instructions.Insert(6, Instruction.Create(OpCodes.Pop));
                            meth1.Body.Instructions.Insert(10, Instruction.Create(OpCodes.Ldloc_1));
                            if (meth1.Body.Instructions[9].OpCode == OpCodes.Nop)
                            {
                                meth1.Body.Instructions.RemoveAt(9);
                                meth1.Body.Instructions[9].OpCode = OpCodes.Br_S;
                                meth1.Body.Instructions[9].Operand = meth1.Body.Instructions[10];
                            }
                            meth1.Body.SimplifyBranches();
                            meth1.Body.OptimizeBranches();
                            t.OpCode = OpCodes.Call;
                            t.Operand = meth1;
                            proxiedStringsNumber++;
                        }
                    }
                }
                Logger.Info(String.Format("Proxied {0} strings.", Output.Green(proxiedStringsNumber.ToString())));
                proxiedStringsNumber = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
        }
    }
}
