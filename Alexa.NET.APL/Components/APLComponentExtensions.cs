using System;
using System.Collections.Generic;
using System.Text;
using VoicifyAlexa.NET.Response.APL;

namespace VoicifyAlexa.NET.APL.Components
{
    public static class APLComponentExtensions
    {
        public static void AddResponsiveDesign(this APLDocument document)
        {
            Import.AlexaLayouts.Into(document);
        }
    }
}
