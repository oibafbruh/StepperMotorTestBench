////////////////////////////////////////////////////////////////////////////////////////////////////////
//FileName: steppermotortestbench.cs
//Project: Stepper Motor testbench
//FileType: Visual C# Source file
//Size : ?
//Author : Fabio Bauer
//Created On : 02.11.2021 01:17:51 AM
//Last Modified On : 
//Copy Rights : Fabio Bauer
//Created for: StepperMotorTestBench
//Description : Main code of the smtb
//Status: wip
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using System.Net;
using System.IO;

namespace StepperMotorTestBench
{
    public partial class steppermotortestbench : Form
    {
        public steppermotortestbench()
        {
            InitializeComponent();
        }

        private void steppermotortestbench_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            portlist.Items.AddRange(ports);
            serialPort1.PortName = portlist.Text;
        }

        private void steppermotortestbench_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@".\StepperMotorTestBench.exe");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void maximizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal; 
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                maximizebtn.Text = "Minimieren";
            }
            else
            {
                maximizebtn.Text = "An Monitor anpassen";
            }
        }

        private void hidebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@".\manual.pdf");
            }
            catch
            {
                MessageBox.Show("Can't open the file");
            }
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@".\manual.pdf");
            }
            catch
            {
                MessageBox.Show("Can't open the file");
            }
        }

        private void newWindowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start(@".\StepperMotorTestBench.exe");
        }

        private void steppermotortestbench_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about form = new about();
            form.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("StepperMotorTestBench.exe");
            this.Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
