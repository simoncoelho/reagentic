using Reagentic.Agents;
using Microsoft.Agents.AI;
using OpenAI;

namespace Reagentic.Agents.UserProxyAgent;

public class UserProxyAgent : IReagent
{
    public AIAgent GetAgent()
    {
        return GlobalConfig
        .GetOpenAIClient()
        .GetChatClient("gpt-4o-mini")
        .CreateAIAgent(name: Config.Name, instructions: Config.SystemMessage);
    }
}
