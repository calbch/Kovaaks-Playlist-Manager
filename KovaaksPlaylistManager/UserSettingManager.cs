using System.IO;
using System.Text.Json;

namespace KovaaksPlaylistManager
{
    public class UserSettingManager
    {
        public static UserSettings LoadUserSettings()
        {
            var userSettingsJson = File.ReadAllText(@"userSettings.json");
            return JsonSerializer.Deserialize<UserSettings>(userSettingsJson);
        }

        public static bool SaveUserSettings(UserSettings settings)
        {
            File.WriteAllText(@"userSettings.json", JsonSerializer.Serialize(settings));
            return LoadUserSettings().Equals(settings);
        }
    }
}