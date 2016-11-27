namespace PersonalAssistant.Services.External.DataContract.Contracts.Requests
{
    using PersonalAssistant.Services.External.DataContract.Contracts.Requests.Base;

    public interface INeedTransportServicesRequest : INeedServicesRequest
    {
        string YourLocation { get; set; }
    }
}