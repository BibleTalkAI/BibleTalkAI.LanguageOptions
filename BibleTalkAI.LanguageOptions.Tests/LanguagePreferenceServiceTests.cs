namespace BibleTalkAI.LanguageOptions.Tests;

public class LanguagePreferenceServiceTests
{
    [Fact]
    public void GetLanguagePreference_ReturnsLanguagePreference()
    {
        // Arrange
        var languagePreferencesService = new LanguagePreferencesService();
        var languagePreferenceOption = 1;

        // Act
        var languagePreference = languagePreferencesService.GetLanguagePreference(languagePreferenceOption);

        // Assert
        Assert.NotNull(languagePreference);
        Assert.Equal("en-US", languagePreference.GatherLanguage);
        Assert.Equal("Polly.Matthew-Neural", languagePreference.SayVoice);
        Assert.Equal("en-US", languagePreference.SayLanguage);
        Assert.Equal("English", languagePreference.LanguageNameInEnglish);
    }

    [Fact]
    public void GetLanguagePreference_ReturnsNull_WhenNotFound()
    {
        // Arrange
        var languagePreferencesService = new LanguagePreferencesService();
        var languagePreferenceOption = -1;

        // Act
        var languagePreference = languagePreferencesService.GetLanguagePreference(languagePreferenceOption);

        // Assert
        Assert.Null(languagePreference);
    }
}