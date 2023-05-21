using System.Security.Cryptography;
using System.Text;

namespace iShopMainVer2.Helpers
{
    public static class GenerateSHA512
    {
        /// <summary>
        /// encrypts a string according to the SHA512 standard
        /// </summary>
        /// <param name="input"></param>
        /// <returns>encoded string</returns>
        public static string Create(string input)
        {
            using SHA512 hash = SHA512.Create();
            return Convert.ToHexString(hash.ComputeHash(Encoding.UTF8.GetBytes(input)));
        }
    }
}
