namespace PersonalAssistant.Services.External.Messages.Contracts.Responses
{
    using System.Collections.Generic;

    using PersonalAssistant.Common.Messages;
    using PersonalAssistant.Services.DataContract.ServiceInformation;

    public class FoundTouristAttractionServicesResponse : HeaderMessage
    {
        public List<TouristAttractionServiceInformation> Activities { get; set; }
    }
}