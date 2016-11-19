using System;
using System.Collections.Generic;
using System.Linq;
using jade.core;
using Newtonsoft.Json;
using PersonalAssistant.Common.Agents;
using PersonalAssistant.Services.Common;
using PersonalAssistant.Services.DataContract;
using PersonalAssistant.Services.DataContract.Messages;
using PersonalAssistant.Services.DataContract.ServiceInformation;

namespace PersonalAssistant.Services.Internal.Agents
{
    public class HotelProviderAgent : ReceiveMessagesAgent,
        IHandleMessages<ServicesFoundResponse>,
        IHandleMessages<NewServicesFound>
    {
        public List<HotelServiceInformation> Services;

        private Func<string, HotelServiceInformation> Deserializer
            => JsonConvert.DeserializeObject<HotelServiceInformation>;

        public override void setup()
        {
            base.setup();

            DoRequestForInitialServices();
        }

        private void DoRequestForInitialServices()
        {
            Services = new List<HotelServiceInformation>();

            var serviceProviderAddress = ServiceLocator.Find("__ServiceProvider", this).First();
            var message = new FindMyServicesRequest {CorrelationId = new Guid(), ServiceType = ServiceType.Hotel};

            SendMessage(serviceProviderAddress, message);
        }

        #region Messaging

        public override void Handle(object message, AID sender)
        {
            if (message is ServicesFoundResponse)
            {
                Handle((ServicesFoundResponse) message, sender);
            }

            if (message is NewServicesFound)
            {
                Handle((NewServicesFound) message, sender);
            }
        }

        public void Handle(ServicesFoundResponse message, AID sender)
        {
            foreach (var hotelServiceInformation in message.ServicesInformation.Select(Deserializer))
            {
                Services.Add(hotelServiceInformation);
            }

            Console.WriteLine($"I have {Services.Count} services.");
        }

        public void Handle(NewServicesFound message, AID sender)
        {
            //TODO - Append the new services
        }

        #endregion Messaging
    }
}