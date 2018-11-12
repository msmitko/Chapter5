using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;
            string coupleOneWinner = string.Empty;
            string coupleTwoWinner = string.Empty;
            string coupleThreeWinner = string.Empty;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());
            //Biggest from A and B

            if (a > b)
            {
                coupleOneWinner = "a";
            }
            else
            {
                coupleOneWinner = "b";
            }
            // Biggest from C and D
            if (c > d)
            {
                coupleTwoWinner = "c";
            }
            else
            {
                coupleTwoWinner = "d";
            }

            // The biggest from CoupleOne and CoupleTwo = Couple Three

            if ((coupleOneWinner == "a") && (coupleTwoWinner == "c"))
            {
                if (a > c)
                {
                    coupleThreeWinner = "a";
                    if (a > e)
                    {
                        Console.WriteLine("{0}", a);
                    }
                    else
                    {
                        Console.WriteLine("{0}", e);
                    }
                }
                else
                {
                    coupleThreeWinner = "c";
                    if (c > e)
                    {
                        Console.WriteLine("{0}", c);
                    }
                    else
                    {
                        Console.WriteLine("{0}", e);
                    }
                }
            }
            else if ((coupleOneWinner == "a") && (coupleTwoWinner == "d"))
            {
                if (a > d)
                {
                    coupleThreeWinner = "a";
                    if (a > e)
                    {
                        Console.WriteLine("{0}", a);
                    }
                    else
                    {
                        Console.WriteLine("{0}", e);
                    }
                }
                else
                {
                    coupleThreeWinner = "d";
                    if (d > e)
                    {
                        Console.WriteLine("{0}", d);
                    }
                    else
                    {
                        Console.WriteLine("{0}", e);
                    }
                }
            }
            else if ((coupleOneWinner == "b") && (coupleTwoWinner == "c"))
            {
                if (b > c)
                {
                    coupleThreeWinner = "b";
                    if (b > e)
                    {
                        Console.WriteLine("{0}", b);
                    }
                    else
                    {
                        Console.WriteLine("{0}", e);
                    }
                }
                else
                {
                    coupleThreeWinner = "c";
                    if (c > e)
                    {
                        Console.WriteLine("{0}", c);
                    }
                    else
                    {
                        Console.WriteLine("{0}", e);
                    }
                }
            }
            else if ((coupleOneWinner == "b") && (coupleTwoWinner == "d"))
            {
                if (b > d)
                {
                    coupleThreeWinner = "b";
                    if (b > e)
                    {
                        Console.WriteLine("{0}", b);
                    }
                    else
                    {
                        Console.WriteLine("{0}", e);
                    }
                }
                else
                {
                    coupleThreeWinner = "d";
                    if (d > e)
                    {
                        Console.WriteLine("{0}", d);
                    }
                    else
                    {
                        Console.WriteLine("{0}", e);
                    }
                }
            }
        }
    }
}
