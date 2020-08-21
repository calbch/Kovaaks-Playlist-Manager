using System;
using System.IO;
using System.Text.Json;

namespace KovaaksPlaylistManager
{
    public static class UserSettingManager
    {
        private static readonly string SettingsPath =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"KovaaksPlaylistManagerSettings.json");
        public static UserSettings LoadUserSettings()
        {
            if (File.Exists(SettingsPath))
            {
                var userSettingsJson = File.ReadAllText(SettingsPath);
                return JsonSerializer.Deserialize<UserSettings>(userSettingsJson);
            }
            var settings = new UserSettings();
            SaveUserSettings(settings);
            return settings;
        }

        public static void SaveUserSettings(UserSettings settings)
        {
            File.WriteAllText(SettingsPath, JsonSerializer.Serialize(settings));
        }

        public static bool UserSettingsExist()
        {
            return File.Exists(SettingsPath);
        }

        public static void CreateUserSettings()
        {
            var settings = new UserSettings {PlaylistPath = ""};
            SaveUserSettings(settings);
        }
    }
}