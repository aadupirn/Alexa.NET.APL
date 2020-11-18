using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Request
{
    public class APLInterfaceDetails
    {
        [JsonProperty("runtime", NullValueHandling = NullValueHandling.Ignore)]
        public APLInterfaceRuntime Runtime { get; set; }
    }
}