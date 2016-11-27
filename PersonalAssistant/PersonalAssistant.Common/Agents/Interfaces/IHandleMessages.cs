namespace PersonalAssistant.Common.Agents.Interfaces
{
    using jade.core;

    public interface IHandleMessages<in T>
    {
        void Handle(T message, AID sender);
    }
}