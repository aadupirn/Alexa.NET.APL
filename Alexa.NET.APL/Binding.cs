﻿using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Response.APL
{
    public class Binding
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public object Value { get; set; }

        [JsonProperty("type")]
        public ParameterType Type { get; set; } = ParameterType.any;

        public bool ShouldSerializeType()
        {
            return Type != ParameterType.any;
        }

        [JsonConstructor]
        private Binding(){}

        public Binding(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}