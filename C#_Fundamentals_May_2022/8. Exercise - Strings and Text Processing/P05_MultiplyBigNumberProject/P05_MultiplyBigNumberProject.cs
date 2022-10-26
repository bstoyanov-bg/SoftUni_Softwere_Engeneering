using System;
using System.Text;

namespace P05_MultiplyBigNumberProject
{
    internal class P05_MultiplyBigNumberProject
    {
        static void Main(string[] args)
        {
            string bigNumer = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            int remainder = 0;

            if (number == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = bigNumer.Length - 1; i >= 0; i--)
            {
                char lastNum = bigNumer[i];
                int lastNumAsDigit = int.Parse(lastNum.ToString());

                int result = lastNumAsDigit * number + remainder;

                sb.Append(result % 10);
                remainder = result / 10;
            }

            if (remainder != 0)
            {
                sb.Append(remainder);
            }

            StringBuilder reversed = new StringBuilder();

            for (int i = sb.Length - 1; i >= 0; i--)
            {
                reversed.Append(sb[i]);
            }

            Console.WriteLine(reversed);
        }
    }
}