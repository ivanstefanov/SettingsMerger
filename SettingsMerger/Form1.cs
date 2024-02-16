using SettingsMerger.Services;

namespace SettingsMerger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string _lastUsedPath = @"C:\";

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
            if (!string.IsNullOrEmpty(tbxLocalSettingsFilePath.Text) && !string.IsNullOrEmpty(tbxExportedSettingsFilePath.Text))
            {
                if (rbAppSettings.Checked)
                {
                    var merger = new AppSettingsMerger(tbxExportedSettingsFilePath.Text, tbxLocalSettingsFilePath.Text);
                    tbxOutput.Text = merger.Merge(chkbOverrideSettingFile.Checked);
                }

                if (rbLocalSettings.Checked)
                {
                    var merger = new LocalSettingsMerger(tbxExportedSettingsFilePath.Text, tbxLocalSettingsFilePath.Text);
                    tbxOutput.Text = merger.Merge(chkbOverrideSettingFile.Checked);
                }
                MessageBox.Show("File has been processed");
            }
            else
            {
                MessageBox.Show("Choose files to merge");
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            tbxExportedSettingsFilePath.Text = string.Empty;
            tbxLocalSettingsFilePath.Text = string.Empty;
            tbxOutput.Text = string.Empty;
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            var help = new HelpForm();
            help.ShowDialog();
        }
    }
}
