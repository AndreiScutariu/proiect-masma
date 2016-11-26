using System;
using System.Threading;
using jade.core;
using Lab6.Agents;
using PersonalAssistant.Common;
using AgentContainer = jade.wrapper.AgentContainer;

namespace Lab6.Startup
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

            var auctionManagerAgent = agentBuilder.Create<AuctionManagerAgent>().Build();
            auctionManagerAgent.start();

            Thread.Sleep(2000);
            Console.WriteLine();

            var buyerAgent = agentBuilder.Create<BuyerAgent>().Build();
            buyerAgent.start();
        }
    }
}