namespace PersonalAssistant.Client.Behaviours
{
    using jade.core.behaviours;

    using PersonalAssistant.Client.Agents;
    using PersonalAssistant.Services.External.DataContract;
    using PersonalAssistant.Services.External.DataContract.Messages.Client;

    internal class FindSomeServicesRequestDemoBehaviour : OneShotBehaviour
    {
        private readonly ClientAgent clientAgent;

        public FindSomeServicesRequestDemoBehaviour(ClientAgent clientAgent)
            : base(clientAgent)
        {
            this.clientAgent = clientAgent;
        }

        public override void action()
        {
            var needServicesRequest = new AggregateServicesRequest
                                          {
                                              NumberOfStars = new Range<int> { Min = 1, Max = 3 },
                                              Price = new Range<int> { Min = 100, Max = 300 },
                                              YourLocation = "Home Location 2"
                                          };

            foreach (var provider in clientAgent.Providers)
            {
                clientAgent.SendMessage(provider, needServicesRequest);
            }
        }
    }
}