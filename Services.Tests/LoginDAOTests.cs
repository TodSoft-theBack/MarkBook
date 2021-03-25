using NUnit.Framework;
using Services.DAO;
using System;

namespace Services.Tests
{
    [TestFixture]
    public class LoginDAOTests
    {
        [Test]
        [TestCase("", "")]
        [TestCase(" ", " ")]
        [TestCase(" _", " _")]
        [TestCase(" _", " ")]
        public void LogIn_InvalidData_ThrowsError(string username, string password)
        {
            var context = new MarkBookDBContext();
            var loginDAO = new LogInDAO(context);

            Assert.Throws<ArgumentException>(() => loginDAO.LogIn(username, password));
        }
    }
}
