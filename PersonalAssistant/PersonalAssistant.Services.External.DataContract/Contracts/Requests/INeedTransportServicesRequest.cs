using System.Collections.Generic;

namespace PersonalAssistant.Services.External.DataContract.Contracts.Requests
{
    using PersonalAssistant.Services.External.DataContract.Contracts.Requests.Base;

    public interface INeedTransportServicesRequest : INeedServicesRequest
    {
        string YourCountry { get; set; }

        string YourLocation { get; set; }

        IEnumerable<string> TransportTypes { get; set; }
    }
}