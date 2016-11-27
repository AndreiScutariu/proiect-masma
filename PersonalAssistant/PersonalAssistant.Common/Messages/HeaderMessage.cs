namespace PersonalAssistant.Common.Messages
{
    using System;

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