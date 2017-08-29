using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace Translator
{
    public static class Translator
    {

        private static string _apiKey = "AIzaSyBqmhaRf_UNwxoIhhuZ4HQ4SqplIK_gb-I";
        private static string _targetLanguageCOde = "en";

        public static List<string> ConvertText(string input)
        {
            List<string> words = new List<string>();

            words.AddRange(input.Split(' ').ToList());

            

            return words;

        }

        public static string Translate(string text)
        {
            Result res;

            List<string> ConvertedText = ConvertText(text);

            string finishedText = String.Join("+", ConvertedText);



            string link = String.Format("https://translation.googleapis.com/language/translate/v2?key={0}&target={1}&q={2}", _apiKey, _targetLanguageCOde, finishedText);

            using (WebClient webclient = new WebClient())
            {
                byte[] test = webclient.DownloadData(link);


                // create stream reader

                using (var stream = new MemoryStream(test))
                using (var streamReader = new StreamReader(stream))
                {
                    res = JsonConvert.DeserializeObject<Result>(streamReader.ReadToEnd());
                }

                return res.Data.Translations[0].TranslatedText;



            }
        }

        



    }
}
