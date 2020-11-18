using VoicifyAlexa.NET.APL;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Request
{
    public class APLSkillRequest:SkillRequest
    {
        private APLContext _context;

        [JsonProperty("context")]
        public new APLContext Context
        {
            get => _context;
            set
            {
                base.Context = value;
                _context = value;
            }
        }
    }
}
