﻿namespace PersonalAssistant.Services.External.Messages.Contracts.Requests
{
    using System;

    using PersonalAssistant.Services.External.Messages.Contracts.Requests.Base;

    public interface INeedHotelServicesRequest : INeedServicesRequest
    {
        string HotelCountry { get; set; }

        Range<int?> NumberOfStars { get; set; }

        int? NumberOfPeoplePerRoom { get; set; }

        int? NumberOfRooms { get; set; }

        Range<DateTime?> IntervalOfDays { get; set; }

        Range<int?> HotelPrice { get; set; }
    }
}