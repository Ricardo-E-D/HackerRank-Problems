using System;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { -4, 3, -9, 0, 4, 1 };


        }

        /// <summary>
        /// writes what the percantage of 0s, -s and +s there are in the array
        /// </summary>
        /// <param name="arr"></param>
        static void plusMinus(int[] arr)
        {
            double size = arr.Length;
            double[] elements = new double[3];

            foreach (var num in arr)
            {
                if (num == 0)
                {
                    elements[2]++;
                }
                else if (num > 0)
                {
                    elements[0]++;
                }
                else if (num < 0)
                {
                    elements[1]++;
                }
            }

            foreach (var element in elements)
            {
                Console.WriteLine(element / size);
            }
        }
    }
}
