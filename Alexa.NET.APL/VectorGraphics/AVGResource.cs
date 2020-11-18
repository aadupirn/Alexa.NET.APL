using System.Collections.Generic;
using VoicifyAlexa.NET.Response.APL;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL.VectorGraphics
{
    public class AVGResource : Resource
    {

        [JsonProperty("patterns", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string,AVG> Patterns { get; set; }

        public void AddPattern(string key, AVG graphic)
        {
            Patterns ??= new Dictionary<string, AVG>();
            Patterns.Add(key, graphic);
        }
    }
}