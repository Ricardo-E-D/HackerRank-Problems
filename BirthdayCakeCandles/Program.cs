using System;
using System.Collections.Generic;

namespace BirthdayCakeCandles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] candles = { 6, 3, 8, 5, 2, 4, 7, 4, 9, 5, 6, 7, 9, 9 };

            int total = birthdayCakeCandles(candles);
            Console.WriteLine(total + " candles have been blown");
        }
        /// <summary>
        /// given an int array, return how many tallest candles(highest value) there are
        /// </summary>
        /// <param name="ar"></param>
        /// <returns></returns>
        static int birthdayCakeCandles(int[] ar)
        {
            int[] candles = { 0, 0 };

            foreach (var candle in ar)
            {
                if (candle > candles[0])
                {
                    candles[0] = candle;
                    candles[1] = 1;
                }
                else if (candle == candles[0])
                {
                    candles[1]++;
                }
            }

            return candles[1];
        }
    }
}
