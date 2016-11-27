namespace PersonalAssistant.Services.External.DataContract.Contracts.Requests
{
    using System.Collections.Generic;

    using PersonalAssistant.Services.External.DataContract.Contracts.Requests.Base;

    public interface INeedTransportServicesRequest : INeedServicesRequest
    {
        string YourCountry { get; set; }

        string YourCity { get; set; }

        IEnumerable<string> TransportTypes { get; set; }
    }
}