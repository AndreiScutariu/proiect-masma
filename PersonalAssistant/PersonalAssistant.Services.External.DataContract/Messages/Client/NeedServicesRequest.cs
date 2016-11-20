using PersonalAssistant.Common.Messages;
using PersonalAssistant.Services.External.DataContract.Contracts.Requests;

namespace PersonalAssistant.Services.External.DataContract.Messages.Client
{
    public class NeedServicesRequest : HeaderMessage, INeedServicesRequest
    {
        public Range<int> NumberOfStars { get; set; }
    }
}