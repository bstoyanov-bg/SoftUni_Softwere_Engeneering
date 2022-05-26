using System;

namespace P03_DepositCalculatorProject
{
    class P03_DepositCalculatorProject
    {
        static void Main()
        {
            //сума = депозирана сума + срок на депозита *((депозирана сума* годишен лихвен процент ) / 12)

            double deposit = double.Parse(Console.ReadLine());
            int depositTermInMonths = int.Parse(Console.ReadLine());
            double annualInterestNum = double.Parse(Console.ReadLine());
            
            double percentageDivider = 100;
            int monthsInYear = 12;

            double annualInterestPercentage = annualInterestNum / percentageDivider;

            double annualInterestOnDeposit = deposit * annualInterestPercentage;
            double monthltInterestOnDeposit = annualInterestOnDeposit / monthsInYear;
            double interestOnDepositForTerm = monthltInterestOnDeposit * depositTermInMonths;
            double finalAmount = deposit + interestOnDepositForTerm;

            Console.WriteLine(finalAmount);
        }
    }
}