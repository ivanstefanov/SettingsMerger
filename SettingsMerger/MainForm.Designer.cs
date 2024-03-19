namespace SettingsMerger
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
            toolStrip1.SuspendLayout();
            tcInput.SuspendLayout();
            tpAzure.SuspendLayout();
            tpConfigFile.SuspendLayout();
            gbInput.SuspendLayout();
            gbDestination.SuspendLayout();
            groupBox1.SuspendLayout();
            gbOutput.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(9, 20);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 0;
            label1.Text = "Exported file path:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(7, 25);
            label2.Margin = new Padding(3, 4, 3, 4);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 1;
            label2.Text = "Dev setting file path:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 41);
            label3.Name = "label3";
            label3.Size = new Size(327, 54);
            label3.TabIndex = 2;
            label3.Text = "Settings Merger";
            // 
            // tbxExportedSettingsFilePath
            // 
            tbxExportedSettingsFilePath.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxExportedSettingsFilePath.Location = new Point(9, 44);
            tbxExportedSettingsFilePath.Margin = new Padding(3, 4, 3, 4);
            tbxExportedSettingsFilePath.Name = "tbxExportedSettingsFilePath";
            tbxExportedSettingsFilePath.Size = new Size(474, 27);
            tbxExportedSettingsFilePath.TabIndex = 3;
            // 
            // tbxLocalSettingsFilePath
            // 
            tbxLocalSettingsFilePath.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxLocalSettingsFilePath.Location = new Point(7, 53);
            tbxLocalSettingsFilePath.Margin = new Padding(3, 4, 3, 4);
            tbxLocalSettingsFilePath.Name = "tbxLocalSettingsFilePath";
            tbxLocalSettingsFilePath.Size = new Size(407, 27);
            tbxLocalSettingsFilePath.TabIndex = 4;
            // 
            // btnBrowseExportedSettings
            // 
            btnBrowseExportedSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowseExportedSettings.Location = new Point(490, 44);
            btnBrowseExportedSettings.Margin = new Padding(3, 4, 3, 4);
            btnBrowseExportedSettings.Name = "btnBrowseExportedSettings";
            btnBrowseExportedSettings.Size = new Size(88, 27);
            btnBrowseExportedSettings.TabIndex = 5;
            btnBrowseExportedSettings.Text = "Browse";
            btnBrowseExportedSettings.UseVisualStyleBackColor = true;
            btnBrowseExportedSettings.Click += btnBrowseExportedSettings_Click;
            // 
            // btnBrowseLocalSettings
            // 
            btnBrowseLocalSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowseLocalSettings.Location = new Point(418, 53);
            btnBrowseLocalSettings.Margin = new Padding(3, 4, 3, 4);
            btnBrowseLocalSettings.Name = "btnBrowseLocalSettings";
            btnBrowseLocalSettings.Size = new Size(84, 28);
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
            btnMerge.Location = new Point(1157, 162);
            btnMerge.Margin = new Padding(3, 4, 3, 4);
            btnMerge.Name = "btnMerge";
            btnMerge.Size = new Size(133, 66);
            btnMerge.TabIndex = 9;
            btnMerge.Text = "Merge";
            btnMerge.UseVisualStyleBackColor = false;
            btnMerge.Click += btnMerge_Click;
            // 
            // tbxOutput
            // 
            tbxOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxOutput.Location = new Point(7, 29);
            tbxOutput.Margin = new Padding(3, 4, 3, 4);
            tbxOutput.Multiline = true;
            tbxOutput.Name = "tbxOutput";
            tbxOutput.ScrollBars = ScrollBars.Both;
            tbxOutput.Size = new Size(1244, 629);
            tbxOutput.TabIndex = 10;
            // 
            // rbLocalSettings
            // 
            rbLocalSettings.AutoSize = true;
            rbLocalSettings.Location = new Point(8, 63);
            rbLocalSettings.Margin = new Padding(3, 4, 3, 4);
            rbLocalSettings.Name = "rbLocalSettings";
            rbLocalSettings.Size = new Size(146, 24);
            rbLocalSettings.TabIndex = 12;
            rbLocalSettings.Text = "local.settings.json";
            rbLocalSettings.UseVisualStyleBackColor = true;
            // 
            // rbAppSettings
            // 
            rbAppSettings.AutoSize = true;
            rbAppSettings.Checked = true;
            rbAppSettings.Location = new Point(8, 29);
            rbAppSettings.Margin = new Padding(3, 4, 3, 4);
            rbAppSettings.Name = "rbAppSettings";
            rbAppSettings.Size = new Size(137, 24);
            rbAppSettings.TabIndex = 13;
            rbAppSettings.TabStop = true;
            rbAppSettings.Text = "appsettings.json";
            rbAppSettings.UseVisualStyleBackColor = true;
            // 
            // chkbOverrideSettingFile
            // 
            chkbOverrideSettingFile.AutoSize = true;
            chkbOverrideSettingFile.Checked = true;
            chkbOverrideSettingFile.CheckState = CheckState.Checked;
            chkbOverrideSettingFile.Location = new Point(253, 92);
            chkbOverrideSettingFile.Margin = new Padding(3, 4, 3, 4);
            chkbOverrideSettingFile.Name = "chkbOverrideSettingFile";
            chkbOverrideSettingFile.Size = new Size(193, 24);
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
            toolStrip1.Size = new Size(1302, 27);
            toolStrip1.TabIndex = 15;
            toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            newToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            newToolStripButton.Image = (Image)resources.GetObject("newToolStripButton.Image");
            newToolStripButton.ImageTransparentColor = Color.Magenta;
            newToolStripButton.Name = "newToolStripButton";
            newToolStripButton.Size = new Size(29, 24);
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
            helpToolStripButton.Size = new Size(29, 24);
            helpToolStripButton.Text = "He&lp";
            helpToolStripButton.Click += helpToolStripButton_Click;
            // 
            // btnExportAzure
            // 
            btnExportAzure.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportAzure.Location = new Point(479, 28);
            btnExportAzure.Margin = new Padding(3, 4, 3, 4);
            btnExportAzure.Name = "btnExportAzure";
            btnExportAzure.Size = new Size(97, 91);
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
            tcInput.Location = new Point(7, 28);
            tcInput.Margin = new Padding(3, 4, 3, 4);
            tcInput.Name = "tcInput";
            tcInput.SelectedIndex = 0;
            tcInput.Size = new Size(592, 165);
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
            tpAzure.Location = new Point(4, 29);
            tpAzure.Margin = new Padding(3, 4, 3, 4);
            tpAzure.Name = "tpAzure";
            tpAzure.Padding = new Padding(3, 4, 3, 4);
            tpAzure.Size = new Size(584, 132);
            tpAzure.TabIndex = 0;
            tpAzure.Text = "Azure";
            tpAzure.UseVisualStyleBackColor = true;
            // 
            // lblWebApp
            // 
            lblWebApp.AutoSize = true;
            lblWebApp.Location = new Point(7, 64);
            lblWebApp.Name = "lblWebApp";
            lblWebApp.Size = new Size(112, 20);
            lblWebApp.TabIndex = 20;
            lblWebApp.Text = "Web App name";
            // 
            // tbxWebAppName
            // 
            tbxWebAppName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbxWebAppName.Location = new Point(7, 88);
            tbxWebAppName.Margin = new Padding(3, 4, 3, 4);
            tbxWebAppName.Name = "tbxWebAppName";
            tbxWebAppName.Size = new Size(466, 27);
            tbxWebAppName.TabIndex = 19;
            // 
            // lblResourceGroupName
            // 
            lblResourceGroupName.AutoSize = true;
            lblResourceGroupName.Location = new Point(7, 4);
            lblResourceGroupName.Name = "lblResourceGroupName";
            lblResourceGroupName.Size = new Size(155, 20);
            lblResourceGroupName.TabIndex = 18;
            lblResourceGroupName.Text = "Resource Group name";
            // 
            // tbxResourceGroupName
            // 
            tbxResourceGroupName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbxResourceGroupName.Location = new Point(7, 28);
            tbxResourceGroupName.Margin = new Padding(3, 4, 3, 4);
            tbxResourceGroupName.Name = "tbxResourceGroupName";
            tbxResourceGroupName.Size = new Size(466, 27);
            tbxResourceGroupName.TabIndex = 17;
            // 
            // tpConfigFile
            // 
            tpConfigFile.Controls.Add(label1);
            tpConfigFile.Controls.Add(tbxExportedSettingsFilePath);
            tpConfigFile.Controls.Add(btnBrowseExportedSettings);
            tpConfigFile.Location = new Point(4, 29);
            tpConfigFile.Margin = new Padding(3, 4, 3, 4);
            tpConfigFile.Name = "tpConfigFile";
            tpConfigFile.Padding = new Padding(3, 4, 3, 4);
            tpConfigFile.Size = new Size(584, 132);
            tpConfigFile.TabIndex = 1;
            tpConfigFile.Text = "Exported Setting File";
            tpConfigFile.UseVisualStyleBackColor = true;
            // 
            // gbInput
            // 
            gbInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbInput.Controls.Add(tcInput);
            gbInput.Location = new Point(14, 105);
            gbInput.Margin = new Padding(3, 4, 3, 4);
            gbInput.Name = "gbInput";
            gbInput.Padding = new Padding(3, 4, 3, 4);
            gbInput.Size = new Size(606, 200);
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
            gbDestination.Location = new Point(639, 105);
            gbDestination.Margin = new Padding(3, 4, 3, 4);
            gbDestination.Name = "gbDestination";
            gbDestination.Padding = new Padding(3, 4, 3, 4);
            gbDestination.Size = new Size(512, 200);
            gbDestination.TabIndex = 19;
            gbDestination.TabStop = false;
            gbDestination.Text = "Destination File";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbAppSettings);
            groupBox1.Controls.Add(rbLocalSettings);
            groupBox1.Location = new Point(7, 91);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(229, 97);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dev setting file type";
            // 
            // gbOutput
            // 
            gbOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbOutput.Controls.Add(tbxOutput);
            gbOutput.Location = new Point(16, 313);
            gbOutput.Margin = new Padding(3, 4, 3, 4);
            gbOutput.Name = "gbOutput";
            gbOutput.Padding = new Padding(3, 4, 3, 4);
            gbOutput.Size = new Size(1258, 668);
            gbOutput.TabIndex = 20;
            gbOutput.TabStop = false;
            gbOutput.Text = "Output";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 989);
            Controls.Add(gbOutput);
            Controls.Add(gbDestination);
            Controls.Add(gbInput);
            Controls.Add(toolStrip1);
            Controls.Add(btnMerge);
            Controls.Add(label3);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}
