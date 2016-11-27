﻿namespace PersonalAssistant.Services.External.Messages.Contracts.Requests
{
    using System;

    using PersonalAssistant.Services.External.Messages.Contracts.Requests.Base;

    public interface INeedTouristAttractionServicesRequest : INeedServicesRequest
    {
        string CountryForAttraction { get; set; }

        Range<DateTime?> EventDate { get; set; }

        string ActivityType { get; set; }
    }
}