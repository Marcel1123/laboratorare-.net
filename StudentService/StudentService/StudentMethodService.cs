using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentService
{
    public class StudentMethodService
    {
        public IEnumerable<Student> GetStudentsOlderThan19(Student[] students)
        {
            if (students == null)
            {
                return null;
            }

            return from student in students
                   where student.Age > 19
                   select student;
        }

        public IEnumerable<Student> GetStudentsBetween18And22(Student[] students)
        {
            if (students == null)
            {
                return null;
            }

            return from student in students
                   where student.Age >= 18 && student.Age <= 22
                   select student;
        }

        public IEnumerable<Student> GetStudentsWithJInName(Student[] students)
        {
            if (students == null)
            {
                return null;
            }

            return from student in students
                   where student.StudentName.Contains('J')
                   select student;
        }

        public IEnumerable<Student> GetStudentsWithlInName(Student[] students)
        {
            if (students == null)
            {
                return null;
            }

            return from student in students
                   where student.StudentName.Contains('l')
                   select student;
        }

        public IEnumerable<Student> GetStudentsWith17Age(Student[] students)
        {
            if (students == null)
            {
                return null;
            }

            return from student in students
                   where student.Age == 17
                   select student;
        }
    }
}
