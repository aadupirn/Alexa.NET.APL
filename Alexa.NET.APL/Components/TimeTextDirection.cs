using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.APL.Components
{
    public enum TimeTextDirection
    {
        [EnumMember(Value="none")]
        None,
        [EnumMember(Value = "up")]
        Up,
        [EnumMember(Value = "down")]
        Down,
    }
}