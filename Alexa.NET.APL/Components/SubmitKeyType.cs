﻿using System.Runtime.Serialization;

namespace VoicifyAlexa.NET.APL.Components
{
    public enum SubmitKeyType
    {
        [EnumMember(Value="done")]
        Done,
        [EnumMember(Value="go")]
        Go,
        [EnumMember(Value="next")]
        Next,
        [EnumMember(Value="search")]
        Search,
        [EnumMember(Value="send")]
        Send
    }
}