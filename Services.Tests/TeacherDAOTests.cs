using NUnit.Framework;
using Services.DAO;
using System;

namespace Services.Tests
{
    [TestFixture]
    public class TeacherDAOTests
    {
        [Test]
        [TestCase("Bob", "Chu", 69)]
        [TestCase("", "", 0)]
        public void AddTeacher_InvalidTeacher_ThrowsError(string firstName, string lastName, int userId)
        {
            var context = new MarkBookDBContext();
            var teacherDAO = new TeacherDAO(context);

            Assert.Throws<ArgumentException>(() => teacherDAO.AddTeacher(firstName, lastName, userId));
        }

        [Test]
        [TestCase(0)]
        [TestCase(69)]
        public void RemoveTeacherById_InvalidId_ThrowsError(int teacherId)
        {
            //Arrange
            var context = new MarkBookDBContext();
            var teacherDAO = new TeacherDAO(context);
            //Act

            //Assert
            Assert.Throws<ArgumentException>(() => teacherDAO.RemoveTeacherById(teacherId));
        }

        //[Test]
        //[TestCase(0)]
        //[TestCase(69)]
        //public void GetteacherById_InvalidId_ThrowsError(int teacherId)
        //{
        //    //Arrange
        //    var context = new MarkBookDBContext();
        //    var teacherDAO = new TeacherDAO(context);
        //    //Act

        //    //Assert
        //    Assert.Throws<ArgumentException>(() => teacherDAO.GetTeacherById(teacherId));
        //}

    //    [Test]
    //    [TestCase(0)]
    //    [TestCase(69)]
    //    public void GetTeacherById_InvalidId_ThrowsError(int teacherId)
    //    {
    //        //Arrange
    //        var context = new MarkBookDBContext();
    //        var teacherDAO = new TeacherDAO(context);
    //        //Act

    //        //Assert
    //        Assert.Throws<ArgumentException>(() => teacherDAO.GetTeacherById(teacherId));
    //    }
    }
}
