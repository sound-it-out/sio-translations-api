﻿namespace SIO.Translations.API.V1.Endpoints
{
    public static class V1Endpoints
    {
        public static IEndpointRouteBuilder MapV1Endpoints(this IEndpointRouteBuilder builder)
         => builder.MapOptionsEndpoint();
    }
}
