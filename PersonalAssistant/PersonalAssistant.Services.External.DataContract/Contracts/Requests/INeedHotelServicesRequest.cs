namespace PersonalAssistant.Services.External.DataContract.Contracts.Requests
{
    using PersonalAssistant.Services.External.DataContract.Contracts.Requests.Base;

    public interface INeedHotelServicesRequest : INeedServicesRequest
    {
        Range<int> NumberOfStars { get; set; }
    }
}