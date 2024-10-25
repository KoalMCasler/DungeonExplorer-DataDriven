using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace TextRPG_OOP_
{
    internal class SettingsManager
    {
        private Settings baseSettings;
        private string savedJson;
        public Settings savedSettings;
        private string fileName = "Settings.json";

        public SettingsManager() //Constructor
        {
            baseSettings = new Settings();
            string baseToJson = JsonSerializer.Serialize(baseSettings);
            LoadSettings();
            if(savedJson != null && savedJson == baseToJson)
            {
                savedSettings = JsonSerializer.Deserialize<Settings>(baseToJson);
            }
            else if(savedJson != null)
            {
                savedSettings = JsonSerializer.Deserialize<Settings>(savedJson);
            }
            else
            {
                savedSettings = JsonSerializer.Deserialize<Settings>(baseToJson);
            }
            string JsonToSave = JsonSerializer.Serialize(savedSettings);
            File.WriteAllText(fileName, JsonToSave);
        }

        private void LoadSettings()
        {
            savedJson = File.ReadAllText(fileName);
        }

    }
}
