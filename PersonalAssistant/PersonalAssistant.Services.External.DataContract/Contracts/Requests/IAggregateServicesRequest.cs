namespace PersonalAssistant.Services.External.Messages.Contracts.Requests
{
    public interface IAggregateServicesRequest : INeedTransportServicesRequest,
                                                 INeedHotelServicesRequest,
                                                 INeedTouristAttractionServicesRequest
    {
    }
}