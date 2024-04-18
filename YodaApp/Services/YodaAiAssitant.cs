using Azure;
using Azure.AI.OpenAI;
using YodaApp.Configuration;
using YodaApp.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YodaApp.Services
{
    public class YodaAiAssistant : IAiAssistant
    {
        private ISetting _settings;
        private const string AssistantBehaviorDescription = "I am an AI assistant that can generate fun facts in a Yoda-like manner.";

        public YodaAiAssistant(ISetting settings)
        {
            _settings = settings;
        }

        public async Task<ChatMessage> GetFunFact()
        {
            try
            {
                var client = new OpenAIClient(new Uri("https://loadsheddingkmpopenai.openai.azure.com/"), new AzureKeyCredential(_settings.AzureOpenAiKey));

                string deploymentName = "gpt35turbo16";
                string funfact = "Give a fun fact";

                var chatCompletionsOptions = new ChatCompletionsOptions()
                {
                    Messages =
                    {
                        new ChatMessage(ChatRole.System, AssistantBehaviorDescription),
                        new ChatMessage(ChatRole.User, funfact)
                    }
                };

                Response<ChatCompletions> response = await client.GetChatCompletionsAsync(deploymentName, chatCompletionsOptions);
                ChatMessage responseMessage = response.Value.Choices[0].Message;

                return responseMessage;
            }
            catch (Exception ex)
            {
                // Handle exception here
            }

            return null;
        }

        /*public Task<ChatMessage> GetCompletion()
        {
            return GetFunFact();
        }*/
    }
}
