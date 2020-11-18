using System.Security.Cryptography.X509Certificates;
using VoicifyAlexa.NET.APL.JsonConverter;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL.Filters
{
    [JsonConverter(typeof(ImageFilterConverter))]
    public interface IImageFilter
    {
        [JsonProperty("type")]
        string Type { get; }
    }
}
