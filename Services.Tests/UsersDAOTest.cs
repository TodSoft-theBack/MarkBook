using NUnit.Framework;
using Services.DAO;
using System;
using Services.Models;

namespace Services.Tests
{
    [TestFixture]
    public class UsersDAOTests
    {
        [Test]
        [TestCase("", "")]
        [TestCase(" ", " ")]
        [TestCase(" _", " _")]
        [TestCase(" _", " ")]
        public void AddUser_InvalidUser_ThrowsError(string username, string password)
        {
            //Arrange
            var context = new MarkBookDBContext();
            var userDAO = new UserDAO(context);
            //Act

            //Assert
            Assert.Throws<ArgumentException>(() => userDAO.AddUser(username, password));
        }

        [Test]
        [TestCase(" ")]
        [TestCase("Bobbychu")]
        public void GetUser_InvalidUser_ThrowsError(string username)
        {
            var context = new MarkBookDBContext();
            var userDAO = new UserDAO(context);

            Assert.Throws<ArgumentException>(() => userDAO.GetUser(username));
        }
    }
}
