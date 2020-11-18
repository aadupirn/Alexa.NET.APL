﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL.Extensions.Backstack
{
    public class BackStackSettings
    {
        [JsonProperty("backstackId", NullValueHandling = NullValueHandling.Ignore)]
        public string BackstackId { get; set; }
    }
}
