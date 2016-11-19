using jade.core;

namespace PersonalAssistant.Common.Agents
{
    public interface IHandleMessages<in T>
    {
        void Handle(T message, AID sender);
    }
}