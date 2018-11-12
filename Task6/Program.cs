using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, discriminant, root1, root2, x;

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            discriminant = ((b * b) - (4 * (a * c)));

            if (a != 0)
            {
                if (discriminant > 0)
                {
                    discriminant = Math.Sqrt(discriminant);
                    root1 = (((b * (-1)) + discriminant) / (2 * a));
                    root2 = (((b * (-1)) - discriminant) / (2 * a));
                    Console.WriteLine("{0} {1}", root1, root2);
                }
                else if (discriminant == 0)
                {
                    x = ((-1) * (b / (2 * a)));
                    Console.WriteLine("{0}", x);
                }
                else if (discriminant < 0)
                {
                    Console.WriteLine("No Roots");
                }
            }
            else if (a == 0)
            {
                Console.WriteLine("Roots");
            }
        }
    }
}
