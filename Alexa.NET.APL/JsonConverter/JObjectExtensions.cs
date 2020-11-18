using Newtonsoft.Json.Linq;

namespace VoicifyAlexa.NET.APL.JsonConverter
{
    internal static class JObjectExtensions
    {
        public static void Move(this JObject jObject, string from, string to)
        {
            if (jObject[from] != null)
            {
                jObject[to] = jObject[from];
                jObject.Remove(from);
            }
        }
    }
}