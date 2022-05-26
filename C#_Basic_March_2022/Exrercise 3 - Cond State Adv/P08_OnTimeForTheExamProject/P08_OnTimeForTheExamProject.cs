using System;

namespace P08_OnTimeForTheExamProject
{
    class P08_OnTimeForTheExamProject
    {
        static void Main()
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int examTimeAsMinutes = examHour * 60 + examMinutes;
            int arrivalTimeAsMinutes = arrivalHour * 60 + arrivalMinutes;

            int differenceExamArrival = examTimeAsMinutes - arrivalTimeAsMinutes;

            int differenceHours = differenceExamArrival / 60;
            int differenceMinutes = differenceExamArrival % 60;

            if (differenceExamArrival == 0)
            {
                Console.WriteLine("On time");
            }
            else if (differenceExamArrival > 0)
            {
                if (differenceExamArrival <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{differenceMinutes} minutes before the start");
                }
                else
                {
                    if (differenceHours <= 0)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{differenceMinutes} minutes before the start");
                    }
                    else
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{differenceHours}:{differenceMinutes:d2} hours before the start");
                    }
                }
            }
            else if (differenceExamArrival < 0)
            {
                if (Math.Abs(differenceExamArrival) <= 59)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{Math.Abs(differenceMinutes)} minutes after the start");
                }
                else
                {
                    Console.WriteLine("Late");
                    differenceMinutes = Math.Abs(differenceMinutes);
                    Console.WriteLine($"{Math.Abs(differenceHours)}:{differenceMinutes:d2} hours after the start");
                }
            }
        }
    }
}