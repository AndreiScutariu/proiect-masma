namespace PersonalAssistant.Services.External.DataContract.Contracts.Requests
{
    public interface IAggregateServicesRequest : INeedTransportServicesRequest,
                                                 INeedHotelServicesRequest,
                                                 INeedTouristAttractionServicesRequest
    {
    }
}