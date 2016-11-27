namespace PersonalAssistant.Services.External.Messages.Messages.Client
{
    using System;
    using System.Collections.Generic;

    using PersonalAssistant.Common.Messages;
    using PersonalAssistant.Services.External.Messages.Contracts.Requests;

    public class AggregateServicesRequest : HeaderMessage, IAggregateServicesRequest
    {
        public string HotelCountry { get; set; }

        public Range<int?> NumberOfStars { get; set; }

        public int? NumberOfPeoplePerRoom { get; set; }

        public int? NumberOfRooms { get; set; }

        public Range<DateTime?> IntervalOfDays { get; set; }

        public Range<int?> HotelPrice { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public string YourCountry { get; set; }

        public string YourCity { get; set; }

        public IEnumerable<string> TransportTypes { get; set; }

        public Range<int?> TransportPrice { get; set; }

        public Range<DateTime?> EventDate { get; set; }

        public IEnumerable<string> ActivityTypes { get; set; }

        public Range<int?> TouristAttractionsPrice { get; set; }
    }
}