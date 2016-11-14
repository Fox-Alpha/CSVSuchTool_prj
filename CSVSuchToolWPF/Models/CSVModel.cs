using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace CSVSuchToolWPF.Models
{
    [JsonObject (MemberSerialization.OptIn)]
    public class CSVModel
    {
        [JsonProperty (Required = Required.Default, PropertyName = "Settings")]
        public CSVSettings Settings;

        [JsonProperty (Required = Required.Default, PropertyName = "Data")]
        public List<CSVData> Data;

        [JsonProperty (PropertyName = "MapFields", Required = Required.AllowNull)]
        Dictionary<string, string> Mapping;

        JsonSerializerSettings jsonSerializerSettings;

        public CSVModel()
        {
            //	Setzen der Serializer Settings
            jsonSerializerSettings = new JsonSerializerSettings ();
            jsonSerializerSettings.Formatting = Formatting.Indented;
            jsonSerializerSettings.MissingMemberHandling = MissingMemberHandling.Ignore;
            jsonSerializerSettings.NullValueHandling = NullValueHandling.Include;
            jsonSerializerSettings.StringEscapeHandling = StringEscapeHandling.EscapeNonAscii;
            jsonSerializerSettings.TypeNameHandling = TypeNameHandling.Auto;
        }
    }

   
    public class CSVSettings
    {
        [JsonProperty (PropertyName = "Fields", Required = Required.Always)]
        public List<string> csvFields;

        [JsonProperty (PropertyName = "SearchFields", Required = Required.AllowNull)]
        public List<string> csvSearchFields;

        [JsonProperty (PropertyName = "DisplayFields", Required = Required.AllowNull)]
        public List<string> csvDisplayFields;

        public CSVSettings()
        {
        }
    }

   
    public class CSVData
    {
        [JsonProperty (PropertyName = "Data", Required = Required.Always)]
        Dictionary<string, string> data;

        public CSVData ()
        {
        }
    }

}

