using System.Diagnostics;
using System.Threading.Tasks;

namespace Comet_3.Classes.DLL;

internal class DLLInterfacing
{
	public void Execute(string script)
	{
        RuyiAPI.run_script(script);
    }
}
