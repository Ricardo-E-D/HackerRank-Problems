using System;
using System.Collections.Generic;

namespace GradingStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> studentGrades = new List<int>() { 73, 67, 38, 33 };

            List<int> correctedGrades = gradingStudents(studentGrades);
        }

        /// <summary>
        /// Any grade less than 40 is a failing grade.
        /// 
        /// if a number is closer to the next multiple of 5, round up to that number, e.g.
        /// 50 - 52 - 55    52 is closer to 50, therefore no roundup
        /// 50 - 53 - 55    53 is closer to 55, therefore roundup
        /// 
        /// if a grade is lower than 38, there will be no roundup
        /// </summary>
        /// <param name="grades"></param>
        /// <returns></returns>
        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> graded = new List<int>();

            foreach (var grade in grades)
            {
                int temp;

                if (grade >= 38)
                {
                    temp = grade % 5;

                    if (temp == 3 || temp == 4)
                    {
                        graded.Add(grade + (5 - temp));
                    }
                    else
                    {
                        graded.Add(grade);
                    }
                }
                else
                {
                    graded.Add(grade);
                }                
            }

            return graded;
        }
    }
}
