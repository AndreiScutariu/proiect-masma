using System;
using System.Linq;
using jade.core;
using PersonalAssistant.Common.Agents.Interfaces;
using PersonalAssistant.Services.DataContract;
using PersonalAssistant.Services.DataContract.ServiceInformation;
using PersonalAssistant.Services.External.DataContract.Contracts.Requests;
using PersonalAssistant.Services.External.DataContract.Messages.Client;
using PersonalAssistant.Services.Internal.Agents.Base;
using PersonalAssistant.Services.Internal.Agents.QueryBuilder;

namespace PersonalAssistant.Services.Internal.Agents
{
    public class TransportProviderAgent : ServiceProviderAgent<TransportServiceInformation>,
        IHandleMessages<INeedTransportServicesRequest>
    {
        protected override ServiceType ServiceType => ServiceType.Transport;

        protected override string ServiceName => "__TransportService";

        public void Handle(INeedTransportServicesRequest message, AID sender)
        {
            SendMessage(sender, new FoundTransportServicesResponse
            {
                Tranports = Services.GetFor(message).ToList()
            });
        }

        public override void Handle(object message, AID sender)
        {
            base.Handle(message, sender);

            if (message is INeedTransportServicesRequest)
            {
                Handle((INeedTransportServicesRequest) message, sender);
            }
        }
    }
}