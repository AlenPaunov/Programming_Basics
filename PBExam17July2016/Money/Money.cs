using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Money
    {
        static void Main()
        {
            //1 bitcoin = 1168 lv.
            //1 uan = 0.15 $;
            //1 dollar = 1.76 lv.
            //1 euro = 1.95lv.
            var bitcoinsCount = double.Parse(Console.ReadLine())*1168.0;
            var uansCount = double.Parse(Console.ReadLine())*0.15*1.76;
            var commission = double.Parse(Console.ReadLine()); // euro

            var totalsum = (bitcoinsCount + uansCount) / 1.95;
            totalsum = totalsum - totalsum * commission / 100.0;
            //totalsum *= 1.95;
            Console.WriteLine($"{totalsum:f2}");
        }
    }
}
