using PersonalAssistant.Common.Messages;

namespace PersonalAssistant.Services.DataContract.Messages
{
    public class FindMyServicesRequest : HeaderMessage
    {
        public ServiceType ServiceType { get; set; }
    }
}