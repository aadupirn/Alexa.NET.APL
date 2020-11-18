using System.Collections.Generic;
using VoicifyAlexa.NET.APL.JsonConverter;
using VoicifyAlexa.NET.Response.APL;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL.Components
{
    public abstract class ActionableComponent: APLComponent
    {
        [JsonProperty("onBlur", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OnBlur { get; set; }

        [JsonProperty("onFocus", NullValueHandling = NullValueHandling.Ignore),
         JsonConverter(typeof(APLCommandListConverter))]
        public APLValue<IList<APLCommand>> OnFocus { get; set; }

        [JsonProperty("handleKeyDown",NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(APLKeyboardHandlerConverter))]
        public APLValue<IList<APLKeyboardHandler>> HandleKeyDown { get; set; }

        [JsonProperty("handleKeyUp", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(APLKeyboardHandlerConverter))]
        public APLValue<IList<APLKeyboardHandler>> HandleKeyUp { get; set; }
    }
}