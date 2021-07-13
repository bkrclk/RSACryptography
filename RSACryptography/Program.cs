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
            while (true)
            {
                try
                {
                    RsaEncryption rsa = new RsaEncryption();

                    ConsoleWriteInColor("Select: 1-Encrypt 2-Decrypt : ", null, ConsoleColor.Yellow, ConsoleColor.Black);
                    var operation = Console.ReadLine();

                    if (operation == "1")
                    {
                        ConsoleWriteInColor("Input Text : ", null, ConsoleColor.Blue, ConsoleColor.Black);
                        var inputText = Console.ReadLine();
                        var cypherText = rsa.Encrypt(inputText);
                        ConsoleWriteInColor("Encrypt CypherText : ", cypherText, ConsoleColor.Green, ConsoleColor.Black);
                        Console.WriteLine("\n");
                    }
                    else if (operation == "2")
                    {
                        ConsoleWriteInColor("Encrypt CypherText Input : ", null, ConsoleColor.Green, ConsoleColor.Black);
                        var encryptText = Console.ReadLine();
                        if (string.IsNullOrEmpty(encryptText) || !IsBase64String(encryptText))
                        {
                            ConsoleWriteInColor("Invalid String Format! ", null, ConsoleColor.Red, ConsoleColor.Black);
                            Console.WriteLine("\n");
                            continue;
                        }
                        var decryptText = rsa.Decrypt(encryptText);
                        ConsoleWriteInColor("Decrypt PlainText : ", decryptText, ConsoleColor.Blue, ConsoleColor.Black);

                        Console.WriteLine("\n");
                    }
                    else
                    {
                        ConsoleWriteInColor("Invalid Selected! ", null, ConsoleColor.Red, ConsoleColor.Black);
                        Console.WriteLine("\n");
                    }
                }
                catch (Exception ex)
                {
                    ConsoleWriteInColor("SYSTEM ERROR! ", ex.Message, ConsoleColor.Red, ConsoleColor.Black);
                    Console.WriteLine("\n");
                }
               
            }
        }

        static void ConsoleWriteInColor(string description, string value, ConsoleColor ForegroundColor, ConsoleColor BackgroundColor, bool WriteLine = true, bool NullCheck = true)
        {
            if (NullCheck && string.IsNullOrWhiteSpace(description))
                description = "-";
            else
            {
                Console.BackgroundColor = BackgroundColor;
                Console.ForegroundColor = ForegroundColor;
            }

            Console.Write(description);
            Console.ResetColor();
            Console.Write(value);
        }

        public static bool IsBase64String(string base64)
        {
            Span<byte> buffer = new Span<byte>(new byte[base64.Length]);
            return Convert.TryFromBase64String(base64, buffer, out int bytesParsed);
        }
    }
}