namespace PersonalAssistant.Services.External.DataContract.Contracts.Requests
{
    public interface INeedServicesRequest : INeedTransportServicesRequest, INeedHotelServicesRequest,
        INeedTouristAttractionRequest
    {
    }
}