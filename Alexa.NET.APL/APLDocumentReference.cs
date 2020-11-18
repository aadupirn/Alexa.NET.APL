using VoicifyAlexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL
{
    [JsonConverter(typeof(APLDocumentConverter))]
    public abstract class APLDocumentReference
    {
        [JsonProperty("type")]
        public abstract string Type { get; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionString { get; set; }
    }
}