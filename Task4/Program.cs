﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second, third, smallest, middle, biggest;

            first = int.Parse(Console.ReadLine());
            second = int.Parse(Console.ReadLine());
            third = int.Parse(Console.ReadLine());

            if (first < second)
            {
                if (first < third)
                {
                    smallest = first;

                    if (second > third)
                    {
                        middle = third;
                        biggest = second;
                        Console.WriteLine("{0} {1} {2}", biggest, middle, smallest);
                    }
                    else if (second < third)
                    {
                        middle = second;
                        biggest = third;
                        Console.WriteLine("{0} {1} {2}", biggest, middle, smallest);
                    }
                }
            }
            if (second < first)
            {
                if (second < third)
                {
                    smallest = second;
                    if (first > third)
                    {
                        middle = third;
                        biggest = first;
                        Console.WriteLine("{0} {1} {2}", biggest, middle, smallest);
                    }
                    else if (first < third)
                    {
                        middle = first;
                        biggest = third;
                        Console.WriteLine("{0} {1} {2}", biggest, middle, smallest);
                    }
                }
            }
            if (third < first)
            {
                if (third < second)
                {
                    smallest = third;
                    if (second > first)
                    {
                        middle = first;
                        biggest = second;
                        Console.WriteLine("{0} {1} {2}", biggest, middle, smallest);
                    }
                    else if (second < first)
                    {
                        middle = second;
                        biggest = first;
                        Console.WriteLine("{0} {1} {2}", biggest, middle, smallest);
                    }
                }
            }
        }
    }
}
