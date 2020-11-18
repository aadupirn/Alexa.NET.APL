using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.APL.Commands
{
    public enum RepeatMode
    {
        [EnumMember(Value="restart")]
        Restart,
        [EnumMember(Value="reverse")]
        Reverse
    }
}