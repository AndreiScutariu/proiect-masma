using jade.core;
using jade.core.behaviours;
using PersonalAssistant.Common.Agents;

namespace PersonalAssistant.Client
{
    public class ClientAgent : ReceiveMessagesAgent
    {
        public override void setup()
        {
            base.setup();

            addBehaviour(new SendRequestBehaviour());
        }

        public override void Handle(object message, AID sender)
        {
        }

        private class SendRequestBehaviour : OneShotBehaviour
        {
            public override void action()
            {
            }
        }
    }
}