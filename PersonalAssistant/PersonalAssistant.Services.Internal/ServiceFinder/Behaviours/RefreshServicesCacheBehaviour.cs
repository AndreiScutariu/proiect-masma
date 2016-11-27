namespace PersonalAssistant.Services.Internal.ServiceFinder.Behaviours
{
    using System.IO;
    using System.Linq;

    using jade.core.behaviours;

    using Newtonsoft.Json;

    using PersonalAssistant.Services.Common;
    using PersonalAssistant.Services.DataContract;

    internal class RefreshServicesCacheBehaviour : TickerBehaviour
    {
        private readonly ServiceFinderAgent agent;

        public RefreshServicesCacheBehaviour(ServiceFinderAgent agent)
            : base(agent, 100)
        {
            this.agent = agent;
        }

        public override void onTick()
        {
            agent.ClearExistingServices();

            foreach (var content in Directory.GetFiles(Resources.DropFolderPaht).Select(File.ReadAllText))
            {
                agent.RegisterNewService(JsonConvert.DeserializeObject<Service>(content));
            }
        }
    }
}