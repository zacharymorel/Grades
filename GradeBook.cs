using System;
using System.Collections.Generic;

namespace Grades
{
    class GradeBook
    {
        private List<float> grades; // class Field 
        public GradeBook() // Constructor 
        {
            grades = new List<float>();
        }
        public void AddGrade(float grade) // class Method
        {
            grades.Add(grade);
        }

        public GradeStatistics ComputeStatistics() 
        {
            // initialization of variable that stores Reference type GradeStatistics
            GradeStatistics stats = new GradeStatistics();
            float sum = 0;
            foreach(float grade in grades) 
            {
                    // Math.Max class takes in two numbers and returns the Highest value
                    stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                    stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                    sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;
            
            return stats;
        }

    }
}