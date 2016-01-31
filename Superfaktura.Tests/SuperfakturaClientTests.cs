using System;
using NUnit.Framework;

namespace Superfaktura.Tests
{
    [TestFixture]
    public class SuperfakturaClientTests
    {
        [Test]
        public void Constructor()
        {
            // Arrange
            var email = "john@example.org";
            var token = "32481C452CA14412BB73AF5971AB5144";

            // Act
            var client = new SuperfakturaClient(email, token);

            // Assert
            Assert.Pass();
        }
    }
}
