using System.Collections.Generic;
using VoicifyAlexa.NET.APL.JsonConverter;
using VoicifyAlexa.NET.Response.APL;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL.Audio
{
    public class Audio:APLAComponent
    {
        public override string Type => nameof(Audio);

        [JsonProperty("source",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Source { get; set; }

        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLAFilterListConverter))]
        public APLValue<IList<APLAFilter>> Filters { get; set; }
    }
}