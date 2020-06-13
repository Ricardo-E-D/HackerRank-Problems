using System;
using System.Linq;

namespace Mini_MaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 256741038, 623958417, 467905213, 714532089, 938071625 };

            miniMaxSum(numbers);
        }

        /// <summary>
        /// return the min and max sums of 4 of 5 elements in the array
        /// return for the following array:
        /// 256741038 623958417 467905213 714532089 938071625
        /// is:
        /// 2063136757 2744467344
        /// </summary>
        /// <param name="arr"></param>
        static void miniMaxSum(int[] arr)
        {
            long[] allPossibleSums = new long[arr.Length];
            long max, min;

            for (int i = 0; i < arr.Length; i++)
            {
                allPossibleSums[i] -= arr.ElementAt(i);

                foreach (var number in arr)
                {
                    allPossibleSums[i] += number;
                }
            }

            max = allPossibleSums.Max();
            min = allPossibleSums.Min();

            Console.WriteLine("{0} {1}", min, max);
        }
    }
}
