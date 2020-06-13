using System;
using System.Collections.Generic;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> numsA = new List<List<int>>()
            {
                new List<int> { 1 , 2 , 3 },
                new List<int> { 2 , 4 , 6 },
                new List<int> { 9 , 8 , 9 }
            };

            int result = diagonalDifference(numsA);
        }

        /// <summary>
        /// return the total difference between two numbers in a cross
        /// e.g. given the following:
        /// 1 2 3
        /// 2 4 6
        /// 9 8 9
        /// add numbers in a cross:
        /// 1 + 4 + 9 = 14
        /// 3 + 4 + 9 = 16
        /// return the absolute difference 14 - 16
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int diagonalDifference(List<List<int>> arr)
        {
            int leftToRight = 0;
            int rightToLeft = 0;
            int indexLTR = 0;
            int indexRTL = arr.Count - 1;

            if (arr.Count % 3 == 0 || arr.Count != 0)
            {
                foreach (var list in arr)
                {
                    leftToRight += list[indexLTR];
                    indexLTR++;

                    rightToLeft += list[indexRTL];
                    indexRTL--;
                }
            }

            return Math.Abs(leftToRight - rightToLeft);
        }
    }
}
