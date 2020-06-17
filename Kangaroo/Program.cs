using System;

namespace Kangaroo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 43, 2, 70, 2 };

            string result = kangaroo(data[0], data[1], data[2], data[3]);
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/kangaroo/problem
        /// </summary>
        /// <param name="x1">starting position for kangaroo 1</param>
        /// <param name="v1">jump distance for kangaroo 1</param>
        /// <param name="x2">starting position for kangaroo 2</param>
        /// <param name="v2">jump position for kangaroo 2</param>
        /// <returns></returns>
        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            if (x1 == x2) return "YES";
            if (v1 == v2) return "NO";

            int currentMinPosition;
            int minJumpDistance;
            int currentMaxPosition;
            int maxJumpDistance;
            bool overlapLocation = false;
            var minStartingPosition = Math.Min(x1, x2);

            if (minStartingPosition == x1)
            {
                currentMinPosition = x1;
                minJumpDistance = v1;
                currentMaxPosition = x2;
                maxJumpDistance = v2;
            }
            else
            {
                currentMinPosition = x2;
                minJumpDistance = v2;
                currentMaxPosition = x1;
                maxJumpDistance = v1;
            }

            while (currentMinPosition <= currentMaxPosition)
            {
                currentMinPosition += minJumpDistance;
                currentMaxPosition += maxJumpDistance;

                if (currentMinPosition == currentMaxPosition)
                {
                    overlapLocation = true;
                    break;
                }
            }          

            if (overlapLocation)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }
    }
}
