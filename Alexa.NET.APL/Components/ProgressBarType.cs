using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.APL.Components
{
    public enum ProgressBarType
    {
        [EnumMember(Value="determinate")]
        Determinate,
        [EnumMember(Value="indeterminate")]
        Indeterminate
    }
}