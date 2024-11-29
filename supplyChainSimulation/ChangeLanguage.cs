using System.Configuration;

namespace supplyChainSimulation
{
    public class ChangeLanguage
    {
        public void UpdateConfig(string key, string value)
        {
            // Open the configuration file for the application
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Get the appSettings section
            var settings = config.AppSettings.Settings;

            // Check if the key exists; if so, update it; otherwise, add it
            if (settings[key] != null)
            {
                settings[key].Value = value;
            }
            else
            {
                settings.Add(key, value);
            }

            // Save the configuration file
            config.Save(ConfigurationSaveMode.Modified);

            // Refresh the appSettings section so changes are reflected at runtime
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
