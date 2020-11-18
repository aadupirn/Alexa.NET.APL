﻿using System;
using System.Linq;
using System.Reflection;
using VoicifyAlexa.NET.APL.VectorGraphics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VoicifyAlexa.NET.APL.JsonConverter
{
    public class AVGItemConverter : Newtonsoft.Json.JsonConverter
    {
        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {

        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);
            var filterType = jObject.Value<string>("type");
            object target = GetFilter(filterType);
            if (target == null)
            {
                throw new ArgumentOutOfRangeException($"Filter type {filterType} not supported");
            }

            try
            {
                serializer.Populate(jObject.CreateReader(), target);
            }
            catch (Exception)
            {
            }

            return target;

        }

        private IAVGItem GetFilter(string type)
        {
            return type switch
            {
                "path" => new AVGPath(),
                "group" => new AVGGroup(),
                "text" => new AVGText(),
                _ => null
            };
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.GetTypeInfo().ImplementedInterfaces.Contains(typeof(IAVGItem));
        }
    }
}