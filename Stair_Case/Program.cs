using System;
using System.Text;

namespace Stair_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
        }
        /// <summary>
        /// n is the size and length of the staircase
        /// e.g. if n = 3, output should be:
        ///   x
        ///  xx
        /// xxx
        /// </summary>
        /// <param name="n"></param>
        static void staircase(int n)
        {
            StringBuilder sb = new StringBuilder();

            
            /// e.g. of n = 5
            /// i equals to n(5) - 1 = 4
            /// first append: ' ' i(4) times
            /// then append: '#' n(5) - i(4) = 1 time
            /// lastly make a new line
            for (int i = n - 1; i >= 0; i--)
            {
                sb.Append(' ', i).Append('#', n - i).Append("\n");
            }

            Console.WriteLine(sb);
        }
    }
}
