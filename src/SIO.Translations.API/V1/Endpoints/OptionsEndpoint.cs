using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using SIO.Domain.TranslationOptions.Queries;
using SIO.Infrastructure;
using SIO.Infrastructure.Queries;
using SIO.Translations.API.Extensions;
using SIO.Translations.API.V1.Responses;

namespace SIO.Translations.API.V1.Endpoints
{
    public static class OptionsEndpoint
    {
        public static IEndpointRouteBuilder MapOptionsEndpoint(this IEndpointRouteBuilder builder)
        {
            builder.MapGet("v1/options", ListOptions)
                .AllowAnonymous();

            return builder;
        }

        private static async Task<IEnumerable<TranslationOptionResponse>> ListOptions([FromServices] IQueryDispatcher queryDispatcher, 
            ClaimsPrincipal user,
            CancellationToken cancellationToken)
        {
            var translationOptionsResult = await queryDispatcher.DispatchAsync(new GetTranslationOptionsQuery(CorrelationId.New(), user.Actor()), cancellationToken);
            return translationOptionsResult.TranslationOptions.Select(to => new TranslationOptionResponse(to.Id, to.Subject, to.TranslationType));
        }
    }
}
