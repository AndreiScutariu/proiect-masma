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
                PrintInfomation($"Found Hotel: " + 
                                $"\r\n\tName: {hotel.Name}, " +
                                $"\r\n\tDescription: {hotel.Description}, " +
                                $"\r\n\tCountry: {hotel.Country}, " +
                                $"\r\n\tCity: {hotel.City}, " +
                                $"\r\n\tNumber of rooms: {hotel.NumberOfRooms}, " +
                                $"\r\n\tNumber of people per room: {hotel.NumberOfPeoplePerRoom}, " +
                                $"\r\n\tNumberOfStars: {hotel.NumberOfStars},"+
                                $"\r\n\tPrice: {hotel.Price}, ");
            }
        }

        public void Handle(FoundTransportServicesResponse message, AID sender)
        {
            foreach (var transport in message.Tranports)
            {
                PrintInfomation($"Found Transport:" +
                                $"\r\n\tName: {transport.Name}, " +
                                $"\r\n\tDescription: {transport.Description}, " +
                                $"\r\n\tFrom (Country): {transport.TransportFromCountry}, " +
                                $"\r\n\tFrom (City): {transport.TransportFromCity}, " +
                                $"\r\n\tTransport Type: {transport.TransportType}," +
                                $"\r\n\tPrice: {transport.Price}, ");
            }
        }

        public void Handle(FoundTouristAttractionServicesResponse message, AID sender)
        {
            foreach (var activity in message.Activities)
            {
                PrintInfomation($"Found Activity:" +
                                $"\r\n\tName: {activity.Name}, " +
                                $"\r\n\tDescription: {activity.Description}, " +
                                $"\r\n\tActivity Type: {activity.ActivityType}," +
                                $"\r\n\tEvent Date: {activity.DateStart} - {activity.DateEnd}," +
                                $"\r\n\tPrice: {activity.Price}, ");
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