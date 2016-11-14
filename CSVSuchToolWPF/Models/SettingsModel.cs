using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Stylet;

namespace CSVSuchToolWPF.Models
{
    [JsonObject (MemberSerialization.OptIn, Title = "settings")]
    class SettingsModel : PropertyChangedBase
    {
        [JsonProperty ("lastsearchlist")]
        public string LastServerList { get; set; }

        [JsonProperty ("ImportDir")]
        public string ImportDirectory { get; set; }
        [JsonProperty ("ConvertedDir")]
        public string ConvertedDirectory { get; set; }

        [JsonProperty ("windowleft")]
        public int WindowLeft { get; set; }
        [JsonProperty ("windowtop")]
        public int WindowTop { get; set; }
        [JsonProperty ("windowwidth")]
        public int WindowWidth { get; set; }
        [JsonProperty ("windowheight")]
        public int WindowHeight { get; set; }

        public void SaveSettings ()
        {
            Directory.CreateDirectory (SettingsDirectory);
            File.WriteAllText (SettingsPath, JsonConvert.SerializeObject (this, Formatting.Indented), Encoding.UTF8);
        }

        public void LoadSettings ()
        {
            if (File.Exists (SettingsPath))
                JsonConvert.PopulateObject (File.ReadAllText (SettingsPath, Encoding.UTF8), this);
        }

        public string SettingsDirectory
        {
            get
            {
                return Path.Combine (
                    Environment.GetFolderPath (Environment.SpecialFolder.ApplicationData),
                    System.Reflection.Assembly.GetExecutingAssembly ().GetName ().Name);
            }
        }

        public string SettingsPath { get { return Path.Combine (SettingsDirectory, "settings.json"); } }
    }
}
