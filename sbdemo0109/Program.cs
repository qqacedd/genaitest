using AzureOpenAI;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Uri azureOpenAIResourceUri = new("https://abcgenaidemo.openai.azure.com/");
AzureKeyCredential azureOpenAIApiKey = new(Environment.GetEnvironmentVariable("Aad468b0125824c3cbc611ef7753e9642"));
OpenAIClient client = new(azureOpenAIResourceUri, azureOpenAIApiKey);

var request = new AzureOpenAI.Image.ImageGenerations
{
    Prompt = "A cute kitten in a basket"
};

var response = api.ImageGenerations.CreateImageAsync(request);
Console.WriteLine("Image URL: {0}", response.Data[0].Url);
