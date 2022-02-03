using Microsoft.Extensions.DependencyInjection;
using SIO.Domain.TranslationOptions.Queries;
using SIO.Domain.TranslationOptions.QueryHandlers;
using SIO.Infrastructure.Queries;

namespace SIO.Domain.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            return services.AddTranslations();
        }

        public static IServiceCollection AddTranslations(this IServiceCollection services)
        {
            //Queries
            services.AddScoped<IQueryHandler<GetTranslationOptionsQuery, GetTranslationOptionsQueryResult>, GetTranslationOptionsQueryHandler>();

            return services;
        }
    }
}
