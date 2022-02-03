using SIO.Translations.API.V1.Endpoints;

namespace SIO.Translations.API.Extensions
{
    public static class EndpointRouteBuilderExtensions
    {
        public static IEndpointRouteBuilder MapEndpoints(this IEndpointRouteBuilder builder)
            => builder.MapV1Endpoints();
    }
}
