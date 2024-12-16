using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Detranscend
{
    public static class Settings
    {
        private static List<Setting> SettingsList = new List<Setting>();

        public static void SetFloat(string name, float value)
        { 
            var setting = SettingsList.Find(s => s.Name == name);
            setting ??= new Setting { Name = name };
            setting.Value = value.ToString(CultureInfo.InvariantCulture);
            SettingsList.Add(setting);
        }

        public static void SetInt(string name, int value)
        {
            var setting = SettingsList.Find(s => s.Name == name);
            setting ??= new Setting { Name = name };
            setting.Value = value.ToString(CultureInfo.InvariantCulture);
            SettingsList.Add(setting);
        }

        public static void SetString(string name, string value)
        {
            var setting = SettingsList.Find(s => s.Name == name);
            setting ??= new Setting { Name = name };
            setting.Value = value;
            SettingsList.Add(setting);
        }

        public static void SetBool(string name, bool value)
        {
            var setting = SettingsList.Find(s => s.Name == name);
            setting ??= new Setting { Name = name };
            setting.Value = value.ToString();
            SettingsList.Add(setting);
        }

        public static float GetFloat(string name, float defaultValue = 0f)
        {
            var setting = SettingsList.Find(s => s.Name == name);
            if (setting == null) return defaultValue;
            if (setting.Value == null) return defaultValue;
            return float.Parse(setting.Value, CultureInfo.InvariantCulture);
        }

        public static int GetInt(string name, int defaultValue = 0)
        {
            var setting = SettingsList.Find(s => s.Name == name);
            if (setting == null) return defaultValue;
            if (setting.Value == null) return defaultValue;
            return int.Parse(setting.Value);
        }

        public static string GetString(string name, string defaultValue = "")
        {
            var setting = SettingsList.Find(s => s.Name == name);
            if (setting == null) return defaultValue;
            if (setting.Value == null) return defaultValue;
            return setting.Value;
        }

        public static bool GetBool(string name, bool defaultValue = false)
        {
            var setting = SettingsList.Find(s => s.Name == name);
            if (setting == null) return defaultValue;
            if (setting.Value == null) return defaultValue;
            return bool.Parse(setting.Value);
        }

        public static void Save()
        {
            var jsonData = JsonSerializer.Serialize(SettingsList);
            File.WriteAllText("settings.json", jsonData);
        }

        public static void Reload()
        {
            if (!File.Exists("settings.json")) return;

            var jsonData = File.ReadAllText("settings.json");
            SettingsList = JsonSerializer.Deserialize<List<Setting>>(jsonData) ?? [];
        }

        private class Setting
        {
            public string Name { get; set; } = "SettingName";
            public string? Value { get; set; }
        }
    }
}
