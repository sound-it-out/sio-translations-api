using SIO.Domain.Extensions;

namespace SIO.Translations.API.Extensions
{
    public static class WebApplicationExtensions
    {
        public static WebApplicationBuilder ConfigureDocumentsApi(this WebApplicationBuilder builder)
        {
            builder.Services
                .AddAuthentication(builder.Configuration, builder.Environment)
                .AddInfrastructure(builder.Configuration)
                .AddDomain();

            return builder;
        }
    }
}
