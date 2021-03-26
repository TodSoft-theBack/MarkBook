using NUnit.Framework;
using Services.DAO;
using System;

namespace Services.Tests
{
    [TestFixture]
    public class AdminDAOTests
    {
        [Test]
        [TestCase("Bob", "Chu", 69)]
        [TestCase("", "", 5)]
        [TestCase("Teodor", "Nikolov", 1)]
        public void AddAdmin_InvalidData_ThrowsError(string firstName, string lastName, int userId)
        {
            var context = new MarkBookDBContext();
            var adminDAO = new AdminDAO(context);

            Assert.Throws<ArgumentException>(() => adminDAO.AddAdmin(firstName, lastName, userId));
        }
    }
}
