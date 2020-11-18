using System;
using System.Collections.Generic;
using System.Text;
using VoicifyAlexa.NET.Response.APL;

namespace VoicifyAlexa.NET.APL.Extensions.Backstack
{
    public class BackstackExtension:APLExtension
    {
        public const string URL = "aplext:backstack:10";

        public BackstackExtension()
        {
            Uri = URL;
        }

        public BackstackExtension(string name):this()
        {
            Name = name;
        }
    }
}
