using System.Collections.Generic;
using VoicifyAlexa.NET.APL;
using VoicifyAlexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Response.APL
{
    [JsonConverter(typeof(APLAComponentConverter))]
    public abstract class APLAComponent:APLComponentBase
    {

    }
}