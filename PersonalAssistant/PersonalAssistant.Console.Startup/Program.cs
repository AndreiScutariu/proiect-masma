using System.Threading;
using jade.core;
using PersonalAssistant.Client.Agents;
using PersonalAssistant.Common;
using PersonalAssistant.Services.Internal.Agents;
using PersonalAssistant.Services.Internal.ServiceFinder;
using AgentContainer = jade.wrapper.AgentContainer;

namespace PersonalAssistant.Console.Startup
{
    internal class Program
    {
        private static AgentContainer CreateAgentContainer()
        {
            var p = new ProfileImpl();
            var rt = Runtime.instance();
            return rt.createMainContainer(p);
        }

        private static void Main(string[] args)
        {
            var mc = CreateAgentContainer();
            var agentBuilder = new AgentBuilder(mc);

            var serviceProvider = agentBuilder.Create<ServiceFinderAgent>().Build();
            serviceProvider.start();

            Thread.Sleep(2000);
            System.Console.WriteLine();

            var hotelAgent = agentBuilder.Create<HotelProviderAgent>().Build();
            hotelAgent.start();

            var transportAgent = agentBuilder.Create<TransportProviderAgent>().Build();
            transportAgent.start();

            Thread.Sleep(2000);
            System.Console.WriteLine();

            var client = agentBuilder.Create<ClientAgent>().Build();
            client.start();
        }
    }
}