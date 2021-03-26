using NUnit.Framework;
using Services.DAO;
using System;

namespace Services.Tests
{
    [TestFixture]
    public class GradeDAOTests
    {
        [Test]
        [TestCase(0)]
        [TestCase(69)]
        public void GetGrade_InvalidId_ThrowsError(int gradeId)
        {
            //Arrange
            var context = new MarkBookDBContext();
            var gradeDAO = new GradeDAO(context);
            //Act

            //Assert
            Assert.Throws<ArgumentException>(() => gradeDAO.GetGrade(gradeId));
        }

        [Test]
        [TestCase(0, " ")]
        [TestCase(13, "g")]
        [TestCase(12, " ")]
        public void AddGrade_InvalidGrade_ThrowsError(int gradeNumber, string gradeForm)
        {
            var context = new MarkBookDBContext();
            var gradeDAO = new GradeDAO(context);

            Assert.Throws<ArgumentException>(() => gradeDAO.AddGrade(gradeNumber, gradeForm));
        }

        [Test]
        [TestCase(0)]
        [TestCase(69)]
        public void GetStudentsByGradeId_InvalidGradeId_ThrowsError(int gradeId)
        {
            var context = new MarkBookDBContext();
            var gradeDAO = new GradeDAO(context);

            Assert.Throws<ArgumentException>(() => gradeDAO.GetStudentsByGradeId(gradeId));
        }
    }
}
