using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class EvenTests
    {
        [TestMethod]
        public void EvenEnsureICanCreateInstance()
        {
            Even my_evens = new Even();
            Assert.IsNotNull(my_evens);
        }
        [TestMethod]
        public void EvenEnsureICanGetFirst()
        {
            //Arrange
            Even my_evens = new Even();

            //Act
            int actual = my_evens.GetFirst();
            int expected = 2;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
