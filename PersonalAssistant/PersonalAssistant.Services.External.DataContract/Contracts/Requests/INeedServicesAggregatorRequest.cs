namespace PersonalAssistant.Services.External.DataContract.Contracts.Requests
{
    public interface INeedServicesAggregatorRequest : INeedTransportServicesRequest, INeedHotelServicesRequest,
        INeedTouristAttractionRequest
    {
    }
}