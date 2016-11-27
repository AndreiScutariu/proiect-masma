namespace PersonalAssistant.Services.External.Messages.Contracts.Requests
{
    using PersonalAssistant.Services.External.DataContract.Contracts.Requests;

    public interface IAggregateServicesRequest : INeedTransportServicesRequest,
                                                 INeedHotelServicesRequest,
                                                 INeedTouristAttractionServicesRequest
    {
    }
}