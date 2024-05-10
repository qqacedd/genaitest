using Azure;
using Azure.AI.OpenAI;

internal class Program
{
    private static async Task Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Uri azureOpenAIResourceUri = new("https://abcgenaidemo.openai.azure.com/");
        AzureKeyCredential azureOpenAIApiKey = new("ad468b0125824c3cbc611ef7753e9642");
        OpenAIClient client = new(azureOpenAIResourceUri, azureOpenAIApiKey);

        var request = new ImageGenerationOptions
        {
            Prompt = "A cute kitten in a basket",
            DeploymentName = "dall-e-3"
        };

        var response = await client.GetImageGenerationsAsync(request);
        Console.WriteLine("Image URL: {0}", response.Value.Data[0].Url.AbsoluteUri);
    }
}