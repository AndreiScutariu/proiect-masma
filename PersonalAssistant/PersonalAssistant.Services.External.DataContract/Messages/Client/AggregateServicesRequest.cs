namespace PersonalAssistant.Services.External.DataContract.Messages.Client
{
    using System;

    using PersonalAssistant.Common.Messages;
    using PersonalAssistant.Services.External.DataContract.Contracts.Requests;

    public class AggregateServicesRequest : HeaderMessage, IAggregateServicesRequest
    {
        public Range<int> NumberOfStars { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public Range<int> Price { get; set; }

        public string YourLocation { get; set; }

        public Range<DateTime?> EventDate { get; set; }

        public string ActivityType { get; set; }
    }
}