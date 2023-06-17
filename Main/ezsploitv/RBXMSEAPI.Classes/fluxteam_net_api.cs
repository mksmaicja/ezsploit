using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using IWshRuntimeLibrary;

namespace RBXMSEAPI.Classes;

public static class fluxteam_net_api
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

	public static IntPtr phandle;

	public static int pid = 0;

	private static readonly IntPtr NULL = (IntPtr)0;

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

	[DllImport("Fluxteam_net_API.dll", CallingConvention = CallingConvention.StdCall)]
	public static extern bool run_script(IntPtr proc, int pid, string path, [MarshalAs(UnmanagedType.LPWStr)] string script);

	[DllImport("Fluxteam_net_API.dll", CallingConvention = CallingConvention.StdCall)]
	public static extern bool is_injected(IntPtr proc, int pid, string path);


	private static Result r_inject(string dll_path)
	{
		dll_path = "c:\\mikusdevPrograms\\ezsploit\\Module.dll";

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
            dll_path = "c:\\mikusdevPrograms\\ezsploit\\Module.dll";
            if (pid != process.Id)
			{
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
		try
		{
            dll_path = "c:\\mikusdevPrograms\\ezsploit\\Module.dll";
            if (!File.Exists(dll_path))
			{
				return Result.DLLNotFound;
			}
			return r_inject(dll_path);
		}
		catch
		{
			return Result.Unknown;
		}
	}

	public static bool is_injected(int pid)
	{
        dll_path = "c:\\mikusdevPrograms\\ezsploit\\Module.dll";
        phandle = OpenProcess(1082u, inhert_handle: false, pid);
		return is_injected(phandle, pid, dll_path);
	}

	public static bool run_script(int pid, string script)
	{
        dll_path = "c:\\mikusdevPrograms\\ezsploit\\Module.dll";
        fluxteam_net_api.pid = pid;
		phandle = OpenProcess(1082u, inhert_handle: false, pid);
		if (pid == 0)
		{
			MessageBox.Show("Please press Inject first!", "Fluxteam.net API Error");
			return false;
		}
		if (script == string.Empty)
		{
			return is_injected(pid);
		}
        dll_path = "c:\\mikusdevPrograms\\ezsploit\\Module.dll";
        return run_script(phandle, pid, dll_path, script);
	}

	
}
