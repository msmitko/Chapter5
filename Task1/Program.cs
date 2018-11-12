using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine(b);
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
        }
    }
}

