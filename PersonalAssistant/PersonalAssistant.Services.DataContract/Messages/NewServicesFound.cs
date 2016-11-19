using System.Collections.Generic;
using PersonalAssistant.Common.Messages;

namespace PersonalAssistant.Services.DataContract.Messages
{
    public class NewServicesFound : HeaderMessage
    {
        public List<string> ServicesInformation { get; set; }
    }
}