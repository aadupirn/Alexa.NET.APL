using VoicifyAlexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL.VectorGraphics
{
    [JsonConverter(typeof(AVGItemConverter))]
    public interface IAVGItem
    {
        [JsonProperty("type")]
        string Type { get; }
    }
}