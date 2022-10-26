using System;
using System.Text;

namespace P04_CaesarCipherProject
{
    internal class P04_CaesarCipherProject
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < message.Length; i++)
            {
                char encryptedChar = (char)(message[i] + 3);
                sb.Append(encryptedChar);
            }

            Console.WriteLine(sb);
        }
    }
}