using NUnit.Framework;
using Services.DAO;
using System;
using Services.Models;
namespace Services.Tests
{
    [TestFixture]
    public class AdminDAOTests
    {
        [Test]
        [TestCase("Bob", "Chu", 8)]
        [TestCase("TedeOK420", "4382bj3uch3", 2)]
        public void AddAdmin_AlreadyExists_ThrowsError(string firstName, string lastName, int userId)
        {
            var context = new MarkBookDBContext();
            var adminDAO = new AdminDAO(context);
            Admins admin = new Admins();
            admin.FirstName = firstName;
            admin.LastName = lastName;
            admin.UserId = userId;
            //Assert.AreEqual(admin, adminDAO.AddAdmin(firstName, lastName, userId));
            Assert.Throws<ArgumentException>(() => adminDAO.AddAdmin(firstName, lastName, userId));
        }


    }
}
