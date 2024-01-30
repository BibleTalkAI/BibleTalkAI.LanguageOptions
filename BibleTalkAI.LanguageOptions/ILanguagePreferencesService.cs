namespace BibleTalkAI.LanguageOptions;

public interface ILanguagePreferencesService
{
    LanguagePreference? GetLanguagePreference(int languagePreferenceOption);
}
