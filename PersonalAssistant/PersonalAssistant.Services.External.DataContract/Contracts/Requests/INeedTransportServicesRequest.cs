﻿namespace PersonalAssistant.Services.External.DataContract.Contracts.Requests
{
    public interface INeedTransportServicesRequest : INeedServicesRequest
    {
        string YourLocation { get; set; }
    }
}