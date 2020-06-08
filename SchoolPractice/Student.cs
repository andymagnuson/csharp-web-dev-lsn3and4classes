using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {

        private static int nextStudentId = 1;
        public string Name { get; set; }
        private readonly int studentId;
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int sId, int numberOfCredits, double gpa)
        {
            Name = name;
            studentId = sId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int sId)
        {
            Name = name;
            studentId = sId;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public Student(string name)
        {
            Name = name;
            studentId = nextStudentId;
            nextStudentId++;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public string StudentInfo()
        {
            return (this.Name + " has a GPA of: " + this.Gpa);
        }

        public void AddGrade(int courseCredits, double grade)
        {
            double points = this.Gpa * this.NumberOfCredits;
            double coursePoints = courseCredits * grade;
            this.NumberOfCredits = this.NumberOfCredits + courseCredits;
            this.Gpa = (points + coursePoints) / this.NumberOfCredits;
           
        }

        public string GetGradeLevel()
        {
            if (this.NumberOfCredits > 89)
            {
                return "Senior";
            } else if (this.NumberOfCredits > 59)
            {
                return "Junior";
            } else if (this.NumberOfCredits > 29)
            {
                return "Sophomore";
            } else
            {
                return "Freshman";
            }
        }

        public override string ToString()
        {
            return Name + ": " + this.GetGradeLevel() + ", GPA: " + Gpa; 
        }

        public override Boolean Equals(object toBeCompared)
        {

            if (toBeCompared == this)
            {
                return true;
            }

            if (toBeCompared == null)
            {
                return false;
            }

            if (toBeCompared.GetType() != this.GetType())
            {
                return false;
            }

            Student s = toBeCompared as Student;
            return s.studentId == studentId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, studentId, NumberOfCredits, Gpa);
        }
    }
}
