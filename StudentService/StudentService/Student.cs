using System;
using System.Collections.Generic;
using System.Text;

namespace StudentService
{
    public class Student
    {
        public int StudentID { get; private set; }
        public string StudentName { get; private set; }
        public int Age { get; private set; }
        public Student(int studentID, string studentName, int age)
        {
            this.StudentID = studentID;
            this.StudentName = studentName;
            this.Age = age;
        }
    }
}
