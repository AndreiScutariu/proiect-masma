using jade.core;
using PersonalAssistant.Services.DataContract;
using PersonalAssistant.Services.DataContract.ServiceInformation;
using PersonalAssistant.Services.Internal.Agents.Base;

namespace PersonalAssistant.Services.Internal.Agents
{
    public class TransportProviderAgent : ServiceProviderAgent<TransportServiceInformation>
    {
        protected override ServiceType ServiceType => ServiceType.Transport;

        protected override string ServiceName => "__TransportService";

        public override void Handle(object message, AID sender)
        {
            base.Handle(message, sender);
        }
    }
}