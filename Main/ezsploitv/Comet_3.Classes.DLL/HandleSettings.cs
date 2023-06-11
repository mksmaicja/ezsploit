using Microsoft.Win32;

namespace Comet_3.Classes;

internal class HandleSettings
{
	private RegistryKey RegistrySettings = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Supercomet3");

	public void SetSettings(string name, string value)
	{
		RegistrySettings.SetValue(name, value);
	}

	

	
}
