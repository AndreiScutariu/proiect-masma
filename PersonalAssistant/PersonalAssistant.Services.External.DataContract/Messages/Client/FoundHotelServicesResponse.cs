using System.Collections.Generic;
using PersonalAssistant.Services.DataContract.ServiceInformation;

namespace PersonalAssistant.Services.External.DataContract.Messages.Client
{
    public class FoundHotelServicesResponse
    {
        public List<HotelServiceInformation> Hotels { get; set; }
    }
}