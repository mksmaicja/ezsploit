using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using IWshRuntimeLibrary;

namespace Comet_3.Classes.DLL;

internal class RuyiAPI
{
    public enum Result : uint
    {
        Success,
        DLLNotFound,
        OpenProcFail,
        AllocFail,
        LoadLibFail,
        AlreadyInjected,
        ProcNotOpen,
        Unknown
    }

    public static string dll_path;

    private static IntPtr phandle;

    private static int pid = 0;

    private static readonly IntPtr NULL = (IntPtr)0;

    private static HandleSettings Settings = new HandleSettings();

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern IntPtr OpenProcess(uint access, bool inhert_handle, int pid);

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint flAllocationType, uint flProtect);

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, IntPtr nSize, int lpNumberOfBytesWritten);

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern IntPtr GetModuleHandle(string lpModuleName);

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttribute, IntPtr dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

    [DllImport("Ruyi.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool run_script(IntPtr proc, int pid, string path, [MarshalAs(UnmanagedType.LPWStr)] string script);

    [DllImport("Ruyi.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool is_injected(IntPtr proc, int pid, string path);

    private static Result r_inject(string dll_path)
    {
        dll_path = DLLFileSystem.DLLPath;
        FileInfo fileInfo = new FileInfo(dll_path);
        FileSecurity accessControl = fileInfo.GetAccessControl();
        SecurityIdentifier identity = new SecurityIdentifier("S-1-15-2-1");
        accessControl.AddAccessRule(new FileSystemAccessRule(identity, FileSystemRights.FullControl, InheritanceFlags.None, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
        fileInfo.SetAccessControl(accessControl);
        Process[] processesByName = Process.GetProcessesByName("Windows10Universal");
        if (processesByName.Length == 0)
        {
            return Result.ProcNotOpen;
        }
        for (uint num = 0u; num < processesByName.Length; num++)
        {
            Process process = processesByName[num];
            if (pid != process.Id)
            {
                dll_path = DLLFileSystem.DLLPath;
                IntPtr intPtr = OpenProcess(1082u, inhert_handle: false, process.Id);
                if (intPtr == NULL)
                {
                    return Result.OpenProcFail;
                }
                IntPtr intPtr2 = VirtualAllocEx(intPtr, NULL, (IntPtr)((dll_path.Length + 1) * Marshal.SizeOf(typeof(char))), 12288u, 64u);
                if (intPtr2 == NULL)
                {
                    return Result.AllocFail;
                }
                byte[] bytes = Encoding.Default.GetBytes(dll_path);
                int num2 = WriteProcessMemory(intPtr, intPtr2, bytes, (IntPtr)((dll_path.Length + 1) * Marshal.SizeOf(typeof(char))), 0);
                if (num2 == 0 || (long)num2 == 6)
                {
                    return Result.Unknown;
                }
                if (CreateRemoteThread(intPtr, NULL, NULL, GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA"), intPtr2, 0u, NULL) == NULL)
                {
                    return Result.LoadLibFail;
                }
                pid = process.Id;
                phandle = intPtr;
                return Result.Success;
            }
            if (pid == process.Id)
            {
                return Result.AlreadyInjected;
            }
        }
        return Result.Unknown;
    }

    public static Result inject_custom()
    {
        dll_path = DLLFileSystem.DLLPath;
        try
        {
            if (!File.Exists(dll_path))
            {
                return Result.DLLNotFound;
            }
            return r_inject(dll_path);
        }
        catch
        {
            System.Windows.MessageBox.Show("Unknown error during r_inject method");
            return Result.Unknown;
        }
    }



    public static bool is_injected()
    {
        dll_path = DLLFileSystem.DLLPath;
        return is_injected(phandle, pid, dll_path);
    }

    public static bool run_script(string script)
    {
        dll_path = DLLFileSystem.DLLPath;
        if (script == string.Empty)
        {
            return is_injected();
        }
        return run_script(phandle, pid, dll_path, script);
    }

    

    private static string get_file_sha384(string path)
    {
        using FileStream inputStream = File.OpenRead(path);
        return BitConverter.ToString(new SHA384Managed().ComputeHash(inputStream)).Replace("-", string.Empty).ToLower();
    }

    public static bool GetCorrectDLL()
    {
        dll_path = DLLFileSystem.DLLPath;
        
        if(!Directory.Exists("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\" + DLLFileSystem.HWID()))
        {
            Directory.CreateDirectory("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\" + DLLFileSystem.HWID());
        }

        Process[] processesByName = Process.GetProcessesByName("Windows10Universal");
        if (processesByName.Length == 0)
        {
            System.Windows.MessageBox.Show("The game was not found!\nDue to the release of Byfron, Comet currently only supports the Windows Store version of the game!\nPlease install and join using the Windows Store version and inject again!", "Comet");
            return false;
        }
        if (processesByName.Length != 0)
        {
            string text = get_file_sha384(Process.GetProcessById(processesByName[0].Id).MainModule.FileName);
            using (WebClient webClient = new WebClient())
            {
                string text2 = webClient.DownloadString("https://cometrbx.xyz/external-files/DLL/get_dll_hash.php?hash=" + text);
                if (text2 == "no")
                {
                    System.Windows.MessageBox.Show("Comet server's doesn't have DLL for newest version of roblox, wait a few hours for update", "EzSploit", MessageBoxButton.OK, MessageBoxImage.Hand);
                    System.Windows.MessageBox.Show("If you injected EzSploit before, it will try to inject old downloaded version of DLL", "EzSploit", MessageBoxButton.OK, MessageBoxImage.Hand);
                }
                else
                {
                    try
                    {
                        webClient.DownloadFile(text2, DLLFileSystem.DLLPath);
                    }
                    catch (Exception ex)
                    {
                        System.Windows.MessageBox.Show("DLL Installation System Failed!\n" + ex.ToString(), "Comet");
                    }
                }
                
            }
            Settings.SetSettings("game_hash_uwp", text);
            return true;
        }
        return true;
    }
}
