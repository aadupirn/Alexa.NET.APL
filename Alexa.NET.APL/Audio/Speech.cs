using VoicifyAlexa.NET.APL.JsonConverter;
using VoicifyAlexa.NET.Response.APL;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL.Audio
{
    public class Speech : APLAComponent
    {
        public override string Type => nameof(Speech);

        [JsonProperty("content",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Content { get; set; }

        [JsonProperty("contentType",NullValueHandling = NullValueHandling.Ignore),
            JsonConverter(typeof(APLValueEnumConverter<SpeechContentType>))]
        public APLValue<SpeechContentType?> ContentType { get; set; }
    }
}