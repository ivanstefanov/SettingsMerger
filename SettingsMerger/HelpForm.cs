using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SettingsMerger
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            string helpContent = "In order to obtain the azure setting file: \r\n" +
                "1. open any bash console \r\n" +
                "2 Run 'az login' in order to login to azure portal \r\n" +
                "3 (optional) Specify the current folder where you want to save the downloaded settings \r\n" +
                "4 Run 'az webapp config appsettings list' with appropriate parameters \r\n" +
                "\r\n" + 
                "Information about the az webbapp command: https://learn.microsoft.com/en-us/cli/azure/webapp/config/appsettings?view=azure-cli-latest#az-webapp-config-appsettings-list \r\n" +
                "\r\n" +
                "Example:\r\n" +
                "az webapp config appsettings list -g  \"{RESOURCE_GROUP_NAME}\" -n  \"{RESOURCE_NAME}\" -o json > {RESOURCE_NAME}.settings.json";

            tbxHelp.Text = helpContent;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
