using System;
using System.Collections.Generic;
using System.Text;
using VoicifyAlexa.NET.APL.Components;
using VoicifyAlexa.NET.APL.JsonConverter;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace VoicifyAlexa.NET.APL.Commands
{
    public class ControlMedia:APLCommand
    {
        [JsonProperty("type")]
        public override string Type => nameof(ControlMedia);

        [JsonProperty("command"),JsonConverter(typeof(APLValueEnumConverter<ControlMediaCommand>))]
        public APLValue<ControlMediaCommand> Command { get; set; }

        [JsonProperty("componentId", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ComponentId { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> Value { get; set; }

    }
}
