using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var cols = 5 * input;
            var rows = 3 * input + 2;
            var star = '*';
            var dot = '.';
            var dots = input;
            char middleChar = '*';
            var middleChars = input * 3 - 2; 
            //first part
            for (int i = 0; i <= input; i++)
            {
                if (i ==0 || i==input)
                {
                    middleChar = '*';
                }
                else
                {
                    middleChar = '.';
                }
                Console.WriteLine(new string (dot,dots)+star+new string(middleChar,middleChars)+star+ new string(dot, dots));
                dots--;
                middleChars += 2;
            }
            //second part
            dots = 1;
            middleChars = cols - 4;
            middleChar = '.';
            for (int i = 0; i < rows - (input + 1); i++)
            {
                if (i == rows-(input+1)-1)
                {
                    middleChar = '*';
                }
                Console.WriteLine(new string(dot, dots) + star + new string(middleChar, middleChars) + star + new string(dot, dots));
                dots++;
                middleChars -= 2;
            }
        }
    }
}
