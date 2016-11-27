namespace PersonalAssistant.Services.External.DataContract.Contracts.Requests
{
    using System;

    using PersonalAssistant.Services.External.DataContract.Contracts.Requests.Base;

    public interface INeedTouristAttractionServicesRequest : INeedServicesRequest
    {
        Range<DateTime?> EventDate { get; set; }

        string ActivityType { get; set; }
    }
}