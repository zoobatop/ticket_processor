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