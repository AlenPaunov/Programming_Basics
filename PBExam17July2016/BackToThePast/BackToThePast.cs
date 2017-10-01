using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToThePast
{
    class BackToThePast
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var yearToLive = int.Parse(Console.ReadLine());
            var ivanAge = 18;
            var moneyNeeded = 0.0;

            for (int i = 1800; i <= yearToLive; i++)
            {
                if (i % 2 == 0)
                {
                    moneyNeeded += 12000.0;
                }
                else
                {
                    moneyNeeded += 12000.0 + 50 * ivanAge;
                }
                ivanAge++;

            }
            if (moneyNeeded <= money)
            {
                var result = money - moneyNeeded;
                Console.WriteLine($"Yes! He will live a carefree life and will have {result:f2} dollars left.");
            }
            else
            {
                var result = moneyNeeded - money;
                Console.WriteLine($"He will need {result:f2} dollars to survive.");
            }
        }
    }
}
