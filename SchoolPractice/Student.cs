using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        public string Name;
        public int StudentID;
        public int NumOfCredits;
        public double GPA;
        
        //private int phone;
       //public int Phone
        //{
        //    set { phone = value; }
        //}

     public Student(string name, int studentID, int numOfCredits, double gpa)
        {
            Name = name;
            StudentID = studentID;
            NumOfCredits = numOfCredits;
            GPA = gpa;
            
        }
       
    }
}
