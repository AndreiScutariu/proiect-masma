namespace PersonalAssistant.Services.External.DataContract.Contracts.Requests
{
    public interface INeedServicesRequest
    {
        string Description { get; set; }

        string Location { get; set; }

        Range<int> Price { get; set; }
    }
}