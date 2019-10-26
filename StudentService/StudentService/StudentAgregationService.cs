using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentService
{
    public class StudentAgregationService
    {
        public Student[] StudentsForAgregation { get; }
        public StudentFactory StudentFactory;
        public StudentAgregationService()
        {
            Student[] studentsForAgregation = {
                new Student(11, "Marcel", 19),
                new Student(12, "Andrei", 18),
                new Student(13, "Ionut", 25),
                new Student(14, "Florin", 17),
                new Student(15, "Sorin", 27),
            };

            StudentsForAgregation = studentsForAgregation;

            StudentFactory = new StudentFactory();
        }

        public IEnumerable<Student> AgregateStudents() => StudentsForAgregation.Union(StudentFactory.Create());
    }
}
