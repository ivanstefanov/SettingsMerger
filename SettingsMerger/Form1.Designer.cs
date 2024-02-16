namespace SettingsMerger
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbxExportedSettingsFilePath = new TextBox();
            tbxLocalSettingsFilePath = new TextBox();
            btnBrowseExportedSettings = new Button();
            btnBrowseLocalSettings = new Button();
            openFileDialog1 = new OpenFileDialog();
            label4 = new Label();
            btnMerge = new Button();
            tbxOutput = new TextBox();
            label5 = new Label();
            rbLocalSettings = new RadioButton();
            rbAppSettings = new RadioButton();
            chkbOverrideSettingFile = new CheckBox();
            toolStrip1 = new ToolStrip();
            newToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            helpToolStripButton = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(12, 87);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Exported file path:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(12, 123);
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
            tbxExportedSettingsFilePath.Location = new Point(133, 84);
            tbxExportedSettingsFilePath.Name = "tbxExportedSettingsFilePath";
            tbxExportedSettingsFilePath.Size = new Size(291, 23);
            tbxExportedSettingsFilePath.TabIndex = 3;
            // 
            // tbxLocalSettingsFilePath
            // 
            tbxLocalSettingsFilePath.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxLocalSettingsFilePath.Location = new Point(133, 120);
            tbxLocalSettingsFilePath.Name = "tbxLocalSettingsFilePath";
            tbxLocalSettingsFilePath.Size = new Size(291, 23);
            tbxLocalSettingsFilePath.TabIndex = 4;
            // 
            // btnBrowseExportedSettings
            // 
            btnBrowseExportedSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowseExportedSettings.Location = new Point(430, 84);
            btnBrowseExportedSettings.Name = "btnBrowseExportedSettings";
            btnBrowseExportedSettings.Size = new Size(75, 23);
            btnBrowseExportedSettings.TabIndex = 5;
            btnBrowseExportedSettings.Text = "Browse";
            btnBrowseExportedSettings.UseVisualStyleBackColor = true;
            btnBrowseExportedSettings.Click += btnBrowseExportedSettings_Click;
            // 
            // btnBrowseLocalSettings
            // 
            btnBrowseLocalSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowseLocalSettings.Location = new Point(430, 120);
            btnBrowseLocalSettings.Name = "btnBrowseLocalSettings";
            btnBrowseLocalSettings.Size = new Size(75, 23);
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
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(12, 161);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 7;
            label4.Text = "Dev setting file type";
            // 
            // btnMerge
            // 
            btnMerge.BackColor = Color.LightCoral;
            btnMerge.ForeColor = SystemColors.ControlText;
            btnMerge.Location = new Point(227, 186);
            btnMerge.Name = "btnMerge";
            btnMerge.Size = new Size(75, 23);
            btnMerge.TabIndex = 9;
            btnMerge.Text = "Merge";
            btnMerge.UseVisualStyleBackColor = false;
            btnMerge.Click += btnMerge_Click;
            // 
            // tbxOutput
            // 
            tbxOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxOutput.Location = new Point(12, 215);
            tbxOutput.Multiline = true;
            tbxOutput.Name = "tbxOutput";
            tbxOutput.ScrollBars = ScrollBars.Both;
            tbxOutput.Size = new Size(505, 496);
            tbxOutput.TabIndex = 10;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(12, 197);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 11;
            label5.Text = "Output";
            // 
            // rbLocalSettings
            // 
            rbLocalSettings.AutoSize = true;
            rbLocalSettings.Location = new Point(250, 160);
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
            rbAppSettings.Location = new Point(133, 159);
            rbAppSettings.Name = "rbAppSettings";
            rbAppSettings.Size = new Size(111, 19);
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
            chkbOverrideSettingFile.Location = new Point(308, 189);
            chkbOverrideSettingFile.Name = "chkbOverrideSettingFile";
            chkbOverrideSettingFile.Size = new Size(153, 19);
            chkbOverrideSettingFile.TabIndex = 14;
            chkbOverrideSettingFile.Text = "Override Dev Setting file";
            chkbOverrideSettingFile.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { newToolStripButton, toolStripSeparator1, helpToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(529, 25);
            toolStrip1.TabIndex = 15;
            toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            newToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            newToolStripButton.Image = (Image)resources.GetObject("newToolStripButton.Image");
            newToolStripButton.ImageTransparentColor = Color.Magenta;
            newToolStripButton.Name = "newToolStripButton";
            newToolStripButton.Size = new Size(23, 22);
            newToolStripButton.Text = "&New";
            newToolStripButton.Click += newToolStripButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // helpToolStripButton
            // 
            helpToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            helpToolStripButton.Image = (Image)resources.GetObject("helpToolStripButton.Image");
            helpToolStripButton.ImageTransparentColor = Color.Magenta;
            helpToolStripButton.Name = "helpToolStripButton";
            helpToolStripButton.Size = new Size(23, 22);
            helpToolStripButton.Text = "He&lp";
            helpToolStripButton.Click += helpToolStripButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 723);
            Controls.Add(toolStrip1);
            Controls.Add(chkbOverrideSettingFile);
            Controls.Add(rbAppSettings);
            Controls.Add(rbLocalSettings);
            Controls.Add(label5);
            Controls.Add(tbxOutput);
            Controls.Add(btnMerge);
            Controls.Add(label4);
            Controls.Add(btnBrowseLocalSettings);
            Controls.Add(btnBrowseExportedSettings);
            Controls.Add(tbxLocalSettingsFilePath);
            Controls.Add(tbxExportedSettingsFilePath);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Settings Merger";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
        private Label label4;
        private Button btnMerge;
        private TextBox tbxOutput;
        private Label label5;
        private RadioButton rbLocalSettings;
        private RadioButton rbAppSettings;
        private CheckBox chkbOverrideSettingFile;
        private ToolStrip toolStrip1;
        private ToolStripButton newToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton helpToolStripButton;
    }
}
