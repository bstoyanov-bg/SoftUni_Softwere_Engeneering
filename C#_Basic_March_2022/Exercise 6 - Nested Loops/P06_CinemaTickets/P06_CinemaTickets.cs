using System;

namespace P06_CinemaTickets
{
    class P06_CinemaTickets
    {
        static void Main()
        {
            int studentTicketSold = 0;
            int standardTicketSold = 0;
            int kidTicketSold = 0;

            int tottalTicketSold = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Finish")
                {
                    break;
                }

                string filmTitle = input;
                int seatsAvailable = int.Parse(Console.ReadLine());
                int ticketsSoldForFilm = 0;

                while (ticketsSoldForFilm < seatsAvailable)
                {
                    string ticketType = Console.ReadLine();

                    if (ticketType == "End")
                    {
                        break;
                    }

                    ticketsSoldForFilm++;
                    tottalTicketSold++;

                    if (ticketType == "student")
                    {
                        studentTicketSold++;
                    }
                    else if (ticketType == "standard")
                    {
                        standardTicketSold++;
                    }
                    else if (ticketType == "kid")
                    {

                        kidTicketSold++;
                    }
                }
                double percentFull = ticketsSoldForFilm / (double)seatsAvailable * 100;
                Console.WriteLine($"{filmTitle} - {percentFull:f2}% full.");
            }

            Console.WriteLine($"Total tickets: {tottalTicketSold}");

            double percentStudentTickets = studentTicketSold / (double)tottalTicketSold * 100;
            Console.WriteLine($"{percentStudentTickets:f2}% student tickets.");

            double percentStandardTickets = standardTicketSold / (double)tottalTicketSold * 100;
            Console.WriteLine($"{percentStandardTickets:f2}% standard tickets.");

            double percentKidTickets = kidTicketSold / (double)tottalTicketSold * 100;
            Console.WriteLine($"{percentKidTickets:f2}% kids tickets.");
        }
    }
}