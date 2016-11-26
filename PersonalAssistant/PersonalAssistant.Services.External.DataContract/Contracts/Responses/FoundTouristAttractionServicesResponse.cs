using System.Collections.Generic;
using PersonalAssistant.Common.Messages;
using PersonalAssistant.Services.DataContract.ServiceInformation;

namespace PersonalAssistant.Services.External.DataContract.Contracts.Responses
{
    public class FoundTouristAttractionServicesResponse : HeaderMessage
    {
        public List<TouristAttractionServiceInformation> Activities { get; set; }
    }
}
