using System;
using System.Collections.Generic;
using System.Text;
using VoicifyAlexa.NET.Response.APL;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VoicifyAlexa.NET.APL.JsonConverter
{
    public class ParameterListConverter : GenericSingleOrListConverter<Parameter>
    {
        public ParameterListConverter() : base() { }

        public ParameterListConverter(bool alwaysArray) : base(alwaysArray) { }
        protected override object OutputArrayItem(Parameter param)
        {
            if (param.Default == null && string.IsNullOrWhiteSpace(param.Description) &&
                param.ShouldSerializeType() == false)
            {
                return param.Name;
            }

            return param;
        }
    }
}
