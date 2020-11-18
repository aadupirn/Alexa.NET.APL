using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.APL.Components
{
    public enum TextOverflow
    {
        [EnumMember(Value= "marquee")]
        Marquee,
        [EnumMember(Value="wrap")]
        Wrap
    }
}