﻿namespace SettingsMerger
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbxExportedSettingsFilePath = new TextBox();
            tbxLocalSettingsFilePath = new TextBox();
            btnBrowseExportedSettings = new Button();
            btnBrowseLocalSettings = new Button();
            openFileDialog1 = new OpenFileDialog();
            btnMerge = new Button();
            tbxOutput = new TextBox();
            rbLocalSettings = new RadioButton();
            rbAppSettings = new RadioButton();
            chkbOverrideSettingFile = new CheckBox();
            toolStrip1 = new ToolStrip();
            newToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            helpToolStripButton = new ToolStripButton();
            btnExportAzure = new Button();
            tcInput = new TabControl();
            tpAzure = new TabPage();
            lblWebApp = new Label();
            tbxWebAppName = new TextBox();
            lblResourceGroupName = new Label();
            tbxResourceGroupName = new TextBox();
            tpConfigFile = new TabPage();
            gbInput = new GroupBox();
            gbDestination = new GroupBox();
            groupBox1 = new GroupBox();
            gbOutput = new GroupBox();
            groupBox2 = new GroupBox();
            toolStrip1.SuspendLayout();
            tcInput.SuspendLayout();
            tpAzure.SuspendLayout();
            tpConfigFile.SuspendLayout();
            gbInput.SuspendLayout();
            gbDestination.SuspendLayout();
            groupBox1.SuspendLayout();
            gbOutput.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(8, 15);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Exported file path:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Margin = new Padding(3);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 1;
            label2.Text = "Dev setting file path:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 31);
            label3.Name = "label3";
            label3.Size = new Size(261, 45);
            label3.TabIndex = 2;
            label3.Text = "Settings Merger";
            // 
            // tbxExportedSettingsFilePath
            // 
            tbxExportedSettingsFilePath.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxExportedSettingsFilePath.Location = new Point(8, 33);
            tbxExportedSettingsFilePath.Name = "tbxExportedSettingsFilePath";
            tbxExportedSettingsFilePath.Size = new Size(415, 23);
            tbxExportedSettingsFilePath.TabIndex = 3;
            // 
            // tbxLocalSettingsFilePath
            // 
            tbxLocalSettingsFilePath.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxLocalSettingsFilePath.Location = new Point(6, 40);
            tbxLocalSettingsFilePath.Name = "tbxLocalSettingsFilePath";
            tbxLocalSettingsFilePath.Size = new Size(357, 23);
            tbxLocalSettingsFilePath.TabIndex = 4;
            // 
            // btnBrowseExportedSettings
            // 
            btnBrowseExportedSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowseExportedSettings.Location = new Point(429, 33);
            btnBrowseExportedSettings.Name = "btnBrowseExportedSettings";
            btnBrowseExportedSettings.Size = new Size(77, 23);
            btnBrowseExportedSettings.TabIndex = 5;
            btnBrowseExportedSettings.Text = "Browse";
            btnBrowseExportedSettings.UseVisualStyleBackColor = true;
            btnBrowseExportedSettings.Click += btnBrowseExportedSettings_Click;
            // 
            // btnBrowseLocalSettings
            // 
            btnBrowseLocalSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowseLocalSettings.Location = new Point(366, 40);
            btnBrowseLocalSettings.Name = "btnBrowseLocalSettings";
            btnBrowseLocalSettings.Size = new Size(74, 23);
            btnBrowseLocalSettings.TabIndex = 6;
            btnBrowseLocalSettings.Text = "Browse";
            btnBrowseLocalSettings.UseVisualStyleBackColor = true;
            btnBrowseLocalSettings.Click += btnBrowseLocalSettings_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.InitialDirectory = "C:\\";
            // 
            // btnMerge
            // 
            btnMerge.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMerge.BackColor = Color.LightCoral;
            btnMerge.ForeColor = SystemColors.ControlText;
            btnMerge.Location = new Point(6, 61);
            btnMerge.Name = "btnMerge";
            btnMerge.Size = new Size(102, 32);
            btnMerge.TabIndex = 9;
            btnMerge.Text = "Merge";
            btnMerge.UseVisualStyleBackColor = false;
            btnMerge.Click += btnMerge_Click;
            // 
            // tbxOutput
            // 
            tbxOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxOutput.Location = new Point(6, 22);
            tbxOutput.Multiline = true;
            tbxOutput.Name = "tbxOutput";
            tbxOutput.ScrollBars = ScrollBars.Both;
            tbxOutput.Size = new Size(1089, 473);
            tbxOutput.TabIndex = 10;
            // 
            // rbLocalSettings
            // 
            rbLocalSettings.AutoSize = true;
            rbLocalSettings.Location = new Point(7, 47);
            rbLocalSettings.Name = "rbLocalSettings";
            rbLocalSettings.Size = new Size(119, 19);
            rbLocalSettings.TabIndex = 12;
            rbLocalSettings.Text = "local.settings.json";
            rbLocalSettings.UseVisualStyleBackColor = true;
            // 
            // rbAppSettings
            // 
            rbAppSettings.AutoSize = true;
            rbAppSettings.Checked = true;
            rbAppSettings.Location = new Point(7, 22);
            rbAppSettings.Name = "rbAppSettings";
            rbAppSettings.Size = new Size(111, 19);
            rbAppSettings.TabIndex = 13;
            rbAppSettings.TabStop = true;
            rbAppSettings.Text = "appsettings.json";
            rbAppSettings.UseVisualStyleBackColor = true;
            // 
            // chkbOverrideSettingFile
            // 
            chkbOverrideSettingFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            chkbOverrideSettingFile.AutoSize = true;
            chkbOverrideSettingFile.Checked = true;
            chkbOverrideSettingFile.CheckState = CheckState.Checked;
            chkbOverrideSettingFile.Location = new Point(212, 74);
            chkbOverrideSettingFile.Name = "chkbOverrideSettingFile";
            chkbOverrideSettingFile.Size = new Size(153, 19);
            chkbOverrideSettingFile.TabIndex = 14;
            chkbOverrideSettingFile.Text = "Override Destination file";
            chkbOverrideSettingFile.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { newToolStripButton, toolStripSeparator1, helpToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1139, 27);
            toolStrip1.TabIndex = 15;
            toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            newToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            newToolStripButton.Image = (Image)resources.GetObject("newToolStripButton.Image");
            newToolStripButton.ImageTransparentColor = Color.Magenta;
            newToolStripButton.Name = "newToolStripButton";
            newToolStripButton.Size = new Size(24, 24);
            newToolStripButton.Text = "&New";
            newToolStripButton.Click += newToolStripButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // helpToolStripButton
            // 
            helpToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            helpToolStripButton.Image = (Image)resources.GetObject("helpToolStripButton.Image");
            helpToolStripButton.ImageTransparentColor = Color.Magenta;
            helpToolStripButton.Name = "helpToolStripButton";
            helpToolStripButton.Size = new Size(24, 24);
            helpToolStripButton.Text = "He&lp";
            helpToolStripButton.Click += helpToolStripButton_Click;
            // 
            // btnExportAzure
            // 
            btnExportAzure.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportAzure.Location = new Point(419, 21);
            btnExportAzure.Name = "btnExportAzure";
            btnExportAzure.Size = new Size(85, 68);
            btnExportAzure.TabIndex = 16;
            btnExportAzure.Text = "Get Azure Settings";
            btnExportAzure.UseVisualStyleBackColor = true;
            btnExportAzure.Click += btnLogin_Click;
            // 
            // tcInput
            // 
            tcInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tcInput.Controls.Add(tpAzure);
            tcInput.Controls.Add(tpConfigFile);
            tcInput.Location = new Point(6, 21);
            tcInput.Name = "tcInput";
            tcInput.SelectedIndex = 0;
            tcInput.Size = new Size(518, 124);
            tcInput.TabIndex = 17;
            tcInput.SelectedIndexChanged += tcInput_SelectedIndexChanged;
            // 
            // tpAzure
            // 
            tpAzure.Controls.Add(lblWebApp);
            tpAzure.Controls.Add(tbxWebAppName);
            tpAzure.Controls.Add(lblResourceGroupName);
            tpAzure.Controls.Add(tbxResourceGroupName);
            tpAzure.Controls.Add(btnExportAzure);
            tpAzure.Location = new Point(4, 24);
            tpAzure.Name = "tpAzure";
            tpAzure.Padding = new Padding(3);
            tpAzure.Size = new Size(510, 96);
            tpAzure.TabIndex = 0;
            tpAzure.Text = "Azure";
            tpAzure.UseVisualStyleBackColor = true;
            // 
            // lblWebApp
            // 
            lblWebApp.AutoSize = true;
            lblWebApp.Location = new Point(6, 48);
            lblWebApp.Name = "lblWebApp";
            lblWebApp.Size = new Size(89, 15);
            lblWebApp.TabIndex = 20;
            lblWebApp.Text = "Web App name";
            // 
            // tbxWebAppName
            // 
            tbxWebAppName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbxWebAppName.Location = new Point(6, 66);
            tbxWebAppName.Name = "tbxWebAppName";
            tbxWebAppName.Size = new Size(408, 23);
            tbxWebAppName.TabIndex = 19;
            // 
            // lblResourceGroupName
            // 
            lblResourceGroupName.AutoSize = true;
            lblResourceGroupName.Location = new Point(6, 3);
            lblResourceGroupName.Name = "lblResourceGroupName";
            lblResourceGroupName.Size = new Size(124, 15);
            lblResourceGroupName.TabIndex = 18;
            lblResourceGroupName.Text = "Resource Group name";
            // 
            // tbxResourceGroupName
            // 
            tbxResourceGroupName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbxResourceGroupName.Location = new Point(6, 21);
            tbxResourceGroupName.Name = "tbxResourceGroupName";
            tbxResourceGroupName.Size = new Size(408, 23);
            tbxResourceGroupName.TabIndex = 17;
            // 
            // tpConfigFile
            // 
            tpConfigFile.Controls.Add(label1);
            tpConfigFile.Controls.Add(tbxExportedSettingsFilePath);
            tpConfigFile.Controls.Add(btnBrowseExportedSettings);
            tpConfigFile.Location = new Point(4, 24);
            tpConfigFile.Name = "tpConfigFile";
            tpConfigFile.Padding = new Padding(3);
            tpConfigFile.Size = new Size(510, 96);
            tpConfigFile.TabIndex = 1;
            tpConfigFile.Text = "Exported Setting File";
            tpConfigFile.UseVisualStyleBackColor = true;
            // 
            // gbInput
            // 
            gbInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbInput.Controls.Add(tcInput);
            gbInput.Location = new Point(12, 79);
            gbInput.Name = "gbInput";
            gbInput.Size = new Size(530, 150);
            gbInput.TabIndex = 18;
            gbInput.TabStop = false;
            gbInput.Text = "Settings Source";
            // 
            // gbDestination
            // 
            gbDestination.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gbDestination.Controls.Add(groupBox1);
            gbDestination.Controls.Add(label2);
            gbDestination.Controls.Add(tbxLocalSettingsFilePath);
            gbDestination.Controls.Add(chkbOverrideSettingFile);
            gbDestination.Controls.Add(btnBrowseLocalSettings);
            gbDestination.Location = new Point(559, 79);
            gbDestination.Name = "gbDestination";
            gbDestination.Size = new Size(448, 150);
            gbDestination.TabIndex = 19;
            gbDestination.TabStop = false;
            gbDestination.Text = "Destination File";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbAppSettings);
            groupBox1.Controls.Add(rbLocalSettings);
            groupBox1.Location = new Point(6, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 73);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dev setting file type";
            // 
            // gbOutput
            // 
            gbOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbOutput.Controls.Add(tbxOutput);
            gbOutput.Location = new Point(14, 235);
            gbOutput.Name = "gbOutput";
            gbOutput.Size = new Size(1101, 501);
            gbOutput.TabIndex = 20;
            gbOutput.TabStop = false;
            gbOutput.Text = "Output";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnMerge);
            groupBox2.Location = new Point(1013, 79);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(114, 150);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Final Step";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 742);
            Controls.Add(groupBox2);
            Controls.Add(gbOutput);
            Controls.Add(gbDestination);
            Controls.Add(gbInput);
            Controls.Add(toolStrip1);
            Controls.Add(label3);
            Name = "MainForm";
            Text = "Settings Merger";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tcInput.ResumeLayout(false);
            tpAzure.ResumeLayout(false);
            tpAzure.PerformLayout();
            tpConfigFile.ResumeLayout(false);
            tpConfigFile.PerformLayout();
            gbInput.ResumeLayout(false);
            gbDestination.ResumeLayout(false);
            gbDestination.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbOutput.ResumeLayout(false);
            gbOutput.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbxExportedSettingsFilePath;
        private TextBox tbxLocalSettingsFilePath;
        private Button btnBrowseExportedSettings;
        private Button btnBrowseLocalSettings;
        private OpenFileDialog openFileDialog1;
        private Button btnMerge;
        private TextBox tbxOutput;
        private RadioButton rbLocalSettings;
        private RadioButton rbAppSettings;
        private CheckBox chkbOverrideSettingFile;
        private ToolStrip toolStrip1;
        private ToolStripButton newToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton helpToolStripButton;
        private Button btnExportAzure;
        private TabControl tcInput;
        private TabPage tpAzure;
        private TabPage tpConfigFile;
        private GroupBox gbInput;
        private GroupBox gbDestination;
        private Label lblWebApp;
        private TextBox tbxWebAppName;
        private Label lblResourceGroupName;
        private TextBox tbxResourceGroupName;
        private GroupBox gbOutput;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
