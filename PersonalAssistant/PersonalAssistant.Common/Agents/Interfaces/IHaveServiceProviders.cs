using System.Collections.Generic;
using jade.core;

namespace PersonalAssistant.Common.Agents.Interfaces
{
    public interface IHaveServiceProviders
    {
        List<AID> Providers { get; set; }

        void FindMyServiceProviders();
    }
}