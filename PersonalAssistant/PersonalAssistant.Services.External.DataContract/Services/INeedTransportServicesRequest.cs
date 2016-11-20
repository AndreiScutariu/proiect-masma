using PersonalAssistant.Common.Messages;

namespace PersonalAssistant.Services.External.DataContract.Services
{
    public interface INeedTransportServicesRequest
    {
    }

    public class NeedTransportServicesRequest : HeaderMessage, INeedTransportServicesRequest
    {
    }
}