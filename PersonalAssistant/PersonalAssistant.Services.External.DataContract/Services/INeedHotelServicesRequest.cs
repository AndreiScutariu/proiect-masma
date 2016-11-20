using PersonalAssistant.Common.Messages;

namespace PersonalAssistant.Services.External.DataContract.Services
{
    public interface INeedHotelServicesRequest
    {
        Range<int> NumberOfStars { get; set; }
    }

    public class NeedHotelServicesRequest : HeaderMessage, INeedHotelServicesRequest
    {
        public Range<int> NumberOfStars { get; set; }
    }
}