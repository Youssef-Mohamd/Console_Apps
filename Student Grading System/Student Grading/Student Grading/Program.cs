


namespace Student_Grading
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>(); // List to store student 

            while (true)
            {
                Console.WriteLine("Welcome to the grading system");

                Console.WriteLine("Please enter your name or enter 'Done' :");


                string studentName = Console.ReadLine();

                if (studentName.ToLower() == "done")
                {
                    break; 
                }

                List<int> studentgrades = new List<int>(); // List to store grades for the current student

                Console.WriteLine("Please enter your grades 5 subjects:");

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Subject {i + 1}:");

                    int gradeValue = int.Parse(Console.ReadLine());

                    // Here you can store the grades in a list or array if needed
                    studentgrades.Add(gradeValue);
                }

                Student student = new Student
                {
                    Name = studentName,
                    Grades = studentgrades
                };

                students.Add(student);

                Console.WriteLine("A new student has been added to the system.");
            }

            GradingSystem gradingSystem = new GradingSystem();
            gradingSystem.DisplayStudentGrades(students, calculateAverage , CheckIfStudentPassed, DisplayData); // used func to pass the method to calculate the average grade for each student
        }

        private static void DisplayData(Student student, double arg2, bool arg3)
        {
            string status = arg3 ? "Passed" : "Failed";
        }

        private static bool CheckIfStudentPassed(double averageValue)
        {
            if (averageValue >= 60)
            {
                Console.WriteLine("The student has passed.");
                return true;
            }
            else
            {
                Console.WriteLine("The student has failed.");
                return false;
            }
        }

        private static double calculateAverage(List<int> grades) // Method to calculate the average grade for a student
        {
            return grades.Average();
        }
    }
}
