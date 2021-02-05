using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace foodPicker.Services
{
    public static class JsonLoadService
    {
        public static T GetJson<T>(string filepath)
        {
            using (StreamReader r = new StreamReader(filepath))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(json);
            }
        }
    }
}
