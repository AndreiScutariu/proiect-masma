using jade.core;
using PersonalAssistant.Services.DataContract;
using PersonalAssistant.Services.DataContract.ServiceInformation;

namespace PersonalAssistant.Services.Internal.Agents
{
    public class HotelProviderAgent : ServiceProviderBaseAgent<HotelServiceInformation>
    {
        protected override ServiceType ServiceType => ServiceType.Hotel;

        protected override string ServiceName => "__HotelService";

        public override void Handle(object message, AID sender)
        {
            base.Handle(message, sender);
        }
    }
}