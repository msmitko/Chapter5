using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if (a >= 0)
            {
                if (b >= 0)
                {
                    if (c >= 0)
                    {
                        if ((a == 0) && (b == 0) && (c == 0))
                        {
                            Console.WriteLine("0");
                        }
                        else
                        {
                            Console.WriteLine("+");
                        }
                    }
                    else if (c <= 0)
                    {
                        if ((a == 0) && (b == 0) && (c == 0))
                        {
                            Console.WriteLine("0");
                        }
                        else
                        {
                            Console.WriteLine("-");
                        }
                    }
                }
                else if (b <= 0)
                {
                    if (c >= 0)
                    {
                        if ((a == 0) && (b == 0) && (c == 0))
                        {
                            Console.WriteLine("0");
                        }
                        else
                        {
                            Console.WriteLine("-");
                        }
                    }
                    else if (c <= 0)
                    {
                        if ((a == 0) && (b == 0) && (c == 0))
                        {
                            Console.WriteLine("0");
                        }
                        else
                        {
                            Console.WriteLine("+");
                        }
                    }
                }
            }
            else if (a <= 0)
            {
                if (b >= 0)
                {
                    if (c >= 0)
                    {
                        if ((a == 0) && (b == 0) && (c == 0))
                        {
                            Console.WriteLine("0");
                        }
                        else
                        {
                            Console.WriteLine("-");
                        }
                    }
                    else if (c <= 0)
                    {
                        if ((a == 0) && (b == 0) && (c == 0))
                        {
                            Console.WriteLine("0");
                        }
                        else
                        {
                            Console.WriteLine("+");
                        }
                    }
                }
                else if (b <= 0)
                {
                    if (c >= 0)
                    {
                        if ((a == 0) && (b == 0) && (c == 0))
                        {
                            Console.WriteLine("0");
                        }
                        else
                        {
                            Console.WriteLine("+");
                        }
                    }
                    else if (c <= 0)
                    {
                        if ((a == 0) && (b == 0) && (c == 0))
                        {
                            Console.WriteLine("0");
                        }
                        else
                        {
                            Console.WriteLine("-");
                        }
                    }
                }
            }
        }
    }
}

