namespace PersonalAssistant.Client.UI.Agents
{
    using System;
    using System.Collections.Generic;

    using jade.core;

    using PersonalAssistant.Client.UI.Behaviours;
    using PersonalAssistant.Common.Agents;
    using PersonalAssistant.Common.Agents.Interfaces;
    using PersonalAssistant.Services.Common;
    using PersonalAssistant.Services.External.Messages.Contracts.Requests;
    using PersonalAssistant.Services.External.Messages.Contracts.Responses;

    public class ClientSearchVacantionPackageAgent : ReceiveMessagesAgent,
                                                     IHaveServiceProviders,
                                                     IHandleMessages<FoundHotelServicesResponse>,
                                                     IHandleMessages<FoundTransportServicesResponse>,
                                                     IHandleMessages<FoundTouristAttractionServicesResponse>
    {
        public DisplayForm Form { get; set; }

        public List<AID> Providers { get; set; }

        public Action<string> PrintInfomation { get; set; }

        public void Handle(FoundHotelServicesResponse message, AID sender)
        {
            foreach (var hotel in message.Hotels)
            {
                PrintInfomation($"Found Hotel: {hotel.Description}, {hotel.NumberOfStars}.");
            }
        }

        public void Handle(FoundTransportServicesResponse message, AID sender)
        {
            foreach (var transport in message.Tranports)
            {
                PrintInfomation($"Found Transport: {transport.Description}, {transport.TransportFromCity}.");
            }
        }

        public void Handle(FoundTouristAttractionServicesResponse message, AID sender)
        {
            foreach (var transport in message.Activities)
            {
                PrintInfomation($"Found Tourist: {transport.Description}, {transport.ActivityType}.");
            }
        }

        public void SearchInformations(IAggregateServicesRequest request)
        {
            foreach (var provider in Providers)
            {
                SendMessage(provider, request);
            }
        }

        public override void setup()
        {
            base.setup();

            InitWindowsForm();

            addBehaviour(new WinFormRefreshBehaviour(this));
        }

        private void InitWindowsForm()
        {
            Form = new DisplayForm { SearchActionAgentCallback = SearchInformations };

            PrintInfomation = Form.AddTextLine;

            Form.Show();
        }

        #region Factory

        public override void Handle(object message, AID sender)
        {
            if (message is FoundHotelServicesResponse)
            {
                Handle((FoundHotelServicesResponse)message, sender);
            }

            if (message is FoundTransportServicesResponse)
            {
                Handle((FoundTransportServicesResponse)message, sender);
            }

            if (message is FoundTouristAttractionServicesResponse)
            {
                Handle((FoundTouristAttractionServicesResponse)message, sender);
            }
        }

        public void FindMyServiceProviders()
        {
            Providers = new List<AID>();

            Providers.AddRange(ServiceLocator.Find("__TransportService", this));
            Providers.AddRange(ServiceLocator.Find("__HotelService", this));
            Providers.AddRange(ServiceLocator.Find("__TouristAttractionsService", this));
        }

        #endregion Factory
    }
}