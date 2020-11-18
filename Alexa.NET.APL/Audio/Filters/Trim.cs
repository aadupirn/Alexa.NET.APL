﻿using System;
using System.Collections.Generic;
using System.Text;
using VoicifyAlexa.NET.Response.APL;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL.Audio.Filters
{
    public class Trim:APLAFilter
    {
        public override string Type => nameof(Trim);

        [JsonProperty("start",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> Start { get; set; }

        [JsonProperty("end",NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<int?> End { get; set; }
    }
}
