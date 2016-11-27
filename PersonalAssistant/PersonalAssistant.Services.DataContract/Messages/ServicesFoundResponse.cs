namespace PersonalAssistant.Services.DataContract.Messages
{
    using System.Collections.Generic;

    using PersonalAssistant.Common.Messages;

    public class ServicesFoundResponse : HeaderMessage
    {
        public List<string> ServicesInformation { get; set; }
    }
}