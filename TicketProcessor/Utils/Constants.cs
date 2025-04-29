namespace Constants
{
    public static class AppConstants
    {
        public static class Cache
        {
            public const int DefaultExpirationMinutes = 30;
            public const string ProductsCacheKey = "Products_";
        }

        public static class DeepSeekKey {
            public const string DefaultKey = "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";
            public const string DefaultApi = "https://openrouter.ai/api/v1/chat/completions";            
        }

        public static class Policies
        {
            public const string AdminOnly = "AdminOnly";
            public const string UserOnly = "UserOnly";
        }

        public static class ErrorMessages
        {
            public const string NotFound = "Resource not found";
            public const string Unauthorized = "Unauthorized access";
        }
    }
}