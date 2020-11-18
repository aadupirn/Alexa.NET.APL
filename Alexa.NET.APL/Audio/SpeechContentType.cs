using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.APL.Audio
{
    public enum SpeechContentType
    {
        [EnumMember(Value="PlainText")]
        PlainText,
        [EnumMember(Value="SSML")]
        Ssml
    }
}