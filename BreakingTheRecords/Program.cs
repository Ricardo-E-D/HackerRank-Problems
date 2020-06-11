using System;
using System.Linq;

namespace BreakingTheRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 };

            breakingRecords(ar);

        }
        /// <summary>
        /// given an array
        /// count how many times your current minimum score decreases and
        /// count how many times your current maximum score increases
        /// 
        /// e.g.:
        /// game    score   Minimum Maximum Min Max
        /// 0       12      12      12      0   0
        /// 1       24      12      24      0   1
        /// 2       10      10      24      1   1
        /// 3       24      10      24      1   1
        /// 
        /// this should return int[] {1 , 1}
        /// </summary>
        /// <param name="scores"></param>
        /// <returns></returns>
        static int[] breakingRecords(int[] scores)
        {
            int[] maxMinScores = { scores[0], scores[0] };
            int[] result = { 0, 0 };

            foreach (var score in scores.Skip(1))
            {
                if (score > maxMinScores[0])
                {
                    maxMinScores[0] = score;
                    result[0]++;
                }
                else if(score < maxMinScores[1])
                {
                    maxMinScores[1] = score;
                    result[1]++;
                }
            }

            return result;
        }
    }
}
