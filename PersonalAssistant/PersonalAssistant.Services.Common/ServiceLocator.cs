namespace PersonalAssistant.Services.Common
{
    using System.Collections.Generic;

    using jade.core;
    using jade.domain;
    using jade.domain.FIPAAgentManagement;

    //TODO - Reimplement this to use timeouts, and implement a load balancer
    public class ServiceLocator
    {
        //TODO - Refactor to support list of service names
        public static List<AID> Find(string serviceName, Agent myAgent)
        {
            var providers = new List<AID>();
            var found = false;

            while (!found)
            {
                var template = new DFAgentDescription();
                var sd = new ServiceDescription();
                sd.setType(serviceName);
                template.addServices(sd);

                DFAgentDescription[] result = DFService.search(myAgent, template);

                if (result == null || result.Length <= 0)
                {
                    continue;
                }

                foreach (var t in result)
                {
                    providers.Add(t.getName());
                    found = true;
                }
            }

            return providers;
        }

        public static void Register(string serviceName, Agent myAgent)
        {
            var dfd = new DFAgentDescription();
            dfd.setName(myAgent.getAID());
            var sd = new ServiceDescription();
            sd.setType(serviceName);
            sd.setName(serviceName);
            dfd.addServices(sd);
            DFService.register(myAgent, dfd);
        }

        public static void Deregister(Agent myAgent)
        {
            DFService.deregister(myAgent);
        }
    }
}