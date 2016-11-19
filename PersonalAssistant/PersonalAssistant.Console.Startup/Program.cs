using System.Threading;
using jade.core;
using PersonalAssistant.Client;
using PersonalAssistant.Common;
using PersonalAssistant.Common.Behaviours;
using PersonalAssistant.Services.Internal;
using PersonalAssistant.Services.Internal.Agents;
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

            var serviceProvider = agentBuilder.Create<ServiceProviderAgent>().Build();
            serviceProvider.start();

            Thread.Sleep(2000);

            var client = agentBuilder.Create<ClientAgent>().Build();
            client.start();

            var hotelAgent = agentBuilder.Create<HotelProviderAgent>().Build();
            hotelAgent.start();
        }
    }
}