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