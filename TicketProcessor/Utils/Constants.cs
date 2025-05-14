namespace Constants
{
    public static class AppConstants
    {
        public static class Database
        {
            public const string DatabaseName = "chamados";
            public const string Host = "localhost";
            public const string Port = "5432";
            public const string UserName = "admin_chamados";
            public const string Password = "S3nh4Sup3rS3gur@!2024";

            public static readonly string ConnectionUrl = $"Host={Host};Port={Port};Database={DatabaseName};Username={UserName};Password={Password}";
        }

        public static class DeepSeekKey
        {
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