using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Teacher
    {
        public string FirstName;
        public string LastName;
        public string Subject;
        public int YearsTeaching;

        //private int phone;
        //public int Phone
        //{
        //    set { phone = value; }
        //}

        public Teacher(string firstName, string lastName, string subject, int yearsTeaching)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
            YearsTeaching = yearsTeaching;

        }

    }
}

