using NUnit.Framework;
using Services.DAO;
using System;

namespace Services.Tests
{
    [TestFixture]
    public class StudentDAOTests
    {
        [Test]
        [TestCase("", "", 0, 0)]
        [TestCase("Bob", "Chu", 69, 69)]
        public void AddStudent_InvalidStudent_ThrowsError(string firstName, string lastName, int userId, int gradeId)
        {
            //Arrange
            var context = new MarkBookDBContext();
            var studentDAO = new StudentDAO(context);
            //Act

            //Assert
            Assert.Throws<ArgumentException>(() => studentDAO.AddStudent(firstName, lastName, userId, gradeId));
        }

        //[Test]
        //[TestCase(0)]
        //[TestCase(69)]
        //public void GetStudentById_InvalidId_ThrowsError(int studentId)
        //{
        //    //Arrange
        //    var context = new MarkBookDBContext();
        //    var studentDAO = new StudentDAO(context);
        //    //Act

        //    //Assert
        //    Assert.Throws<ArgumentException>(() => studentDAO.GetStudentById(studentId));
        //}

        [Test]
        [TestCase(0)]
        [TestCase(69)]
        public void RemoveStudentById_InvalidId_ThrowsError(int studentId)
        {
            //Arrange
            var context = new MarkBookDBContext();
            var studentDAO = new StudentDAO(context);
            //Act

            //Assert
            Assert.Throws<ArgumentException>(() => studentDAO.RemoveStudentById(studentId));
        }

        [Test]
        [TestCase(0)]
        [TestCase(69)]
        public void AllStudentsFromGrade_InvalidId_ThrowsError(int gradeId)
        {
            //Arrange
            var context = new MarkBookDBContext();
            var studentDAO = new StudentDAO(context);
            //Act

            //Assert
            Assert.Throws<ArgumentException>(() => studentDAO.AllStudentsFromGrade(gradeId));
        }

        //[Test]
        //[TestCase(0)]
        //[TestCase(69)]
        //public void GetStudentByUserID_InvalidId_ThrowsError(int userId)
        //{
        //    var context = new MarkBookDBContext();
        //    var studentDAO = new StudentDAO(context);

        //    Assert.Throws<ArgumentException>(() => studentDAO.GetStudentByUserID(userId));
        //}

        [Test]
        [TestCase(0)]
        [TestCase(69)]
        public void AllMarksOfStudent_InvalidStudent_ThrowsError(int studentId)
        {
            var context = new MarkBookDBContext();
            var studentDAO = new StudentDAO(context);

            Assert.Throws<ArgumentException>(() => studentDAO.AllMarksOfStudent(studentId));
        }
    }
}
