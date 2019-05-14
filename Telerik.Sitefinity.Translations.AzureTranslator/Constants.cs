﻿namespace Telerik.Sitefinity.Translations.AzureTranslator
{
    internal class Constants
    {
        internal const string Name = "AzureTranslatorTextConnector";
        internal const string Title = "Azure Translator Text Connector";
        internal const string AzureTranslateApiEndpointUrl = "https://api.cognitive.microsofttranslator.com/translate?api-version=3.0";
        internal const int ValidApiKeyLength = 32;

        internal class ExceptionMessages
        {
            internal const string InvalidApiKeyExceptionMessage = "Invalid API subscription key.";
            internal const string NoApiKeyExceptionMessage = "No API key configured for azure translations connector.";
            internal const string InvalidParameterForAzureTransaltionRequestExceptionMessagePrefix = "Invalid parameter for azure translation request.";
            internal const string NullOrEmptyParameterExceptionMessageTemplate = "Parameter with name {0} cannot be null or empty.";
            internal static readonly string InvalidParameterForAzureTransaltionRequestExceptionMessageTemplate = InvalidParameterForAzureTransaltionRequestExceptionMessagePrefix + " " + NullOrEmptyParameterExceptionMessageTemplate;

            internal static readonly string UnexpectedErrorResponseFormat = $"{AzureServerErrorMessage} {UnexpectedResponseFormat}";
            internal static readonly string ErrorSerializingErrorResponseFromServer = $"{AzureServerErrorMessage} {ErrorSerializingResponseFromServer}";
            internal static readonly string ErrorSerializingResponseFromServer = "Could not serialize response from Azure.";
            internal const string UnexpectedResponseFormat = "The response received was not in the expected format.";

            public const string AzureServerErrorMessage = "An error ocurred on the Azure server.";
        }

        internal struct ConfigParameters
        {
            internal const string ApiKey = "apiKey";
        }
    }
}