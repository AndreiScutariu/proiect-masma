namespace PersonalAssistant.Services.External.DataContract.Messages.Services
{
    using System;
    using System.Collections.Generic;

    using PersonalAssistant.Common.Messages;
    using PersonalAssistant.Services.External.DataContract.Contracts.Requests;
    using PersonalAssistant.Services.External.Messages;

    public class NeedTouristAttractionServicesRequest : HeaderMessage, INeedTouristAttractionServicesRequest
    {
        public string Description { get; set; }

        public string Location { get; set; }
        
        public string CountryForAttraction { get; set; }

        public Range<DateTime?> EventDate { get; set; }

        public IEnumerable<string> ActivityTypes { get; set; }

        public Range<int?> TouristAttractionsPrice { get; set; }
    }
}