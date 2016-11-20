using System.Collections.Generic;
using PersonalAssistant.Services.DataContract.ServiceInformation;

namespace PersonalAssistant.Services.External.DataContract.Messages.Client
{
    public class FoundTransportServicesResponse
    {
        public List<TransportServiceInformation> Tranports { get; set; }
    }
}