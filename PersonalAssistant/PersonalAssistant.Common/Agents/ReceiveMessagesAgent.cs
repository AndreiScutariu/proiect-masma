using jade.core;

namespace PersonalAssistant.Common.Agents
{
    public abstract class ReceiveMessagesAgent : BaseAgent
    {
        public abstract void Handle(object message, AID sender);
    }
}