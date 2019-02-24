using System;
using Xunit;
using Grades;


namespace GradesTest
{
    public class GradeBookTests
    { 
        [Fact]
        public void ComputesHighestGrade()
        {
            Grades.GradeBook book = new Grades.GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            Grades.GradeStatistics result = book.ComputeStatistics();
            Assert.Equal(90, result.HighestGrade);

        }

        [Fact]
        public void ComputesLowestGrade()
        {
            Grades.GradeBook book = new Grades.GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            Grades.GradeStatistics result = book.ComputeStatistics();
            Assert.Equal(10, result.LowestGrade);

        }

        [Fact]
        public void ComputesAverageGrade()
        {
            Grades.GradeBook book = new Grades.GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            Grades.GradeStatistics result = book.ComputeStatistics();
            Assert.Equal(85.17, result.AverageGrade, 2);

        }

    }
}
