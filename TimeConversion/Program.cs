using System;
using System.Linq;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = "07:05:45PM";

            string t = timeConversion(time);
            Console.WriteLine(t);
        }

        /// <summary>
        /// Return a 12h time to a 24h time
        /// without using datetime
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static string timeConversion(string s)
        {
            s = s.Replace(" ", "");

            string amOrPm = s.Substring(s.Length - 2);
            int hour = Int32.Parse(s.Substring(0, s.IndexOf(":")));

            if (amOrPm.Equals("pm", StringComparison.InvariantCultureIgnoreCase) && hour != 12)
            {
                s = s.Replace(s.Substring(0, s.IndexOf(":")), Convert.ToString(hour + 12));
                return s.Substring(0, s.Length - 2);
            }
            else if (amOrPm.Equals("am", StringComparison.InvariantCultureIgnoreCase) && hour == 12)
            {
                s = s.Replace(s.Substring(0, s.IndexOf(":")), "00");
                return s.Substring(0, s.Length - 2);

            }
            return s.Substring(0, s.Length - 2);
        }
    }
}
