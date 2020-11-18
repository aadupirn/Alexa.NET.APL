using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL
{
    public class InterSegment
    {
        [JsonProperty("x")]
        public int X { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }

        [JsonProperty("characters")]
        public string Characters { get; set; }
    }
}