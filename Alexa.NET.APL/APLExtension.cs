using VoicifyAlexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL
{
    [JsonConverter(typeof(APLExtensionConverter))]
    public class APLExtension
    {
        [JsonProperty("name",NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("uri",NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }
    }
}