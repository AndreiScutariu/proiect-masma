using jade.core;
using jade.lang.acl;
using Newtonsoft.Json;
using PersonalAssistant.Common.Behaviours;

namespace PersonalAssistant.Common.Agents
{
    public abstract class ReceiveMessagesAgent : BaseAgent
    {
        public override void setup()
        {
            base.setup();

            addBehaviour(new ReceiveMessagesBehaviour(this));
        }

        public abstract void Handle(object message, AID sender);

        public void SendMessage(AID to, object info, int type = ACLMessage.REQUEST)
        {
            var reply = new ACLMessage(type);
            var receiverAid = new AID(to.getLocalName(), AID.ISLOCALNAME);
            reply.addReceiver(receiverAid);

            reply.setContent(JsonConvert.SerializeObject(info));
            send(reply);
        }
    }
}