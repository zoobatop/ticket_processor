namespace Constants
{
    public static class AppConstants
    {
        public static class Database {
            public const string DatabaseName = "";
            public const string DatabaseVersion = "";
            public const string ConnectionUrl = "";
        }

        public static class DeepSeekKey {
            public const string DefaultKey = "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";
            public const string DefaultApi = "https://openrouter.ai/api/v1/chat/completions";            
        }

        public static class ErrorMessages
        {
            public const string NotFound = "Resource not found";
            public const string Unauthorized = "Unauthorized access";
        }
    }
}