using NUnit.Framework;
using Services.DAO;
using System;
using Services.Models;
using System.Linq;

namespace Services.Tests
{
    [TestFixture]
    public class UserDAOTests
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

        [Test]
        [TestCase("Something")]
        [TestCase("Asie")]
        public void GetUser_ValidUser_ReturnsUser(string username)
        {
            var context = new MarkBookDBContext();
            var userDAO = new UserDAO(context);

            Assert.AreEqual(userDAO.GetUser(username).Username, username);
        }

        [Test]
        [TestCase("Something", 5)]
        [TestCase("Asie", 6)]
        public void GetUserById_ValidUser_ReturnsUser(string username, int id)
        {
            var context = new MarkBookDBContext();
            var userDAO = new UserDAO(context);

            Assert.AreEqual(userDAO.GetUserById(id).Username, username);
        }
        //[Test]
        //[TestCase(1, 1)]
        //public void AddUser_Succesful_ReturnsUser(int username, int password)
        //{
        //    var context = new MarkBookDBContext();
        //    var userDAO = new UserDAO(context);
        // ne stana...
        //    string usernameString = username.ToString();
        //    string passwordString = password.ToString();
        //    userDAO.AddUser(usernameString, passwordString);
        //    //var testUser = userDAO.AddUser(username, password);
        //    Assert.AreEqual(usernameString, context.Users.Where(u => u.Username == usernameString).FirstOrDefault().Username);
        //    Assert.AreEqual(passwordString, context.Users.Where(u => u.Username == usernameString).FirstOrDefault().Password);
        //    //userDAO.RemoveUserById(context.Users.Where(u => u.UserId == ));
        //}
    }
}
