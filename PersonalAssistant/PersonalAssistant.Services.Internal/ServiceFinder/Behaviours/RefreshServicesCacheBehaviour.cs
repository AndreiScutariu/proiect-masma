using System.IO;
using System.Linq;
using jade.core.behaviours;
using Newtonsoft.Json;
using PersonalAssistant.Services.Common;
using PersonalAssistant.Services.DataContract;

namespace PersonalAssistant.Services.Internal.ServiceFinder.Behaviours
{
    internal class RefreshServicesCacheBehaviour : TickerBehaviour
    {
        private readonly ServiceFinderAgent _a;

        public RefreshServicesCacheBehaviour(ServiceFinderAgent a) : base(a, 1000)
        {
            _a = a;
        }

        public override void onTick()
        {
            _a.ClearExistingServices();

            foreach (var content in Directory.GetFiles(Resources.DropFolderPaht).Select(File.ReadAllText))
            {
                _a.RegisterNewService(JsonConvert.DeserializeObject<Service>(content));
            }
        }
    }
}