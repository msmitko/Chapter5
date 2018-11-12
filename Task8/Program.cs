using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());
            string enterValue = Console.ReadLine();
            long intValue = 0;
            double doubleValue = 0.0;
            string stringValue = "";
            switch (n)
            {
                case 1:
                    {
                        intValue = int.Parse(enterValue);
                        intValue += 1;
                        Console.WriteLine(intValue);
                        break;
                    }
                case 2:
                    {
                        doubleValue = double.Parse(enterValue);
                        doubleValue += 1.0;
                        Console.WriteLine(doubleValue);
                        break;
                    }
                case 3:
                    {
                        stringValue = enterValue;
                        stringValue += "*";
                        Console.WriteLine(stringValue);
                        break;
                    }

            }
        }
    }
}
