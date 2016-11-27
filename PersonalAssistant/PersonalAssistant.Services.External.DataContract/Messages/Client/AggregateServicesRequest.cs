using System.Collections.Generic;

namespace PersonalAssistant.Services.External.DataContract.Messages.Client
{
    using System;

    using PersonalAssistant.Common.Messages;
    using PersonalAssistant.Services.External.DataContract.Contracts.Requests;

    public class AggregateServicesRequest : HeaderMessage, IAggregateServicesRequest
    {
        public string HotelCountry { get; set; }

        public Range<int> NumberOfStars { get; set; }

        public int NumberOfPeoplePerRoom { get; set; }

        public Range<DateTime?> IntervalOfDays { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public Range<int> Price { get; set; }

        public string YourCountry { get; set; }

        public string YourCity { get; set; }

        public IEnumerable<string> TransportTypes { get; set; }
        
        public string CountryForAttraction { get; set; }

        public Range<DateTime?> EventDate { get; set; }

        public string ActivityType { get; set; }
    }
}