using VoicifyAlexa.NET.Response.APL;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL.Audio.Filters
{
    public class Volume : APLAFilter
    {
        public override string Type => nameof(Volume);

        [JsonProperty("amount")]
        public APLValue<double> Duration { get; set; }
    }
}