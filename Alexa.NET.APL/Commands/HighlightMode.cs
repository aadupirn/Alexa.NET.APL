using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.APL.Commands
{
    public enum HighlightMode
    {
        [EnumMember(Value="line")]
        Line,
        [EnumMember(Value = "block")]
        Block
    }
}