namespace PersonalAssistant.Services.Internal.Agents
{
    using System.Collections.Generic;
    using System.Linq;

    using jade.core;

    using PersonalAssistant.Common.Agents.Interfaces;
    using PersonalAssistant.Services.DataContract;
    using PersonalAssistant.Services.DataContract.ServiceInformation;
    using PersonalAssistant.Services.External.DataContract.Contracts.Requests;
    using PersonalAssistant.Services.External.DataContract.Contracts.Responses;
    using PersonalAssistant.Services.Internal.Agents.Base;
    using PersonalAssistant.Services.Internal.Agents.QueryBuilder;

    public class TouristAttractionsAgent : ServiceProviderAgent<TouristAttractionServiceInformation>,
                                           IHandleMessages<INeedTouristAttractionServicesRequest>
    {
        protected override ServiceType ServiceType => ServiceType.TouristAttraction;

        protected override string ServiceName => "__TouristAttractionsService";

        public void Handle(INeedTouristAttractionServicesRequest message, AID sender)
        {
            List<TouristAttractionServiceInformation> touristAttractionServiceInformations =
                Services.GetFor(message).ToList();

            SendMessage(
                sender,
                new FoundTouristAttractionServicesResponse
                    {
                        CorrelationId = message.CorrelationId,
                        Activities = touristAttractionServiceInformations
                    });
        }

        public override void Handle(object message, AID sender)
        {
            base.Handle(message, sender);

            if (message is INeedTouristAttractionServicesRequest)
            {
                Handle((INeedTouristAttractionServicesRequest)message, sender);
            }
        }
    }
}