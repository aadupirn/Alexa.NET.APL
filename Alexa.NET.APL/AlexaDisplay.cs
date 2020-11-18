using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL
{
    public class AlexaDisplay
    {
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}