using Azure;
using Azure.AI.OpenAI;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using Microsoft.Extensions.Configuration;

namespace LoanPortalAPIDev.Utilities
{
    
    public class AI
    {
        //OpenAI git commit3
        private IConfigurationRoot config = new ConfigurationBuilder()
            .AddUserSecrets<Program>()
            .Build();

        
        public async Task<string> Chat(string msg) {
            OpenAIClient client = new OpenAIClient(config["OpenAIClientAPIKey"]);

            var chatCompletions = new ChatCompletionsOptions()
            {
                DeploymentName = "gpt-3.5-turbo",
                Messages = {
                    new ChatRequestSystemMessage("You are a professional assistant."),
                    new ChatRequestUserMessage("Can you help me?"),
                    new ChatRequestUserMessage("Hello!, Of course, what can I do for you?"),
                    new ChatRequestUserMessage(msg)
                }
            };

            Response<ChatCompletions> response = await client.GetChatCompletionsAsync(chatCompletions);
            ChatResponseMessage responseMessage = response.Value.Choices[0].Message;

            return responseMessage.Content.ToString();

        }
    }
}
