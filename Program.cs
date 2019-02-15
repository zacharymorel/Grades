using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);

            GradeBook book2 = new GradeBook();
            book2.AddGrade(75);

            // Blow is an Example showing variables using the same reference object
            // GradeBook book2 = book; 
            // book2.AddGrade(75);
        }
    }
}
