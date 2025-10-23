using Microsoft.Extensions.AI;
using OpenAI;
using System;

namespace Reagentic.Agents;

internal static class GlobalConfig
{
    internal const string OpenAIKey = "OPENAI_API_KEY";
    internal const string ChatModel = "gpt-4o-mini";

    internal static IChatClient GetOpenAIClient() => new OpenAIClient(Environment.GetEnvironmentVariable(OpenAIKey)).GetChatClient(ChatModel).AsIChatClient();


}
