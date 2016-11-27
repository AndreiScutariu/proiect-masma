namespace PersonalAssistant.Services.External.Messages.Contracts.Requests.Base
{
    using System;

    public interface INeedServicesRequest
    {
        Guid CorrelationId { get; set; }

        string Description { get; set; }

        string Location { get; set; }
    }
}