using System;
using System.Collections.Generic;

namespace Grades
{
    class GradeBook
    {
        List<float> grades; // class Field 
        public GradeBook() // Constructor 
        {
            grades = new List<float>();
        }
        public void AddGrade(float grade) // class Method
        {
            grades.Add(grade);
        }

    }
}