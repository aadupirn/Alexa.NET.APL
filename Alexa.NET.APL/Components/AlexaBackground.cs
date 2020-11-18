﻿using System;
using System.Collections.Generic;
using System.Text;
using VoicifyAlexa.NET.APL.JsonConverter;
using VoicifyAlexa.NET.Response.APL;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL.Components
{
    public class AlexaBackground : ResponsiveTemplate
    {
        [JsonProperty("type")]
        public override string Type => nameof(AlexaBackground);

        [JsonProperty("colorOverlay", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> ColorOverlay { get; set; }


        [JsonProperty("overlayGradient", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> OverlayGradient { get; set; }


        [JsonProperty("videoAudioTrack", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> VideoAudioTrack { get; set; } = "foreground";


        [JsonProperty("videoAutoPlay", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<bool?> VideoAutoPlay { get; set; }

    }
}
