namespace SettingsMerger.Services.Base
{
    public abstract class BaseMerger
    {        
        public BaseMerger(string azureConfigPath, string localFilePath)
        {
        }

        public abstract string Merge(bool overrideLocalFile);
    }
}
