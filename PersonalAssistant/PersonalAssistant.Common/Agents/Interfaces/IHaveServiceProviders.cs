namespace PersonalAssistant.Common.Agents.Interfaces
{
    using System.Collections.Generic;

    using jade.core;

    public interface IHaveServiceProviders
    {
        List<AID> Providers { get; set; }

        void FindMyServiceProviders();
    }
}