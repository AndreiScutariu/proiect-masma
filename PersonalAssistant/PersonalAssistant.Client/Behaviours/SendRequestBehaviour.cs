using jade.core.behaviours;
using PersonalAssistant.Client.Agents;

namespace PersonalAssistant.Client.Behaviours
{
    internal class SendRequestBehaviour : OneShotBehaviour
    {
        private readonly ClientAgent _clientAgent;

        public SendRequestBehaviour(ClientAgent clientAgent) : base(clientAgent)
        {
            _clientAgent = clientAgent;
        }

        public override void action()
        {
        }
    }
}