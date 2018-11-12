using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            int bonusPoints = int.Parse(Console.ReadLine());
            int result = 1;
            if (bonusPoints >= 1 && bonusPoints <= 3)
            {
                result = bonusPoints * 10;
                Console.WriteLine(result);
            }
            else if (bonusPoints >= 4 && bonusPoints <= 6)
            {
                result = bonusPoints * 100;
                Console.WriteLine(result);
            }
            else if (bonusPoints >= 7 && bonusPoints <= 9)
            {
                result = bonusPoints * 1000;
                Console.WriteLine(result);
            }
            else if (bonusPoints == 0 || bonusPoints > 9)
            {
                string res = "ERROR 37";
                Console.WriteLine(res);
            }
        }
    }
}


