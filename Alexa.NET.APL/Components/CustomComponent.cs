using System;
using System.Collections.Generic;
using System.Text;
using VoicifyAlexa.NET.APL.JsonConverter;
using VoicifyAlexa.NET.Response.APL;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL.Components
{
    public class CustomComponent : APLComponent
    {
        public CustomComponent(string type)
        {
            Type = type;
        }

        public override string Type { get; }
    }
}
