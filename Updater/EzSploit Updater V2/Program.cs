using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EzSploit_Updater_V2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            WebClient webClient = new WebClient();
            try
            {
                Process[] procs = Process.GetProcessesByName("ezsploitv");
                foreach (Process p in procs) { p.Kill(); }
            }
            catch (Exception)
            {

            }
            try
            {
                Process[] procs = Process.GetProcessesByName("EzSploitV4");
                foreach (Process p in procs) { p.Kill(); }
            }
            catch (Exception)
            {

            }
            try
            {
                Console.WriteLine("Checking internet connection...");
                string iswebavible = webClient.DownloadString("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/versionew.txt");
                Console.WriteLine("Updating...");
                try
                {
                    foreach (Process process in Process.GetProcessesByName("tmp"))
                    {
                        process.Kill();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Failed to kill EzSploit.exe");
                }
                

                string configsfolder = @"c:\mikusdevPrograms\ezsploit";
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (Directory.Exists(configsfolder))
                {
                    webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/EzSploitV4.exe", @"c:\mikusdevPrograms\ezsploit\EzSploitV4.exe");
                }
                else
                {
                    DirectoryInfo di = Directory.CreateDirectory(@"c:\mikusdevPrograms\ezsploit");

                    webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/EzSploitV4.exe", @"c:\mikusdevPrograms\ezsploit\EzSploitV4.exe");
                }


                Directory.Move(@"c:\mikusdevPrograms\ezsploit\Configs", @"c:\mikusdevPrograms\ezsploit\updatetemp");

                
                Thread.Sleep(100);
                Console.WriteLine("Update completed! ReLaunching EzSploit");
                Process.Start(@"c:\mikusdevPrograms\ezsploit\EzSploitV4.exe");
                Console.WriteLine("Exiting...");
                Thread.Sleep(500);
            }
            catch (Exception)
            {
                Console.WriteLine("No internet connection! Exiting...");
                Thread.Sleep(1000);
            }
        }
    }
}
