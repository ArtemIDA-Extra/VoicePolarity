using System.Text.Json.Serialization;

public class TTSManager
{
    private OpenAIWrapper openAIWrapper;
    private TTSModel model = TTSModel.TTS_1;
    private TTSVoice voice = TTSVoice.Alloy;
    private float speed = 1f;

    public async void SynthesizeAndPlay(string text)
    {
        Console.WriteLine("Trying to synthesize " + text);
        byte[] audioData = await openAIWrapper.RequestTextToSpeech(text, model, voice, speed);
        if (audioData != null)
        {
            Console.WriteLine("Playing audio.");
            //audioPlayer.ProcessAudioBytes(audioData);
        }
        else
        {
            Console.WriteLine("Failed to get audio data from OpenAI.");
        }
    }

    public async void SynthesizeAndPlay(string text, TTSModel model, TTSVoice voice, float speed)
    {
        this.model = model;
        this.voice = voice;
        this.speed = speed;
        SynthesizeAndPlay(text);
    }
}