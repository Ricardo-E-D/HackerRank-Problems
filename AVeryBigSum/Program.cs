using System;

namespace AVeryBigSum
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };

            long sum = aVeryBigSum(numbers);
        }

        /// <summary>
        /// returns the sum of a elements from an array
        /// </summary>
        /// <param name="ar"></param>
        /// <returns></returns>
        static long aVeryBigSum(long[] ar)
        {
            long result = 0;

            foreach (var number in ar)
            {
                result += number;
            }
            return result;
        }
    }
}
