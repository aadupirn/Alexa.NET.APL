using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL
{
    public class APLViewportConfigurationContainer
    {
        [JsonProperty("current",NullValueHandling = NullValueHandling.Ignore)]
        public APLViewportConfiguration Current { get; set; }
    }
}