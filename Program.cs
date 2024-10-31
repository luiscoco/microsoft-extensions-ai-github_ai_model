using Azure;
using Azure.AI.Inference;
using Microsoft.Extensions.AI;

var endpoint = new Uri("https://models.inference.ai.azure.com");
var modelId = "gpt-4o";

//https://github.com/marketplace/models
var credential = new AzureKeyCredential("");

IChatClient client =
    new ChatCompletionsClient(endpoint, credential)
        .AsChatClient(modelId);

var response = await client.CompleteAsync("Hello");

Console.WriteLine(response.Message);