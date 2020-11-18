using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.APL.Filters
{
    public enum NoiseKind
    {
        [EnumMember(Value="gaussian")]
        Gaussian,
        [EnumMember(Value="uniform")]
        Uniform
    }
}