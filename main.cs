////////////////////////////////////////////////////////////////////////////////////////////////////////
//FileName: main.cs
//Project: SharpUpdate2
//FileType: Visual C# Source file
//Size : ?
//Author : Fabio Bauer
//Created On : 06.01.2021 11:32:13 PM
//Last Modified On : 09.01.2021 11:01:23 PM
//Copy Rights : Fabio Bauer
//Created for: StepperMotorTestBench
//Description : Control program for the update reminder
//Status: DONE, !modify strings if url changes!
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml;
using System.Diagnostics;

namespace SharpUpdate2
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
    }

        private void main_Load(object sender, EventArgs e)
        {
            string versionurl = "http://localhost/version/version.xml"; //URL of the version.xml
            try
            {
                //Block to read the xml file
                //Gets the newest avaiable version
                XmlReader reader = XmlReader.Create(versionurl);
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) && reader.Name == "version")
                    {
                        if (reader.HasAttributes)
                        {
                            newversion.Text = reader.GetAttribute("newestver");
                        }
                    }
                }

            }
            catch
            {
                MessageBox.Show("Please check your internet connection and restart the application.", "Error(441)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }


            try
            {
                //Block to read the xml file
                //Gets the current version
                XmlReader reader = XmlReader.Create(@".\version.xml");
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) && reader.Name == "version")
                    {
                        if (reader.HasAttributes)
                        {
                            currentversion.Text = reader.GetAttribute("currentver");
                        }
                    }
                }
                reader.Close();
            }
            catch
            {
                currentversion.Text = "2.0.0"; //default text if xml not available
            }
        }

        private void versionskip_Click(object sender, EventArgs e)
        {
            //Replaces the version.xml to appear as being updated
            string downloadurl = "http://localhost/version/version.xml";
            string filename = @".\version.xml";
            File.Delete(@".\version.xml");
            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(WebClient_DownloadFileCompleted);
            webClient.DownloadFileAsync(new Uri(downloadurl), filename);
        }

        private void WebClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //This function is called when the file has been downloaded
            Process.Start("StepperMotorTestBench.exe"); //starts the application
            ((WebClient)sender).Dispose(); //frees the resources of the webclient
            this.Close(); //closes the window
        }

        private void remindmebtn_Click(object sender, EventArgs e)
        {
            Process.Start("StepperMotorTestBench.exe");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SharpUpdater form = new SharpUpdater();
            form.Show(); //opens the updater
            this.Hide(); //closes this window
        }

        private void descriptionupdatetext_Click(object sender, EventArgs e)
        {

        }
    }
}