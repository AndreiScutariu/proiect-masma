using System.Collections.Generic;

namespace PersonalAssistant.Services.External.DataContract.Contracts.Requests
{
    using System;

    using PersonalAssistant.Services.External.Messages.Contracts.Requests.Base;

    public interface INeedTouristAttractionServicesRequest : INeedServicesRequest
    {
        Range<DateTime?> EventDate { get; set; }

        IEnumerable<string> ActivityTypes { get; set; }
    }
}