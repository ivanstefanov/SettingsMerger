using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using SettingsMerger.Models;
using SettingsMerger.Services.Base;

namespace SettingsMerger.Services
{
    public class AppSettingsMerger :BaseMerger
    {
        string _azureConfigPath = "";
        string _appSettingsPath = "";

        public AppSettingsMerger(string azureConfigPath, string appSettingsPath): base(azureConfigPath, appSettingsPath)
        {
            _azureConfigPath = azureConfigPath;
            _appSettingsPath = appSettingsPath;
        }
        public override string Merge(bool overrideLocalFile = true)
        {
            var output = "No results...";
            try
            {

                var azureConfig = JsonConvert.DeserializeObject<List<AzureConfigItem>>(File.ReadAllText(_azureConfigPath));
                var appSettings = JObject.Parse(File.ReadAllText(_appSettingsPath));

                foreach (var item in azureConfig)
                {
                    var pathParts = item.Name.Split(':');
                    JObject currentObject = appSettings;
                    for (int i = 0; i < pathParts.Length - 1; i++)
                    {
                        if (currentObject[pathParts[i]] == null)
                        {
                            currentObject[pathParts[i]] = new JObject();
                        }
                        currentObject = (JObject)currentObject[pathParts[i]];
                    }

                    currentObject[pathParts[^1]] = item.Value;
                }
                output = JsonConvert.SerializeObject(appSettings, Newtonsoft.Json.Formatting.Indented);
                if (overrideLocalFile)
                {
                    File.WriteAllText(_appSettingsPath, output);
                }                
            }
            catch (Exception ex)
            {
                output = "Error occured:" + ex.ToString();
            }
            return output;
        }
    }
}
