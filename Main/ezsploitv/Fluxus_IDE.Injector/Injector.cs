using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows;

namespace Fluxus_IDE.Injector;

public class Injector
{
	public enum Legacy_Result : uint
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

	public enum Result : uint
	{
		Success,
		DLLNotFound,
		OpenProcFail,
		RobloxNotOpen,
		LoadLibFail,
		ExportNotFound,
		Timeout,
		UnsupportedBuild,
		AlreadyInjected,
		Unknown
	}

	private static readonly IntPtr NULL = (IntPtr)0;

	private IntPtr phandle;

	public int pid;

	public Dictionary<int, string> Clients = new Dictionary<int, string>();

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

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern int CloseHandle(IntPtr hObject);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool WaitNamedPipe(string pipe, int timeout = 10);

	[DllImport("bin/FluxusAuth.dll", CallingConvention = CallingConvention.StdCall)]
	public static extern int zYeDcizNXv(IntPtr proc, int pid, string path, string path_2);

	[DllImport("bin/FluxusAuth.dll", CallingConvention = CallingConvention.StdCall)]
	public static extern int run_script(IntPtr proc, int pid, string path, [MarshalAs(UnmanagedType.LPWStr)] string script);

	[DllImport("bin/FluxusAuth.dll", CallingConvention = CallingConvention.StdCall)]
	public static extern int rconsoleinput_call(IntPtr proc, int pid, string path, [MarshalAs(UnmanagedType.LPWStr)] string script);

	[DllImport("bin/FluxusAuth.dll", CallingConvention = CallingConvention.StdCall)]
	public static extern int setting_call(IntPtr proc, int pid, string path, int obs);

	[DllImport("bin/FluxusAuth.dll", CallingConvention = CallingConvention.StdCall)]
	[return: MarshalAs(UnmanagedType.BStr)]
	public static extern string JtSZRomqos(IntPtr proc, int pid);

	public bool Exists(string Name)
	{
		return WaitNamedPipe("\\\\.\\pipe\\" + Name);
	}

	public bool is_ghost_proc(ProcessModuleCollection a1)
	{
		foreach (ProcessModule item in a1)
		{
			string text = item.FileName.ToString();
			if (text.Contains("cryptnet") || text.Contains("mswsock") || text.Contains("urlmon") || text.Contains("XInput1_4") || text.Contains("CoreUIComponents"))
			{
				return false;
			}
		}
		return true;
	}

	private Result r_inject(bool hide_obs, string dll_path, string dll_path_2)
	{
		Process[] processesByName = Process.GetProcessesByName("Windows10Universal");
		if (processesByName.Length == 0)
		{
			return Result.RobloxNotOpen;
		}
		for (uint num = 0u; num < processesByName.Length; num++)
		{
			Process process = processesByName[num];
			_ = "fluxus_luac_send_pipe" + process.Id;
			if (pid != process.Id && !is_ghost_proc(process.Modules))
			{
				phandle = OpenProcess(2035711u, inhert_handle: false, process.Id);
				if (phandle == NULL)
				{
					return Result.OpenProcFail;
				}
				Result result = (Result)zYeDcizNXv(phandle, process.Id, dll_path, dll_path_2);
				if (result != 0)
				{
					return result;
				}
				if (hide_obs)
				{
					int num2 = run_script(phandle, process.Id, dll_path, "setfflag(\"Custom_AntiObsCapture\", \"true\")");
					int num3 = 4;
					while (num2 == 0 && num3 <= 4)
					{
						num3++;
						Thread.Sleep(500);
						num2 = run_script(phandle, process.Id, dll_path, "setfflag(\"Custom_AntiObsCapture\", \"true\")");
					}
				}
				pid = process.Id;
				return Result.Success;
			}
			if (pid == process.Id)
			{
				return Result.AlreadyInjected;
			}
		}
		return Result.Unknown;
	}

	private Legacy_Result r_inject_legacy(bool hide_obs, string dll_path)
	{
		FileInfo fileInfo = new FileInfo(dll_path);
		FileSecurity accessControl = fileInfo.GetAccessControl();
		SecurityIdentifier identity = new SecurityIdentifier("S-1-15-2-1");
		accessControl.AddAccessRule(new FileSystemAccessRule(identity, FileSystemRights.FullControl, InheritanceFlags.None, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
		fileInfo.SetAccessControl(accessControl);
		Process[] processesByName = Process.GetProcessesByName("Windows10Universal");
		if (processesByName.Length == 0)
		{
			return Legacy_Result.ProcNotOpen;
		}
		for (uint num = 0u; num < processesByName.Length; num++)
		{
			Process process = processesByName[num];
			if (pid != process.Id)
			{
				IntPtr intPtr = OpenProcess(1082u, inhert_handle: false, process.Id);
				if (intPtr == NULL)
				{
					return Legacy_Result.OpenProcFail;
				}
				IntPtr intPtr2 = VirtualAllocEx(intPtr, NULL, (IntPtr)((dll_path.Length + 1) * Marshal.SizeOf(typeof(char))), 12288u, 64u);
				if (intPtr2 == NULL)
				{
					return Legacy_Result.AllocFail;
				}
				byte[] bytes = Encoding.Default.GetBytes(dll_path);
				int num2 = WriteProcessMemory(intPtr, intPtr2, bytes, (IntPtr)((dll_path.Length + 1) * Marshal.SizeOf(typeof(char))), 0);
				if (num2 == 0 || (long)num2 == 6)
				{
					return Legacy_Result.Unknown;
				}
				if (CreateRemoteThread(intPtr, NULL, NULL, GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA"), intPtr2, 0u, NULL) == NULL)
				{
					return Legacy_Result.LoadLibFail;
				}
				pid = process.Id;
				phandle = intPtr;
				if (hide_obs)
				{
					int num3 = run_script(phandle, process.Id, dll_path, "setfflag(\"Custom_AntiObsCapture\", \"true\")");
					int num4 = 4;
					while (num3 == 0 && num4 <= 4)
					{
						num4++;
						Thread.Sleep(500);
						num3 = run_script(phandle, process.Id, dll_path, "setfflag(\"Custom_AntiObsCapture\", \"true\")");
					}
				}
				return Legacy_Result.Success;
			}
			if (pid == process.Id)
			{
				return Legacy_Result.AlreadyInjected;
			}
		}
		return Legacy_Result.Unknown;
	}

	public string GetUser(int pid)
	{
		if (Clients.ContainsKey(pid))
		{
			return Clients[pid];
		}
		IntPtr intPtr = OpenProcess(2035711u, inhert_handle: false, pid);
		if (intPtr != NULL)
		{
			string result = JtSZRomqos(intPtr, pid);
			CloseHandle(intPtr);
			return result;
		}
		return "FAIL";
	}

	public int run_script(string path, string script)
	{
        MessageBox.Show("debug3");
        return run_script(phandle, pid, path, script);
	}

	public int rconsoleinput_call(string path, string script)
	{
		if (script == "")
		{
			script = "\0";
		}
		return rconsoleinput_call(phandle, pid, path, script);
	}

	public Result inject(bool hide_obs, string path, string path_2)
	{
		try
		{
			if (!File.Exists(path))
			{
				return Result.DLLNotFound;
			}
			return r_inject(hide_obs, path, path_2);
		}
		catch (Exception ex)
		{
			MessageBox.Show("Injection Error\n" + ex.ToString(), "Injection", MessageBoxButton.OK, MessageBoxImage.Hand);
		}
		return Result.Unknown;
	}

	public Legacy_Result inject_legacy(bool hide_obs, string path)
	{
		try
		{
			if (!File.Exists(path))
			{
				return Legacy_Result.DLLNotFound;
			}
			return r_inject_legacy(hide_obs, path);
		}
		catch (Exception ex)
		{
			MessageBox.Show("Injection Error\n" + ex.ToString(), "Injection", MessageBoxButton.OK, MessageBoxImage.Hand);
		}
		return Legacy_Result.Unknown;
	}
}
