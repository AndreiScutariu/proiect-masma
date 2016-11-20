using System;
using PersonalAssistant.Services.External.DataContract.Contracts.Requests.Base;

namespace PersonalAssistant.Services.External.DataContract.Contracts.Requests
{
    public interface INeedHotelServicesRequest : INeedServicesRequest
    {
        Range<int> NumberOfStars { get; set; }
        
    }
}