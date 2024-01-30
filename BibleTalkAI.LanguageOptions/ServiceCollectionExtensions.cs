using Microsoft.Extensions.DependencyInjection;

namespace BibleTalkAI.LanguageOptions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddLanguagePreferencesService(this IServiceCollection services)
    {
        services.AddSingleton<ILanguagePreferencesService, LanguagePreferencesService>();
        return services;
    }
}
