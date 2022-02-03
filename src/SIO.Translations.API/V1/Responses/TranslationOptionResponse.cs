using SIO.IntegrationEvents.Documents;

namespace SIO.Translations.API.V1.Responses
{
    public record TranslationOptionResponse(string Id, string Subject, TranslationType TranslationType);
}
