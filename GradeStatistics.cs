using System;

namespace Grades
{
    class GradeStatistics 
    {
        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;

        // Constructor 
        public GradeStatistics()
        {   
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }
    }
}