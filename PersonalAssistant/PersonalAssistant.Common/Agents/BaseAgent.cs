namespace PersonalAssistant.Common.Agents
{
    using System;
    using System.Linq;

    using jade.core;
    using jade.core.behaviours;

    using PersonalAssistant.Common.Agents.Interfaces;

    public class BaseAgent : Agent
    {
        public override void setup()
        {
            LogMyDetails();

            object[] arguments = getArguments();

            foreach (var type in arguments.Cast<Type>())
            {
                Behaviour instance;

                if (typeof(INeedSpecificAgent).IsAssignableFrom(type))
                {
                    instance = Activator.CreateInstance(type, this) as Behaviour;
                }
                else
                {
                    instance = Activator.CreateInstance(type) as Behaviour;
                }

                addBehaviour(instance);
            }

            InitializeMyDependencies();
        }

        public override void takeDown()
        {
            Console.WriteLine(
                "Agent " + getLocalName() + " is being removed from " + getContainerController().getContainerName()
                + "... \n");
        }

        protected void LogMyDetails()
        {
            Console.WriteLine(
                "I'm " + getLocalName() + " and I'm living in " + getContainerController().getContainerName());
        }

        private void InitializeMyDependencies()
        {
            var myType = GetType();

            if (typeof(INeedToRegisterInServiceLocator).IsAssignableFrom(myType))
            {
                (this as INeedToRegisterInServiceLocator)?.RegisterInTheServiceLocator();
            }

            if (typeof(IHaveServiceProviders).IsAssignableFrom(myType))
            {
                (this as IHaveServiceProviders)?.FindMyServiceProviders();
            }
        }
    }
}