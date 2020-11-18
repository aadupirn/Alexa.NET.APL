using System.Collections.Generic;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL
{
    public class AlexaExtensions
    {
        [JsonProperty("available",NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string,object> Available { get; set; }
    }
}