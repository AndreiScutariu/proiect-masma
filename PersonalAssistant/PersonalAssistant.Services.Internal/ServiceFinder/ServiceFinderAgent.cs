using System.Collections.Generic;
using System.Linq;
using jade.core;
using PersonalAssistant.Common.Agents;
using PersonalAssistant.Services.Common;
using PersonalAssistant.Services.DataContract.Messages;
using PersonalAssistant.Services.Internal.Interfaces;
using PersonalAssistant.Services.Internal.ServiceFinder.Behaviours;
using Service = PersonalAssistant.Services.DataContract.Service;

namespace PersonalAssistant.Services.Internal.ServiceFinder
{
    public class ServiceFinderAgent : ReceiveMessagesAgent,
        INeedToRegisterInServiceLocator,
        IHandleMessages<FindMyServicesRequest>
    {
        private List<Service> _services;

        public void Handle(FindMyServicesRequest message, AID sender)
        {
            SendMessage(sender, new ServicesFoundResponse
            {
                CorrelationId = message.CorrelationId,
                ServicesInformation = _services.Where(service => service.ServiceType == message.ServiceType)
                    .Select(service => service.ServiceInformation)
                    .ToList()
            });
        }
        public override void Handle(object message, AID sender)
        {
            if (message is FindMyServicesRequest)
            {
                Handle((FindMyServicesRequest)message, sender);
            }
        }

        public void Register()
        {
            ServiceLocator.Register("__ServiceFinder", this);
        }

        public override void setup()
        {
            base.setup();

            _services = new List<Service>();

            addBehaviour(new RefreshServicesCacheBehaviour(this));
        }

        public void ClearExistingServices()
        {
            _services.Clear();
        }

        public void RegisterNewService(Service service)
        {
            _services.Add(service);
        }
    }
}