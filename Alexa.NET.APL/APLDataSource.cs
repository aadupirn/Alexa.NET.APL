using System.Collections.Generic;
using VoicifyAlexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL
{
    [JsonConverter(typeof(APLDataSourceConverter))]
    public abstract class APLDataSource
    {
        [JsonProperty("type")]
        public abstract string Type { get; }
    }
}