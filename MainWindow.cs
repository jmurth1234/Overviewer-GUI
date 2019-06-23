using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;
using Ini;
using Newtonsoft.Json.Linq;
using System.Security.Policy;
using System.IO.Compression;

namespace OverviewerGUI
{
    public partial class MainWindow : Form
    {
        private string worldDir;
        private string worldName;
        private string outDir;
        private string configFile;
        TextWriter _writer = null;
        private Process proc = new Process();
        private Boolean haltedRender = false;
        private Boolean windowExpanded = false;

        private IniFile configuration;
        private String[] splashes = {
                "Can't track the killers IP!",
                "CLOOOOOOOUD",
                "Uses the minecraft Overviewer!",
                "Coded in C#!",
                "Open source!",
                "Now with title bar splashes!",
                "Splashes are stupid!",
                "MIIIIIINECRAFT",
                "It was trivial!",
                "At the weekend!",
                "Some people want it in python!"
            };

        private string url;
        private string version;
        private string ovExe;

        public delegate void setProgressBarDelegate();
        public delegate void setRenderEnabledDelegate(bool enabled);
        public delegate void setProgressBarPercentDelegate(int per);
        public delegate void setStatusDelegate(string info);

        public void setStatus(string info)
        {
            if (statusLabel.InvokeRequired == true)
            {
                Invoke(new setStatusDelegate(setStatus), info);
            }
            else
            {
                statusLabel.Text = info;
            }
        }

        public void setRenderEnabled(bool enabled)
        {
            if (statusLabel.InvokeRequired == true)
            {
                Invoke(new setRenderEnabledDelegate(setRenderEnabled), enabled);
            }
            else
            {
                startRender.Enabled = enabled;
            }
        }

        public void setProgressBarPercent(int per)
        {
            if (renderProgress.InvokeRequired == true)
            {
                Invoke(new setProgressBarPercentDelegate(setProgressBarPercent), per);
            }
            else
            {
                renderProgress.Value = per;
            }
        }


        public void setProgressBarToContinuous()
        {
            if (renderProgress.InvokeRequired == true)
            {
                Invoke(new setProgressBarDelegate(setProgressBarToContinuous), null);
            }
            else
            {
                renderProgress.Style = ProgressBarStyle.Continuous;
            }
        }

        public void setProgressBarToMarquee()
        {
            if (renderProgress.InvokeRequired == true)
            {
                Invoke(new setProgressBarDelegate(setProgressBarToMarquee), null);
            }
            else
            {
                renderProgress.Style = ProgressBarStyle.Marquee;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        { 
            proc.Kill();
        }

        private string GetFile(string file)
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "OverviewerGUI", file);
        }

        private void MainWindow_LoadAsync(object sender, EventArgs e)
        {
            var fileName = GetFile("OverviewerGUI.ini");
            Debug.WriteLine(fileName);
            Directory.CreateDirectory(GetFile(""));
            configuration = new IniFile(fileName);

            // Instantiate the writer
            _writer = new ConsoleRedirect(OVOutput);
            // Redirect the out Console stream
            Console.SetOut(_writer);
            Console.WriteLine("Saved config in " + fileName);

            this.Text = "Overviewer GUI - " + getSplash();

            try
            {
                //Download the latest overviewer
                using (WebClient wc = new WebClient())
                {
                    var json = wc.DownloadString("http://overviewer.org/downloads.json");

                    bool is64 = System.Environment.Is64BitOperatingSystem;
                    JObject downloads = JObject.Parse(json);

                    url = (string)downloads[is64 ? "win64" : "win32"]["url"];
                    version = (string)downloads[is64 ? "win64" : "win32"]["version"];
                    ovExe = GetFile("overviewer-" + version + "\\overviewer.exe");

                    if (!Directory.Exists(GetFile("overviewer-" + version))) { 
                        var file = "overviewer-" + version + ".zip";
                        var path = GetFile(file);

                        wc.DownloadFileAsync(new Uri(url), path);

                        wc.DownloadProgressChanged += Wc_DownloadProgressChanged;
                        wc.DownloadFileCompleted += (s, a1) =>
                        {
                            ZipFile.ExtractToDirectory(path, GetFile("."));

                            setProgressBarPercent(0);
                            setStatus("Download finished, ready to render...");
                        };
                    }
                }
            } catch { }

            //Configuration initialization
            var configWorldName = configuration.IniReadValue("Name", "worldName");
            var configWorldPath = configuration.IniReadValue("Paths", "worldDir");
            var configOutPath = configuration.IniReadValue("Paths", "outDir");

            if (configWorldName != "" && configWorldName != null)
            {
                worldName = configWorldName;
                worldNameBox.Text = configWorldName;
            }

            if (configWorldPath != "" && configWorldPath != null)
            {
                worldFolder.Text = configWorldPath;
                worldDir = configWorldPath;
            }

            if (configOutPath != "" && configOutPath != null)
            {
                outputFolder.Text = configOutPath;
                outDir = configOutPath;
            }
        }

        private void Wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            setStatus("Download " + e.ProgressPercentage + "% complete");
            setProgressBarPercent(e.ProgressPercentage);
        }

        private void buttonLevelBrowse_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.
            DialogResult result = LevelDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                worldFolder.Text = LevelDialog.SelectedPath;
                worldDir = LevelDialog.SelectedPath;
                configuration.IniWriteValue("Paths", "worldDir", LevelDialog.SelectedPath);
            }
        }

        private void buttonDirBrowse_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.
            DialogResult result = outputDir.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                outputFolder.Text = outputDir.SelectedPath;
                outDir = outputDir.SelectedPath;
                configuration.IniWriteValue("Paths", "outDir", outputDir.SelectedPath);
            }
        }

        private void advancedModeHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("In advanced mode, instead of specifying a world dir and an output directory, " +
                            "you specify a configuration file for the Overviewer. If using the config file, " +
                            "you do not need to specify world dir or output dir with the GUI - you can specify " +
                            "them in the config file :). More details on the config file are avaliable at " +
                            "docs.overviewer.org",
                            "What is advanced mode?", MessageBoxButtons.OK);
        }

        private void startRender_Click_1(object sender, EventArgs e)
        {
            if (configFile != null)
            {
                configRender(configFile);
            }
            else
            {
                simpleRender(worldDir, outDir);
            }
            startRender.Enabled = false;
        }

        private void simpleRender(string worldDir, string outDir)
        {
            OverviewerConfigGenerator config = new OverviewerConfigGenerator()
            {
                WorldName = worldName,
                WorldPath = worldDir, 
                RenderModes = getRenderModes(), 
                OutputDir = outDir
            };

            var file = GetFile("config.generated.py");
            File.WriteAllText(file, config.generateConfig());

            configRender(file);
        }

        private void configRender(String config)
        {
            proc = new Process();
            proc.StartInfo.FileName = ovExe;
            proc.StartInfo.Arguments = "--config=\"" + config + "\" ";

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

            setStatus("Starting render...");
            OVOutput.Text = "";

            if (configFile != null) outDir = "the directory specified in the config";

            proc.BeginErrorReadLine();
            proc.BeginOutputReadLine();
            proc.Exited += new EventHandler(ProcessExited);
        }

        private void configButton_Click_1(object sender, EventArgs e)
        {
            DialogResult result = configDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                configTextBox.Text = configDialog.FileName;
                configFile = configDialog.FileName;
            }
        }

        void proc_DataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data == null)
            {
                return;
            }

            if (e.Data.Contains("Welcome to Minecraft Overviewer!"))
            {
                setProgressBarToMarquee();
            }

            if (e.Data.Contains("inaccurate"))
            {
                haltedRender = true;
                setStatus("Last render was interrupted.  You won't get detailed progress for this render.");
            }

            if (e.Data.Contains("Press [Enter]"))
            {
                proc.Kill();
            }

            string stripBrackets = e.Data.Replace("(", "").Replace(")", "").Replace(" ", "");
            var progress = stripBrackets.Split(',');

            if (progress.Length == 3)
            {
                haltedRender = false;
            }

            if (!haltedRender && progress.Length == 3)
            {
                setProgressBarToContinuous();

                int percent = Convert.ToInt32(Convert.ToDouble(progress[2]));
                setStatus(progress[0] + " / " + progress[1] + " tiles, " + percent + "% complete");
                setProgressBarPercent(percent);
            }
            else
            {
                Console.WriteLine(e.Data);
            }
        }

        private void ProcessExited(Object sender, EventArgs e)   
        {
            setRenderEnabled(true);
            setProgressBarToContinuous();
            setProgressBarPercent(100);

            if (OVOutput.Text.ToLower().Contains("error"))
            {
                setStatus("Render finished with error");
                MessageBox.Show("Looks like an error occured! This means the render failed! Better report the error!");
            }
            else
            {
                setStatus("Render complete!");
                if (Directory.Exists(outDir))
                    Process.Start(outDir);

                MessageBox.Show("The render is complete! Click index.html in the opened folder to view it! :)");
            }
        }

        private List<Render> getRenderModes()
        {
            List<Render> rendermodes = new List<Render>();
            if (normalCheck.Checked == true)
            {
                rendermodes.Add(Render.Normal);
            }
            if (lightingCheck.Checked == true)
            {
                rendermodes.Add(Render.Lighting);
            }
            if (smoothLighingCheck.Checked == true)
            {
                rendermodes.Add(Render.SmoothLighting);
            }
            if (caveCheck.Checked == true)
            {
                rendermodes.Add(Render.Cave);
            }
            if (nightCheck.Checked == true)
            {
                rendermodes.Add(Render.Night);
            }
            if (smoothNightCheck.Checked == true)
            {
                rendermodes.Add(Render.NightSmooth);
            }

            if (rendermodes.Count == 0)
            {
                Console.WriteLine("You need to specify a rendermode! Automatically rendering normal");
                rendermodes.Add(Render.Normal);
            }
            else
            {
                Console.WriteLine("Ok, I'll be rendering the selected render modes");
            }

            return rendermodes;
        }

        private void reportError_Click(object sender, EventArgs e)
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

        private void expandCollapseButton_Click(object sender, EventArgs e)
        {
            if (windowExpanded)
            {
                MainWindow.ActiveForm.Height = 420;
                expandCollapseButton.Text = "Expand";
            }
            else
            {
                MainWindow.ActiveForm.Height = 664;
                expandCollapseButton.Text = "Collapse";
            }

            windowExpanded = !windowExpanded;
        }

        private void worldNameBox_TextChanged(object sender, EventArgs e)
        {
            worldName = worldNameBox.Text;
            configuration.IniWriteValue("Name", "worldName", worldNameBox.Text);
        }
    }
}
