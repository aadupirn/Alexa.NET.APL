using System.Linq;
using VoicifyAlexa.NET.Request.Type;

namespace VoicifyAlexa.NET.Request
{
    public class UserEventRequestHandler:IRequestTypeConverter
    {
        public bool CanConvert(string requestType)
        {
            return requestType == UserEventRequest.RequestType;
        }

        public Request.Type.Request Convert(string requestType)
        {
            return new UserEventRequest();
        }

        private static readonly object directiveadd = new object();

        public void AddToRequestConverter()
        {
            lock (directiveadd)
            {
                if (RequestConverter.RequestConverters.Where(rc => rc != null)
                    .All(rc => rc.GetType() != typeof(UserEventRequestHandler)))
                {
                    RequestConverter.RequestConverters.Add(this);
                }
            }
        }
    }
}
