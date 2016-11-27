using System;

namespace PersonalAssistant.Services.External.DataContract.Contracts.Requests
{
    using PersonalAssistant.Services.External.DataContract.Contracts.Requests.Base;

    public interface INeedHotelServicesRequest : INeedServicesRequest
    {
        string HotelCountry { get; set; }

        Range<int> NumberOfStars { get; set; }

        int NumberOfPeoplePerRoom { get; set; }

        Range<DateTime?> IntervalOfDays { get; set; }
    }
}