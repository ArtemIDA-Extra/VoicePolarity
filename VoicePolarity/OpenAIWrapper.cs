using System.Text;
using System.Net.Http.Headers;
using System.Diagnostics;

[System.Serializable]
public class TTSPayload
{
    public string model;
    public string input;
    public string voice;
    public string response_format;
    public float speed;
}

public class OpenAIWrapper
{
    private string openAIKey;
    private TTSModel model = TTSModel.TTS_1;
    private TTSVoice voice = TTSVoice.Alloy;
    private float speed = 1f;
    private readonly string outputFormat = "mp3";

    public OpenAIWrapper()
    {
        if (Environment.GetEnvironmentVariable("OpenAIKey") != null)
            openAIKey = Environment.GetEnvironmentVariable("OpenAIKey");
        else throw new Exception("The OpenAI API key was not found in the environment variables. [Variable name = OpenAIKey]");
    }

    public async Task<byte[]> RequestTextToSpeech(string text)
    {
        Console.WriteLine("Sending new request to OpenAI TTS.");
        using var httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", openAIKey);

        TTSPayload payload = new TTSPayload
        {
            model = this.model.EnumToString(),
            input = text,
            voice = this.voice.ToString().ToLower(),
            response_format = this.outputFormat,
            speed = this.speed
        };

        string jsonPayload = Newtonsoft.Json.JsonConvert.SerializeObject(payload);

        var httpResponse = await httpClient.PostAsync(
            "https://api.openai.com/v1/audio/speech", 
            new StringContent(jsonPayload, Encoding.UTF8, "application/json"));

        byte[] response = await httpResponse.Content.ReadAsByteArrayAsync();

        if (httpResponse.IsSuccessStatusCode)
        {
            return response;
        }
        throw new Exception("Error: " + httpResponse.ReasonPhrase);
    }
    
    public async Task<byte[]> RequestTextToSpeech(string text, TTSModel model, TTSVoice voice, float speed)
    {
        this.model = model;
        this.voice = voice;
        this.speed = speed;
        return await RequestTextToSpeech(text);
    }
}