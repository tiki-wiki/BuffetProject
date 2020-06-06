using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;
using System.IO;
namespace BuffetAssistant.Classes
{
    internal class AppSetting
    {
        private static readonly string settingsPath = $"{AppDomain.CurrentDomain.BaseDirectory}AppConfig.json";
        public static AppConfig config { get; set; }

        //methods
        public static void SaveSetting()
        {
            var jsonFile = JsonConvert.SerializeObject(config);
            File.WriteAllText(settingsPath, jsonFile);
        }
        public static void SettingReader()
        {
            if (File.Exists(settingsPath))
            {
                try
                {
                    var json = File.ReadAllText(settingsPath);
                    config = JsonConvert.DeserializeObject<AppConfig>(json);
                }
                catch
                {
                    config = new AppConfig();
                }
            }

        }
        internal class AppConfig
        {
            //font section
            public int FontSize { get; set; }
            public Brushes FontColor { get; set; }
            public FontFamily FontFamily { get; set; }

            //theme section
            public System.Windows.Media.Brush Theme { get; set; }
        }

    }

}
