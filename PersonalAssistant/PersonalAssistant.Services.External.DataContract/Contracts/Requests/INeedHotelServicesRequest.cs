namespace PersonalAssistant.Services.External.DataContract.Contracts.Requests
{
    public interface INeedHotelServicesRequest : INeedServicesRequest
    {
        Range<int> NumberOfStars { get; set; }
    }
}