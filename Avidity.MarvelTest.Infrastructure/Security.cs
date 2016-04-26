using System;
using System.Security.Cryptography;
using System.Text;
using System.Configuration;

namespace Avidity.MarvelTest.Utils
{
    public class Security
    {
        public const string MarvelPublicKey = "d503a233dcb5180f9c5980a85711b904";
        private const string MarvelPrivateKey = "eeb6007ee11db108448adea64f778bdd0530619a";

        /// <summary>
        /// Calculates the MD5 hash.
        /// </summary>
        /// <returns>The MD5 hash.</returns>
        /// <param name="input">Input.</param>
        public static string CalculateMD5Hash(string input)
        {
            byte[] data = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }

            return sb.ToString();
        }

        /// <summary>
        /// Gets the marvel hash request code.
        /// </summary>
        /// <returns>The marvel hash request code.</returns>
        public static string GetMarvelHashRequestCode()
        {
            return CalculateMD5Hash("1" + MarvelPrivateKey + MarvelPublicKey);
        }
    }
}

