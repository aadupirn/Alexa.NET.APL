using System.Collections.Generic;
using System.Linq;
using VoicifyAlexa.NET.APL;
using VoicifyAlexa.NET.APL.JsonConverter;
using VoicifyAlexa.NET.Response.Converters;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Response
{
    public class ExecuteCommandsDirective:IDirective
    {
        private const string DirectiveType = "Alexa.Presentation.APL.ExecuteCommands";
        private static readonly object directiveadd = new object();
        public static void AddSupport()
        {
            lock(directiveadd)
            {
                if (!DirectiveConverter.TypeFactories.ContainsKey(DirectiveType))
                {
                    DirectiveConverter.TypeFactories.Add(DirectiveType, () => new ExecuteCommandsDirective());
                }
            }
        }

        public ExecuteCommandsDirective() { }

        public ExecuteCommandsDirective(string token)
        {
            Token = token;
        }

        public ExecuteCommandsDirective(string token, IEnumerable<APLCommand> commands):
            this(token)
        {
            Commands = commands.ToList();
        }

        public ExecuteCommandsDirective(string token, params APLCommand[] commands) : 
            this(token, (IEnumerable<APLCommand>)commands)
        { }

        [JsonProperty("type")]
        public string Type => DirectiveType;

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("commands"),
         JsonConverter(typeof(APLCommandListConverter),true)]
        public IList<APLCommand> Commands { get; set; }
    }
}
