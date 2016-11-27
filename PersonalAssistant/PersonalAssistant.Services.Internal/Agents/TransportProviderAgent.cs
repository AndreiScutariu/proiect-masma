namespace PersonalAssistant.Services.Internal.Agents
{
    using System.Collections.Generic;
    using System.Linq;

    using jade.core;

    using PersonalAssistant.Common.Agents.Interfaces;
    using PersonalAssistant.Services.DataContract;
    using PersonalAssistant.Services.DataContract.ServiceInformation;
    using PersonalAssistant.Services.External.Messages.Contracts.Requests;
    using PersonalAssistant.Services.External.Messages.Contracts.Responses;
    using PersonalAssistant.Services.Internal.Agents.Base;
    using PersonalAssistant.Services.Internal.Agents.QueryBuilder;

    public class TransportProviderAgent : ServiceProviderAgent<TransportServiceInformation>,
                                          IHandleMessages<INeedTransportServicesRequest>
    {
        protected override ServiceType ServiceType => ServiceType.Transport;

        protected override string ServiceName => "__TransportService";

        public void Handle(INeedTransportServicesRequest message, AID sender)
        {
            List<TransportServiceInformation> transportServiceInformations = Services.GetFor(message).ToList();

            SendMessage(
                sender,
                new FoundTransportServicesResponse
                    {
                        CorrelationId = message.CorrelationId,
                        Tranports = transportServiceInformations
                    });
        }

        public override void Handle(object message, AID sender)
        {
            base.Handle(message, sender);

            if (message is INeedTransportServicesRequest)
            {
                Handle((INeedTransportServicesRequest)message, sender);
            }
        }
    }
}