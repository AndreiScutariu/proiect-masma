using System;
using jade.core;
using PersonalAssistant.Common.Agents.Interfaces;
using PersonalAssistant.Services.DataContract;
using PersonalAssistant.Services.DataContract.ServiceInformation;
using PersonalAssistant.Services.External.DataContract.Contracts.Requests;
using PersonalAssistant.Services.Internal.Agents.Base;

namespace PersonalAssistant.Services.Internal.Agents
{
    public class HotelProviderAgent : ServiceProviderAgent<HotelServiceInformation>,
        IHandleMessages<INeedHotelServicesRequest>
    {
        protected override ServiceType ServiceType => ServiceType.Hotel;

        protected override string ServiceName => "__HotelService";

        public void Handle(INeedHotelServicesRequest message, AID sender)
        {
            Console.WriteLine($"{ServiceName} - Handle a request.");
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