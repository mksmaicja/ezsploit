﻿using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzSploit_Launcher
{
    public partial class updating : Form
    {

        string textboxtext;
        string selectedapi;
        string selectedtheme;
        string autoinj;

        WebClient webClient = new WebClient();
        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
        public updating()
        {
            InitializeComponent();

            wait(500);

            string configsfolder = @"c:\mikusdevPrograms\ezsploit";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (Directory.Exists(configsfolder))
            {
                webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/EzSploitV4.exe", @"c:\mikusdevPrograms\ezsploit\EzSploitV4.exe");

                

                return;
            }
            DirectoryInfo di = Directory.CreateDirectory(@"c:\mikusdevPrograms\ezsploit");
            
            webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/EzSploitV4.exe", @"c:\mikusdevPrograms\ezsploit\EzSploitV4.exe");
        }
        

        Point lastPoint;
        private void Form1_Load(object sender, EventArgs e)

        {
            wait(500);
            System.IO.File.Delete(@"c:\mikusdevPrograms\ezsploit\version.txt");
            wait(500);
            System.IO.File.Move(@"c:\mikusdevPrograms\ezsploit\versionew.txt", @"c:\mikusdevPrograms\ezsploit\version.txt");
            wait(500);
            DirectoryInfo di1 = Directory.CreateDirectory(@"c:\mikusdevPrograms\ezsploit\updatetemp");

            textboxtext = System.IO.File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\Configs\textboxconf.txt");
            selectedapi = System.IO.File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\Configs\selectedAPI.txt");
            selectedtheme = System.IO.File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\Configs\selectedTheme.txt");
            autoinj = System.IO.File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\Configs\autoinject.txt");

            using (FileStream fs = System.IO.File.Create(@"c:\mikusdevPrograms\ezsploit\updatetemp\textboxconf.txt"))
            using (FileStream fs2 = System.IO.File.Create(@"c:\mikusdevPrograms\ezsploit\updatetemp\selectedAPI.txt"))
            using (FileStream fs3 = System.IO.File.Create(@"c:\mikusdevPrograms\ezsploit\updatetemp\selectedTheme.txt"))
            using (FileStream fs4 = System.IO.File.Create(@"c:\mikusdevPrograms\ezsploit\updatetemp\autoinject.txt"))
            wait(100);
            System.IO.File.WriteAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\textboxconf.txt", textboxtext);
            System.IO.File.WriteAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\selectedAPI.txt", selectedapi);
            System.IO.File.WriteAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\selectedTheme.txt", selectedtheme);
            System.IO.File.WriteAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\autoinject.txt", autoinj);


            Directory.Delete(@"c:\mikusdevPrograms\ezsploit\Configs", true);
            wait(200);
            completed f2 = new completed();
            f2.ShowDialog();

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
        }

        private void pictureBox1_LoadProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_LoadCompleted_1(object sender, AsyncCompletedEventArgs e)
        {
        }
    }
}

