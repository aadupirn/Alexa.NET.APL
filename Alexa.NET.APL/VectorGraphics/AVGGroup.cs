﻿using System.Collections.Generic;
using VoicifyAlexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL.VectorGraphics
{
    public class AVGGroup : IAVGItem
    {
        [JsonProperty("type")] public string Type => "group";

        [JsonProperty("opacity",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<double?> Opacity { get; set; }

        [JsonProperty("style", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Style { get; set; }

        [JsonProperty("clipPath",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> ClipPath { get; set; }

        [JsonProperty("transform",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Transform { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(AVGItemListConverter))]
        public APLValue<IList<IAVGItem>> Items { get; set; }

    }
}