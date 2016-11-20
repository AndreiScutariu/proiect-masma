using jade.core;

namespace PersonalAssistant.Common.Agents.Interfaces
{
    public interface IHandleMessages<in T>
    {
        void Handle(T message, AID sender);
    }
}