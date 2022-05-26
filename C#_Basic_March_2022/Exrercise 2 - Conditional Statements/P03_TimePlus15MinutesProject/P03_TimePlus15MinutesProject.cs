using System;

namespace P03_TimePlus15MinutesProject
{
    class P03_TimePlus15MinutesProject
    {
        static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int timePlusFifteenMinutes = minutes + 15;
            int minutesInHour = 60;

            if (timePlusFifteenMinutes > 59)
            {
                hours++;
                if (hours > 23)
                {
                    hours = 0;
                }
                timePlusFifteenMinutes = timePlusFifteenMinutes - minutesInHour;
            }
            
            Console.WriteLine($"{hours}:{timePlusFifteenMinutes:D2}");
        }
    }
}