using System.Text;
using System.Text.Json;

namespace GenAiDay2.Services
{
    public class AIService
    {
        public async Task<string>AskAsync(string pdfText,string question) 
        {
            //Read API Key and model from App Settings 
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            string apiKey = configuration["Gemini:ApiKey"]!;
            string model = configuration["Gemini:ChatModel"]!;
            // Prompt
            string Prompt = $"""
                You are a helpful assistant.
                Answer the Question Using only the PDF content .
                if you cannot find the answer in the pdf,
                say: "I Could not find the answer in the pdf ."
                pdf content:
                ----------------
                {pdfText}
                ----------------
                Question:
                {question}
                """;
            using HttpClient client = new HttpClient();
            client.Timeout = TimeSpan.FromSeconds(60);
            client.DefaultRequestHeaders.Add("x-goog-api-key", apiKey);
            // Request Body 
            var requestBody = new
            {
                contents = new[]
                {
                    new
                    {
                        parts= new []
                        {
                            new
                            {
                                text=Prompt
                            }
                        }
                    }
                }
            };

            //Json 
            string json = JsonSerializer.Serialize(requestBody);
            using var content  = new StringContent(json,Encoding.UTF8,"application/json");

            var response = await client.PostAsync($"https://generativelanguage.googleapis.com/v1beta/models/{model}:generateContent", content);

            string responseJson =  await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode) 
            {
                throw new Exception($"Gemini Error :{response.StatusCode}\n{responseJson}");
            }
            using JsonDocument document = JsonDocument.Parse(responseJson);
            string answer = document.RootElement.GetProperty("candidates")[0].GetProperty("content").GetProperty("parts")[0].GetProperty("text").GetString() ?? "";

            return answer;
        }
    }
}
