using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Translator
{

    public class Result
    {

        

        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public class Data
    {
        [JsonProperty("translations")]
        public Translation[] Translations { get; set; }
    }

    public class Translation
    {
        [JsonProperty("translatedText")]
        public string TranslatedText { get; set; }
        [JsonProperty("detectedSourceLanguage")]
        public string DetectedSourceLanguage { get; set; }
    }

}
