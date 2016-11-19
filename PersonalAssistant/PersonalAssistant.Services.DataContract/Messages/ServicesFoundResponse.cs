using System.Collections.Generic;
using PersonalAssistant.Common.Messages;

namespace PersonalAssistant.Services.DataContract.Messages
{
    public class ServicesFoundResponse : HeaderMessage
    {
        public List<string> ServicesInformation { get; set; }
    }
}