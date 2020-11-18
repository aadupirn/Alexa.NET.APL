using VoicifyAlexa.NET.APL;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace VoicifyAlexa.NET.Response.APL
{
    public class APLTDocument : APLDocumentBase
    {
        public override string Type => "APLT";

        public APLTDocument():base(APLDocumentVersion.V1)
        {

        }
    }
}