using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.APL
{
    public enum APLGradientType
    {
        [EnumMember(Value="linear")]
        Linear,
        [EnumMember(Value = "radial")]
        Radial
    }
}