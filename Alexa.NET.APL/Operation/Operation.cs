using VoicifyAlexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL.Operation
{
    [JsonConverter(typeof(OperationConverter))]
    public abstract class Operation
    {
        [JsonProperty("type")]
        public abstract string Type { get; }
    }
}