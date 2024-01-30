namespace BibleTalkAI.LanguageOptions;

public class LanguagePreferencesService : ILanguagePreferencesService
{
    public LanguagePreference? GetLanguagePreference(int languagePreferenceOption)
    {
        if (LanguagePreferences.Languages.TryGetValue(languagePreferenceOption, out LanguagePreference? languagePreference))
        {
            return languagePreference;
        }
        return null;
    }
}
