using PersonalAssistant.Common.Messages;

namespace Lab6.Messages
{
    public class AuctionStartedEvent : HeaderMessage
    {
        public string ProductName { get; set; }

        public int ProductPrice { get; set; }
    }
}