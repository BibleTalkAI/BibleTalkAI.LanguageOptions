namespace BibleTalkAI.LanguageOptions.Tests;

public class LanguagePreferencesTests
{
    [Fact]
    public void Language_Has_45_Options()
    {
        // Arrange
        var languagePreferences = LanguagePreferences.Languages;

        // Act
        var count = languagePreferences.Count;

        // Assert
        Assert.Equal(45, count);
    }

    [Theory]
    [InlineData(1, "en-US", "Polly.Matthew-Neural", "en-US", "English")]
    [InlineData(2, "cmn-Hans-CN", "Google.cmn-CN-Wavenet-B", "cmn-CN", "Chinese Mandarin")]
    [InlineData(3, "hi-IN", "Google.hi-IN-Wavenet-B", "hi-IN", "Hindi")]
    [InlineData(4, "es-US", "Polly.Pedro-Neural", "es-US", "Spanish")]
    [InlineData(5, "ar-MA", "Google.ar-XA-Wavenet-B", "ar-XA", "Arabic")]
    [InlineData(6, "ms-MY", "Google.ms-MY-Wavenet-B", "ms-MY", "Malay")]
    [InlineData(7, "fr-FR", "Polly.Remi-Neural", "fr-FR", "French")]
    [InlineData(8, "pt-BR", "Polly.Thiago-Neural", "pt-BR", "Portuguese")]
    [InlineData(9, "ru-RU", "Google.ru-RU-Wavenet-B", "ru-RU", "Russian")]
    [InlineData(10, "id-ID", "Google.id-ID-Wavenet-B", "id-ID", "Indonesian")]
    [InlineData(11, "de-DE", "Polly.Daniel-Neural", "de-DE", "German")]
    [InlineData(12, "ja-JP", "Polly.Takumi-Neural", "ja-JP", "Japanese")]
    [InlineData(14, "mr-IN", "Google.mr-IN-Wavenet-B", "mr-IN", "Marathi")]
    [InlineData(15, "te-IN", "Google.te-IN-Standard-B", "te-IN", "Telugu")]
    [InlineData(16, "ko-KR", "Google.ko-KR-Wavenet-C", "ko-KR", "Korean")]
    [InlineData(17, "vi-VN", "Google.vi-VN-Wavenet-B", "vi-VN", "Vietnamese")]
    [InlineData(18, "ta-IN", "Google.ta-IN-Wavenet-D", "ta-IN", "Tamil")]
    [InlineData(19, "tr-TR", "Google.tr-TR-Wavenet-B", "tr-TR", "Turkish")]
    [InlineData(20, "yue-Hant-HK", "Google.yue-HK-Standard-B", "yue-HK", "Chinese Cantonese")]
    [InlineData(21, "it-IT", "Polly.Adriano-Neural", "it-IT", "Italian")]
    [InlineData(22, "pl-PL", "Google.pl-PL-Wavenet-B", "pl-PL", "Polish")]
    [InlineData(23, "ml-IN", "Google.ml-IN-Wavenet-D", "ml-IN", "Malayalam")]
    [InlineData(24, "fil-PH", "Google.fil-PH-Wavenet-B", "fil-PH", "Filipino")]
    [InlineData(25, "nl-NL", "Google.nl-NL-Wavenet-B", "nl-NL", "Dutch")]
    [InlineData(26, "sv-SE", "Google.sv-SE-Wavenet-C", "sv-SE", "Swedish")]
    [InlineData(27, "he-IL", "Google.he-IL-Wavenet-B", "he-IL", "Hebrew")]
    [InlineData(28, "da-DK", "Google.da-DK-Wavenet-C", "da-DK", "Danish")]
    [InlineData(29, "nb-NO", "Google.nb-NO-Wavenet-B", "nb-NO", "Norwegian")]
    [InlineData(30, "lt-LT", "Google.lt-LT-Standard-A", "lt-LT", "Lithuanian")]
    [InlineData(31, "lv-LV", "Google.lv-LV-Standard-A", "lv-LV", "Latvian")]
    [InlineData(32, "af-ZA", "Google.af-ZA-Standard-A", "af-ZA", "Afrikaans")]
    [InlineData(33, "eu-ES", "Google.eu-ES-Standard-A", "eu-ES", "Basque")]
    [InlineData(34, "bg-BG", "Google.bg-BG-Standard-A", "bg-BG", "Bulgarian")]
    [InlineData(35, "ca-ES", "Polly.Arlet-Neural", "ca-ES", "Catalan")]
    [InlineData(36, "cs-CZ", "Google.cs-CZ-Wavenet-A", "cs-CZ", "Czech")]
    [InlineData(37, "fi-FI", "Polly.Suvi-Neural", "fi-FI", "Finnish")]
    [InlineData(38, "gl-ES", "Google.gl-ES-Standard-A", "gl-ES", "Galician")]
    [InlineData(39, "el-GR", "Google.el-GR-Wavenet-A", "el-GR", "Greek")]
    [InlineData(40, "hu-HU", "Google.hu-HU-Wavenet-A", "hu-HU", "Hungarian")]
    [InlineData(41, "is-IS", "Polly.Karl", "is-IS", "Icelandic")]
    [InlineData(42, "ro-RO", "Google.ro-RO-Wavenet-A", "ro-RO", "Romanian")]
    [InlineData(43, "sr-RS", "Google.sr-RS-Standard-A", "sr-RS", "Serbian")]
    [InlineData(44, "sk-SK", "Google.sk-SK-Wavenet-A", "sk-SK", "Slovak")]
    [InlineData(45, "th-TH", "Google.th-TH-Standard-A", "th-TH", "Thai")]
    [InlineData(46, "uk-UA", "Google.uk-UA-Wavenet-A", "uk-UA", "Ukrainian")]
    public void GetLanguagePreference_ReturnsLanguagePreference(int languagePreferenceOption, string gatherLanguage, string sayVoice, string sayLanguage, string languageNameInEnglish)
    {
        // Arrange
        var languagePreferencesService = new LanguagePreferencesService();

        // Act
        var languagePreference = languagePreferencesService.GetLanguagePreference(languagePreferenceOption);

        // Assert
        Assert.NotNull(languagePreference);
        Assert.Equal(gatherLanguage, languagePreference.GatherLanguage);
        Assert.Equal(sayVoice, languagePreference.SayVoice);
        Assert.Equal(sayLanguage, languagePreference.SayLanguage);
        Assert.Equal(languageNameInEnglish, languagePreference.LanguageNameInEnglish);
    }
}
