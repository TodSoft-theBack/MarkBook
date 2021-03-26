using NUnit.Framework;
using Services.DAO;
using System;

namespace Services.Tests
{
    [TestFixture]
    public class MarkDAOTests
    {
        [Test]
        [TestCase(1)]
        [TestCase(11)]
        [TestCase(7)]
        [TestCase(7.20)]
        public void AddMark_InvalidMark_ThrowsError(decimal mark)
        {
            //Arrange
            var context = new MarkBookDBContext();
            var markDAO = new MarkDAO(context);
            //Act

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => markDAO.AddMark(mark, 1, 1, "asd"));
        }

        [Test]
        [TestCase(69)]
        public void RemoveMark_InvalidMark_ThrowsError(int markId)
        {
            //Arrange
            var context = new MarkBookDBContext();
            var markDAO = new MarkDAO(context);

            //Act

            //Assert
            Assert.Throws<ArgumentException>(() => markDAO.RemoveMark(markId));
        }

        [Test]
        [TestCase(69)]
        public void GetMarkById_InvalidMark_ThrowsError(int markId)
        {
            //Arrange
            var context = new MarkBookDBContext();
            var markDAO = new MarkDAO(context);

            //Act

            //Assert
            Assert.Throws<ArgumentException>(() => markDAO.GetMarkById(markId));
        }

        [Test]
        [TestCase(3)]
        [TestCase(0)]
        public void GetAllMarksOfStudentById_InvalidStudent_ThrowsError(int studentId) 
        {
            //Arrange
            var context = new MarkBookDBContext();
            var markDAO = new MarkDAO(context);

            //Act

            //Assert
            Assert.Throws<ArgumentException>(() => markDAO.GetAllMarksOfStudentById(studentId));
        }

        [Test]
        [TestCase(3, 3)]
        [TestCase(0, 0)]
        public void GetAllMarksOfStudentForGivenSubjectById_InvalidSubject_Or_InvalidStudent_ThrowsError(int subjectId, int studentId)
        {
            //Arrange
            var context = new MarkBookDBContext();
            var MarkDAO = new MarkDAO(context);
            //Act

            //Assert
            Assert.Throws<ArgumentException>(() => MarkDAO.GetMarksOfStudentForGivenSubjectById(subjectId, studentId));
        }

        [Test]
        [TestCase(3)]
        [TestCase(0)]
        public void GetAllMarksForGivenSubjectById_InvalidSubject_Or_InvalidStudent_ThrowsError(int subjectId)
        {
            //Arrange
            var context = new MarkBookDBContext();
            var MarkDAO = new MarkDAO(context);
            //Act

            //Assert
            Assert.Throws<ArgumentException>(() => MarkDAO.GetMarksForGivenSubjectById(subjectId));
        }
    }
}