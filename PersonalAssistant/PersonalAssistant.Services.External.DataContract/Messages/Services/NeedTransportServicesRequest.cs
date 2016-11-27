﻿namespace PersonalAssistant.Services.External.DataContract.Messages.Services
{
    using PersonalAssistant.Common.Messages;
    using PersonalAssistant.Services.External.DataContract.Contracts.Requests;

    public class NeedTransportServicesRequest : HeaderMessage, INeedTransportServicesRequest
    {
        public string Description { get; set; }

        public string Location { get; set; }

        public Range<int> Price { get; set; }

        public string YourLocation { get; set; }
    }
}