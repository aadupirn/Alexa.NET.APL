using VoicifyAlexa.NET.APL.JsonConverter;
using VoicifyAlexa.NET.Response.APL;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL.Components
{
    public class AlexaProgressBarRadial : AlexaProgressBarBase
    {
        public override string Type => nameof(AlexaProgressBarRadial);
    }
}