namespace PersonalAssistant.Services.External.Messages.Contracts.Requests
{
    using System.Collections.Generic;

    using PersonalAssistant.Services.External.Messages.Contracts.Requests.Base;

    public interface INeedTransportServicesRequest : INeedServicesRequest
    {
        string YourCountry { get; set; }

        string YourCity { get; set; }

        IEnumerable<string> TransportTypes { get; set; }

        Range<int?> TransportPrice { get; set; }
    }
}