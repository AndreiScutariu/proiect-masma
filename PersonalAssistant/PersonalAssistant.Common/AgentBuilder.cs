namespace PersonalAssistant.Common
{
    using System;
    using System.Collections.Generic;

    using jade.core;
    using jade.core.behaviours;
    using jade.wrapper;

    using AgentContainer = jade.wrapper.AgentContainer;

    public class AgentBuilder
    {
        private readonly AgentContainer agentContainer;

        private readonly IList<Type> behaviourTypes;

        private string agentName;

        private Type typeOfAgent;

        public AgentBuilder(AgentContainer agentContainer)
        {
            this.agentContainer = agentContainer;
            behaviourTypes = new List<Type>();
        }

        public AgentBuilder Create<T>() where T : Agent
        {
            typeOfAgent = typeof(T);
            agentName = typeof(T).Name;

            return this;
        }

        public AgentBuilder Create<T>(string agentName) where T : Agent
        {
            typeOfAgent = typeof(T);
            this.agentName = agentName;

            return this;
        }

        public AgentBuilder WithBehaivour<T>() where T : Behaviour
        {
            behaviourTypes.Add(typeof(T));

            return this;
        }

        public AgentController Build()
        {
            var arguments = new object[behaviourTypes.Count];
            var idx = 0;

            foreach (var behaviourType in behaviourTypes)
            {
                arguments[idx++] = behaviourType;
            }

            behaviourTypes.Clear();
            return agentContainer.createNewAgent(agentName, typeOfAgent.FullName, arguments);
        }
    }
}