using VoicifyAlexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL.Commands
{
    [JsonConverter(typeof(AnimatedPropertyConverter))]
    public abstract class AnimatedProperty
    {
        [JsonProperty("property")]
        public abstract APLValue<string> Property { get; }
    }
}