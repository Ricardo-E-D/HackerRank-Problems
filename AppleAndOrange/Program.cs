using System;
using System.Collections.Generic;

namespace AppleAndOrange
{
    class Program
    {
        static void Main(string[] args)
        {
            int houseStart = 7;
            int houseEnd = 10;
            int appleTree = 4;
            int orangeTree = 12;
            int[] apples = { 2, 3, -4 };
            int[] oranges = { 3, -2, -4 };

            countApplesAndOranges(houseStart, houseEnd, appleTree, orangeTree, apples, oranges);

        }

        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            List<int> applesPositions = new List<int>();
            List<int> orangesPositions = new List<int>();

            int totalApples = 0;
            int totalOranges = 0;

            foreach (var apple in apples)
            {
                applesPositions.Add(a + apple);
            }
            foreach (var orange in oranges)
            {
                orangesPositions.Add(b + orange);
            }

            foreach (var apple in applesPositions)
            {
                if (apple >= s && apple <= t)
                {
                    totalApples++;
                }
            }
            foreach (var orange in orangesPositions)
            {
                if (orange >= s && orange <= t)
                {
                    totalOranges++;
                }
            }

            Console.WriteLine(totalApples + "\n" + totalOranges);
        }
    }
}
