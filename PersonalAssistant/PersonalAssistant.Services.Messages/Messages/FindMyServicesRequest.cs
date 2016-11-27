namespace PersonalAssistant.Services.Messages.Messages
{
    using PersonalAssistant.Common.Messages;
    using PersonalAssistant.Services.DataContract;

    public class FindMyServicesRequest : HeaderMessage
    {
        public ServiceType ServiceType { get; set; }
    }
}