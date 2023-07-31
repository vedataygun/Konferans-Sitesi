using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json;

namespace Conference_Website.Extension
{
    public static class TempdataExtension
    {
        public static void Put<T>(this ITempDataDictionary tempdata, string key, T value) where T : class
        {
            tempdata[key] = JsonConvert.SerializeObject(value);
        }

        public static T Get<T>(this ITempDataDictionary tempdata, string key) where T : class
        {
            object o;
            tempdata.TryGetValue(key, out o);
            return o == null ? null : JsonConvert.DeserializeObject<T>((string)o);
        }
    }
}
