namespace PersonalAssistant.Client.UI
{
    using System;
    using System.Threading;
    using System.Windows.Forms;

    using jade.core;

    using PersonalAssistant.Client.UI.Agents;
    using PersonalAssistant.Common;
    using PersonalAssistant.Services.Internal.Agents;
    using PersonalAssistant.Services.Internal.ServiceFinder;

    using AgentContainer = jade.wrapper.AgentContainer;

    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            var mc = CreateAgentContainer();
            var agentBuilder = new AgentBuilder(mc);

            var serviceProvider = agentBuilder.Create<ServiceFinderAgent>().Build();
            serviceProvider.start();

            Thread.Sleep(1000);

            var hotelAgent = agentBuilder.Create<HotelProviderAgent>().Build();
            hotelAgent.start();

            var transportAgent = agentBuilder.Create<TransportProviderAgent>().Build();
            transportAgent.start();

            var attractionAgent = agentBuilder.Create<TouristAttractionsAgent>().Build();
            attractionAgent.start();

            Thread.Sleep(1000);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var client = agentBuilder.Create<ClientSearchVacantionPackageAgent>().Build();
            client.start();
        }

        private static AgentContainer CreateAgentContainer()
        {
            var p = new ProfileImpl();
            var rt = Runtime.instance();
            return rt.createMainContainer(p);
        }
    }
}