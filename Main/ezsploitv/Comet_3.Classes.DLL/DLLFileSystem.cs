using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Comet_3.Classes.DLL;

internal class DLLFileSystem
{
    public static string DLLFolder = "C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\" + HWID() + "\\";

    public static string DLLPath = DLLFolder + HWID() + ".dll";

    public static bool DiscordRPCEnabled = false;

    [DllImport("bin/CometAuth.dll", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.BStr)]
    public static extern string HWID();

    
}
