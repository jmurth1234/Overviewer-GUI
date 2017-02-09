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
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.buttonDirBrowse = new System.Windows.Forms.Button();
            this.outputFolder = new System.Windows.Forms.TextBox();
            this.outputDir = new System.Windows.Forms.FolderBrowserDialog();
            this.tabSimpleAdvanced = new System.Windows.Forms.TabControl();
            this.simpleModeTab = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.worldNameBox = new System.Windows.Forms.TextBox();
            this.smoothNightCheck = new System.Windows.Forms.CheckBox();
            this.nightCheck = new System.Windows.Forms.CheckBox();
            this.caveCheck = new System.Windows.Forms.CheckBox();
            this.smoothLighingCheck = new System.Windows.Forms.CheckBox();
            this.lightingCheck = new System.Windows.Forms.CheckBox();
            this.normalCheck = new System.Windows.Forms.CheckBox();
            this.renderModesLabel = new System.Windows.Forms.Label();
            this.worldGroupBox = new System.Windows.Forms.GroupBox();
            this.buttonLeveBrowse = new System.Windows.Forms.Button();
            this.worldFolder = new System.Windows.Forms.TextBox();
            this.advancedModeTab = new System.Windows.Forms.TabPage();
            this.configGroupBox = new System.Windows.Forms.GroupBox();
            this.configTextBox = new System.Windows.Forms.TextBox();
            this.configButton = new System.Windows.Forms.Button();
            this.advancedModeHelp = new System.Windows.Forms.LinkLabel();
            this.OVOutput = new System.Windows.Forms.TextBox();
            this.startRender = new System.Windows.Forms.Button();
            this.configDialog = new System.Windows.Forms.OpenFileDialog();
            this.LevelDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.errorButton = new System.Windows.Forms.Button();
            this.renderProgress = new System.Windows.Forms.ProgressBar();
            this.statusLabel = new System.Windows.Forms.Label();
            this.expandCollapseButton = new System.Windows.Forms.Button();
            this.outputGroupBox.SuspendLayout();
            this.tabSimpleAdvanced.SuspendLayout();
            this.simpleModeTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.worldGroupBox.SuspendLayout();
            this.advancedModeTab.SuspendLayout();
            this.configGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Controls.Add(this.buttonDirBrowse);
            this.outputGroupBox.Controls.Add(this.outputFolder);
            this.outputGroupBox.Location = new System.Drawing.Point(6, 125);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Size = new System.Drawing.Size(462, 56);
            this.outputGroupBox.TabIndex = 1;
            this.outputGroupBox.TabStop = false;
            this.outputGroupBox.Text = "Output folder";
            // 
            // buttonDirBrowse
            // 
            this.buttonDirBrowse.Location = new System.Drawing.Point(381, 19);
            this.buttonDirBrowse.Name = "buttonDirBrowse";
            this.buttonDirBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonDirBrowse.TabIndex = 1;
            this.buttonDirBrowse.Text = "Browse";
            this.buttonDirBrowse.UseVisualStyleBackColor = true;
            this.buttonDirBrowse.Click += new System.EventHandler(this.buttonDirBrowse_Click);
            // 
            // outputFolder
            // 
            this.outputFolder.Location = new System.Drawing.Point(6, 19);
            this.outputFolder.Name = "outputFolder";
            this.outputFolder.ReadOnly = true;
            this.outputFolder.Size = new System.Drawing.Size(369, 20);
            this.outputFolder.TabIndex = 0;
            // 
            // outputDir
            // 
            this.outputDir.Description = "Select where the Overviewer will save the html files and render to";
            // 
            // tabSimpleAdvanced
            // 
            this.tabSimpleAdvanced.Controls.Add(this.simpleModeTab);
            this.tabSimpleAdvanced.Controls.Add(this.advancedModeTab);
            this.tabSimpleAdvanced.Location = new System.Drawing.Point(12, 13);
            this.tabSimpleAdvanced.Name = "tabSimpleAdvanced";
            this.tabSimpleAdvanced.SelectedIndex = 0;
            this.tabSimpleAdvanced.Size = new System.Drawing.Size(482, 281);
            this.tabSimpleAdvanced.TabIndex = 2;
            // 
            // simpleModeTab
            // 
            this.simpleModeTab.Controls.Add(this.groupBox3);
            this.simpleModeTab.Controls.Add(this.smoothNightCheck);
            this.simpleModeTab.Controls.Add(this.nightCheck);
            this.simpleModeTab.Controls.Add(this.caveCheck);
            this.simpleModeTab.Controls.Add(this.smoothLighingCheck);
            this.simpleModeTab.Controls.Add(this.lightingCheck);
            this.simpleModeTab.Controls.Add(this.normalCheck);
            this.simpleModeTab.Controls.Add(this.renderModesLabel);
            this.simpleModeTab.Controls.Add(this.worldGroupBox);
            this.simpleModeTab.Controls.Add(this.outputGroupBox);
            this.simpleModeTab.Location = new System.Drawing.Point(4, 22);
            this.simpleModeTab.Name = "simpleModeTab";
            this.simpleModeTab.Padding = new System.Windows.Forms.Padding(3);
            this.simpleModeTab.Size = new System.Drawing.Size(474, 255);
            this.simpleModeTab.TabIndex = 0;
            this.simpleModeTab.Text = "Simple Mode";
            this.simpleModeTab.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.worldNameBox);
            this.groupBox3.Location = new System.Drawing.Point(6, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(462, 51);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "World Name";
            // 
            // worldNameBox
            // 
            this.worldNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.worldNameBox.BackColor = System.Drawing.SystemColors.Control;
            this.worldNameBox.Location = new System.Drawing.Point(6, 19);
            this.worldNameBox.Name = "worldNameBox";
            this.worldNameBox.Size = new System.Drawing.Size(450, 20);
            this.worldNameBox.TabIndex = 0;
            this.worldNameBox.TextChanged += new System.EventHandler(this.worldNameBox_TextChanged);
            // 
            // smoothNightCheck
            // 
            this.smoothNightCheck.AutoSize = true;
            this.smoothNightCheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.smoothNightCheck.Location = new System.Drawing.Point(226, 228);
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
            this.nightCheck.Location = new System.Drawing.Point(226, 204);
            this.nightCheck.Name = "nightCheck";
            this.nightCheck.Size = new System.Drawing.Size(51, 17);
            this.nightCheck.TabIndex = 8;
            this.nightCheck.Text = "Night";
            this.nightCheck.UseVisualStyleBackColor = true;
            // 
            // caveCheck
            // 
            this.caveCheck.AutoSize = true;
            this.caveCheck.Location = new System.Drawing.Point(117, 228);
            this.caveCheck.Name = "caveCheck";
            this.caveCheck.Size = new System.Drawing.Size(51, 17);
            this.caveCheck.TabIndex = 7;
            this.caveCheck.Text = "Cave";
            this.caveCheck.UseVisualStyleBackColor = true;
            // 
            // smoothLighingCheck
            // 
            this.smoothLighingCheck.AutoSize = true;
            this.smoothLighingCheck.Location = new System.Drawing.Point(117, 204);
            this.smoothLighingCheck.Name = "smoothLighingCheck";
            this.smoothLighingCheck.Size = new System.Drawing.Size(102, 17);
            this.smoothLighingCheck.TabIndex = 6;
            this.smoothLighingCheck.Text = "Smooth Lighting";
            this.smoothLighingCheck.UseVisualStyleBackColor = true;
            // 
            // lightingCheck
            // 
            this.lightingCheck.AutoSize = true;
            this.lightingCheck.Location = new System.Drawing.Point(9, 228);
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
            this.normalCheck.Location = new System.Drawing.Point(9, 204);
            this.normalCheck.Name = "normalCheck";
            this.normalCheck.Size = new System.Drawing.Size(102, 17);
            this.normalCheck.TabIndex = 4;
            this.normalCheck.Text = "Normal (Default)";
            this.normalCheck.UseVisualStyleBackColor = true;
            // 
            // renderModesLabel
            // 
            this.renderModesLabel.AutoSize = true;
            this.renderModesLabel.Location = new System.Drawing.Point(6, 187);
            this.renderModesLabel.Name = "renderModesLabel";
            this.renderModesLabel.Size = new System.Drawing.Size(77, 13);
            this.renderModesLabel.TabIndex = 3;
            this.renderModesLabel.Text = "Render Modes";
            // 
            // worldGroupBox
            // 
            this.worldGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.worldGroupBox.Controls.Add(this.buttonLeveBrowse);
            this.worldGroupBox.Controls.Add(this.worldFolder);
            this.worldGroupBox.Location = new System.Drawing.Point(6, 68);
            this.worldGroupBox.Name = "worldGroupBox";
            this.worldGroupBox.Size = new System.Drawing.Size(462, 51);
            this.worldGroupBox.TabIndex = 0;
            this.worldGroupBox.TabStop = false;
            this.worldGroupBox.Text = "World Folder";
            // 
            // buttonLeveBrowse
            // 
            this.buttonLeveBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeveBrowse.Location = new System.Drawing.Point(381, 19);
            this.buttonLeveBrowse.Name = "buttonLeveBrowse";
            this.buttonLeveBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonLeveBrowse.TabIndex = 1;
            this.buttonLeveBrowse.Text = "Browse";
            this.buttonLeveBrowse.UseVisualStyleBackColor = true;
            this.buttonLeveBrowse.Click += new System.EventHandler(this.buttonLevelBrowse_Click);
            // 
            // worldFolder
            // 
            this.worldFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.worldFolder.BackColor = System.Drawing.SystemColors.Control;
            this.worldFolder.Location = new System.Drawing.Point(6, 19);
            this.worldFolder.Name = "worldFolder";
            this.worldFolder.ReadOnly = true;
            this.worldFolder.Size = new System.Drawing.Size(369, 20);
            this.worldFolder.TabIndex = 0;
            // 
            // advancedModeTab
            // 
            this.advancedModeTab.Controls.Add(this.configGroupBox);
            this.advancedModeTab.Controls.Add(this.advancedModeHelp);
            this.advancedModeTab.Location = new System.Drawing.Point(4, 22);
            this.advancedModeTab.Name = "advancedModeTab";
            this.advancedModeTab.Padding = new System.Windows.Forms.Padding(3);
            this.advancedModeTab.Size = new System.Drawing.Size(474, 255);
            this.advancedModeTab.TabIndex = 1;
            this.advancedModeTab.Text = "Advanced Mode";
            this.advancedModeTab.UseVisualStyleBackColor = true;
            // 
            // configGroupBox
            // 
            this.configGroupBox.Controls.Add(this.configTextBox);
            this.configGroupBox.Controls.Add(this.configButton);
            this.configGroupBox.Location = new System.Drawing.Point(15, 13);
            this.configGroupBox.Name = "configGroupBox";
            this.configGroupBox.Size = new System.Drawing.Size(453, 58);
            this.configGroupBox.TabIndex = 1;
            this.configGroupBox.TabStop = false;
            this.configGroupBox.Text = "Overviewer Config File";
            // 
            // configTextBox
            // 
            this.configTextBox.Location = new System.Drawing.Point(11, 21);
            this.configTextBox.Name = "configTextBox";
            this.configTextBox.ReadOnly = true;
            this.configTextBox.Size = new System.Drawing.Size(355, 20);
            this.configTextBox.TabIndex = 1;
            // 
            // configButton
            // 
            this.configButton.Location = new System.Drawing.Point(372, 19);
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(75, 23);
            this.configButton.TabIndex = 0;
            this.configButton.Text = "Browse";
            this.configButton.UseVisualStyleBackColor = true;
            this.configButton.Click += new System.EventHandler(this.configButton_Click_1);
            // 
            // advancedModeHelp
            // 
            this.advancedModeHelp.AutoSize = true;
            this.advancedModeHelp.Location = new System.Drawing.Point(23, 143);
            this.advancedModeHelp.Name = "advancedModeHelp";
            this.advancedModeHelp.Size = new System.Drawing.Size(126, 13);
            this.advancedModeHelp.TabIndex = 0;
            this.advancedModeHelp.TabStop = true;
            this.advancedModeHelp.Text = "What\'s advanced mode?";
            this.advancedModeHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.advancedModeHelp_LinkClicked);
            // 
            // OVOutput
            // 
            this.OVOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.OVOutput.BackColor = System.Drawing.Color.Black;
            this.OVOutput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OVOutput.ForeColor = System.Drawing.Color.White;
            this.OVOutput.Location = new System.Drawing.Point(12, 338);
            this.OVOutput.Multiline = true;
            this.OVOutput.Name = "OVOutput";
            this.OVOutput.ReadOnly = true;
            this.OVOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OVOutput.Size = new System.Drawing.Size(482, 0);
            this.OVOutput.TabIndex = 3;
            // 
            // startRender
            // 
            this.startRender.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startRender.Location = new System.Drawing.Point(417, 313);
            this.startRender.Name = "startRender";
            this.startRender.Size = new System.Drawing.Size(77, 23);
            this.startRender.TabIndex = 4;
            this.startRender.Text = "Start Render";
            this.startRender.UseVisualStyleBackColor = true;
            this.startRender.Click += new System.EventHandler(this.startRender_Click_1);
            // 
            // configDialog
            // 
            this.configDialog.Filter = "Python Files|*.py|All Files|*.*";
            // 
            // LevelDialog
            // 
            this.LevelDialog.Description = "Select the folder that the level.dat of your world resides in.";
            // 
            // errorButton
            // 
            this.errorButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.errorButton.Location = new System.Drawing.Point(12, 342);
            this.errorButton.Name = "errorButton";
            this.errorButton.Size = new System.Drawing.Size(83, 23);
            this.errorButton.TabIndex = 5;
            this.errorButton.Text = "Report Error";
            this.errorButton.UseVisualStyleBackColor = true;
            this.errorButton.Click += new System.EventHandler(this.reportError_Click);
            // 
            // renderProgress
            // 
            this.renderProgress.Location = new System.Drawing.Point(12, 313);
            this.renderProgress.Name = "renderProgress";
            this.renderProgress.Size = new System.Drawing.Size(393, 23);
            this.renderProgress.TabIndex = 6;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(9, 297);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(84, 13);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "Render Status...";
            // 
            // expandCollapseButton
            // 
            this.expandCollapseButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.expandCollapseButton.Location = new System.Drawing.Point(411, 342);
            this.expandCollapseButton.Name = "expandCollapseButton";
            this.expandCollapseButton.Size = new System.Drawing.Size(83, 23);
            this.expandCollapseButton.TabIndex = 8;
            this.expandCollapseButton.Text = "Expand";
            this.expandCollapseButton.UseVisualStyleBackColor = true;
            this.expandCollapseButton.Click += new System.EventHandler(this.expandCollapseButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 377);
            this.Controls.Add(this.expandCollapseButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.renderProgress);
            this.Controls.Add(this.errorButton);
            this.Controls.Add(this.startRender);
            this.Controls.Add(this.OVOutput);
            this.Controls.Add(this.tabSimpleAdvanced);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Overviewer GUI";
            this.Load += new System.EventHandler(this.MainWindow_LoadAsync);
            this.outputGroupBox.ResumeLayout(false);
            this.outputGroupBox.PerformLayout();
            this.tabSimpleAdvanced.ResumeLayout(false);
            this.simpleModeTab.ResumeLayout(false);
            this.simpleModeTab.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.worldGroupBox.ResumeLayout(false);
            this.worldGroupBox.PerformLayout();
            this.advancedModeTab.ResumeLayout(false);
            this.advancedModeTab.PerformLayout();
            this.configGroupBox.ResumeLayout(false);
            this.configGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.Windows.Forms.Button buttonDirBrowse;
        private System.Windows.Forms.TextBox outputFolder;
        private System.Windows.Forms.FolderBrowserDialog outputDir;
        private System.Windows.Forms.TabControl tabSimpleAdvanced;
        private System.Windows.Forms.TabPage simpleModeTab;
        private System.Windows.Forms.TabPage advancedModeTab;
        private System.Windows.Forms.LinkLabel advancedModeHelp;
        private System.Windows.Forms.Button startRender;
        private System.Windows.Forms.TextBox OVOutput;
        private System.Windows.Forms.GroupBox configGroupBox;
        private System.Windows.Forms.TextBox configTextBox;
        private System.Windows.Forms.Button configButton;
        private System.Windows.Forms.OpenFileDialog configDialog;
        private System.Windows.Forms.FolderBrowserDialog LevelDialog;
        private System.Windows.Forms.GroupBox worldGroupBox;
        private System.Windows.Forms.Button buttonLeveBrowse;
        private System.Windows.Forms.TextBox worldFolder;
        private System.Windows.Forms.Label renderModesLabel;
        private System.Windows.Forms.CheckBox caveCheck;
        private System.Windows.Forms.CheckBox smoothLighingCheck;
        private System.Windows.Forms.CheckBox lightingCheck;
        private System.Windows.Forms.CheckBox normalCheck;
        private System.Windows.Forms.CheckBox smoothNightCheck;
        private System.Windows.Forms.CheckBox nightCheck;
        private System.Windows.Forms.Button errorButton;
        private System.Windows.Forms.ProgressBar renderProgress;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button expandCollapseButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox worldNameBox;
    }
}

