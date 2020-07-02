using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MongoDML.Core.Helpers
{
    public class ConfigHelper
    {
        private static ConfigHelper _instance = null;

        private JObject jObject = null;

        private ConfigHelper()
        {
            var filePath = Application.StartupPath + @"\config.json";
            var fileText = File.ReadAllText(filePath);
            jObject = JObject.Parse(fileText);
        }

        public static ConfigHelper GetInstance()
        {
            if (_instance == null) _instance = new ConfigHelper();
            return _instance;
        }

        public string Get(string key)
        {
            return jObject.Value<string>(key);
        }
    }
}
