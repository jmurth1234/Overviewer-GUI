﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace OverviewerGUI
{
    public partial class MainWindow : Form
    {
        private string worldDir;
        private string outDir;
        private string configFile;
        TextWriter _writer = null;
        private String[] splashes = new String[8];

        public MainWindow()
        {
            InitializeComponent();
            splashes[0] = "Can't track the killers IP!";
            splashes[1] = "CLOOOOOOOUD";
            splashes[2] = "Uses the minecraft Overviewer!";
            splashes[3] = "Coded in C#!";
            splashes[4] = "Open source!";
            splashes[5] = "Now with title bar splashes!";
            splashes[6] = "Splashes are stupid!";
            splashes[7] = "MIIIIIINECRAFT";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Instantiate the writer
            _writer = new ConsoleRedirect(OVOutput);
            // Redirect the out Console stream
            Console.SetOut(_writer);
            Console.WriteLine("Now redirecting output to the text box");

            this.Text = "Overviewer GUI - " + getSplash();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.
            DialogResult result = LevelDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                textBox1.Text = LevelDialog.SelectedPath;
                worldDir = LevelDialog.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.
            DialogResult result = outputDir.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                textBox2.Text = outputDir.SelectedPath;
                outDir = outputDir.SelectedPath;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("In advanced mode, instead of specifying a world dir and an output directory, you specify a configuration file for the Overviewer. If using the config file, you do not need to specify world dir or output dir with the GUI - you can specify them in the config file :). More details on th config file are avaliable at docs.overviewer.org", "What is advanced mode?", MessageBoxButtons.OK);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (configFile != null)
            {
                configRender(configFile);
            }
            else
            {
                simpleRender(worldDir, outDir);
            }
        }

        private void simpleRender(string worldDir, string outDir)
        {
            Process proc = new Process();

            proc.StartInfo.FileName = @"cmd";
            proc.StartInfo.Arguments = "/c overviewer.exe --rendermodes=" + getRenderModes() + " \"" + worldDir + "\" \"" + outDir + "\" ";
            // set up output redirection
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.RedirectStandardError = true;
            proc.EnableRaisingEvents = true;
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.UseShellExecute = false;
            // see below for output handler
            proc.ErrorDataReceived += proc_DataReceived;
            proc.OutputDataReceived += proc_DataReceived;
            proc.Start();
            proc.BeginErrorReadLine();
            proc.BeginOutputReadLine();
            proc.Exited += new EventHandler(ProcessExited);

        }

        private void configRender(String config)
        {
            Process proc = new Process();

            proc.StartInfo.FileName = @"cmd";
            proc.StartInfo.Arguments = "/c overviewer.exe --config=\"" + config + "\" ";
            // set up output redirection
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.RedirectStandardError = true;
            proc.EnableRaisingEvents = true;
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.UseShellExecute = false;
            // see below for output handler
            proc.ErrorDataReceived += proc_DataReceived;
            proc.OutputDataReceived += proc_DataReceived;
            proc.Start();
            outDir = "the directory specified in the config";
            proc.BeginErrorReadLine();
            proc.BeginOutputReadLine();
            proc.Exited += new EventHandler(ProcessExited);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult result = configDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                textBox4.Text = configDialog.FileName;
                configFile = configDialog.FileName;
            }
        }

        void proc_DataReceived(object sender, DataReceivedEventArgs e)
        {
            Console.WriteLine(e.Data);
        }
        private void ProcessExited(Object sender, EventArgs e)
            
        {
            if (OVOutput.Text.Contains("Error"))
            {
                Console.WriteLine("Looks like an error occured! This means the render failed! Better report the error!");
            }
            else
            {
                Console.WriteLine("The render is complete! Go to " + outDir + " and click index.html to view it! :)");
            }
        }

        private String getRenderModes()
        {
            //WALL OF IF STATEMENTS FTW
            List<string> rendermodes = new List<string>();
            if (normalCheck.Checked == true)
            {
                rendermodes.Add("normal");
            }
            if (lightingCheck.Checked == true)
            {
                rendermodes.Add("lighting");
            }
            if (smoothLighingCheck.Checked == true)
            {
                rendermodes.Add("smooth-lighting");
            }
            if (caveCheck.Checked == true)
            {
                rendermodes.Add("cave");
            }
            if (nightCheck.Checked == true)
            {
                rendermodes.Add("night");
            }
            if (smoothNightCheck.Checked == true)
            {
                rendermodes.Add("smooth-night");
            }


            if (rendermodes.Count == 0)
            {
                Console.WriteLine("You need to specify a rendermode! Automatically rendering normal");
                rendermodes.Add("normal");
            }
            else
            {
                Console.WriteLine("Ok, I'll be rendering " + string.Join(",", rendermodes.ToArray()));
            }

            return string.Join(",", rendermodes.ToArray())
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Collections.Specialized.NameValueCollection Data = new System.Collections.Specialized.NameValueCollection();
            String header = "###########################################" + Environment.NewLine +
                            "#                                         #" + Environment.NewLine +
                            "#   This pastebin was generated by the    #" + Environment.NewLine +
                            "#            Overviewer GUI               #" + Environment.NewLine +
                            "#                                         #" + Environment.NewLine +
                            "#   Paste the link for this in the IRC    #" + Environment.NewLine +
                            "#  channel at http://overviewer.org/irc   #" + Environment.NewLine +
                            "#  And we'll help you with the error :)   #" + Environment.NewLine +
                            "#                                         #" + Environment.NewLine +
                            "###########################################" + Environment.NewLine;
            Data["api_paste_name"] = "[OV-GUI] Log file upload via the GUI";
            Data["api_paste_expire_date"] = "N";
            Data["api_paste_code"] = header + OVOutput.Text;
            Data["api_dev_key"] = "8aaa33c046fd8faf1d495718d2414165";
            Data["api_option"] = "paste";
            WebClient wb = new WebClient();
            byte[] bytes = wb.UploadValues("http://pastebin.com/api/api_post.php", Data);
            string response;
            using (MemoryStream ms = new MemoryStream(bytes))
            using (StreamReader reader = new StreamReader(ms))
                response = reader.ReadToEnd();
            if (response.StartsWith("Bad API request"))
            {
                Console.WriteLine("Something went wrong. How ironic, the error report returned an error");
                Console.WriteLine("Look, just go to http://overviewer.org/irc. We'll help there :)");
            }
            else
            {
                System.Diagnostics.Process.Start(response);
            }
        }

        public String getSplash()
        {
            Random random = new Random();
            int n = random.Next(0, splashes.Length);
            return splashes[n];
        }
    }
}
