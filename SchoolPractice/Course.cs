using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
   public class Course
    {
        public string CourseName;
        public List<Student> Roster;
        public Teacher InstructorName;


        public Course(string courseName, List<Student> roster, Teacher instructorName)
        {
            CourseName = courseName;
            Roster = roster;
            InstructorName = instructorName;

        }
    }
}
