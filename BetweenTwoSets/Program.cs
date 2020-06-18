using System;
using System.Collections.Generic;
using System.Linq;

namespace BetweenTwoSets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr1 = new List<int>() { 2, 4 };
            List<int> arr2 = new List<int>() { 16, 32, 96 };

            int result = getTotalX(arr1, arr2);
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/between-two-sets/problem
        /// </summary>
        /// <param name="a">array of ints, all are factors of the integer being considered</param>
        /// <param name="b">array of ints, the integer being considered is a factor of all elements in this array</param>
        /// <returns></returns>
        public static int getTotalX(List<int> a, List<int> b)
        {
            int result = 0;
            int min = a.Max();
            int max = b.Min();

            List<int> elements = a.Concat(b).ToList();
            List<int> factors = new List<int>();

            var temp = new List<int>();

            for (int i = elements.Min(); i <= elements.Max(); i += elements.Min())
            {
                factors.Add(i);
            }

            foreach (var element in elements.Skip(1))
            {
                foreach (var factor in factors)
                {
                    if (element >= factor)
                    {
                        if (element % factor == 0)
                        {
                            temp.Add(factor);
                        }
                    }
                    else if (element < factor)
                    {
                        if (factor % element == 0)
                        {
                            temp.Add(factor);
                        }
                    }
                }
                factors = temp;
                temp = new List<int>();
            }

            foreach (var item in factors)
            {
                if (item >= min && item <= max)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
