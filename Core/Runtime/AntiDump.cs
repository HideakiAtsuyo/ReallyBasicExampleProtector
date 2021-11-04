using System;
using System.Runtime.InteropServices;

namespace ReallyBasicExampleProtector.Core.Runtime
{
    public static class AntiDump
    {
        [DllImport("kernel32.dll", EntryPoint = "VirtualProtect")]
        private static extern unsafe bool VirtualProtect(IntPtr lpAddress, uint dwSize, uint flNewProtect, out uint lpflOldProtect); // :)
        [DllImport("kernel32.dll", EntryPoint = "ZeroMemory")]
        private static extern IntPtr ZeroMemory(IntPtr addr, IntPtr size);
        private static unsafe void AntiDumpLmao()
        {
            byte* ptr = (byte*)(void*)Marshal.GetHINSTANCE(typeof(AntiDump).Module);
            byte* ptr2 = ptr + 60;
            IntPtr ptrLmao = (IntPtr)((void*)((byte*)(ptr + (uint)(*(int*)(ptr + 60))) + 24));
            uint prot = 0;
            VirtualProtect(ptrLmao, 1, 64U, out prot);
            ptr2 = ptr + *(uint*)ptr2;
            ptr2 += 6;
            ZeroMemory(ptrLmao, (IntPtr)1);
            ushort num = *(ushort*)ptr2;
            ptr2 += 14;
            ushort num2 = *(ushort*)ptr2;
            ZeroMemory(ptrLmao, (IntPtr)2);
            ptr2 = ptr2 + 4 + num2;
            UIntPtr uintPtr = (UIntPtr)11;
            uint num3;
            VirtualProtect(ptrLmao, 1, prot, out prot);
            AntiDump.VirtualProtect((IntPtr)ptr2 - 16, 8, 64u, out num3);
            *(int*)(ptr2 - 12) = 0;
            byte* ptr3 = ptr + *(uint*)(ptr2 - 16);
            *(int*)(ptr2 - 16) = 0;
            AntiDump.VirtualProtect((IntPtr)ptr3, 72, 64u, out num3);
            byte* ptr4 = ptr + *(uint*)(ptr3 + 8);
            *(int*)ptr3 = 0;
            *(int*)(ptr3 + 4) = 0;
            *(int*)(ptr3 + 2 * 4) = 0;
            *(int*)(ptr3 + 3 * 4) = 0;
            AntiDump.VirtualProtect((IntPtr)ptr4, 4, 64u, out num3);
            *(int*)ptr4 = 0;
            for (int i = 0; i < (int)num; i++)
            {
                AntiDump.VirtualProtect((IntPtr)ptr2, 8, 64u, out num3);
                Marshal.Copy(new byte[8], 0, (IntPtr)((void*)ptr2), 8);
                ptr2 += 40;
            }
        }
    }
}
