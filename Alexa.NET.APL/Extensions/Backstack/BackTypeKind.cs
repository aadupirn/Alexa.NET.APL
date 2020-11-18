using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.APL.Extensions.Backstack
{
    public enum BackTypeKind
    {
        [EnumMember(Value="count")]
        Count,
        [EnumMember(Value = "index")]
        Index,
        [EnumMember(Value = "id")]
        Id
    }
}