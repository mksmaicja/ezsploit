using System.Diagnostics;
using System.Threading.Tasks;

namespace Comet_3.Classes.DLL;

internal class DLLInterfacing
{
	private void Inject_Comet()
	{
	}

	public void Execute(string script)
	{
        RuyiAPI.run_script(script);
    }
}
