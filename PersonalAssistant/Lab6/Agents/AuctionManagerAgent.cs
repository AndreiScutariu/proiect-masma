using jade.core;
using Lab6.Messages;
using PersonalAssistant.Common.Agents;
using PersonalAssistant.Common.Agents.Interfaces;
using PersonalAssistant.Services.Common;

namespace Lab6.Agents
{
    public class AuctionManagerAgent : ReceiveMessagesAgent,
        INeedToRegisterInServiceLocator,
        IHandleMessages<RegisterToAuctionRequest>
    {
        public void RegisterInTheServiceLocator()
        {
            ServiceLocator.Register("__AuctionManagerAgent", this);
        }

        public override void Handle(object message, AID sender)
        {
            if (message is RegisterToAuctionRequest)
            {
                Handle((RegisterToAuctionRequest)message, sender);
            }
        }

        public void Handle(RegisterToAuctionRequest message, AID sender)
        {
        }
    }
}