using System;
using System.IO;

namespace Grades
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            IGradeTracker book = CreateGradeBook();

            book.NameChanged += OnNameChanged;

            GetBookName(book);

            AddGrades(book);

            SaveGrades(book);
            ;
            WriteResults(book);
        }

        private static IGradeTracker CreateGradeBook()
        {
            return new ThrowAwayGradeBook();
        }

        private static void SaveGrades(IGradeTracker book)
        {
            using (StreamWriter outputFile = File.CreateText("grades.txt"))
            {
                book.WriteGrades(outputFile);
            }
        }

        private static void WriteResults(IGradeTracker book)
        {
            foreach (float grade in book)
            {
                Console.WriteLine(grade);
            }
            
            
            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            WriteResult("Average grade", stats.AverageGrade);
            WriteResult("Highest grade", (int)stats.HighestGrade);
            WriteResult("Lowest grade", stats.LowestGrade);
            WriteResult(stats.Description, stats.LetterGrade);
        }

        private static void AddGrades(IGradeTracker book)
        {
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(71);
        }

        private static void GetBookName(IGradeTracker book)
        {

            //do
            //{
            //    Console.WriteLine("Please enter a name:");
            //    book.Name = Console.ReadLine();
            //}
            //while (String.IsNullOrEmpty(book.Name));

            try
            {
                Console.WriteLine("Please enter a name:");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Something went wrong");
            }
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}");
        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine("{0}: {1}", description, result);
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine("{0}: {1:F2}", description, result);
        }

        static void WriteResult(string description, string result)
        {
            Console.WriteLine("{0}: {1}", description, result);
        }
    }
}