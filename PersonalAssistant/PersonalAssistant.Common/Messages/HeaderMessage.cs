using System;

namespace PersonalAssistant.Common.Messages
{
    public class HeaderMessage
    {
        public HeaderMessage()
        {
            Type = GetType();
        }

        public Guid CorrelationId { get; set; }

        public Type Type { get; set; }
    }
}