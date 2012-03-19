namespace OverviewerGUI
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDirBrowse = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.outputDir = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.smoothNightCheck = new System.Windows.Forms.CheckBox();
            this.nightCheck = new System.Windows.Forms.CheckBox();
            this.caveCheck = new System.Windows.Forms.CheckBox();
            this.smoothLighingCheck = new System.Windows.Forms.CheckBox();
            this.lightingCheck = new System.Windows.Forms.CheckBox();
            this.normalCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLeveBrowse = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.OVOutput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.configDialog = new System.Windows.Forms.OpenFileDialog();
            this.LevelDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDirBrowse);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(6, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 56);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output folder";
            // 
            // buttonDirBrowse
            // 
            this.buttonDirBrowse.Location = new System.Drawing.Point(358, 19);
            this.buttonDirBrowse.Name = "buttonDirBrowse";
            this.buttonDirBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonDirBrowse.TabIndex = 1;
            this.buttonDirBrowse.Text = "Browse";
            this.buttonDirBrowse.UseVisualStyleBackColor = true;
            this.buttonDirBrowse.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(346, 20);
            this.textBox2.TabIndex = 0;
            // 
            // outputDir
            // 
            this.outputDir.Description = "Select where the Overviewer will save the html files and render to";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(482, 230);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.smoothNightCheck);
            this.tabPage1.Controls.Add(this.nightCheck);
            this.tabPage1.Controls.Add(this.caveCheck);
            this.tabPage1.Controls.Add(this.smoothLighingCheck);
            this.tabPage1.Controls.Add(this.lightingCheck);
            this.tabPage1.Controls.Add(this.normalCheck);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(474, 204);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Simple Mode";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // smoothNightCheck
            // 
            this.smoothNightCheck.AutoSize = true;
            this.smoothNightCheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.smoothNightCheck.Location = new System.Drawing.Point(229, 166);
            this.smoothNightCheck.Name = "smoothNightCheck";
            this.smoothNightCheck.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.smoothNightCheck.Size = new System.Drawing.Size(90, 17);
            this.smoothNightCheck.TabIndex = 9;
            this.smoothNightCheck.Text = "Smooth Night";
            this.smoothNightCheck.UseVisualStyleBackColor = true;
            // 
            // nightCheck
            // 
            this.nightCheck.AutoSize = true;
            this.nightCheck.Location = new System.Drawing.Point(229, 142);
            this.nightCheck.Name = "nightCheck";
            this.nightCheck.Size = new System.Drawing.Size(51, 17);
            this.nightCheck.TabIndex = 8;
            this.nightCheck.Text = "Night";
            this.nightCheck.UseVisualStyleBackColor = true;
            // 
            // caveCheck
            // 
            this.caveCheck.AutoSize = true;
            this.caveCheck.Location = new System.Drawing.Point(120, 166);
            this.caveCheck.Name = "caveCheck";
            this.caveCheck.Size = new System.Drawing.Size(51, 17);
            this.caveCheck.TabIndex = 7;
            this.caveCheck.Text = "Cave";
            this.caveCheck.UseVisualStyleBackColor = true;
            // 
            // smoothLighingCheck
            // 
            this.smoothLighingCheck.AutoSize = true;
            this.smoothLighingCheck.Location = new System.Drawing.Point(120, 142);
            this.smoothLighingCheck.Name = "smoothLighingCheck";
            this.smoothLighingCheck.Size = new System.Drawing.Size(102, 17);
            this.smoothLighingCheck.TabIndex = 6;
            this.smoothLighingCheck.Text = "Smooth Lighting";
            this.smoothLighingCheck.UseVisualStyleBackColor = true;
            // 
            // lightingCheck
            // 
            this.lightingCheck.AutoSize = true;
            this.lightingCheck.Location = new System.Drawing.Point(12, 166);
            this.lightingCheck.Name = "lightingCheck";
            this.lightingCheck.Size = new System.Drawing.Size(63, 17);
            this.lightingCheck.TabIndex = 5;
            this.lightingCheck.Text = "Lighting";
            this.lightingCheck.UseVisualStyleBackColor = true;
            // 
            // normalCheck
            // 
            this.normalCheck.AutoSize = true;
            this.normalCheck.Checked = true;
            this.normalCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.normalCheck.Location = new System.Drawing.Point(12, 142);
            this.normalCheck.Name = "normalCheck";
            this.normalCheck.Size = new System.Drawing.Size(102, 17);
            this.normalCheck.TabIndex = 4;
            this.normalCheck.Text = "Normal (Default)";
            this.normalCheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "RenderModes";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.buttonLeveBrowse);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "World Folder";
            // 
            // buttonLeveBrowse
            // 
            this.buttonLeveBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeveBrowse.Location = new System.Drawing.Point(358, 19);
            this.buttonLeveBrowse.Name = "buttonLeveBrowse";
            this.buttonLeveBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonLeveBrowse.TabIndex = 1;
            this.buttonLeveBrowse.Text = "Browse";
            this.buttonLeveBrowse.UseVisualStyleBackColor = true;
            this.buttonLeveBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(346, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.linkLabel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(474, 204);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced Mode";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(15, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(453, 58);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Overviewer Config File";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(11, 21);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(355, 20);
            this.textBox4.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(23, 143);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(126, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "What\'s advanced mode?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // OVOutput
            // 
            this.OVOutput.Location = new System.Drawing.Point(12, 249);
            this.OVOutput.Multiline = true;
            this.OVOutput.Name = "OVOutput";
            this.OVOutput.ReadOnly = true;
            this.OVOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OVOutput.Size = new System.Drawing.Size(362, 215);
            this.OVOutput.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start Render";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // configDialog
            // 
            this.configDialog.Filter = "Python Files|*.py|All Files|*.*";
            // 
            // LevelDialog
            // 
            this.LevelDialog.Description = "Select the folder that the level.dat of your world resides in.";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(380, 426);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 38);
            this.button3.TabIndex = 5;
            this.button3.Text = "Got an error? CLICK THIS BUTTON";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 476);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OVOutput);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Overviewer GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDirBrowse;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.FolderBrowserDialog outputDir;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox OVOutput;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog configDialog;
        private System.Windows.Forms.FolderBrowserDialog LevelDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonLeveBrowse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox caveCheck;
        private System.Windows.Forms.CheckBox smoothLighingCheck;
        private System.Windows.Forms.CheckBox lightingCheck;
        private System.Windows.Forms.CheckBox normalCheck;
        private System.Windows.Forms.CheckBox smoothNightCheck;
        private System.Windows.Forms.CheckBox nightCheck;
        private System.Windows.Forms.Button button3;
    }
}

