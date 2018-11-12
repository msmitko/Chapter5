using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second, third;

            first = int.Parse(Console.ReadLine());
            second = int.Parse(Console.ReadLine());
            third = int.Parse(Console.ReadLine());

            if ((first > second) && (second >= third))
            {
                Console.WriteLine(first);
            }
            else if ((second > first) && (first >= third))
            {
                Console.WriteLine(second);
            }
            else if ((third > first) && (first >= second))
            {
                Console.WriteLine(third);
            }
            else if (first == second)
            {
                if (first < third)
                {
                    Console.WriteLine(third);
                }
                else
                {
                    Console.WriteLine(first);
                }
            }
            else if ((second == third) && (first > second))
            {
                Console.WriteLine(first);
            }
            else if (first == third)
            {
                if (second > first)
                    Console.WriteLine(second);
                else
                {
                    Console.WriteLine(first);
                }
            }
            else if ((first == second) && (second == third))
            {
                Console.WriteLine(0);
            }
            else if ((first < second) && (second <= third))
            {
                if (second == third)
                {
                    Console.WriteLine(second);
                }
                else
                {
                    Console.WriteLine(third);
                }
            }
        }
    }
}
