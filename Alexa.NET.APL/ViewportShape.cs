using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.APL
{
    public enum ViewportShape
    {
        [EnumMember(Value="SQUARE")]
        Square,
        [EnumMember(Value = "RECTANGLE")]
        Rectangle,
        [EnumMember(Value = "ROUND")]
        Round
    }
}