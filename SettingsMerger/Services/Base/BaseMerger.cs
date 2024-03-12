namespace SettingsMerger.Services.Base
{
    public abstract class BaseMerger
    {        
        public BaseMerger(string azureSettingsToMerge, string localFilePath)
        {
        }

        public abstract string Merge(bool overrideLocalFile = true);
    }
}
