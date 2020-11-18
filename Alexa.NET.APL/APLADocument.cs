﻿using System;
using System.Collections.Generic;
using System.Text;
using VoicifyAlexa.NET.APL.Audio;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL
{
    public class APLADocument:APLDocumentReference
    {
        public APLADocument()
        {
            VersionString = "0.8";
        }
        public override string Type => "APLA";

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public APLValue<string> Description { get; set; }

        [JsonIgnore]
        public APLADocumentVersion Version
        {
            get => EnumParser.ToEnum(VersionString, APLADocumentVersion.Unknown);
            set => VersionString = EnumParser.ToEnumString(typeof(APLADocumentVersion), value);
        }

        [JsonProperty("mainTemplate")]
        public AudioLayout MainTemplate { get; set; }
    }
}
