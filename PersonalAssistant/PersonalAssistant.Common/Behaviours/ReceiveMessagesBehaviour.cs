namespace PersonalAssistant.Common.Behaviours
{
    using jade.core.behaviours;

    using Newtonsoft.Json;

    using PersonalAssistant.Common.Agents;
    using PersonalAssistant.Common.Agents.Interfaces;
    using PersonalAssistant.Common.Messages;

    public class ReceiveMessagesBehaviour : CyclicBehaviour, INeedSpecificAgent
    {
        private readonly ReceiveMessagesAgent agent;

        public ReceiveMessagesBehaviour(ReceiveMessagesAgent agent)
            : base(agent)
        {
            this.agent = agent;
        }

        public override void action()
        {
            var message = agent.receive();

            if (message != null)
            {
                var content = message.getContent();
                var sender = message.getSender();

                var receivedMessage = JsonConvert.DeserializeObject<HeaderMessage>(content);
                var type = receivedMessage.Type;

                var instance = MessageDeserializer.GetMessageInstance(type, content);

                agent.Handle(instance, sender);
            }
            else
            {
                block();
            }
        }
    }
}