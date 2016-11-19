using System;
using System.Collections.Generic;
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

        public override void setup()
        {
            base.setup();

            SendMessage(Resources.ServiceProviderAdress, new FindMyServicesRequest {CorrelationId = new Guid(), ServiceType = ServiceType.Hotel});
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
            foreach (var information in message.ServicesInformation)
            {
                Services.Add(JsonConvert.DeserializeObject<HotelServiceInformation>(information));
            }
        }

        public void Handle(NewServicesFound message, AID sender)
        {
            //TODO - Append the new services
        }

        #endregion Messaging
    }
}