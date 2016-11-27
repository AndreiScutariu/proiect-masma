namespace PersonalAssistant.Services.Internal.ServiceFinder
{
    using System.Collections.Generic;
    using System.Linq;

    using jade.core;

    using PersonalAssistant.Common.Agents;
    using PersonalAssistant.Common.Agents.Interfaces;
    using PersonalAssistant.Services.Common;
    using PersonalAssistant.Services.DataContract.Messages;
    using PersonalAssistant.Services.Internal.ServiceFinder.Behaviours;

    using Service = PersonalAssistant.Services.DataContract.Service;

    public class ServiceFinderAgent : ReceiveMessagesAgent,
                                      INeedToRegisterInServiceLocator,
                                      IHandleMessages<FindMyServicesRequest>
    {
        private List<Service> services;

        public void Handle(FindMyServicesRequest message, AID sender)
        {
            SendMessage(
                sender,
                new ServicesFoundResponse
                    {
                        CorrelationId = message.CorrelationId,
                        ServicesInformation =
                            services.Where(service => service.ServiceType == message.ServiceType)
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

        public void RegisterInTheServiceLocator()
        {
            ServiceLocator.Register("__ServiceFinder", this);
        }

        public override void setup()
        {
            base.setup();

            services = new List<Service>();

            addBehaviour(new RefreshServicesCacheBehaviour(this));
        }

        public void ClearExistingServices()
        {
            services.Clear();
        }

        public void RegisterNewService(Service service)
        {
            services.Add(service);
        }
    }
}