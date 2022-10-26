using System;

namespace P01_EncryptSortAndPrintArrayMore
{
    internal class P01_EncryptSortAndPrintArrayMore
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] results = new int[n];

            string vowels = "EeUuIiOoAa";

            for (int i = 0; i < n; i++)
            {
                double totalSum = 0.00;
                string name = Console.ReadLine();

                for (int j = 0; j < name.Length; j++)
                {
                    if (vowels.Contains(name[j]))
                    {
                        totalSum += name[j] * name.Length;
                    }
                    else
                    {
                        totalSum += name[j] / name.Length;
                    }
                }
                results[i] = (int)totalSum;
            }

            Array.Sort(results);

            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
        }
    }
}