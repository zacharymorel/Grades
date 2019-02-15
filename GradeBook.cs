using System;
using System.Collections.Generic;

namespace Grades
{
    class GradeBook
    {
        public GradeBook() // Constructor 
        {
            grades = new List<float>();
        }
        public void AddGrade(float grade) // class Method
        {
            grades.Add(grade);
        }

        List<float> grades; // class Field 
    }
}