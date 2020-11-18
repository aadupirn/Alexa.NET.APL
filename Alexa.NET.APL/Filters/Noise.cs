using VoicifyAlexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL.Filters
{
    public class Noise : IImageFilter
    {
        public string Type => nameof(Noise);
        [JsonProperty("useColor",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> UseColor { get; set; }

        [JsonProperty("sigma",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> Sigma { get; set; }

        [JsonProperty("kind",NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(APLValueEnumConverter<NoiseKind>))]
        public APLValue<NoiseKind?> Kind { get; set; }
    }
}