using jade.core.behaviours;
using PersonalAssistant.Client.Agents;
using PersonalAssistant.Services.External.DataContract;
using PersonalAssistant.Services.External.DataContract.Messages.Client;

namespace PersonalAssistant.Client.Behaviours
{
    internal class FindSomeServicesRequestDemoBehaviour : OneShotBehaviour
    {
        private readonly ClientAgent _clientAgent;

        public FindSomeServicesRequestDemoBehaviour(ClientAgent clientAgent) : base(clientAgent)
        {
            _clientAgent = clientAgent;
        }

        public override void action()
        {
            var needServicesRequest = new AggregateServicesRequest
            {
                NumberOfStars = new Range<int> {Min = 1, Max = 3},
                Price = new Range<int> {Min = 100, Max = 300},
                YourLocation = "Home Location 2"
            };

            foreach (var provider in _clientAgent.Providers)
            {
                _clientAgent.SendMessage(provider, needServicesRequest);
            }
        }
    }
}