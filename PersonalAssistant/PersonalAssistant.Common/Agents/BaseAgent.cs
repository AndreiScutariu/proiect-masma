using System;
using jade.core;
using jade.core.behaviours;
using PersonalAssistant.Common.Agents.Interfaces;

namespace PersonalAssistant.Common.Agents
{
    public class BaseAgent : Agent
    {
        public override void setup()
        {
            LogMyDetails();

            var arguments = getArguments();

            foreach (var argument in arguments)
            {
                var type = (Type) argument;
                Behaviour instance;

                if (typeof (INeedSpecificAgent).IsAssignableFrom(type))
                {
                    instance = Activator.CreateInstance(type, this) as Behaviour;
                }
                else
                {
                    instance = Activator.CreateInstance(type) as Behaviour;
                }

                addBehaviour(instance);
            }
        }

        protected void LogMyDetails()
        {
            Console.WriteLine("I'm " + getLocalName() + " and I'm living in " + getContainerController().getContainerName());
        }

        public override void takeDown()
        {
            Console.WriteLine("Agent " + getLocalName() + " is being removed from " + getContainerController().getContainerName() + "... \n");
        }
    }
}