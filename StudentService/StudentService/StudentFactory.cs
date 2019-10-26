using System;

namespace StudentService
{
    public class StudentFactory
    {
        public Student[] Create()
        {
            Student[] studentArray = {
                    new Student(1, "John", 18),
                    new Student(3, "Bill", 25),
                    new Student(4, "Ram", 20),
                    new Student(2, "Steve", 21),
                    new Student(5, "Ron", 23),
                    new Student(6, "Chris", 17),
                    new Student(7, "Rob", 19),
                    new Student(8, "Jan", 16),
                    new Student(9, "Job", 17),
                    new Student(10, "Steven", 20),
            };
            return studentArray;
        }
    }
}
