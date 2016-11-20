using System.Linq;
using jade.core;
using PersonalAssistant.Common.Agents.Interfaces;
using PersonalAssistant.Services.DataContract;
using PersonalAssistant.Services.DataContract.ServiceInformation;
using PersonalAssistant.Services.External.DataContract.Contracts.Requests;
using PersonalAssistant.Services.External.DataContract.Messages.Client;
using PersonalAssistant.Services.Internal.Agents.Base;
using PersonalAssistant.Services.Internal.Agents.QueryBuilder;

namespace PersonalAssistant.Services.Internal.Agents
{
    public class HotelProviderAgent : ServiceProviderAgent<HotelServiceInformation>,
        IHandleMessages<INeedHotelServicesRequest>
    {
        protected override ServiceType ServiceType => ServiceType.Hotel;

        protected override string ServiceName => "__HotelService";

        public void Handle(INeedHotelServicesRequest message, AID sender)
        {
            SendMessage(sender, new FoundHotelServicesResponse
            {
                Hotels = Services.GetFor(message).ToList()
            });
        }

        public override void Handle(object message, AID sender)
        {
            base.Handle(message, sender);

            if (message is INeedHotelServicesRequest)
            {
                Handle((INeedHotelServicesRequest) message, sender);
            }
        }
    }
}