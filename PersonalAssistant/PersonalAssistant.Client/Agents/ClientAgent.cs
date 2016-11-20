using System.Collections.Generic;
using jade.core;
using PersonalAssistant.Client.Behaviours;
using PersonalAssistant.Client.Interfaces;
using PersonalAssistant.Common.Agents;
using PersonalAssistant.Services.Common;

namespace PersonalAssistant.Client.Agents
{
    public class ClientAgent : ReceiveMessagesAgent,
        IHaveServiceProviders
    {
        public override void setup()
        {
            base.setup();

            addBehaviour(new SendRequestBehaviour(this));
        }

        public List<AID> Providers { get; set; }

        public void FindMyServiceProviders()
        {
            Providers = new List<AID>();

            Providers.AddRange(ServiceLocator.Find("__TransportService", this));
            Providers.AddRange(ServiceLocator.Find("__HotelService", this));
        }

        public override void Handle(object message, AID sender)
        {

        }
    }
}