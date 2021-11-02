using Crayon;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using ReallyBasicExampleProtector.Core.Helpers;
using System;
using System.IO;
using System.Linq;

namespace ReallyBasicExampleProtector.Core.Protections
{
    public static class Calli
    {
		public static int callToCalli = 0;
        private static MemberRef member;

        public static void Execute(ModuleDef mod)
        {
			//Prolly broken not sure
			MethodDef cctor = mod.GlobalType.FindOrCreateStaticConstructor();
			try
			{
				foreach (var type in mod.GetTypes().Where(x => x.HasMethods))
				{
					foreach (var method in type.Methods.Where(x => x.HasBody && x.Body.HasInstructions && !x.IsConstructor && !x.DeclaringType.IsGlobalModuleType && !x.IsStaticConstructor && !x.FullName.Contains("My.") && !x.FullName.Contains(".My") && !x.FullName.Contains(".My") && !x.FullName.Contains(".ctor")))
					{
						int i = 0;
						foreach (Instruction instr in method.Body.Instructions)
						{
							i++;
							bool flag;
							if (instr.OpCode == OpCodes.Call || instr.OpCode == OpCodes.Callvirt)
							{
								object operand = instr.Operand;
								member = (operand as MemberRef);
								flag = (member != null);
							}
							else
							{
								flag = false;
								if (flag)
								{
									if (!member.HasThis || !member.ResolveMethodDef().ParamDefs.Any((ParamDef x) => x.IsOut) || !member.ResolveMethodDef().IsVirtual || !member.ResolveMethodDef().ReturnType.FullName.ToLower().Contains("bool"))
									{
										if (new FileInfo(mod.Location).Length > 1000000L)
										{
											instr.OpCode = OpCodes.Ldftn;
											instr.Operand = member;
											method.Body.Instructions.Insert(instr.GetParameterIndex(), Instruction.Create(OpCodes.Calli, member.MethodSig));
											callToCalli++;
										}
										else
										{
											FieldDef field = new FieldDefUser(RenamerHelper.RandomString(Others.rdm.Next(10, 20)), new FieldSig(mod.CorLibTypes.Object), FieldAttributes.FamANDAssem | FieldAttributes.Family | FieldAttributes.Static);
											method.DeclaringType.Fields.Add(field);
											cctor.Body.Instructions.Insert(0, Instruction.Create(OpCodes.Stsfld, field));
											//cctor.Body.Instructions.Insert(cctor.Body.Instructions.Count-1, Instruction.Create(OpCodes.Stsfld, field));
											cctor.Body.Instructions.Insert(0, Instruction.Create(OpCodes.Ldftn, member));
											//cctor.Body.Instructions.Insert(cctor.Body.Instructions.Count-2, Instruction.Create(OpCodes.Ldftn, member));
											instr.OpCode = OpCodes.Ldsfld;
											instr.Operand = field;
											method.Body.Instructions.Insert(i++, Instruction.Create(OpCodes.Calli, member.MethodSig));
											callToCalli++;
										}
									}
								}
							}
						}
						
					}
				}
				Logger.Info(String.Format("[?] Call to Calli {0}", Output.Green(callToCalli.ToString())));
				callToCalli = 0;
			}
			catch (Exception ex)
			{
				Logger.Info(String.Format("[?] Call to Calli {0} | Program can crash !!", Output.Green(callToCalli.ToString())));
				callToCalli = 0;
				/*Console.WriteLine(ex);
				Console.ReadLine();*/
			}
		}
	}
}
