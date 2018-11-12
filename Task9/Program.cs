﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[5];
            string[] lineArr = Console.ReadLine().Split(new string[] { " " },
                StringSplitOptions.RemoveEmptyEntries);
            int j = 0;
            foreach (string elem in lineArr)
            {
                arr[j] = int.Parse(elem);
                j++;
            }


            bool isFind = false;

            List<int[]> lists = createSubsets(arr);

            for (int i = 0; i < lists.Count; i++)
            {
                if (sumOfArray(lists.ElementAt(i)) == 0)
                {
                    printArr(lists.ElementAt(i));
                    isFind = true;
                }
            }

            if (isFind == false)
            {
                Console.WriteLine("NO SUBSETS");
            }

        }

        private static void printArr(int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
                Console.Write(" " + arr[i] + " ");
            Console.WriteLine();
        }
        private static int sumOfArray(int[] subset)
        {
            int sum = 0;
            for (var i = 0; i < subset.Length; i++)
            {
                sum += subset[i];
            }
            return sum;
        }

        private static List<T[]> createSubsets<T>(T[] originalArray)
        {
            List<T[]> subsets = new List<T[]>();

            for (int i = 0; i < originalArray.Length; i++)
            {
                int subsetCount = subsets.Count;
                subsets.Add(new T[] { originalArray[i] });

                for (int j = 0; j < subsetCount; j++)
                {
                    T[] newSubset = new T[subsets[j].Length + 1];
                    subsets[j].CopyTo(newSubset, 0);
                    newSubset[newSubset.Length - 1] = originalArray[i];
                    subsets.Add(newSubset);
                }
            }

            return subsets;
        }
    }
}