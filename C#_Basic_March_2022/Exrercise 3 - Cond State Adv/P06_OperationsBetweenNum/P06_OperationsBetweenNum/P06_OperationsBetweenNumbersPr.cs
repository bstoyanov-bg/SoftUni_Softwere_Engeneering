using System;

namespace P06_OperationsBetweenNumbersProject
{
    class P06_OperationsBetweenNumbersProject
    {
        static void Main()
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());

            double mathResult = 0.0;
            string finalResult = null;

            switch (operation)
            {
                case '+':
                    mathResult = numOne + numTwo;
                    if (mathResult % 2 == 0)
                    {
                        finalResult = $"{numOne} {operation} {numTwo} = {mathResult} - even";
                    }
                    else 
                    {
                        finalResult = $"{numOne} {operation} {numTwo} = {mathResult} - odd";
                    }
                    break;
                case '-':
                    mathResult = numOne - numTwo;
                    if (mathResult % 2 == 0)
                    {
                        finalResult = $"{numOne} {operation} {numTwo} = {mathResult} - even";
                    }
                    else
                    {
                        finalResult = $"{numOne} {operation} {numTwo} = {mathResult} - odd";
                    }
                    break;
                case '*':
                    mathResult = numOne * numTwo;
                    if (mathResult % 2 == 0)
                    {
                        finalResult = $"{numOne} {operation} {numTwo} = {mathResult} - even";
                    }
                    else
                    {
                        finalResult = $"{numOne} {operation} {numTwo} = {mathResult} - odd";
                    }
                    break;
                case '/':
                    if (numTwo == 0)
                    {
                        finalResult = $"Cannot divide {numOne} by zero";
                    }
                    else 
                    {
                        mathResult = numOne / (double)numTwo;
                        finalResult = $"{numOne} {operation} {numTwo} = {mathResult:f2}";
                    }
                    break;
                case '%':
                    if (numTwo == 0)
                    {
                        finalResult = $"Cannot divide {numOne} by zero";
                    }
                    else
                    {
                        mathResult = numOne % numTwo;
                        finalResult = $"{numOne} {operation} {numTwo} = {mathResult}";
                    }
                    break;
            }
            Console.WriteLine(finalResult);
        }
    }
}