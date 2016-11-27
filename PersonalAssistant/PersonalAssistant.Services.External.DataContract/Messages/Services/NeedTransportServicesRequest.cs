namespace PersonalAssistant.Services.External.Messages.Messages.Services
{
    using System.Collections.Generic;

    using PersonalAssistant.Common.Messages;
    using PersonalAssistant.Services.External.Messages.Contracts.Requests;

    public class NeedTransportServicesRequest : HeaderMessage, INeedTransportServicesRequest
    {
        public string Description { get; set; }

        public string Location { get; set; }

        public Range<int> Price { get; set; }

        public string YourCountry { get; set; }

        public string YourCity { get; set; }

        public IEnumerable<string> TransportTypes { get; set; }
    }
}