using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL.Commands
{
    public class ClearFocus : APLCommand
    {
        [JsonProperty("type")]
        public override string Type => nameof(ClearFocus);

    }
}