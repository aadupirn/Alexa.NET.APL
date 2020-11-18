using System;
using System.Collections.Generic;
using System.Text;
using VoicifyAlexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL
{
    [JsonConverter(typeof(APLGestureConverter))]
    public abstract class APLGesture
    {
        [JsonProperty("type")]
        public abstract string Type { get; }
    }
}
