////////////////////////////////////////////////////////////////////////////////////////////////////////
//FileName: SharpUpdater.cs
//Project: SharpUpdate2
//FileType: Visual C# Source file
//Size : ?
//Author : Fabio Bauer
//Created On : 07.01.2021 2:02:23 PM
//Last Modified On : 09.01.2021 11:09:45 PM
//Copy Rights : Fabio Bauer
//Created for: StepperMotorTestBench
//Description : Update program for the updater
//Status: DONE, !modify strings if url changes!
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.IO.Compression;
using System.Threading;

namespace SharpUpdate2
{
    public partial class SharpUpdater : Form
    {
        public SharpUpdater()
        {
            InitializeComponent();
        }

        private void SharpUpdater_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void SharpUpdater_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            string oldversion = @".\StepperMotorTestBench.exe";
            string backup = @".\backup\backup.fb";
            string downloadurl = "http://localhost/version/StepperMotorTestBench.zip";
            string filename = @".\StepperMotorTestBench.zip";
            statustxt.Text = "Creating backup...";
            File.Copy(oldversion, backup);
            progressBar1.Value = 50;
            statustxt.Text = "Removing old version...";
            File.Delete(oldversion);
            progressBar1.Value = 100;
            Thread.Sleep(200);
            progressBar1.Value = 0;
            statustxt.Text = "Downloading new update...";
            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(WebClient_DownloadFileCompleted);
            webClient.DownloadProgressChanged += WebClient_DownloadProgressChanged;
            webClient.DownloadFileAsync(new Uri(downloadurl), filename);
            progressBar1.Value = 100;
        }

        private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Increment(1);
        }

        private void WebClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            statustxt.Text = "Installing new files...";
            string filename = @".\StepperMotorTestBench.zip";
            string extractPath = @".\";
            string exeName = "StepperMotorTestBench.exe";
            string backup = @".\backup\backup.fb";
            statustxt.Text = "Creating backup...";
            ZipFile.ExtractToDirectory(filename, extractPath);
            File.Delete(filename);
            File.Delete(backup);
            Process.Start(exeName);
            this.Close();
        }
    }
}
