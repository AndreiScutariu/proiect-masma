namespace PersonalAssistant.Client.UI.Behaviours
{
    using jade.core.behaviours;

    using PersonalAssistant.Client.UI.Agents;

    public class WinFormRefreshBehaviour : TickerBehaviour
    {
        private readonly ClientSearchVacantionPackageAgent agent;

        public WinFormRefreshBehaviour(ClientSearchVacantionPackageAgent agent)
            : base(agent, 10)
        {
            this.agent = agent;
        }

        public override void onTick()
        {
            agent.Form.DoEvents();
        }
    }
}