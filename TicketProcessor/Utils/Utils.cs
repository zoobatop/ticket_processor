using System;
using System.Security.Cryptography;
using System.Text;

namespace TicketProcessor.Utils
{
    public static class SecurityUtils
    {
        public static string HashSHA256(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            using (var sha256 = SHA256.Create())
            {
                // Converter para Base64 ao invés de string hexadecimal
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                return Convert.ToBase64String(hashedBytes);
            }
        }
    }

    public static class StringUtils
    {
        public static string ClearString(string input)
        {
            return input?.Replace("\0", string.Empty);
        }
    }

}