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
        public static AppConfiguration config { get; set; }

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
                    config = JsonConvert.DeserializeObject<AppConfiguration>(json);
                }
                catch
                {
                    config = new AppConfiguration();
                }
            }

        }
        internal class AppConfiguration
        {
            //font section
            public double FontSize { get; set; }
            public Brushes FontColor { get; set; }
            public object FontFamily { get; set; }

            //theme section
            public System.Windows.Media.Brush Theme { get; set; }
        }

    }

}
