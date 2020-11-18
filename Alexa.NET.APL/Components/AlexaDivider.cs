using System;
using System.Collections.Generic;
using System.Text;
using VoicifyAlexa.NET.Response.APL;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL.Components
{
    public class AlexaDivider:APLComponent
    {
        [JsonProperty("type")]
        public override string Type => nameof(AlexaDivider);

        [JsonProperty("theme",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Theme { get; set; }
    }
}
