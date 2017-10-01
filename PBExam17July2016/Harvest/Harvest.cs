using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Harvest
    {
        static void Main(string[] args)
        {
            // 2,5 kg grapes per wine liter

            var vineyardArea = int.Parse(Console.ReadLine());
            var grapesPerMeter = double.Parse(Console.ReadLine());
            var wineNeeded = int.Parse(Console.ReadLine());
            var workersCount = int.Parse(Console.ReadLine());
            var grapes = vineyardArea * grapesPerMeter * 0.4;
            var wine = grapes / 2.5;

            if (wine < wineNeeded)
            {
                var result = Math.Truncate(wineNeeded - wine);
                Console.WriteLine($"It will be a tough winter! More {result} liters wine needed.");
            }
            else
            {
                var result = Math.Truncate(wine);
                var wineLeft = Math.Ceiling(wine - wineNeeded);
                var winePerWorker = Math.Ceiling(wineLeft / workersCount);
                Console.WriteLine($"Good harvest this year! Total wine: {result} liters.");
                Console.WriteLine($"{wineLeft} liters left -> {winePerWorker} liters per person.");
            }

        }
    }
}
