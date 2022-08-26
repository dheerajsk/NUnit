using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Tests
{
    class AssertTests
    {
        [Test]
        public void Test()
        {
            // Arrange
            int expectedResult = 200;
            int actualResult = 200;
            City city = new City();
            string actualCity;

            // Act
            actualCity = city.GetCity();

            // Assert
            Assert.That(expectedResult, Is.EqualTo(actualResult));
            Assert.That(expectedResult, Is.GreaterThanOrEqualTo(actualResult));
            Assert.That(actualCity, Is.Not.Null);
            //Assert.That(city.Contains("India"));
            Assert.That("Mumbai", Is.EqualTo(actualCity).IgnoreCase);

        }
    }
}
