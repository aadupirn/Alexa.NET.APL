using System.Collections.Generic;
using VoicifyAlexa.NET.APL.Commands;
using VoicifyAlexa.NET.APL.JsonConverter;
using VoicifyAlexa.NET.Response.APL;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL.Components
{
    public class TouchWrapper : TouchComponent
    {
        public TouchWrapper()
        {

        }

        public TouchWrapper(APLComponent item)
        {
            Item = new List<APLComponent> { item };
        }

        public TouchWrapper(params APLComponent[] item) : this((IEnumerable<APLComponent>)item)
        {

        }

        public TouchWrapper(IEnumerable<APLComponent> item)
        {
            Item = new List<APLComponent>(item);
        }

        [JsonProperty("type")]
        public override string Type => nameof(TouchWrapper);


        [JsonProperty("item", NullValueHandling = NullValueHandling.Ignore),
        JsonConverter(typeof(APLComponentListConverter))]
        public APLValue<IList<APLComponent>> Item { get; set; }
    }
}
