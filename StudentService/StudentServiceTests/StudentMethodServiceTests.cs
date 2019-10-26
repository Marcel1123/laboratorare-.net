using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentService;
using System.Linq;

namespace StudentServiceTests
{
    [TestClass]
    public class StudentMethodServiceTests
    {
        private StudentMethodService StudentMethodService;
        private Student[] students;

        [TestMethod]
        public void Test_GetStudentsOlderThan19_Method()
        {
            //Arrange
            BuildMethodServiceInstance();
            BuilStudentList();

            //Act
            var result = StudentMethodService.GetStudentsOlderThan19(students);

            //Assert
            Assert.AreEqual(5, result.Count());
        }
        [TestMethod]
        public void Test_GetStudentsBetween18And22_Method()
        {
            //Arrange
            BuildMethodServiceInstance();
            BuilStudentList();

            //Act
            var result = StudentMethodService.GetStudentsBetween18And22(students);

            //Assert
            Assert.AreEqual(5, result.Count());
        }
        [TestMethod]
        public void Test_GetStudentsWithJInName_Method()
        {
            //Arrange
            BuildMethodServiceInstance();
            BuilStudentList();

            //Act
            var result = StudentMethodService.GetStudentsWithJInName(students);

            //Assert
            Assert.AreEqual(3, result.Count());
        }
        [TestMethod]
        public void Test_GetStudentsWithlInName_Method()
        {
            //Arrange
            BuildMethodServiceInstance();
            BuilStudentList();

            //Act
            var result = StudentMethodService.GetStudentsWithlInName(students);

            //Assert
            Assert.AreEqual(1, result.Count());
        }
        [TestMethod]
        public void Test_GetStudentsWith17Age_Method()
        {
            //Arrange
            BuildMethodServiceInstance();
            BuilStudentList();

            //Act
            var result = StudentMethodService.GetStudentsWith17Age(students);

            //Assert
            Assert.AreEqual(2, result.Count());
        }
        private void BuildMethodServiceInstance()
        {
            StudentMethodService = new StudentMethodService();
        }
        
        private void BuilStudentList()
        {
            students = new StudentFactory().Create();
        }
    }
}
