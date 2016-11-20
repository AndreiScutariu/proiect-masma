using System;
using System.Collections.Generic;
using jade.core;
using PersonalAssistant.Client.Behaviours;
using PersonalAssistant.Common.Agents;
using PersonalAssistant.Common.Agents.Interfaces;
using PersonalAssistant.Services.Common;
using PersonalAssistant.Services.External.DataContract.Contracts.Responses;

namespace PersonalAssistant.Client.Agents
{
    public class ClientAgent : ReceiveMessagesAgent,
        IHaveServiceProviders,
        IHandleMessages<FoundHotelServicesResponse>,
        IHandleMessages<FoundTransportServicesResponse>
    {
        public void Handle(FoundHotelServicesResponse message, AID sender)
        {
            foreach (var hotel in message.Hotels)
            {
                Console.WriteLine($"Found Hotel: {hotel.Description}, {hotel.NumberOfStars}.");
            }
        }

        public void Handle(FoundTransportServicesResponse message, AID sender)
        {
            foreach (var transport in message.Tranports)
            {
                Console.WriteLine($"Found Transport: {transport.Description}, {transport.YourLocation}.");
            }
        }

        public List<AID> Providers { get; set; }

        public void FindMyServiceProviders()
        {
            Providers = new List<AID>();

            Providers.AddRange(ServiceLocator.Find("__TransportService", this));
            Providers.AddRange(ServiceLocator.Find("__HotelService", this));
        }

        public override void setup()
        {
            base.setup();

            addBehaviour(new FindSomeServicesRequestDemoBehaviour(this));
        }

        public override void Handle(object message, AID sender)
        {
            if (message is FoundHotelServicesResponse)
            {
                Handle((FoundHotelServicesResponse) message, sender);
            }

            if (message is FoundTransportServicesResponse)
            {
                Handle((FoundTransportServicesResponse) message, sender);
            }
        }
    }
}