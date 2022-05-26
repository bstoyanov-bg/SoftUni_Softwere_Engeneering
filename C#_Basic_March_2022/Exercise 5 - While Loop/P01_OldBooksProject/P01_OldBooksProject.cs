using System;

namespace P01_OldBooksProject
{
    class P01_OldBooksProject
    {
        static void Main()
        {
            string favBook = Console.ReadLine();

            int counter = 0;
            bool isBookFound = false;

            string nextBookName = Console.ReadLine();
            while (nextBookName != "No More Books")
            {
                if (nextBookName == favBook)
                {
                    isBookFound = true;
                    break;
                }
                counter++;
                nextBookName = Console.ReadLine();
            }

            if (isBookFound)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else 
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}