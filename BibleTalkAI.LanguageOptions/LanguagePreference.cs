using Twilio.TwiML.Voice;

namespace BibleTalkAI.LanguageOptions;

public class LanguagePreference
{
    public required int LanguagePreferenceOption { get; init; }

    private string? languageNameInEnglish;
    private string? languagePrompt;
    public required string LanguageNameInEnglish
    {
        get => languageNameInEnglish!;
        init
        {
            languageNameInEnglish = value;
            languagePrompt = $"[The person you are conversing with has indicated that they prefer to continue this conversation in the {value} language. Please respond to the user question below this line. Please respond in the language of their choice {value}.]";
        }
    }

    public string LanguagePrompt => languagePrompt!;

    public required Gather.LanguageEnum GatherLanguage { get; init; } = default!;
    public required Say.VoiceEnum SayVoice { get; init; } = default!;
    public required Say.LanguageEnum SayLanguage { get; init; } = default!;
}
