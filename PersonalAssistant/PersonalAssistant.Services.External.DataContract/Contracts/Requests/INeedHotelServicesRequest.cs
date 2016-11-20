namespace PersonalAssistant.Services.External.DataContract.Contracts.Requests
{
    public interface INeedHotelServicesRequest
    {
        Range<int> NumberOfStars { get; set; }
    }
}