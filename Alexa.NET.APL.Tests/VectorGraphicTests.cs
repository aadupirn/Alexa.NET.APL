using System;
using System.Collections.Generic;
using System.Text;
using VoicifyAlexa.NET.APL.VectorGraphics;
using Xunit;

namespace VoicifyAlexa.NET.APL.Tests
{
    public class VectorGraphicTests
    {
        [Fact]
        public void AVGGeneratesCorrectJson()
        {
            Utility.AssertSerialization<AVG>("AVG.json");
        }
    }
}
