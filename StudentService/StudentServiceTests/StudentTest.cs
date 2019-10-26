using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentService;

namespace StudentServiceTests
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void TestStudentConstructor()
        {
            //Arrange
            Student student = new Student(1, "Marcel", 22);

            //Act
            int studentId = student.StudentID;
            string studentName = student.StudentName;
            int studentAge = student.Age;

            //Assert
            Assert.AreEqual(studentId, student.StudentID);
            Assert.AreEqual(studentName, student.StudentName);
            Assert.AreEqual(studentAge, student.Age);
        }
    }
}
