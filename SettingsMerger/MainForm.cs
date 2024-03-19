using System.Diagnostics;

using Azure.Identity;

using SettingsMerger.Services;


namespace SettingsMerger
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        string _lastUsedPath = @"C:\";

        public string ExportedAzureSettings { get; set; }

        private void btnBrowseExportedSettings_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = this._lastUsedPath;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxExportedSettingsFilePath.Text = openFileDialog1.FileName;
                this._lastUsedPath = Path.GetFullPath(openFileDialog1.FileName);
            }
        }

        private void btnBrowseLocalSettings_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = this._lastUsedPath;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxLocalSettingsFilePath.Text = openFileDialog1.FileName;
                this._lastUsedPath = Path.GetFullPath(openFileDialog1.FileName);
            }
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxLocalSettingsFilePath.Text))
            {
                var settingsSource = ExportedAzureSettings;
                if (tcInput.SelectedIndex == 1)
                {
                    settingsSource = File.ReadAllText(tbxExportedSettingsFilePath.Text);
                }

                if (rbAppSettings.Checked)
                {
                    var merger = new AppSettingsMerger(settingsSource, tbxLocalSettingsFilePath.Text);
                    tbxOutput.Text = merger.Merge(chkbOverrideSettingFile.Checked);
                }

                if (rbLocalSettings.Checked)
                {
                    var merger = new LocalSettingsMerger(settingsSource, tbxLocalSettingsFilePath.Text);
                    tbxOutput.Text = merger.Merge(chkbOverrideSettingFile.Checked);
                }
                gbOutput.Text = "Setting file";
                MessageBox.Show("File has been processed");
            }
            else
            {
                MessageBox.Show("Choose dev settings file path to merge");
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            tbxExportedSettingsFilePath.Text = string.Empty;
            tbxLocalSettingsFilePath.Text = string.Empty;
            tbxResourceGroupName.Text = string.Empty;
            tbxWebAppName.Text = string.Empty;
            tbxOutput.Text = string.Empty;
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            var help = new HelpForm();
            help.ShowDialog();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbxResourceGroupName.Text) && String.IsNullOrWhiteSpace(tbxWebAppName.Text))
            {
                MessageBox.Show("Add Resource group and Web App names in order to continue");
                return;
            }

            var credential = new DefaultAzureCredential();


            string command = "az webapp config appsettings list";
            string arguments = $"-g \"{tbxResourceGroupName.Text.Trim()}\" -n \"{tbxWebAppName.Text.Trim()}\"";

            // Start a new process for the command
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "cmd.exe", // Use cmd.exe on Windows
                Arguments = $"/c {command} {arguments}",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
            };

            using (Process process = Process.Start(startInfo))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    ExportedAzureSettings = reader.ReadToEnd();

                    process.WaitForExit();

                    gbOutput.Text = "Azure Configuration Settings";
                    tbxOutput.Text = ExportedAzureSettings;
                }
            }

        }

        private void tbxResourceGroupName_TextChanged(object sender, EventArgs e)
        {
            btnExportAzure.Enabled = IsAzureInformationAvailable();
        }

        private bool IsAzureInformationAvailable()
        {
            return tbxResourceGroupName.Text != string.Empty && tbxWebAppName.Text != string.Empty;
        }

        private void tbxWebAppName_TextChanged(object sender, EventArgs e)
        {
            btnExportAzure.Enabled = IsAzureInformationAvailable();
        }

        private void tcInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbOutput.Text = "Output";
        }
    }
}