using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

namespace RSACryptography
{
    public class RsaEncryption
    {
        private static RSACryptoServiceProvider csp = new RSACryptoServiceProvider(2048);
        static string publicKey = Environment.GetEnvironmentVariable("RSA_PUBLIC_KEY");
        static string privateKey = Environment.GetEnvironmentVariable("RSA_PRIVATE_KEY");

        public string Encrypt(string plainText)
        {
            csp = new RSACryptoServiceProvider();
            csp.FromXmlString(publicKey.ToString());
            var data = Encoding.Unicode.GetBytes(plainText);
            var cypher = csp.Encrypt(data, false);
            return Convert.ToBase64String(cypher);

        }

        public string Decrypt(string cypherText)
        {
            var dataBytes = Convert.FromBase64String(cypherText);
            csp.FromXmlString(privateKey.ToString());
            var plainText = csp.Decrypt(dataBytes, false);
            return Encoding.Unicode.GetString(plainText);

        }
    }
}




