using PersonalAssistant.Common.Messages;
using PersonalAssistant.Services.External.DataContract.Services;

namespace PersonalAssistant.Services.External.DataContract.Client
{
    public interface INeedServicesRequest : INeedTransportServicesRequest, INeedHotelServicesRequest,
        INeedTouristAttractionRequest
    {
    }

    public class NeedServicesRequest : HeaderMessage, INeedServicesRequest
    {
        public Range<int> NumberOfStars { get; set; }
    }
}