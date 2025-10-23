using Microsoft.Agents.AI;
using Microsoft.Agents.AI.Workflows;

namespace Reagentic.Agents.Workflows
{
    public class DemoWorkflow
    {
        AIAgent UserProxy = UserProxyAgent.GetAgent();
        AIAgent Critic = CriticAgent.GetAgent();
        IEnumerable<AIAgent> AllAgents;
        Workflow Workflow;

        public DemoWorkflow()
        {
            AllAgents = new List<AIAgent>() { UserProxy, Critic };
        }

        public CreateWorkflow()
        {
            Workflow = AgentWorkflowBuilder.BuildSequential(AllAgents);    
        }
    }
}
