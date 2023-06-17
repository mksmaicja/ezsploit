using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using File = System.IO.File;
using Path = System.IO.Path;

namespace EzSploit_Loader_V2
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            await Task.Delay(1000);

            WebClient webClient = new WebClient();


            async void updatechecker()
            {

                try
                {

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
                        Process[] procs = Process.GetProcessesByName("ezV6");
                        foreach (Process p in procs) { p.Kill(); }
                    }
                    catch (Exception)
                    {

                    }





                    Directory.CreateDirectory("c:\\mikusdevPrograms\\ezsploit");

                    Console.WriteLine("IF EZSPLOIT IS DROPPING FILE ERRORS, THEN RENAME 'Configs' folder to 'updatetemp' in ezsploit directory");

                    webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/versionew.txt", "c:\\mikusdevPrograms\\ezsploit\\versionew.txt");
                    int version = int.Parse(File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\version.txt"));
                    int lastversion = int.Parse(File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\versionew.txt"));
                    if (version < lastversion)
                    {
                        textlabel.Content = "Update avible! Updating...";
                        webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/EzSploit%20Launcher.exe", "c:\\mikusdevPrograms\\ezsploit\\EzSploit Updater.exe");
                        await Task.Delay(100);
                        Process.Start("c:\\mikusdevPrograms\\ezsploit\\EzSploit Updater.exe");
                        Close();
                    }
                    else
                    {
                        if (!File.Exists("c:\\mikusdevPrograms\\ezsploit\\DiscordRPC.dll"))
                        {
                            textlabel.Content = ("Downloading DiscordRPC.dll");
                            webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/DiscordRPC.dll", "c:\\mikusdevPrograms\\ezsploit\\DiscordRPC.dll");
                        }
                        if (!File.Exists("c:\\mikusdevPrograms\\ezsploit\\Newtonsoft.Json.dll"))
                        {
                            textlabel.Content = ("Downloading Newtonsoft.Json.dll");
                            webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/Newtonsoft.Json.dll", "c:\\mikusdevPrograms\\ezsploit\\Newtonsoft.Json.dll");
                        }


                        if (!Directory.Exists("c:\\mikusdevPrograms\\ezsploit\\runtimes"))
                        {
                            textlabel.Content = ("Downloading runtimes.zip");
                            webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/runtimes.zip", "c:\\mikusdevPrograms\\ezsploit\\runtimes.zip");
                            textlabel.Content = ("Extracting runtimes.zip");
                            ZipFile.ExtractToDirectory("c:\\mikusdevPrograms\\ezsploit\\runtimes.zip", "c:\\mikusdevPrograms\\ezsploit");
                        }

                        if (!File.Exists("c:\\mikusdevPrograms\\ezsploit\\Ruyi.dll"))
                        {
                            textlabel.Content = ("Downloading Ruyi.dll");
                            webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/Ruyi.dll", "c:\\mikusdevPrograms\\ezsploit\\Ruyi.dll");
                        }
                        if (!Directory.Exists("c:\\mikusdevPrograms\\ezsploit\\bin"))
                        {
                            Directory.CreateDirectory("c:\\mikusdevPrograms\\ezsploit\\bin");
                        }
                        if (!File.Exists("c:\\mikusdevPrograms\\ezsploit\\bin\\CometAuth.dll"))
                        {
                            textlabel.Content = ("Downloading Comet_auth.dll");
                            webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/CometAuth.dll", "c:\\mikusdevPrograms\\ezsploit\\bin\\CometAuth.dll");
                        }
                        if (!File.Exists("c:\\mikusdevPrograms\\ezsploit\\bin\\FluxusAuth.dll"))
                        {
                            textlabel.Content = ("Downloading FluxusAuth.dll ");
                            webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/FluxusAuth.dll", "c:\\mikusdevPrograms\\ezsploit\\bin\\FluxusAuth.dll");
                        }

                        if (!File.Exists("c:\\mikusdevPrograms\\ezsploit\\CometAuth.dll"))
                        {
                            textlabel.Content = ("Downloading main Comet_auth.dll");
                            webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/CometAuth.dll", "c:\\mikusdevPrograms\\ezsploit\\CometAuth.dll");
                        }
                        if (!File.Exists("c:\\mikusdevPrograms\\ezsploit\\COMETleaked.dll"))
                        {
                            textlabel.Content = ("Downloading Comet key bypass");
                            webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/COMETleaked.dll", "c:\\mikusdevPrograms\\ezsploit\\COMETleaked.dll");
                        }

                        if (!File.Exists("c:\\mikusdevPrograms\\ezsploit\\ValyseAPI.dll"))
                        {
                            textlabel.Content = ("Downloading Valyse deps");
                            webClient.DownloadFile("https://api.valyse.net/download?download=valyse", "c:\\mikusdevPrograms\\ezsploit\\valyseTEMP.zip");

                            if (!Directory.Exists("c:\\mikusdevPrograms\\ezsploit\\valyseTMP"))
                            {
                                Directory.CreateDirectory("c:\\mikusdevPrograms\\ezsploit\\valyseTMP");
                            }
                            else
                            {
                                Directory.Delete("c:\\mikusdevPrograms\\ezsploit\\valyseTMP", true);
                                await Task.Delay(100);
                                Directory.CreateDirectory("c:\\mikusdevPrograms\\ezsploit\\valyseTMP");
                            }
                            await Task.Delay(100);
                            ZipFile.ExtractToDirectory("c:\\mikusdevPrograms\\ezsploit\\valyseTEMP.zip", "c:\\mikusdevPrograms\\ezsploit\\valyseTMP");
                            await Task.Delay(100);
                            File.Move("c:\\mikusdevPrograms\\ezsploit\\valyseTMP\\bin\\ValyseAPI.dll", "c:\\mikusdevPrograms\\ezsploit\\ValyseAPI.dll");
                        }
                        if (!File.Exists("c:\\mikusdevPrograms\\ezsploit\\System.Net.Http.Formatting.dll"))
                        {
                            textlabel.Content = ("Downloading Valyse deps");
                            webClient.DownloadFile("https://api.valyse.net/download?download=valyse", "c:\\mikusdevPrograms\\ezsploit\\valyseTEMP.zip");

                            if (!Directory.Exists("c:\\mikusdevPrograms\\ezsploit\\valyseTMP"))
                            {
                                Directory.CreateDirectory("c:\\mikusdevPrograms\\ezsploit\\valyseTMP");
                            }
                            else
                            {
                                Directory.Delete("c:\\mikusdevPrograms\\ezsploit\\valyseTMP", true);
                                await Task.Delay(100);
                                Directory.CreateDirectory("c:\\mikusdevPrograms\\ezsploit\\valyseTMP");
                            }
                            await Task.Delay(100);
                            ZipFile.ExtractToDirectory("c:\\mikusdevPrograms\\ezsploit\\valyseTEMP.zip", "c:\\mikusdevPrograms\\ezsploit\\valyseTMP");
                            await Task.Delay(100);
                            File.Move("c:\\mikusdevPrograms\\ezsploit\\valyseTMP\\bin\\System.Net.Http.Formatting.dll", "c:\\mikusdevPrograms\\ezsploit\\System.Net.Http.Formatting.dll");
                        }
                        if (!File.Exists("c:\\mikusdevPrograms\\ezsploit\\Valyse.exe"))
                        {
                            textlabel.Content = ("Downloading Valyse.crk");
                            webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/Valyse.exe", "c:\\mikusdevPrograms\\ezsploit\\Valyse.exe");
                        }

                        if (!File.Exists("c:\\mikusdevPrograms\\ezsploit\\Microsoft.Web.WebView2.Core.dll"))
                        {
                            textlabel.Content = ("Downloading Microsoft.Web.WebView2.Core.dll");
                            webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/Microsoft.Web.WebView2.Core.dll", "c:\\mikusdevPrograms\\ezsploit\\Microsoft.Web.WebView2.Core.dll");
                        }
                        if (!File.Exists("c:\\mikusdevPrograms\\ezsploit\\Microsoft.Web.WebView2.WinForms.dll"))
                        {
                            textlabel.Content = ("Downloading Microsoft.Web.WebView2.WinForms.dll");
                            webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/Microsoft.Web.WebView2.WinForms.dll", "c:\\mikusdevPrograms\\ezsploit\\Microsoft.Web.WebView2.WinForms.dll");
                        }
                        if (!File.Exists("c:\\mikusdevPrograms\\ezsploit\\Microsoft.Web.WebView2.Wpf.dll"))
                        {
                            textlabel.Content = ("Downloading Microsoft.Web.WebView2.Wpf.dll");
                            webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/Microsoft.Web.WebView2.Wpf.dll", "c:\\mikusdevPrograms\\ezsploit\\Microsoft.Web.WebView2.Wpf.dll");
                        }

                        if (!Directory.Exists("c:\\mikusdevPrograms\\ezsploit\\Configs"))
                        {
                            textlabel.Content = ("Triggered redownload by user/update");
                            await Task.Delay(100);
                            textlabel.Content = ("Downloading exploit dll's");
                            await Task.Delay(100);
                            Console.WriteLine("Downloading Ruyi.dll");
                            webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/Ruyi.dll", "c:\\mikusdevPrograms\\ezsploit\\Ruyi.dll");

                            if (!Directory.Exists("c:\\mikusdevPrograms\\ezsploit\\bin"))
                            {
                                Directory.CreateDirectory("c:\\mikusdevPrograms\\ezsploit\\bin");
                            }

                            textlabel.Content = ("Downloading Comet_auth.dll");
                            webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/CometAuth.dll", "c:\\mikusdevPrograms\\ezsploit\\bin\\CometAuth.dll");
                            webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/CometAuth.dll", "c:\\mikusdevPrograms\\ezsploit\\CometAuth.dll");

                            textlabel.Content = ("Downloading Comet keysys");
                            webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/COMETleaked.dll", "c:\\mikusdevPrograms\\ezsploit\\COMETleaked.dll");
                            textlabel.Content = ("Downloading FluxusAuth.dll ");
                            webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/FluxusAuth.dll", "c:\\mikusdevPrograms\\ezsploit\\bin\\FluxusAuth.dll");

                            textlabel.Content = ("Downloading Valyse deps");
                            webClient.DownloadFile("https://api.valyse.net/download?download=valyse", "c:\\mikusdevPrograms\\ezsploit\\valyseTEMP.zip");

                            if (File.Exists("c:\\mikusdevPrograms\\ezsploit\\ValyseAPI.dll"))
                            {
                                File.Delete("c:\\mikusdevPrograms\\ezsploit\\ValyseAPI.dll");
                            }
                            if (File.Exists("c:\\mikusdevPrograms\\ezsploit\\System.Net.Http.Formatting.dll"))
                            {
                                File.Delete("c:\\mikusdevPrograms\\ezsploit\\System.Net.Http.Formatting.dll");
                            }
                            if (!Directory.Exists("c:\\mikusdevPrograms\\ezsploit\\valyseTMP"))
                            {
                                Directory.CreateDirectory("c:\\mikusdevPrograms\\ezsploit\\valyseTMP");
                            }
                            else
                            {
                                Directory.Delete("c:\\mikusdevPrograms\\ezsploit\\valyseTMP", true);
                                await Task.Delay(100);
                                Directory.CreateDirectory("c:\\mikusdevPrograms\\ezsploit\\valyseTMP");
                            }
                            await Task.Delay(100);
                            ZipFile.ExtractToDirectory("c:\\mikusdevPrograms\\ezsploit\\valyseTEMP.zip", "c:\\mikusdevPrograms\\ezsploit\\valyseTMP");
                            await Task.Delay(100);
                            File.Move("c:\\mikusdevPrograms\\ezsploit\\valyseTMP\\bin\\ValyseAPI.dll", "c:\\mikusdevPrograms\\ezsploit\\ValyseAPI.dll");
                            File.Move("c:\\mikusdevPrograms\\ezsploit\\valyseTMP\\bin\\System.Net.Http.Formatting.dll", "c:\\mikusdevPrograms\\ezsploit\\System.Net.Http.Formatting.dll");


                            if (!Directory.Exists("c:\\mikusdevPrograms\\ezsploit\\monaco-editor"))
                            {
                                textlabel.Content = ("Downloading monaco-editor.zip");
                                webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/monaco-editor.zip", "c:\\mikusdevPrograms\\ezsploit\\monaco-editor.zip");
                                textlabel.Content = ("Extracting monaco-editor.zip");
                                ZipFile.ExtractToDirectory("c:\\mikusdevPrograms\\ezsploit\\monaco-editor.zip", "c:\\mikusdevPrograms\\ezsploit");
                            }

                            if (Directory.Exists(@"c:\mikusdevPrograms\ezsploit\updatetemp"))
                            {
                                Directory.Move(@"c:\mikusdevPrograms\ezsploit\updatetemp", @"c:\mikusdevPrograms\ezsploit\Configs");

                                Directory.CreateDirectory("c:\\mikusdevPrograms\\ezsploit\\Scripts");
                                if (Directory.Exists("c:\\mikusdevPrograms\\ezsploit\\monaco-editor"))
                                {
                                    textlabel.Content = ("ReDownloading monaco-editor");
                                    await Task.Delay(100);
                                    textlabel.Content = ("Deleting monaco-editor");
                                    Directory.Delete("c:\\mikusdevPrograms\\ezsploit\\monaco-editor", true);
                                    await Task.Delay(100);
                                    textlabel.Content = ("Downloading monaco-editor.zip");
                                    webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/monaco-editor.zip", "c:\\mikusdevPrograms\\ezsploit\\monaco-editor.zip");
                                    textlabel.Content = ("Extracting monaco-editor.zip");
                                    ZipFile.ExtractToDirectory("c:\\mikusdevPrograms\\ezsploit\\monaco-editor.zip", "c:\\mikusdevPrograms\\ezsploit");
                                }
                                if (Directory.Exists("c:\\mikusdevPrograms\\ezsploit\\runtimes"))
                                {
                                    textlabel.Content = ("ReDownloading runtimes");
                                    await Task.Delay(100);
                                    textlabel.Content = ("Deleting runtimes");
                                    Directory.Delete("c:\\mikusdevPrograms\\ezsploit\\runtimes", true);
                                    await Task.Delay(100);
                                    textlabel.Content = ("Downloading runtimes.zip");
                                    webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/runtimes.zip", "c:\\mikusdevPrograms\\ezsploit\\runtimes.zip");
                                    textlabel.Content = ("Extracting runtimes.zip");
                                    ZipFile.ExtractToDirectory("c:\\mikusdevPrograms\\ezsploit\\runtimes.zip", "c:\\mikusdevPrograms\\ezsploit");
                                }
                                if (Directory.Exists("c:\\mikusdevPrograms\\ezsploit\\valyseTMP"))
                                {
                                    Directory.Delete("c:\\mikusdevPrograms\\ezsploit\\valyseTMP", true);
                                }
                                textlabel.Content = ("Restored Configs!");
                                await Task.Delay(100);
                                textlabel.Content = ("Launching EzSploit 6");
                                webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/ezsploitv.exe", "c:\\mikusdevPrograms\\ezsploit\\ezV6.exe");
                                await Task.Delay(50);
                                Process.Start("c:\\mikusdevPrograms\\ezsploit\\ezV6.exe");
                                Close();
                                return;
                            }
                            Directory.CreateDirectory("c:\\mikusdevPrograms\\ezsploit\\Configs");

                            Directory.CreateDirectory("c:\\mikusdevPrograms\\ezsploit\\Scripts");

                            using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt"))
                            {
                            }
                            using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedTheme.txt"))
                            {
                            }
                            using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt"))
                            {
                            }
                            using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt"))
                            {
                            }
                            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedTheme.txt", "classic");
                            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt", "Turned off");
                            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt", "Comet");
                            using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script2.txt"))
                            {
                            }
                            using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script3.txt"))
                            {
                            }
                            using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script4.txt"))
                            {
                            }
                            using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script5.txt"))
                            {
                            }
                            using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script6.txt"))
                            {
                            }
                            using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script7.txt"))
                            {
                            }
                            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script2.txt", "off");
                            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script3.txt", "off");
                            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script4.txt", "off");
                            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script5.txt", "off");
                            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script6.txt", "off");
                            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script7.txt", "off");
                            using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script1text.txt"))
                            {
                            }
                            using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script2text.txt"))
                            {
                            }
                            using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script3text.txt"))
                            {
                            }
                            using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script4text.txt"))
                            {
                            }
                            using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script5text.txt"))
                            {
                            }
                            using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script6text.txt"))
                            {
                            }
                            using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script7text.txt"))
                            {
                            }
                            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "1");
                            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script1text.txt", "EzSploit \rBy mikusdev/mikusgszyp");
                            textlabel.Content = ("Configs set to def!");

                        }
                        if (Directory.Exists(@"c:\mikusdevPrograms\ezsploit\updatetemp"))
                        {
                            Directory.Delete(@"c:\mikusdevPrograms\ezsploit\updatetemp", true);
                        }
                        if (Directory.Exists("c:\\mikusdevPrograms\\ezsploit\\valyseTMP"))
                        {
                            Directory.Delete("c:\\mikusdevPrograms\\ezsploit\\valyseTMP", true);
                        }

                        textlabel.Content = ("Launching EzSploit 6");
                        webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/ezsploitv.exe", "c:\\mikusdevPrograms\\ezsploit\\ezV6.exe");
                        await Task.Delay(50);
                        Process.Start("c:\\mikusdevPrograms\\ezsploit\\ezV6.exe");
                        Close();
                    }



                }
                catch (Exception)
                {
                    textlabel.Content = ("ERROR, running updater...");
                    webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/EzSploit%20Launcher.exe", "c:\\mikusdevPrograms\\ezsploit\\EzSploit Updater.exe");
                    await Task.Delay(100);
                    Process.Start("c:\\mikusdevPrograms\\ezsploit\\EzSploit Updater.exe");
                    Close();
                }
            }

            string destkop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (Directory.Exists("c:\\mikusdevPrograms\\ezsploit"))
            {
                if (System.IO.File.Exists("c:\\mikusdevPrograms\\ezsploit\\version.txt"))
                {
                    System.IO.File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\version.txt", "72");
                }
                if (!System.IO.File.Exists("c:\\mikusdevPrograms\\ezsploit\\version.txt"))
                {
                    using (System.IO.File.Create("c:\\mikusdevPrograms\\ezsploit\\version.txt"))
                    {
                        await Task.Delay(50);
                    }
                    System.IO.File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\version.txt", "72");
                }
            }




            Console.WriteLine("INFO: If ezsploit is not launching, or dll's not injecting then disable antivirus or delete 'C:/mikusdevPrograms' folder on your PC.");
            Console.WriteLine("INFO: You can also install WebView2");
            if (System.IO.File.Exists("C:\\mikusdevPrograms\\ezsploit\\EzSploitV4.exe"))
            {
                updatechecker();
            }
            else
            {
                textlabel.Content = ("EzSploit not detected!");
                await Task.Delay(100);
                textlabel.Content = ("Installing...");
                await Task.Delay(100);
                textlabel.Content = ("Creating Directory...");
                await Task.Delay(100);
                DirectoryInfo di = Directory.CreateDirectory(@"c:\mikusdevPrograms\ezsploit");
                await Task.Delay(500);
                if (Directory.Exists(@"c:\mikusdevPrograms\ezsploit\Configs"))
                {
                    textlabel.Content = ("Deleting Configs...");
                    Directory.Delete(@"c:\mikusdevPrograms\ezsploit\Configs", true);
                }
                textlabel.Content = ("Downloading Main .exe");
                webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/EzSploitV4.exe", @"c:\mikusdevPrograms\ezsploit\EzSploitV4.exe");
                await Task.Delay(1000);
                textlabel.Content = ("Creating Desktop shortcut...");
                object shDesktop = (object)"Desktop";
                WshShell shell = new WshShell();
                string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\EzSploit.lnk";
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
                shortcut.Description = "EzSploit shortcut";
                shortcut.Hotkey = "Ctrl+Shift+E";
                shortcut.TargetPath = @"c:\mikusdevPrograms\ezsploit\EzSploitV4.exe";
                shortcut.WorkingDirectory = @"c:\mikusdevPrograms\ezsploit";
                shortcut.Save();
                textlabel.Content = ("Creating Start Menu shortcut...");
                string programs_path = Environment.GetFolderPath(Environment.SpecialFolder.Programs);
                string shortcutFolder = Path.Combine(programs_path, @"mikusdev");
                if (!Directory.Exists(shortcutFolder))
                {
                    Directory.CreateDirectory(shortcutFolder);
                }
                WshShell shellClass = new WshShell();
                //Create First Shortcut for Application Settings
                string settingsLink = Path.Combine(shortcutFolder, "EzSploit.lnk");
                IWshShortcut shortcutmenu = (IWshShortcut)shellClass.CreateShortcut(settingsLink);
                shortcutmenu.TargetPath = @"c:\mikusdevPrograms\ezsploit\EzSploitV4.exe";
                shortcutmenu.WorkingDirectory = @"c:\mikusdevPrograms\ezsploit";
                shortcutmenu.Description = "EzSploit shortcut";
                shortcutmenu.Save();
                textlabel.Content = ("installed!");
                await Task.Delay(100);
                textlabel.Content = ("Run EzSploit by shortcut on your desktop");
                await Task.Delay(4000);
                Close();
            }
        }
    }
}
