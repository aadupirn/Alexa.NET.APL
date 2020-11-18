using VoicifyAlexa.NET.APL;
using VoicifyAlexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Response.APL
{
    [JsonConverter(typeof(APLAFilterConverter))]
    public abstract class APLAFilter
    {
        [JsonProperty("type")]
        public abstract string Type { get; }

        [JsonProperty("when", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> When { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Description { get; set; }
    }
}