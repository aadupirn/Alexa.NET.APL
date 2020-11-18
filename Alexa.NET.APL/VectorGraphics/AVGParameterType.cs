using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.APL.VectorGraphics
{
    public enum AVGParameterType
    {
        [EnumMember(Value="any")]
        Any,
        [EnumMember(Value = "string")]
        String,
        [EnumMember(Value = "number")]
        Number,
        [EnumMember(Value = "color")]
        Color,
    }
}