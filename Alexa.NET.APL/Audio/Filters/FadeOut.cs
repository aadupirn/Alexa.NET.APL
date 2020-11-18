using VoicifyAlexa.NET.Response.APL;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL.Audio.Filters
{
    public class FadeOut : APLAFilter
    {
        public override string Type => nameof(FadeOut);

        [JsonProperty("duration")]
        public APLValue<int> Duration { get; set; }
    }
}