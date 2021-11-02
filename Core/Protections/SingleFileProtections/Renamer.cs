using Crayon;
using dnlib.DotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReallyBasicExampleProtector.Core.Protections
{
    public static class Renamer
    {
        public static void Execute(ModuleDef mod)
        {
            string oofed = "Hideaki     Was     Here     ;)";
            mod.Name = oofed;
            mod.Assembly.Name = oofed;
            if (!Settings.randomRenaming)
            {
                string name = "/*ᅠHWᅠ*/";
                int notBreak = Helpers.Others.rdm.Next(1, 999999), notBreak2 = Helpers.Others.rdm.Next(1, 999999);
                if (Settings.b64Names)
                    name = Helpers.RenamerHelper.b64Renamer(String.Format("-_-{0}<([ᅠ{1}|{2}|{3}ᅠ])>{4}-_-", notBreak2, notBreak, name, notBreak, notBreak2));
                else
                    name = String.Format("-_-{0}<([ᅠ{1}|{2}|{3}ᅠ])>{4}-_-", notBreak2, notBreak, name, notBreak, notBreak2);

                foreach (TypeDef type in mod.Types.Where(x => !x.IsGlobalModuleType && !x.IsSpecialName && !x.IsRuntimeSpecialName))
                {
                    //type.Namespace = "-";
                    type.Namespace = string.Empty;
                    //type.Name = name; //Not A Good Idea Oof

                    foreach (MethodDef method in type.Methods)
                    {
                        method.Name = Helpers.RenamerHelper.weirdRenamer(method.MDToken, name);
                    }

                    foreach (PropertyDef property in type.Properties)
                    {
                        property.Name = Helpers.RenamerHelper.weirdRenamer(property.MDToken, name);
                    }

                    foreach (FieldDef field in type.Fields)
                    {
                        field.Name = Helpers.RenamerHelper.weirdRenamer(field.MDToken, name);
                    }

                    foreach (EventDef thisEvent in type.Events)
                    {
                        thisEvent.Name = Helpers.RenamerHelper.weirdRenamer(thisEvent.MDToken, name);
                    }

                    foreach (var x in mod.Types.Where(x => x.IsGlobalModuleType))
                    {
                        x.Name = oofed.Replace("     ", "ᅠ");//Shht who said that you need a simple thing ?
                    }
                }
            } else if(Settings.randomRenaming)
            {
                string name = "/*ᅠHWᅠ*/";
                int notBreak = Helpers.Others.rdm.Next(1, 999999), notBreak2 = Helpers.Others.rdm.Next(1, 999999);
                if (Settings.b64Names)
                    name = Helpers.RenamerHelper.b64Renamer(String.Format("-_-{0}<([ᅠ{1}|{2}|{3}ᅠ])>{4}-_-", notBreak2, notBreak, name, notBreak, notBreak2));
                else
                    name = String.Format("-_-{0}<([ᅠ{1}|{2}|{3}ᅠ])>{4}-_-", notBreak2, notBreak, name, notBreak, notBreak2);

                mod.EntryPoint.Name = "/*ᅠEntryPointLmaoᅠ*/";
                mod.EntryPoint.DeclaringType.Name = "/*ᅠMainᅠClassᅠ*/";
                foreach (TypeDef type in mod.Types.Where(x => !x.IsGlobalModuleType && !x.IsSpecialName && !x.IsRuntimeSpecialName))
                {
                    //type.Namespace = "-";
                    type.Namespace = string.Empty;
                    //type.Name = name; //Not A Good Idea Oof

                    foreach (MethodDef method in type.Methods)
                    {
                        method.Name = Helpers.RenamerHelper.RandomString(Helpers.Others.rdm.Next(10, 20));
                    }

                    foreach (PropertyDef property in type.Properties)
                    {
                        property.Name = Helpers.RenamerHelper.RandomString(Helpers.Others.rdm.Next(10, 20));
                    }

                    foreach (FieldDef field in type.Fields)
                    {
                        field.Name = Helpers.RenamerHelper.RandomString(Helpers.Others.rdm.Next(10, 20));
                    }

                    foreach (EventDef thisEvent in type.Events)
                    {
                        thisEvent.Name = Helpers.RenamerHelper.RandomString(Helpers.Others.rdm.Next(10, 20));
                    }

                    foreach (var x in mod.Types.Where(x => x.IsGlobalModuleType))
                    {
                        x.Name = oofed.Replace("     ", "ᅠ");//Shht who said that you need a simple thing ?
                    }
                }

            }
            mod.EntryPoint.Name = "/*ᅠEntryPointLmaoᅠ*/";
            mod.EntryPoint.DeclaringType.Name = "/*ᅠMainᅠClassᅠ*/";
            Logger.Info(String.Format("Renaming finished on type {0}.", Output.Green(mod.Types.Where(x => !x.IsGlobalModuleType && !x.IsSpecialName && !x.IsRuntimeSpecialName).Count().ToString())));

        }
    }
}
