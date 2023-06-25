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
