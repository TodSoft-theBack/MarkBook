using NUnit.Framework;
using Services.DAO;
using System;

namespace Services.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase(1)]
        [TestCase(7)]
        [TestCase(11)]
        [TestCase(6.20)]
        public void AddMark_InvalidMark_ThrowsError1(decimal mark)
        {
            //Arrange
            var context = new MarkBookDBContext();
            var markDAO = new MarkDAO(context);
            //Act

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => markDAO.AddMark(mark, 1, 1, "asd"));
        }
    }
}