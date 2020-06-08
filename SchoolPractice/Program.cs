using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student andyStudent = new Student("Andy", 1,1, 4.0);
            Console.WriteLine(andyStudent.Name);
            andyStudent.AddGrade(1, 3.0);
            Console.WriteLine(andyStudent.Gpa);
            Console.WriteLine(andyStudent.NumberOfCredits);
            Console.WriteLine(andyStudent.StudentInfo());
            Console.WriteLine(andyStudent.ToString());
            Console.WriteLine(andyStudent.Equals(andyStudent));
        }
    }
}
