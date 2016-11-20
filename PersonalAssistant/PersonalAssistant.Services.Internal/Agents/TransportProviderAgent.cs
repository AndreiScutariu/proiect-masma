using System;
using jade.core;
using PersonalAssistant.Common.Agents.Interfaces;
using PersonalAssistant.Services.DataContract;
using PersonalAssistant.Services.DataContract.ServiceInformation;
using PersonalAssistant.Services.External.DataContract.Contracts.Requests;
using PersonalAssistant.Services.Internal.Agents.Base;

namespace PersonalAssistant.Services.Internal.Agents
{
    public class TransportProviderAgent : ServiceProviderAgent<TransportServiceInformation>,
        IHandleMessages<INeedTransportServicesRequest>
    {
        protected override ServiceType ServiceType => ServiceType.Transport;

        protected override string ServiceName => "__TransportService";

        public void Handle(INeedTransportServicesRequest message, AID sender)
        {
            Console.WriteLine($"{ServiceName} - Handle a request.");
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