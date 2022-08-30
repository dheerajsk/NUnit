using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Tests
{
    class CalculatorProgramTest
    {
        [Test]
        public void Add_Test()
        {
            /// AAA

            // 1. Arrange
            FakeValidator validator = new FakeValidator();
            CalculatorProgram calc = new CalculatorProgram(validator);
            int num1 = 2;
            int num2 = 3;
            int expectedResult=5;
            int actualResult;

            // Act
            actualResult = calc.Add(num1, num2);

            // Assert
            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }


        [Test]
        public void Div_Test()
        {
            /// AAA

            // 1. Arrange
            //CalculatorProgram calc = new CalculatorProgram();
            //int num1 = 2;
            //int num2 = 0;

            //// Act && Assert
            //Assert.That(() => calc.Div(num1, num2), Throws.Exception.TypeOf<DivideByZeroException>());

            //actualResult = calc.Div(num1, num2);

            // Assert
            //Assert.That(expectedResult, Is.EqualTo(actualResult));
        }
    }
}
