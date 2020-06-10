using SimpleArraySum;
using System;
using Xunit;

namespace SimpleArraySum_XUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestIfTheMethodSumsEverythingInAnArray()
        {
            int[] arr1 = { 1, 2, 3, 5, 4 };
            int[] arr2 = { 2, 4, 3, 1 };
            int[] arr3 = { 2, 8, 3 };
            int[] arr4 = { 3, 6, 3 };
            int[] arr5 = { 3, 2, 3, 5, 7 };
            int[] arr6 = { 5, 6, 6 };
            int[] arr7 = { 9, 6, 1, 9, 8 };
            int[] arr8 = { 2, 2, 1 };
            int[] arr9 = { 5, 7, 1, 1, 4, 1 };

            int res1 = 15;
            int res2 = 10;
            int res3 = 13;
            int res4 = 12;
            int res5 = 20;
            int res6 = 17;
            int res7 = 33;
            int res8 = 5;
            int res9 = 19;

            for (int i = 1; i <= 9; i++)
            {

            }
        }
    }
}
