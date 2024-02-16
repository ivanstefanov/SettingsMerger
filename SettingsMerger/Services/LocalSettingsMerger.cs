using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using SettingsMerger.Models;
using SettingsMerger.Services.Base;

namespace SettingsMerger.Services
{
    public class LocalSettingsMerger: BaseMerger
    {
        string _azureConfigPath = "";
        string _localSettingsPath = "";

        public LocalSettingsMerger(string azureConfigPath, string localSettingsPath): base(azureConfigPath, localSettingsPath)
        {
            _azureConfigPath = azureConfigPath;
            _localSettingsPath = localSettingsPath;
        }

        public override string Merge(bool overrideLocalFile = true)
        {
            var output = "No results...";
            try
            {
                var azureConfig = JsonConvert.DeserializeObject<List<AzureConfigItem>>(File.ReadAllText(_azureConfigPath));
                var localSettings = JObject.Parse(File.ReadAllText(_localSettingsPath));

                if (localSettings["Values"] == null)
                {
                    localSettings["Values"] = new JObject();
                }

                var valuesObject = (JObject)localSettings["Values"];
                
                foreach (var item in azureConfig)
                {
                    valuesObject[item.Name] = item.Value;
                }

                output = JsonConvert.SerializeObject(localSettings, Formatting.Indented);
                if (overrideLocalFile) 
                {
                    File.WriteAllText(_localSettingsPath, output);
                }
                
            }
            catch (Exception ex)
            {
                output = "An error occurred: " + ex.Message;
            }
            return output;
        }
    }
}
