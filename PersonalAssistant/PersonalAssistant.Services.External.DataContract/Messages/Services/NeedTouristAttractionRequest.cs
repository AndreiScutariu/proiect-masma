﻿using PersonalAssistant.Common.Messages;
using PersonalAssistant.Services.External.DataContract.Contracts.Requests;

namespace PersonalAssistant.Services.External.DataContract.Messages.Services
{
    public class NeedTouristAttractionRequest : HeaderMessage, INeedTouristAttractionRequest
    {
        public string Description { get; set; }

        public string Location { get; set; }

        public Range<int> Price { get; set; }
    }
}