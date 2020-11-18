using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL
{
    public class VideoSupport
    {
        [JsonProperty("codecs")]
        public string[] Codecs { get; set; }
    }
}