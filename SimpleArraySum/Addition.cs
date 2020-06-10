using System;

namespace SimpleArraySum
{
    public static class Addition
    {
        public static int simpleArraySum(int[] ar)
        {
            int sumOfArray = 0;

            foreach (var number in ar)
            {
                sumOfArray += number;
            }
            return sumOfArray;
        }
    }
}
