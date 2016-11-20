using System;

namespace PersonalAssistant.Services.External.DataContract.Contracts.Requests.Base
{
    public interface INeedServicesRequest
    {
        Guid CorrelationId { get; set; }

        string Description { get; set; }

        string Location { get; set; }

        Range<int> Price { get; set; }
    }
}