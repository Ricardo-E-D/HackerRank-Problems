using System;

namespace SimpleArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 10, 11 };

            int total = simpleArraySum(numbers);
        }

        /// <summary>
        /// returns the total sum of all items in the array
        /// </summary>
        /// <param name="ar"></param>
        /// <returns></returns>
        static int simpleArraySum(int[] ar)
        {
            int sum = 0;

            foreach (var num in ar)
            {
                sum += num;
            }
            return sum;
        }
    }
}
