using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets
{
    class MatchTickets
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var category = Console.ReadLine();
            var peopleCount = int.Parse(Console.ReadLine());
            var ticketPrice = 0.0;
            var transportPrice = 0.0;

            switch (category)
            {
                case "VIP":
                    ticketPrice = 499.99;
                    break;
                case "Normal":
                    ticketPrice = 249.99;
                    break;
            }

            if (peopleCount >= 50)
            {
                transportPrice = budget * 0.25;
            }
            else if (peopleCount >= 25)
            {
                transportPrice = budget * 0.40;
            }
            else if (peopleCount >= 10)
            {
                transportPrice = budget * 0.50;
            }
            else if (peopleCount >= 5)
            {
                transportPrice = budget * 0.60;
            }
            else
            {
                transportPrice = budget * 0.75;
            }

            if ((transportPrice) + ticketPrice * peopleCount <= budget)
            {
                var n = budget - (ticketPrice * peopleCount + transportPrice);
                Console.WriteLine($"Yes! You have {n:f2} leva left.");
            }
            else
            {
                var m = ((transportPrice) + ticketPrice * peopleCount) - budget;
                Console.WriteLine($"Not enough money! You need {m:f2} leva.");
            }
        }
    }
}
