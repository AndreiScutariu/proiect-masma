using System;
using PersonalAssistant.Services.External.DataContract.Contracts.Requests.Base;

namespace PersonalAssistant.Services.External.DataContract.Contracts.Requests
{
    public interface INeedTouristAttractionServicesRequest : INeedServicesRequest
    {
        Range<DateTime?> EventDate { get; set; }

        string ActivityType { get; set; }
    }
}