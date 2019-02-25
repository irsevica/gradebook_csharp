using System.Collections;
using System.IO;

namespace Grades
{
    public interface IGradeTracker : IEnumerable
    {
        string Name { get; set; }
        
        event NameChangedDelegate NameChanged;
        
        void AddGrade(float grade);

        GradeStatistics ComputeStatistics();

        void WriteGrades(TextWriter destination);
    }
}