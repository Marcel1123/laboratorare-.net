using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentService;
using System.Linq;

namespace StudentServiceTests
{
    [TestClass]
    public class StudentAgregationServiceTest
    {
        private StudentAgregationService studentAgregationService; 

        [TestMethod]
        public void ConstructorTest()
        {
            //Arrange
            studentAgregationService = GenerateInstance();

            //Act
            Student[] studentsForAgregation = {
                new Student(11, "Marcel", 19),
                new Student(12, "Andrei", 18),
                new Student(13, "Ionut", 25),
                new Student(14, "Florin", 17),
                new Student(15, "Sorin", 27),
            };

            //Assert
            Assert.Equals(studentsForAgregation, studentAgregationService.StudentsForAgregation);
        }
        [TestMethod]
        public void AgregateSolutionTest()
        {
            //Arrange
            studentAgregationService = GenerateInstance();

            //Act


            //Assert


        }
        private StudentAgregationService GenerateInstance()
        {
            return new StudentAgregationService();
        }
    }
}
