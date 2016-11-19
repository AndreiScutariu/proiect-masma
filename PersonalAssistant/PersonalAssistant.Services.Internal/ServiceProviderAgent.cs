using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using jade.core;
using jade.core.behaviours;
using Newtonsoft.Json;
using PersonalAssistant.Common.Agents;
using PersonalAssistant.Services.Common;
using PersonalAssistant.Services.DataContract.Messages;
using Service = PersonalAssistant.Services.DataContract.Service;

namespace PersonalAssistant.Services.Internal
{
    public class ServiceProviderAgent : ReceiveMessagesAgent,
        IHandleMessages<FindMyServicesRequest>
    {
        private List<Service> _services;

        public override void setup()
        {
            base.setup();

            addBehaviour(new RefreshServicesCacheBehaviour(this));

            _services = new List<Service>();
        }

        public void ClearExistingServices()
        {
            _services.Clear();
        }

        public void RegisterNewService(Service service)
        {
            _services.Add(service);
        }

        #region Behaviours

        private class RefreshServicesCacheBehaviour : TickerBehaviour
        {
            private readonly ServiceProviderAgent _a;

            public RefreshServicesCacheBehaviour(ServiceProviderAgent a) : base(a, 1000)
            {
                _a = a;
            }

            public override void onTick()
            {
                //TODO - Read only new services. Push the new services to specific agents

                _a.ClearExistingServices(); //TODO - Remove this

                foreach (var content in Directory.GetFiles(Resources.DropFolderPaht).Select(File.ReadAllText))
                {
                    _a.RegisterNewService(JsonConvert.DeserializeObject<Service>(content));
                }
            }
        }

        #endregion Behaviours

        #region Messaging

        public override void Handle(object message, AID sender)
        {
            if (message is FindMyServicesRequest)
            {
                Handle((FindMyServicesRequest) message, sender);
            }
        }

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

        #endregion Messaging
    }
}