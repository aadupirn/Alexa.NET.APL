using VoicifyAlexa.NET.Request;
using VoicifyAlexa.NET.Response;

namespace VoicifyAlexa.NET.APL
{
    public static class APLSupport
    {
        public static void Add()
        {
            RenderDocumentDirective.AddSupport();
            ExecuteCommandsDirective.AddSupport();
            SendIndexListDataDirective.AddSupport();
            UpdateIndexListDataDirective.AddSupport();
            new UserEventRequestHandler().AddToRequestConverter();
            new LoadIndexListDataRequestHandler().AddToRequestConverter();
            new RuntimeErrorRequestHandler().AddToRequestConverter();
        }
    }
}
