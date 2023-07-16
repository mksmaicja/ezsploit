using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Compression;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ezsploitv
{
    /// <summary>
    /// Logika interakcji dla klasy initial.xaml
    /// </summary>
    public partial class initial : Window
    {
        public initial()
        {
            InitializeComponent();
        }

        
        private async void Border_Loaded(object sender, RoutedEventArgs e)
        {
            await Task.Delay(500);
            WebClient webClient = new WebClient();
            try
            {

                Console.WriteLine("IF EZSPLOIT IS DROPPING FILE ERRORS, THEN RENAME 'Configs' folder to 'updatetemp' in ezsploit directory");

                webClient.DownloadFile("http://dziecizautyzmem.ovh/EzSploit/versionew.txt", "c:\\mikusdevPrograms\\ezsploit\\versionew.txt");
                int version = 85;
                int lastversion = int.Parse(File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\versionew.txt"));
                if (version < lastversion)
                {
                    textlabel.Content = "Update avible! Updating...";
                    webClient.DownloadFile("http://dziecizautyzmem.ovh/EzSploit/EzSploit%20Launcher.exe", "c:\\mikusdevPrograms\\ezsploit\\EzSploit Updater.exe");
                    await Task.Delay(100);
                    Process.Start("c:\\mikusdevPrograms\\ezsploit\\EzSploit Updater.exe");
                    Close();
                }
                else
                {
                    if (!File.Exists("c:\\mikusdevPrograms\\ezsploit\\DiscordRPC.dll"))
                    {
                        textlabel.Content = ("Downloading DiscordRPC.dll");
                        webClient.DownloadFile("http://dziecizautyzmem.ovh/EzSploit/DiscordRPC.dll", "c:\\mikusdevPrograms\\ezsploit\\DiscordRPC.dll");
                    }
                    if (!File.Exists("c:\\mikusdevPrograms\\ezsploit\\Newtonsoft.Json.dll"))
                    {
                        textlabel.Content = ("Downloading Newtonsoft.Json.dll");
                        webClient.DownloadFile("http://dziecizautyzmem.ovh/EzSploit/Newtonsoft.Json.dll", "c:\\mikusdevPrograms\\ezsploit\\Newtonsoft.Json.dll");
                    }


                    if (!Directory.Exists("c:\\mikusdevPrograms\\ezsploit\\runtimes"))
                    {
                        textlabel.Content = ("Downloading runtimes.zip");
                        webClient.DownloadFile("http://dziecizautyzmem.ovh/EzSploit/runtimes.zip", "c:\\mikusdevPrograms\\ezsploit\\runtimes.zip");
                        textlabel.Content = ("Extracting runtimes.zip");
                        ZipFile.ExtractToDirectory("c:\\mikusdevPrograms\\ezsploit\\runtimes.zip", "c:\\mikusdevPrograms\\ezsploit");
                    }

                    if (!File.Exists("c:\\mikusdevPrograms\\ezsploit\\Ruyi.dll"))
                    {
                        textlabel.Content = ("Downloading Ruyi.dll");
                        webClient.DownloadFile("http://dziecizautyzmem.ovh/EzSploit/Ruyi.dll", "c:\\mikusdevPrograms\\ezsploit\\Ruyi.dll");
                    }
                    if (!Directory.Exists("c:\\mikusdevPrograms\\ezsploit\\bin"))
                    {
                        Directory.CreateDirectory("c:\\mikusdevPrograms\\ezsploit\\bin");
                    }
                    if (!File.Exists("c:\\mikusdevPrograms\\ezsploit\\bin\\CometAuth.dll"))
                    {
                        textlabel.Content = ("Downloading Comet_auth.dll");
                        webClient.DownloadFile("http://dziecizautyzmem.ovh/EzSploit/CometAuth.dll", "c:\\mikusdevPrograms\\ezsploit\\bin\\CometAuth.dll");
                    }
                    if (!File.Exists("c:\\mikusdevPrograms\\ezsploit\\bin\\FluxusAuth.dll"))
                    {
                        textlabel.Content = ("Downloading FluxusAuth.dll ");
                        webClient.DownloadFile("http://dziecizautyzmem.ovh/EzSploit/FluxusAuth.dll", "c:\\mikusdevPrograms\\ezsploit\\bin\\FluxusAuth.dll");
                    }

                    if (!File.Exists("c:\\mikusdevPrograms\\ezsploit\\CometAuth.dll"))
                    {
                        textlabel.Content = ("Downloading main Comet_auth.dll");
                        webClient.DownloadFile("http://dziecizautyzmem.ovh/EzSploit/CometAuth.dll", "c:\\mikusdevPrograms\\ezsploit\\CometAuth.dll");
                    }
                    

                    if (!File.Exists("c:\\mikusdevPrograms\\ezsploit\\Module.dll"))
                    {
                        textlabel.Content = ("Downloading KeylessFlux API deps v6-8");
                        
                        webClient.DownloadFile("http://dziecizautyzmem.ovh/EzSploit/Module.dll", "c:\\mikusdevPrograms\\ezsploit\\Module.dll");
                        
                        
                    }
                    if (!File.Exists("c:\\mikusdevPrograms\\ezsploit\\Fluxteam_net_API.dll"))
                    {
                        textlabel.Content = ("Downloading KeylessFlux API deps  v6-8");
                        
                        webClient.DownloadFile("http://dziecizautyzmem.ovh/EzSploit/Fluxteam_net_API.dll", "c:\\mikusdevPrograms\\ezsploit\\Fluxteam_net_API.dll");
                        
                    }

                    try
                    {
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
                            webClient.DownloadFile("http://dziecizautyzmem.ovh/EzSploit/Valyse.exe", "c:\\mikusdevPrograms\\ezsploit\\Valyse.exe");
                        }
                    }
                    catch (Exception)
                    {
                        textlabel.Content = "VALYSE WEB SERVER ERROR!";
                        await Task.Delay(1000);
                        textlabel.Content = "Skipping downloading this API!";
                        await Task.Delay(1000);
                        webClient.DownloadFile("http://dziecizautyzmem.ovh/EzSploit/Valyse.exe", "c:\\mikusdevPrograms\\ezsploit\\Valyse.exe");
                        webClient.DownloadFile("http://dziecizautyzmem.ovh/EzSploit/ValyseAPI.dll", "c:\\mikusdevPrograms\\ezsploit\\ValyseAPI.dll");
                        webClient.DownloadFile("http://dziecizautyzmem.ovh/EzSploit/System.Net.Http.Formatting.dll", "c:\\mikusdevPrograms\\ezsploit\\System.Net.Http.Formatting.dll");
                    }

                    if (!File.Exists("c:\\mikusdevPrograms\\ezsploit\\Microsoft.Web.WebView2.Core.dll"))
                    {
                        textlabel.Content = ("Downloading Microsoft.Web.WebView2.Core.dll");
                        webClient.DownloadFile("http://dziecizautyzmem.ovh/EzSploit/Microsoft.Web.WebView2.Core.dll", "c:\\mikusdevPrograms\\ezsploit\\Microsoft.Web.WebView2.Core.dll");
                    }
                    if (!File.Exists("c:\\mikusdevPrograms\\ezsploit\\Microsoft.Web.WebView2.WinForms.dll"))
                    {
                        textlabel.Content = ("Downloading Microsoft.Web.WebView2.WinForms.dll");
                        webClient.DownloadFile("http://dziecizautyzmem.ovh/EzSploit/Microsoft.Web.WebView2.WinForms.dll", "c:\\mikusdevPrograms\\ezsploit\\Microsoft.Web.WebView2.WinForms.dll");
                    }
                    if (!File.Exists("c:\\mikusdevPrograms\\ezsploit\\Microsoft.Web.WebView2.Wpf.dll"))
                    {
                        textlabel.Content = ("Downloading Microsoft.Web.WebView2.Wpf.dll");
                        webClient.DownloadFile("http://dziecizautyzmem.ovh/EzSploit/Microsoft.Web.WebView2.Wpf.dll", "c:\\mikusdevPrograms\\ezsploit\\Microsoft.Web.WebView2.Wpf.dll");
                    }

                    if (!Directory.Exists("c:\\mikusdevPrograms\\ezsploit\\Configs"))
                    {
                        textlabel.Content = ("Triggered redownload by user/update");
                        await Task.Delay(100);
                        textlabel.Content = ("Downloading exploit dll's");
                        await Task.Delay(100);
                        Console.WriteLine("Downloading Ruyi.dll");
                        webClient.DownloadFile("http://dziecizautyzmem.ovh/EzSploit/Ruyi.dll", "c:\\mikusdevPrograms\\ezsploit\\Ruyi.dll");

                        if (!Directory.Exists("c:\\mikusdevPrograms\\ezsploit\\bin"))
                        {
                            Directory.CreateDirectory("c:\\mikusdevPrograms\\ezsploit\\bin");
                        }

                        textlabel.Content = ("Downloading Comet_auth.dll");
                        webClient.DownloadFile("http://dziecizautyzmem.ovh/EzSploit/CometAuth.dll", "c:\\mikusdevPrograms\\ezsploit\\bin\\CometAuth.dll");
                        webClient.DownloadFile("http://dziecizautyzmem.ovh/EzSploit/CometAuth.dll", "c:\\mikusdevPrograms\\ezsploit\\CometAuth.dll");

                        
                        textlabel.Content = ("Downloading FluxusAuth.dll ");
                        webClient.DownloadFile("http://dziecizautyzmem.ovh/EzSploit/FluxusAuth.dll", "c:\\mikusdevPrograms\\ezsploit\\bin\\FluxusAuth.dll");


                        
                        textlabel.Content = ("Downloading KeylessFlux API deps v6-8");
                        
                        webClient.DownloadFile("http://dziecizautyzmem.ovh/EzSploit/Module.dll", "c:\\mikusdevPrograms\\ezsploit\\Module.dll");
                        

                        
                        textlabel.Content = ("Downloading KeylessFlux API deps  v6-8");
                        webClient.DownloadFile("http://dziecizautyzmem.ovh/EzSploit/Fluxteam_net_API.dll", "c:\\mikusdevPrograms\\ezsploit\\Fluxteam_net_API.dll");
                        


                        try
                        {
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
                        }
                        catch (Exception)
                        {
                            textlabel.Content = "VALYSE WEB SERVER ERROR!";
                            await Task.Delay(1000);
                            textlabel.Content = "Downloading recovery version of valyse...";
                            await Task.Delay(1000);
                            webClient.DownloadFile("http://dziecizautyzmem.ovh/EzSploit/Valyse.exe", "c:\\mikusdevPrograms\\ezsploit\\Valyse.exe");
                            webClient.DownloadFile("http://dziecizautyzmem.ovh/EzSploit/ValyseAPI.dll", "c:\\mikusdevPrograms\\ezsploit\\ValyseAPI.dll");
                            webClient.DownloadFile("http://dziecizautyzmem.ovh/EzSploit/System.Net.Http.Formatting.dll", "c:\\mikusdevPrograms\\ezsploit\\System.Net.Http.Formatting.dll");
                        }


                        if (!Directory.Exists("c:\\mikusdevPrograms\\ezsploit\\monaco-editor"))
                        {
                            textlabel.Content = ("Downloading monaco-editor.zip");
                            webClient.DownloadFile("http://dziecizautyzmem.ovh/EzSploit/monaco-editor.zip", "c:\\mikusdevPrograms\\ezsploit\\monaco-editor.zip");
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
                                webClient.DownloadFile("http://dziecizautyzmem.ovh/EzSploit/monaco-editor.zip", "c:\\mikusdevPrograms\\ezsploit\\monaco-editor.zip");
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
                                webClient.DownloadFile("http://dziecizautyzmem.ovh/EzSploit/runtimes.zip", "c:\\mikusdevPrograms\\ezsploit\\runtimes.zip");
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
                            
                            await Task.Delay(50);
                            MainWindow ihopeyoupassaway = new MainWindow();
                            ihopeyoupassaway.Show();
                            this.Close();
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
                        using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script8.txt"))
                        {
                        }
                        using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script9.txt"))
                        {
                        }
                        using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script10.txt"))
                        {
                        }
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script2.txt", "off");
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script3.txt", "off");
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script4.txt", "off");
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script5.txt", "off");
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script6.txt", "off");
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script7.txt", "off");
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script8.txt", "off");
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script9.txt", "off");
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script10.txt", "off");
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
                        using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script8text.txt"))
                        {
                        }
                        using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script9text.txt"))
                        {
                        }
                        using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script10text.txt"))
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
                    MainWindow ihopeyoupassaway2 = new MainWindow();
                    ihopeyoupassaway2.Show();
                    this.Close();
                }



            }
            catch (Exception ex)
            {
                textlabel.Content = ("ERROR, running updater...");
                MessageBox.Show(ex.ToString());
                webClient.DownloadFile("http://dziecizautyzmem.ovh/EzSploit/EzSploit%20Launcher.exe", "c:\\mikusdevPrograms\\ezsploit\\EzSploit Updater.exe");
                await Task.Delay(100);
                Process.Start("c:\\mikusdevPrograms\\ezsploit\\EzSploit Updater.exe");
                Close();
            }
        }
    }
}
