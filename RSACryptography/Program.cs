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

            ConsoleWriteInColor("Input Text : ", null, ConsoleColor.Blue, ConsoleColor.Black);
            var inputText = Console.ReadLine();
            var cypherText = rsa.Encrypt(inputText);
            ConsoleWriteInColor("Encrypt CypherText : ", cypherText, ConsoleColor.Green, ConsoleColor.Black);
            Console.WriteLine("\n");

            ConsoleWriteInColor("Encrypt CypherText Input : ", null, ConsoleColor.Green, ConsoleColor.Black);
            var encryptText = Console.ReadLine();
            var decryptText = rsa.Decrypt(encryptText);
            ConsoleWriteInColor("Decrypt PlainText : ", decryptText, ConsoleColor.Blue, ConsoleColor.Black);

            Console.ReadKey();
        }

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