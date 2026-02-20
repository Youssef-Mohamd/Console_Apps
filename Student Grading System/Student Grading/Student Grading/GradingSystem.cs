using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grading
{
    internal class GradingSystem
    {
        public void DisplayStudentGrades(List<Student> students
            , Func<List<int>,double> calculateAverage,
              Predicate<double> checkIfPassed,
              Action<Student,double,bool> displayData)
        {
            foreach (var student in students)
            {
              double averageGrades = calculateAverage(student.Grades);
                Console.WriteLine($"Student Name: {student.Name}, Average Grade: {averageGrades}");
                bool isStudentPass = checkIfPassed(averageGrades);
                displayData(student, averageGrades, isStudentPass);
            }
        }
    }
}
