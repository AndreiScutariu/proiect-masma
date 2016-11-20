using System.Collections.Generic;
using PersonalAssistant.Common.Messages;
using PersonalAssistant.Services.DataContract.ServiceInformation;

namespace PersonalAssistant.Services.External.DataContract.Contracts.Responses
{
    public class FoundHotelServicesResponse : HeaderMessage
    {
        public List<HotelServiceInformation> Hotels { get; set; }
    }
}