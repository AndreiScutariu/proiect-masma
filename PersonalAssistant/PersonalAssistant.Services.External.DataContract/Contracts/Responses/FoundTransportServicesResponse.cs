using System.Collections.Generic;
using PersonalAssistant.Common.Messages;
using PersonalAssistant.Services.DataContract.ServiceInformation;

namespace PersonalAssistant.Services.External.DataContract.Contracts.Responses
{
    public class FoundTransportServicesResponse : HeaderMessage
    {
        public List<TransportServiceInformation> Tranports { get; set; }
    }
}