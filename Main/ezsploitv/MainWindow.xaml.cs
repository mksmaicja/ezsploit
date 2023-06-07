﻿using Comet_3.Classes.DLL;
using DiscordRPC;
using DiscordRPC.Logging;
using DiscordRPC.Message;
using IWshRuntimeLibrary;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.Wpf;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Web;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using static System.Net.Mime.MediaTypeNames;
using MessageBox = System.Windows.Forms.MessageBox;
using Path = System.IO.Path;

namespace ezsploitv
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WebClient webClient = new WebClient();

        public DiscordRpcClient client;
        public MainWindow()
        {
            InitializeComponent();
            HomeBorder.Visibility = Visibility.Hidden;
            options.Visibility = Visibility.Hidden;
            notifyBorder.Visibility = Visibility.Hidden;
            consoleborder.Visibility = Visibility.Hidden;
            listbox1.Items.Clear();
            Functions.PopulateListBox(listbox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", "*.txt");
            Functions.PopulateListBox(listbox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", " *.lua");

            if (!Directory.Exists("c:\\mikusdevPrograms\\ezsploit\\monaco-editor"))
            {
                webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/monaco-editor.zip", "c:\\mikusdevPrograms\\ezsploit\\monaco-editor.zip");
                ZipFile.ExtractToDirectory("c:\\mikusdevPrograms\\ezsploit\\monaco-editor.zip", "c:\\mikusdevPrograms\\ezsploit");
            }

            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "Comet")
            {

            }
            else
            {
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt", "Comet");
            }
        }

        [DllImport("bin/CometAuth.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool Verify([MarshalAs(UnmanagedType.LPStr)] string key);

        [DllImport("bin/CometAuth.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.BStr)]
        public static extern string HWID();

        public static string HttpGet(string url)
        {
            using WebClient webClient = new WebClient();
            webClient.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            return webClient.DownloadString(url);
        }

        Storyboard storyboard = new Storyboard();
        TimeSpan halfsecond = TimeSpan.FromMilliseconds(500);
        TimeSpan second = TimeSpan.FromSeconds(1);

        private IEasingFunction Smooth
        {
            get;
            set;
        }
        = new QuadraticEase
        {
            EasingMode = EasingMode.EaseInOut
        };

        public void Fade(DependencyObject Object)
        {
            DoubleAnimation FadeIn = new DoubleAnimation()
            {
                From = 0.0,
                To = 1.0,
                Duration = new Duration(halfsecond),
            };
            Storyboard.SetTarget(FadeIn, Object);
            Storyboard.SetTargetProperty(FadeIn, new PropertyPath("Opacity", 1));
            storyboard.Children.Add(FadeIn);
            storyboard.Begin();
        }

        public void FadeOut(DependencyObject Object)
        {
            DoubleAnimation FadeOut = new DoubleAnimation()
            {
                From = 1.0,
                To = 0.0,
                Duration = new Duration(halfsecond),
            };
            Storyboard.SetTarget(FadeOut, Object);
            Storyboard.SetTargetProperty(FadeOut, new PropertyPath("Opacity", 1));
            storyboard.Children.Add(FadeOut);
            storyboard.Begin();
        }

        public void Resize()
        {
            DoubleAnimation dananimationX = new DoubleAnimation();
            dananimationX.From = MainBorder.Width;
            dananimationX.To = 500;
            dananimationX.Duration = second;
            dananimationX.EasingFunction = Smooth;
            MainBorder.BeginAnimation(WidthProperty, dananimationX);

            DoubleAnimation dananimationY = new DoubleAnimation();
            dananimationY.From = MainBorder.Height;
            dananimationY.To = 370;
            dananimationY.Duration = second;
            dananimationY.EasingFunction = Smooth;
            MainBorder.BeginAnimation(HeightProperty, dananimationY);
        }
        
        public void ObjectShiftPos(DependencyObject Object, Thickness Get, Thickness Set)
        {
            ThicknessAnimation ShiftAnimation = new ThicknessAnimation()
            {
                From = Get,
                To = Set,
                Duration = second,
                EasingFunction = Smooth,
            };
            Storyboard.SetTarget(ShiftAnimation, Object);
            Storyboard.SetTargetProperty(ShiftAnimation, new PropertyPath(MarginProperty));
            storyboard.Children.Add(ShiftAnimation);
            storyboard.Begin();
        }

        Random rnd = new Random();

        int jajorandomowe;
        private async void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            jajorandomowe = rnd.Next(1, 6);
            if (jajorandomowe == 1)
            {
                randomfacts.Content = "                   fun fact: EzSploit is developed by a kid";
            }
            else if (jajorandomowe == 2)
            {
                randomfacts.Content = "   fun fact: EzSploit is propably the safest executor";
            }
            else if (jajorandomowe == 3)
            {
                randomfacts.Content = "fun fact: EzSploit has better version of CometAPI";
            }
            else if (jajorandomowe == 4)
            {
                randomfacts.Content = "                              fun fact: EzSploit is open-source";
            }
            else if (jajorandomowe == 5)
            {
                randomfacts.Content = "We're no strangers to love You know the rules and so do I";
            }
            else if (jajorandomowe == 6)
            {
                randomfacts.Content = "We're no strangers to love You know the rules and so do I";
            }

            this.Fade(this.MainBorder);
            ObjectShiftPos(MainBorder, MainBorder.Margin, new Thickness(0, 0, 0, 124));
            await Task.Delay(2000);
            ObjectShiftPos(MainBorder, MainBorder.Margin, new Thickness(0,0,-300, 124));
            this.FadeOut(this.MainBorder);
            HomeBorder.Visibility = Visibility.Visible;
            await Task.Delay(1000);
            MainBorder.Visibility = Visibility.Hidden;
            
        }

        public void SetText(string text)
        {
            ((WebView2)MonacoEditor).CoreWebView2.ExecuteScriptAsync("SetText(\"" + HttpUtility.JavaScriptStringEncode(text) + "\")");
            
        }

        
        public string GetText()
        {
            
            ((WebView2)MonacoEditor).CoreWebView2.WebMessageReceived += delegate (object __1, CoreWebView2WebMessageReceivedEventArgs argsy)
            {
                zabijsieoki = argsy.TryGetWebMessageAsString();
            };
            return zabijsieoki;
        }
        public string zabijsieoki;
        public void savetext()
        {
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "1")
            {
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script1text.txt", GetText());
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "2")
            {
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script2text.txt", GetText());
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "3")
            {
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script3text.txt", GetText());
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "4")
            {
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script4text.txt", GetText());
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "5")
            {
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script5text.txt", GetText());
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "6")
            {
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script6text.txt", GetText());
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "7")
            {
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script7text.txt", GetText());
            }
        }

        public void readtext()
        {
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "1")
            {
                SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script1text.txt"));
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "2")
            {
                SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script2text.txt"));
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "3")
            {
                SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script3text.txt"));
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "4")
            {
                SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script4text.txt"));
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "5")
            {
                SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script5text.txt"));
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "6")
            {
                SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script6text.txt"));
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "7")
            {
                SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script7text.txt"));
            }
        }

        private async void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Scripts/{listbox1.SelectedItem}"));
                await Task.Delay(100);
                savetext();
            }
            catch (Exception)
            {

            }
            
        }


        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            SetText("");
            sendnotify("Textbox cleared!");
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            sendnotify("Deleting Script...");
            LogConsole("Deleting Script...");
            File.Delete("c:\\mikusdevPrograms\\ezsploit\\Scripts\\" + listbox1.SelectedItem);
            try
            {
                listbox1.Items.Clear();
                Functions.PopulateListBox(listbox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", "*.txt");
                Functions.PopulateListBox(listbox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", "*.lua");
            }
            catch (Exception)
            {
                listbox1.Items.Clear();
                Functions.PopulateListBox(listbox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", "*.txt");
                Functions.PopulateListBox(listbox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", "*.lua");
            }
            
        }
       
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            sendnotify("Saving Script...");
            LogConsole("Saving Script...");
            using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Scripts\\" + textBox1.Text + ".txt"))
            {
            }
            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Scripts\\" + textBox1.Text + ".txt", GetText());
            listbox1.Items.Clear();
            Functions.PopulateListBox(listbox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", "*.txt");
            Functions.PopulateListBox(listbox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", "*.lua");
            savetext();
        }

        private void Execute_Click(object sender, RoutedEventArgs e)
        {
            LogConsole("Trying Execute...");
            sendnotify("Trying Execute...");
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "Comet")
            {
                new DLLInterfacing().Execute(GetText());
            }
            savetext();
        }
        
        private async void Close_Click(object sender, RoutedEventArgs e)
        {
            savetext();
            MonacoEditor.Visibility = Visibility.Hidden;
            this.FadeOut(MainGrid);
            await Task.Delay(500);
            Process[] procs = Process.GetProcessesByName("ezsploitv");
            foreach (Process p in procs) { p.Kill(); }
            Close();
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            window.WindowState = WindowState.Minimized;
        }

        private async void grid1_enter(object sender, RoutedEventArgs e)
        {
            this.FadeOut(options);
            await Task.Delay(500);
            this.Fade(Grid1);
            Grid1.Visibility = Visibility.Visible;
            options.Visibility = Visibility.Hidden;
            
        }

        private async void options_enter(object sender, RoutedEventArgs e)
        {
            savetext();
            this.FadeOut(Grid1);
            await Task.Delay(500);
            this.Fade(options);
            Grid1.Visibility = Visibility.Hidden;
            options.Visibility = Visibility.Visible;
        }

        public void selectedtabcol()
        {
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "1")
            {
                script1.Background = System.Windows.Media.Brushes.Gray;
                script2.Background = System.Windows.Media.Brushes.Black;
                script3.Background = System.Windows.Media.Brushes.Black;
                script4.Background = System.Windows.Media.Brushes.Black;
                script5.Background = System.Windows.Media.Brushes.Black;
                script6.Background = System.Windows.Media.Brushes.Black;
                script7.Background = System.Windows.Media.Brushes.Black;
            }
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "2")
            {
                script2.Background = System.Windows.Media.Brushes.Gray;
                script1.Background = System.Windows.Media.Brushes.Black;
                script3.Background = System.Windows.Media.Brushes.Black;
                script4.Background = System.Windows.Media.Brushes.Black;
                script5.Background = System.Windows.Media.Brushes.Black;
                script6.Background = System.Windows.Media.Brushes.Black;
                script7.Background = System.Windows.Media.Brushes.Black;
            }
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "3")
            {
                script3.Background = System.Windows.Media.Brushes.Gray;
                script2.Background = System.Windows.Media.Brushes.Black;
                script1.Background = System.Windows.Media.Brushes.Black;
                script4.Background = System.Windows.Media.Brushes.Black;
                script5.Background = System.Windows.Media.Brushes.Black;
                script6.Background = System.Windows.Media.Brushes.Black;
                script7.Background = System.Windows.Media.Brushes.Black;
            }
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "4")
            {
                script4.Background = System.Windows.Media.Brushes.Gray;
                script2.Background = System.Windows.Media.Brushes.Black;
                script3.Background = System.Windows.Media.Brushes.Black;
                script1.Background = System.Windows.Media.Brushes.Black;
                script5.Background = System.Windows.Media.Brushes.Black;
                script6.Background = System.Windows.Media.Brushes.Black;
                script7.Background = System.Windows.Media.Brushes.Black;
            }
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "5")
            {
                script5.Background = System.Windows.Media.Brushes.Gray;
                script2.Background = System.Windows.Media.Brushes.Black;
                script3.Background = System.Windows.Media.Brushes.Black;
                script4.Background = System.Windows.Media.Brushes.Black;
                script1.Background = System.Windows.Media.Brushes.Black;
                script6.Background = System.Windows.Media.Brushes.Black;
                script7.Background = System.Windows.Media.Brushes.Black;
            }
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "6")
            {
                script6.Background = System.Windows.Media.Brushes.Gray;
                script2.Background = System.Windows.Media.Brushes.Black;
                script3.Background = System.Windows.Media.Brushes.Black;
                script4.Background = System.Windows.Media.Brushes.Black;
                script5.Background = System.Windows.Media.Brushes.Black;
                script1.Background = System.Windows.Media.Brushes.Black;
                script7.Background = System.Windows.Media.Brushes.Black;
            }
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "7")
            {
                script7.Background = System.Windows.Media.Brushes.Gray;
                script2.Background = System.Windows.Media.Brushes.Black;
                script3.Background = System.Windows.Media.Brushes.Black;
                script4.Background = System.Windows.Media.Brushes.Black;
                script5.Background = System.Windows.Media.Brushes.Black;
                script6.Background = System.Windows.Media.Brushes.Black;
                script1.Background = System.Windows.Media.Brushes.Black;
            }
        }

        private void script1_Click(object sender, RoutedEventArgs e)
        {
            savetext();
            
            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "1");
            SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script1text.txt"));
            selectedtabcol();
        }

        private void script2_Click(object sender, RoutedEventArgs e)
        {
            savetext();

            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "2");
            SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script2text.txt"));
            selectedtabcol();
        }

        private void script3_Click(object sender, RoutedEventArgs e)
        {
            savetext();

            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "3");
            SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script3text.txt"));
            selectedtabcol();
        }

        private void script4_Click(object sender, RoutedEventArgs e)
        {
            savetext();

            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "4");
            SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script4text.txt"));
            selectedtabcol();
        }

        private void script5_Click(object sender, RoutedEventArgs e)
        {
            savetext();

            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "5");
            SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script5text.txt"));
            selectedtabcol();
        }

        private void script6_Click(object sender, RoutedEventArgs e)
        {
            savetext();

            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "6");
            SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script6text.txt"));
            selectedtabcol();
        }

        private void script7_Click(object sender, RoutedEventArgs e)
        {
            savetext();

            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "7");
            SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script7text.txt"));
            selectedtabcol();
        }

        private void addtab_Click(object sender, RoutedEventArgs e)
        {
            savetext();


            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script2.txt") == "off")
            {
                script2.Visibility = Visibility.Visible;
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "2");
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script2.txt", "on");
                SetText("");
            }
            else
            {
                if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script3.txt") == "off")
                {
                    script3.Visibility = Visibility.Visible;
                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "3");
                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script3.txt", "on");
                    SetText("");
                }
                else
                {
                    if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script4.txt") == "off")
                    {
                        script4.Visibility = Visibility.Visible;
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "4");
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script4.txt", "on");
                        SetText("");
                    }
                    else
                    {
                        if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script5.txt") == "off")
                        {
                            script5.Visibility = Visibility.Visible;
                            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "5");
                            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script5.txt", "on");
                            SetText("");
                        }
                        else
                        {
                            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script6.txt") == "off")
                            {
                                script6.Visibility = Visibility.Visible;
                                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "6");
                                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script6.txt", "on");
                                SetText("");
                            }
                            else
                            {
                                if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script7.txt") == "off")
                                {
                                    script7.Visibility = Visibility.Visible;
                                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "7");
                                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script7.txt", "on");
                                    SetText("");
                                }
                                else
                                {
                                    sendnotify("max amount of script tabs is 7");
                                }
                            }
                        }
                    }
                }
            }
            selectedtabcol();
        }

        private void remtab_Click(object sender, RoutedEventArgs e)
        {
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script7.txt") == "on")
            {
                script7.Visibility = Visibility.Hidden;
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script7.txt", "off");
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script7text.txt", "");
                if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "7")
                {
                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "6");
                    readtext();
                }
            }
            else
            {
                if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script6.txt") == "on")
                {
                    script6.Visibility = Visibility.Hidden;
                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script6.txt", "off");
                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script6text.txt", "");
                    if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "6")
                    {
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "5");
                        readtext();
                    }
                }
                else
                {
                    if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script5.txt") == "on")
                    {
                        script5.Visibility = Visibility.Hidden;
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script5.txt", "off");
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script5text.txt", "");
                        if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "5")
                        {
                            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "4");
                            readtext();
                        }
                    }
                    else
                    {
                        if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script4.txt") == "on")
                        {
                            script4.Visibility = Visibility.Hidden;
                            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script4.txt", "off");
                            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script4text.txt", "");
                            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "4")
                            {
                                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "3");
                                readtext();
                            }
                        }
                        else
                        {
                            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script3.txt") == "on")
                            {
                                script3.Visibility = Visibility.Hidden;
                                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script3.txt", "off");
                                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script3text.txt", "");
                                if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "3")
                                {
                                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "2");
                                    readtext();
                                }
                            }
                            else
                            {
                                if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script2.txt") == "on")
                                {
                                    script2.Visibility = Visibility.Hidden;
                                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script2.txt", "off");
                                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script2text.txt", "");
                                    if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "2")
                                    {
                                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "1");
                                        readtext();
                                    }
                                }
                                else
                                {
                                    sendnotify("You can't delete script1");
                                }
                            }
                        }
                    }
                }
            }
            selectedtabcol();
        }

        public async void sendnotify(string not)
        {
            try
            {
                notifytext.Content = not;
                notifyBorder.Visibility = Visibility.Visible;
                ObjectShiftPos(notifyBorder, notifyBorder.Margin, new Thickness(193, -2, 193, 404));
                Fade(notifyBorder);
                await Task.Delay(1500);
                FadeOut(notifyBorder);
                ObjectShiftPos(notifyBorder, notifyBorder.Margin, new Thickness(193, -48, 193, 450));
                await Task.Delay(500);
                notifyBorder.Visibility = Visibility.Hidden;
            }
            catch (Exception)
            {

            }
        }

        public async void LogConsole(string sex)
        {
            try
            {
                MonacoConsole.Text = MonacoConsole.Text + "\r\n" +sex;
            }
            catch (Exception)
            {
                try
                {
                    MonacoConsole.Text = MonacoConsole.Text + "\r\n" + sex;
                }
                catch (Exception)
                {
                    
                }
            }
        }

        private async void Grid1_Loaded(object sender1, RoutedEventArgs e1)
        {
            await Task.Delay(1700);
            client = new DiscordRpcClient("1078735530654707772");
            client.Logger = new ConsoleLogger
            {
                Level = LogLevel.Warning
            };
            client.OnReady += async delegate (object sender, ReadyMessage e)
            {

            };
            client.OnPresenceUpdate += delegate (object sender, PresenceMessage e)
            {
            };
            client.Initialize();
            client.SetPresence(new RichPresence
            {
                Details = "Roblox Script Executor",
                State = "join discord plz",
                Timestamps = Timestamps.Now,
                Assets = new Assets
                {
                    LargeImageKey = "https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/ezsploit5.png"
                },
                Buttons = new DiscordRPC.Button[2]
                {
                    new DiscordRPC.Button
                    {
                        Label = "Download",
                        Url = "https://mikusgszyp.github.io/ezsploit/"
                    },
                    new DiscordRPC.Button
                    {
                        Label = "Discord",
                        Url = "https://discord.gg/JJ4Qpe9gSC"
                    }
                }
            });

            script1.Visibility = Visibility.Visible;

            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script2.txt") == "on")
            {
                script2.Visibility = Visibility.Visible;
                if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script3.txt") == "on")
                {
                    script3.Visibility = Visibility.Visible;
                    if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script4.txt") == "on")
                    {
                        script4.Visibility = Visibility.Visible;
                        if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script5.txt") == "on")
                        {
                            script5.Visibility = Visibility.Visible;
                            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script6.txt") == "on")
                            {
                                script6.Visibility = Visibility.Visible;
                                if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script7.txt") == "on")
                                {
                                    script7.Visibility = Visibility.Visible;

                                }
                                else
                                {
                                    script7.Visibility = Visibility.Hidden;
                                }
                            }
                            else
                            {
                                script6.Visibility = Visibility.Hidden;
                                script7.Visibility = Visibility.Hidden;
                            }
                        }
                        else
                        {
                            script5.Visibility = Visibility.Hidden;
                            script6.Visibility = Visibility.Hidden;
                            script7.Visibility = Visibility.Hidden;
                        }
                    }
                    else
                    {
                        script4.Visibility = Visibility.Hidden;
                        script5.Visibility = Visibility.Hidden;
                        script6.Visibility = Visibility.Hidden;
                        script7.Visibility = Visibility.Hidden;
                    }
                }
                else
                {
                    script3.Visibility = Visibility.Hidden;
                    script4.Visibility = Visibility.Hidden;
                    script5.Visibility = Visibility.Hidden;
                    script6.Visibility = Visibility.Hidden;
                    script7.Visibility = Visibility.Hidden;
                }
            }
            else
            {
                script2.Visibility = Visibility.Hidden;
                script3.Visibility = Visibility.Hidden;
                script4.Visibility = Visibility.Hidden;
                script5.Visibility = Visibility.Hidden;
                script6.Visibility = Visibility.Hidden;
                script7.Visibility = Visibility.Hidden;
            }
            selectedtabcol();

            readtext();
            savetext();
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt") == "Turned on")
            {
                LogConsole("Auto-Inject: enabled");
            }
            else
            {
                LogConsole("Auto-Inject: disabled");
            }
            await Task.Delay(50);
            LogConsole("Selected API: " + File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt"));
            await Task.Delay(50);
            LogConsole("version - 6.4 - keyForm patch1");
            await Task.Delay(50);
            LogConsole("developed by - mikusdev");
            await Task.Delay(50);
            LogConsole("helper (bro helped me mentally) - nicknamez");
            await Task.Delay(700);
            LogConsole("Checking Comet key");

            if (Verify(HWID()))
            {
                LogConsole("Key ok!");
                
            }
            else
            {
                LogConsole("Wrong key!");
                COMETKEY.Visibility = Visibility.Visible;
            }
            await Task.Delay(100);
            sendnotify("EzSploit Loaded!");
            await Task.Delay(4000);
            savetext();
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt") == "Turned on")
            {
                LogConsole("Auto-Inject initialized");
                ProcessWatcher processWatcher = new ProcessWatcher("Windows10Universal");

                processWatcher.Created += async (sender, proc) =>
                {
                    Process RobloxProcess = proc;
                    await Task.Delay(4000);
                    injectezsploit();
                };
            }


        }

        private async void killboblocx_Click(object sender, RoutedEventArgs e)
        {

            Process[] processesByName = Process.GetProcessesByName("Windows10Universal");
            for (int i = 0; i < processesByName.Length; i++)
            {
                await Task.Delay(50);
                LogConsole("Roblox killed");
                processesByName[i].Kill();
            }
        }

        private void ReDownload_Click(object sender, RoutedEventArgs e)
        {
            webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/EzSploit%20Launcher.exe", "c:\\mikusdevPrograms\\ezsploit\\EzSploit Updater.exe");
            Thread.Sleep(100);
            Process.Start("c:\\mikusdevPrograms\\ezsploit\\EzSploit Updater.exe");
            Thread.Sleep(50);
            Close();
        }

        private async void fix_Click(object sender, RoutedEventArgs e)
        {
            var message = "Fix Update will fix missing error files, but it will delete: ScriptTabs, configs. Your saved scripts will be preserved. I reccomend you to hit 'ReDownload' button after this action.";
            var title = "EzSploit notification";
            var result = System.Windows.Forms.MessageBox.Show(
                message,
                title,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            switch (result)
            {
                case System.Windows.Forms.DialogResult.Yes:
                    Directory.Delete(@"c:\mikusdevPrograms\ezsploit\Configs", true);
                    if (Directory.Exists(@"c:\mikusdevPrograms\ezsploit\updatetemp"))
                    {
                        Directory.Delete(@"c:\mikusdevPrograms\ezsploit\updatetemp", true);
                    }
                    await Task.Delay(100);
                    Close();
                    break;
                case System.Windows.Forms.DialogResult.No:
                    break;
            }
        }

        private void oxygen_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt", "Comet");
            LogConsole("Selected API: Comet");
        }

        private async void autoinject_Click(object sender, RoutedEventArgs e)
        {
            string path = File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt");
            if (path == "Turned off")
            {
                autoinjbutton.Content = "Turned on";
                autoinjbutton.Foreground = Brushes.Green;
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt", "Turned on");
                await Task.Delay(100);
                path = File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt");
            }
            else if (path == "Turned on")
            {
                autoinjbutton.Content = "Turned off";
                autoinjbutton.Foreground = Brushes.Red;
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt", "Turned off");
                await Task.Delay(100);
                path = File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt");
            }
            Process.Start("c:\\mikusdevPrograms\\ezsploit\\EzSploitV4.exe");
            await Task.Delay(50);
            Process[] procs = Process.GetProcessesByName("ezsploitv");
            foreach (Process p in procs) { p.Kill(); }
            Close();
        }

        private void options_Loaded(object sender, RoutedEventArgs e)
        {
            autoinjbutton.Content = File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt");
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt") == "Turned on")
            {
                autoinjbutton.Foreground = Brushes.Green;
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt") == "Turned off")
            {
                autoinjbutton.Foreground = Brushes.Red;
            }
        }

        private void folder1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            LogConsole("Opening File...");
            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    SetText(File.ReadAllText(openFileDialog.FileName));
                    sendnotify("File opened!");
                    LogConsole("Opened file: " + openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    LogConsole($"Error: Could not read file from disk. Original error: {ex.Message}");//display if got error
                    sendnotify("Error, check console");
                }
            }
            savetext();
        }

        private void Injectbutt(object sender, RoutedEventArgs e)
        {
            
            injectezsploit();
            
            
        }

        public async void injectezsploit()
        {
            if (Verify(HWID()))
            {
                try
                {
                    sendnotify("Injecting...");
                }
                catch (Exception)
                {

                }
                await Task.Delay(500);
                if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "Comet")
                {
                    RuyiAPI.inject();
                }
            }
            else
            {
                COMETKEY.Visibility = Visibility.Visible;
            }
            
        }

        private void MonacoEditor_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            savetext();
        }

        private void Grid1_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {

        }
        public int consoleon = 0;
        private async void openconsole_Click(object sender, RoutedEventArgs e)
        {

            if (consoleon == 0)
            {
                consoleborder.Visibility = Visibility.Visible;
                Fade(consoleborder);
                await Task.Delay(500);
                consoleon = 1;
            }
            else
            {
                FadeOut(consoleborder);
                await Task.Delay(500);
                consoleborder.Visibility = Visibility.Hidden;
                consoleon = 0;
            }
            
        }

        private void ezsploitfolder_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("explorer.exe", "c:\\mikusdevPrograms\\ezsploit");
        }

        private void commetfolder_Click(object sender, RoutedEventArgs e)
        {
            DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(Environment.GetEnvironmentVariable("LocalAppData") + "\\Packages");
            FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles("*" + "ROBLOXCORPORATION" + "*.*");
            DirectoryInfo[] dirsInDir = hdDirectoryInWhichToSearch.GetDirectories("*" + "ROBLOXCORPORATION" + "*.*");
            foreach (DirectoryInfo foundDir in dirsInDir)
            {
                Process.Start("explorer.exe", foundDir.FullName + "\\AC\\workspace");
            }
        }

        private void getkey_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show("When you get the key, paste it in the box below.");
                Process.Start("https://cometrbx.xyz/ks/start.php?HWID=" + HWID());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Key System Error!");
                if (ex.ToString().Contains("An attempt was made to load a program with an incorrect") || ex.ToString().Contains("BadImageFormatException"))
                {
                    Process.Start("https://aka.ms/vs/16/release/vc_redist.x86.exe");
                    Process.Start("https://aka.ms/vs/16/release/vc_redist.x64.exe");
                    MessageBox.Show("Your system is missing the C/C++ redistributions.\nThe link to both of them were started.\nPlease download both of them.\nIf there is an option for repair, select that. If not, continue with a normal installation.\nOnce both are installed, restart your computer.", "Error");
                }
                else
                {
                    MessageBox.Show("Get key error!\n" + ex.ToString());
                }
            }
        }
        private DispatcherTimer KeySpam;
        private async void checkkey_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Verify(jebanysciemkluczxddd.Text))
                {
                    MessageBox.Show("Valid key! (This Key will last a 24h)");
                    await Task.Delay(1000);
                    Process.Start("c:\\mikusdevPrograms\\ezsploit\\EzSploitV4.exe");
                    Close();
                }
                else
                {
                    MessageBox.Show("This key is invalid.");
                    MessageBox.Show("Invalid Key, didn't mean this to be? Please ask people in our discord server.");
                }

            }
            catch (Exception ex)
            {
                if (ex.ToString().Contains("An attempt was made to load a program with an incorrect") || ex.ToString().Contains("BadImageFormatException"))
                {
                    Process.Start("https://aka.ms/vs/16/release/vc_redist.x86.exe");
                    Process.Start("https://aka.ms/vs/16/release/vc_redist.x64.exe");
                    MessageBox.Show("Your system is missing the C/C++ redistributions.\nThe link to both of them were started.\nPlease download both of them.\nIf there is an option for repair, select that. If not, continue with a normal installation.\nOnce both are installed, restart your computer.", "Error");
                }
                else
                {
                    MessageBox.Show("Verify key error!\n" + ex.ToString());
                }

            }
            KeySpam.Start();
        }
    }
}
