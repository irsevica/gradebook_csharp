using System;

namespace Grades
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(71);

            GradeStatistics stats = book.ComputeStatistics();
            WriteResult("Average grade", stats.AverageGrade);
            WriteResult("Highest grade", (int)stats.HighestGrade);
            WriteResult("Lowest grade", stats.LowestGrade);


        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine(description + ": " + result);
        }
    }
}