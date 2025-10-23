using Reagentic.Agents;
using Microsoft.Agents.AI;
using OpenAI;

namespace Reagentic.Agents;

public static partial class UserProxyAgent
{
    public static AIAgent GetAgent()
    {
        return new ChatClientAgent(GlobalConfig.GetOpenAIClient(),
            new ChatClientAgentOptions()
            {
                Name = Name,
                Instructions = SystemMessage
            });
    }
}
