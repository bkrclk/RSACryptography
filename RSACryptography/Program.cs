using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;
using static RSACryptography.Program;

namespace RSACryptography
{
    public class Program
    {
        static void Main(string[] args)
        {
            RsaEncryption rsa = new RsaEncryption();

            var encryptText = "HelloWorld.123";

            var cypher = rsa.Encrypt(encryptText);
            var decryptText = rsa.Decrypt(cypher);

            ConsoleWriteInColor("PlainText : ", encryptText, ConsoleColor.Red, ConsoleColor.Black);
            ConsoleWriteInColor("Encrypt CypherText : " , cypher, ConsoleColor.Green, ConsoleColor.Black);
            ConsoleWriteInColor("Decrypt PlainText : " , decryptText, ConsoleColor.Yellow, ConsoleColor.Black);

            Console.ReadKey();
        }

        // Console renklendirmesi için yardımcı metod
        static void ConsoleWriteInColor(string value, string value2, ConsoleColor ForegroundColor, ConsoleColor BackgroundColor, bool WriteLine = true, bool NullCheck = true)
        {
            if (NullCheck && string.IsNullOrWhiteSpace(value))
                value = "-";
            else
            {
                Console.BackgroundColor = BackgroundColor;
                Console.ForegroundColor = ForegroundColor;
            }

            Console.Write(value);
            Console.ResetColor();
            Console.Write(value2);

            if (WriteLine)
                Console.WriteLine();
        }
    }
}