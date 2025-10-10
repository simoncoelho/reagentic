using OpenAI;
using System;

namespace Reagentic.Agents;

internal static class GlobalConfig
{
    internal const string OpenAIKey = "OPENAI_API_KEY";

    internal static OpenAIClient GetOpenAIClient() => new OpenAIClient(Environment.GetEnvironmentVariable(OpenAIKey));


}
