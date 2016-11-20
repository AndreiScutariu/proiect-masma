using System;
using System.Collections.Generic;
using System.Linq;
using jade.core;
using Newtonsoft.Json;
using PersonalAssistant.Common.Agents;
using PersonalAssistant.Services.Common;
using PersonalAssistant.Services.DataContract;
using PersonalAssistant.Services.DataContract.Messages;

namespace PersonalAssistant.Services.Internal.Agents
{
    public abstract class ServiceProviderBaseAgent<T> : ReceiveMessagesAgent,
        IHandleMessages<ServicesFoundResponse>,
        IHandleMessages<NewServicesFound>
    {
        protected List<T> Services;

        protected abstract ServiceType ServiceType { get; }

        protected abstract string ServiceName { get; }

        private Func<string, T> DeserializeWith => JsonConvert.DeserializeObject<T>;

        public void Handle(NewServicesFound message, AID sender)
        {
        }

        public void Handle(ServicesFoundResponse message, AID sender)
        {
            foreach (var hotelServiceInformation in message.ServicesInformation.Select(DeserializeWith))
            {
                Services.Add(hotelServiceInformation);
            }

            Console.WriteLine($"I have {Services.Count} services.");
        }

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

        public override void setup()
        {
            base.setup();

            DoRequestForInitialServices();
        }

        private void DoRequestForInitialServices()
        {
            Services = new List<T>();

            var serviceProviderAddress = ServiceLocator.Find("__ServiceFinder", this).First();
            var message = new FindMyServicesRequest {CorrelationId = new Guid(), ServiceType = ServiceType};

            SendMessage(serviceProviderAddress, message);
        }
    }
}