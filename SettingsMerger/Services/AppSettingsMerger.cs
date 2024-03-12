using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using SettingsMerger.Models;
using SettingsMerger.Services.Base;

namespace SettingsMerger.Services
{
    public class AppSettingsMerger :BaseMerger
    {
        string _azureSettingsToMerge = "";
        string _appSettingsPath = "";

        public AppSettingsMerger(string azureSettingsToMerge, string appSettingsPath): base(azureSettingsToMerge, appSettingsPath)
        {
            _azureSettingsToMerge = azureSettingsToMerge;
            _appSettingsPath = appSettingsPath;
        }
        public override string Merge(bool overrideLocalFile = true)
        {
            var output = "No results...";
            try
            {
                var azureConfig = JsonConvert.DeserializeObject<List<AzureConfigItem>>(_azureSettingsToMerge);
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
                        try
                        {
                            currentObject = (JObject)currentObject[pathParts[i]];
                        }
                        catch (Exception ex)
                        {
                            output = $"Casting error occurred: currentObject: {currentObject}";
                            throw;
                        }                        
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
                output += "Error occurred:" + ex.ToString();
            }
            return output;
        }
    }
}
