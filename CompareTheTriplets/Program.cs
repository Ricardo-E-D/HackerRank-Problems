using System;
using System.Collections.Generic;

namespace CompareTheTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> alice = new List<int> { 17, 28, 30 };
            List<int> Bob = new List<int> { 99, 16, 8 };

            compareTriplets(alice, Bob);
        }

        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> aliceAndBobPoints = new List<int> { 0, 0 };

            if (a.Count == b.Count)
            {
                for (int i = 0; i < a.Count; i++)
                {
                    if (a[i] > b[i])
                    {
                        aliceAndBobPoints[0]++;
                    }
                    else if (a[i] < b[i])
                    {
                        aliceAndBobPoints[1]++;
                    }
                }
            }
            return aliceAndBobPoints;
        }
    }
}
