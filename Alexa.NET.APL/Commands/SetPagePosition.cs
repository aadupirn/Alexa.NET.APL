using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.APL.Commands
{
    public enum SetPagePosition
    {
        [EnumMember(Value="absolute")]
        Absolute,
        [EnumMember(Value="relative")]
        Relative
    }
}