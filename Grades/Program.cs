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
            Console.WriteLine($"Average grade: {stats.AverageGrade}");
            Console.WriteLine($"Highest grade: {stats.HighestGrade}");
            Console.WriteLine($"Lowest grade: {stats.LowestGrade}");


        }
    }
}