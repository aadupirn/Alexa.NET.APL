using System;
using System.Collections.Generic;
using System.Text;
using VoicifyAlexa.NET.Response.APL;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace VoicifyAlexa.NET.APL.JsonConverter
{
    public class UnknownDocumentVersionConverter:StringEnumConverter
    {
        public UnknownDocumentVersionConverter()
        {

        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            try
            {
                return base.ReadJson(reader, objectType, existingValue, serializer);
            }
            catch (JsonSerializationException)
            {
                return APLDocumentVersion.Unknown;
            }
        }
    }
}
