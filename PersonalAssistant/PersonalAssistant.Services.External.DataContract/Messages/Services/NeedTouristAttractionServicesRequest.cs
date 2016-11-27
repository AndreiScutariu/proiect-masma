namespace PersonalAssistant.Services.External.DataContract.Messages.Services
{
    using System;

    using PersonalAssistant.Common.Messages;
    using PersonalAssistant.Services.External.DataContract.Contracts.Requests;

    public class NeedTouristAttractionServicesRequest : HeaderMessage, INeedTouristAttractionServicesRequest
    {
        public string Description { get; set; }

        public string Location { get; set; }

        public Range<int> Price { get; set; }

        public string CountryForAttraction { get; set; }

        public Range<DateTime?> EventDate { get; set; }

        public string ActivityType { get; set; }
    }
}