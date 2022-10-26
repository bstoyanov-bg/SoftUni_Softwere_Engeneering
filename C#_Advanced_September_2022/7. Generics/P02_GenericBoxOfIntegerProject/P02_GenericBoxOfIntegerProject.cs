using System;

namespace P02_GenericBoxOfIntegerProject
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Box<int> box = new Box<int>();

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());

                box.Items.Add(number);
            }

            Console.WriteLine(box.ToString());
        }
    }
}