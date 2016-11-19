using jade.core.behaviours;
using Newtonsoft.Json;
using PersonalAssistant.Common.Agents;
using PersonalAssistant.Common.Agents.Interfaces;
using PersonalAssistant.Common.Messages;

namespace PersonalAssistant.Common.Behaviours
{
    public class ReceiveMessagesBehaviour : CyclicBehaviour, INeedSpecificAgent
    {
        private readonly ReceiveMessagesAgent _agent;

        public ReceiveMessagesBehaviour(ReceiveMessagesAgent agent) : base(agent)
        {
            _agent = agent;
        }

        public override void action()
        {
            var message = _agent.receive();

            if (message != null)
            {
                var content = message.getContent();
                var sender = message.getSender();

                var receivedMessage = JsonConvert.DeserializeObject<HeaderMessage>(content);
                var type = receivedMessage.Type;

                var instance = MessageDeserializer.GetMessageInstance(type, content);

                _agent.Handle(instance, sender);
            }
            else
            {
                block();
            }
        }
    }
}