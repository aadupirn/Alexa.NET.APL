using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.APL.Gestures
{
    public enum SwipeDirection
    {
        [EnumMember(Value="left")]
        Left,
        [EnumMember(Value="right")]
        Right,
        [EnumMember(Value="up")]
        Up,
        [EnumMember(Value="down")]
        Down
    }
}