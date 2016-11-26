using System;
using System.Collections.Generic;
using jade.core;
using Lab6.Messages;
using PersonalAssistant.Common.Agents;
using PersonalAssistant.Common.Agents.Interfaces;
using PersonalAssistant.Services.Common;

namespace Lab6.Agents
{
    public class BuyerAgent : ReceiveMessagesAgent,
        IHaveServiceProviders,
        IHandleMessages<AuctionStartedEvent>
    {
        public override void setup()
        {
            base.setup();

            RegisterToAuction();
        }

        private void RegisterToAuction()
        {
            foreach (var provider in Providers)
            {
                SendMessage(provider, new RegisterToAuctionRequest
                {
                    CorrelationId = Guid.NewGuid()
                });
            }
        }

        public List<AID> Providers { get; set; }

        public void FindMyServiceProviders()
        {
            Providers = ServiceLocator.Find("__AuctionManagerAgent", this);
        }

        public override void Handle(object message, AID sender)
        {
            if (message is AuctionStartedEvent)
            {
                Handle((AuctionStartedEvent)message, sender);
            }
        }

        public void Handle(AuctionStartedEvent message, AID sender)
        {
            Console.WriteLine($"{getLocalName()} - Auction Started.");
        }
    }
}