namespace PersonalAssistant.Services.External.Messages.Messages.Services
{
    using System;

    using PersonalAssistant.Common.Messages;
    using PersonalAssistant.Services.External.Messages.Contracts.Requests;

    public class NeedHotelServicesRequest : HeaderMessage, INeedHotelServicesRequest
    {
        public string HotelCountry { get; set; }

        public Range<int> NumberOfStars { get; set; }

        public int NumberOfPeoplePerRoom { get; set; }

        public Range<DateTime?> IntervalOfDays { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public Range<int> Price { get; set; }
    }
}